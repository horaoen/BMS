using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace BMS.Services
{
    public class BaseService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        protected BaseService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string? GetUserId()
        {
            var userId = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null) return null;
            return userId;
        }

        public string? GetUserRole()
        {
            var role = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.Role)?.Value;
            return role;
        }
    }
}