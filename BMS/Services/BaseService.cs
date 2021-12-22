using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace BMS.Services
{
    public class BaseService
    {
        public string? GetUserId(IHttpContextAccessor httpContextAccessor)
        {
            var userId = httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null) return null;
            return userId;
        }

        public string? GetUserRole(IHttpContextAccessor httpContextAccessor)
        {
            var role = httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.Role)?.Value;
            return role;
        }
    }
}