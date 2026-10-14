using WebApplication2.Services;

namespace WebApplication2.Middlewares
{
    public class TotalFriendsMiddleware
    {
        private readonly RequestDelegate _next;

        public TotalFriendsMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, FriendsService friendsService)
        {
            if (context.Request.Path == "/total-friends")
            {
                var count = friendsService.GetAll().Count;
                await context.Response.WriteAsync(count.ToString());
            }
            else
            {
                await _next(context);
            }
        }
    }
}