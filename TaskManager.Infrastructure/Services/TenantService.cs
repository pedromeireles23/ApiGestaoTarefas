using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using TaskManager.Application.Interfaces;

namespace TaskManager.Infrastructure.Services
{
    public class TenantService : ITenantService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TenantService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid TenantId
        {
            get
            {
                var tenantIdStr = _httpContextAccessor.HttpContext?.User?.FindFirst("tenantId")?.Value;

                if (string.IsNullOrWhiteSpace(tenantIdStr))
                {
                    throw new UnauthorizedAccessException("O identificador do Tenant não foi encontrado na requisição atual ou o usuário não está autenticado.");
                }

                
                if (!Guid.TryParse(tenantIdStr, out Guid tenantGuid))
                {
                    throw new BadHttpRequestException("O formato do TenantId presente no token é inválido.");
                }

                return tenantGuid;
            }
        }
    }
}