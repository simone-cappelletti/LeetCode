namespace LeetCode
{
    public static class Extensions
    {
        public static void AddLeetCodeBusiness(this IServiceCollection services)
        {
            services.AddScoped<ILeetCodeBusiness, LeetCodeBusiness>();
        }
    }
}
