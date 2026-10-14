using System.Text.Json;
using WebApplication2.Services;

namespace WebApplication2.Middlewares
{
    public class FriendsJsonMiddleware
    {
        private readonly RequestDelegate _next;

        public FriendsJsonMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, FriendsService friendsService)
        {
            if (context.Request.Path.Equals("/friends-json", StringComparison.OrdinalIgnoreCase))
            {
                var friends = friendsService.GetAll();
                context.Response.ContentType = "application/json; charset=utf-8";
                await context.Response.WriteAsync(JsonSerializer.Serialize(friends));
                return; 
            }

            await _next(context);
        }
    }
}