using Microsoft.AspNetCore.Authorization;

namespace HumanResourceApi
{
    public class ApiAuthroizeAttribute : AuthorizeAttribute
    {
        const string POLICY_PREFIX = "MinimumAge";

        public ApiAuthroizeAttribute(int age) => Age = age;

        // Get or set the Age property by manipulating the underlying Policy property
        public int Age
        {
            get
            {
                if (int.TryParse(Policy.Substring(POLICY_PREFIX.Length), out var age))
                {
                    return age;
                }
                return default(int);
            }
            set
            {
                Policy = $"{POLICY_PREFIX}{value.ToString()}";
            } 
        }
    }

}
