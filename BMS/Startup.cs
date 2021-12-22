using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using BMS.Database;
using BMS.Models.Entities;
using BMS.Services;
using BMS.Services.IRepository;
using BMS.Services.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;

namespace BMS
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(setupAction => { setupAction.ReturnHttpNotAcceptable = false; })
                .AddNewtonsoftJson(setupAction =>
                    setupAction.SerializerSettings.ContractResolver =
                        new CamelCasePropertyNamesContractResolver())
                .AddXmlDataContractSerializerFormatters()
                .ConfigureApiBehaviorOptions(
                    setupAction =>
                    {
                        setupAction.InvalidModelStateResponseFactory = context =>
                        {
                            var problemDetail = new ValidationProblemDetails(context.ModelState)
                            {
                                Status = StatusCodes.Status422UnprocessableEntity,
                                Instance = context.HttpContext.Request.Path,
                                Extensions =
                                    {new KeyValuePair<string, object?>("traceId", context.HttpContext.TraceIdentifier)}
                            };
                            return new UnprocessableEntityObjectResult(problemDetail)
                            {
                                ContentTypes = {"application/problem+json"}
                            };
                        };
                    });

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddDbContextPool<AppDbContext>(options =>
            {
                options.UseMySql(Configuration["ConnectionStrings:MySql"],
                    new MySqlServerVersion(new Version(8, 0, 27)));
            });
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    var secretByte = Encoding.UTF8.GetBytes(Configuration["Authentication:SecretKey"]);
                    options.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidIssuer = Configuration["Authentication:Issuer"],

                        ValidateAudience = true,
                        ValidAudience = Configuration["Authentication:Audience"],
                        

                        ValidateLifetime = true,

                        IssuerSigningKey = new SymmetricSecurityKey(secretByte)
                    };
                });

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "BMS.Swagger",
                    Description = "An ASP.NET Core Web API for managing Books",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Contact me",
                        Url = new Uri("https://github.com/horaoen")
                    },
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);

                var securityScheme = new OpenApiSecurityScheme()
                {
                    Description =
                        "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "JWT Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT"
                };
                var securityRequirement = new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "bearerAuth"
                            }
                        },
                        new string[] { }
                    }
                };
                options.AddSecurityDefinition("bearerAuth", securityScheme);
                options.AddSecurityRequirement(securityRequirement);
            });

            #region DI
            services.AddTransient<IBookTitleRepository, BookTitleRepository>();
            services.AddTransient<ILoanRepository, LoanRepository>();
            services.AddTransient<IReservationRepository, ReservationRepository>();
            services.AddTransient<IBookTitleItemRepository, BookTitleItemRepository>();
            services.AddTransient<ReservationService>();
            services.AddTransient<LoanService>();
            services.AddTransient<BookTitleService>();
            services.AddTransient<BookTitleItemService>();
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            #endregion
            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDataInitializer();
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "BMS.Swagger");
            });
            
            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}