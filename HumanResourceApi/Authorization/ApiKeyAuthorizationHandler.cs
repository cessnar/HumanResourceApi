using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceApi.Authorization
{
    public class ApiKeyAuthorizationHandler : AuthorizationHandler<ApiKeyRequirment>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ApiKeyRequirment requirement)
        {
            if (!context.User.HasClaim(c => c.Type == "Api-Key")) 
            {
                return Task.CompletedTask;


            }
            context.Succeed(requirement);

            return Task.CompletedTask;
        }

       
    }


    public class ApiKeyRequirment : IAuthorizationRequirement 
    {
       

    
    }
}
