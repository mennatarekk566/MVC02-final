using System.Diagnostics;

namespace MVC02.Middleware
{
    public class RequestTimeMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var stop = Stopwatch.StartNew();

            await _next(context);

            stop.Stop();
            Console.WriteLine($"{context.Request.Path} --> {stop.ElapsedMilliseconds} ms");
        }
    }
}