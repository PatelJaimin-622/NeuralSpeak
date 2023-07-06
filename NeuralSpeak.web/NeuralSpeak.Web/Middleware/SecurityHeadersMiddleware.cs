using Microsoft.Extensions.Primitives;
using Microsoft.Net.Http.Headers;

namespace NeuralSpeak.Web.Middleware
{
    public sealed class SecurityHeadersMiddleware
    {
        private readonly RequestDelegate _next;

        public SecurityHeadersMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public Task Invoke(HttpContext context)
        {
            if (!context.Response.Headers.ContainsKey("Feature-Policy"))
                context.Response.Headers.Add("Feature-Policy", "accelerometer 'self'; camera 'self'; microphone 'self';");

            if (!context.Response.Headers.ContainsKey("Referrer-Policy"))
                context.Response.Headers.Add("Referrer-Policy", "no-referrer");

            if (!context.Response.Headers.ContainsKey("Permissions-Policy"))
                context.Response.Headers.Add("Permissions-Policy", "accelerometer=(), camera=(), geolocation=(), gyroscope=(), magnetometer=(), microphone=(), payment=*, usb=()");

            if (!context.Response.Headers.ContainsKey("X-Content-Type-Options"))
                context.Response.Headers.Add("X-Content-Type-Options", "nosniff");

            if (!context.Response.Headers.ContainsKey("X-Frame-Options"))
                context.Response.Headers.Add("X-Frame-Options", "Deny");

            if (!context.Response.Headers.ContainsKey("X-Permitted-Cross-Domain-Policies"))
                context.Response.Headers.Add("X-Permitted-Cross-Domain-Policies", new StringValues("none"));

            if (!context.Response.Headers.ContainsKey("x-xss-protectio"))
                context.Response.Headers.Add("x-xss-protection", new StringValues("1; mode=block"));

            if (!context.Response.Headers.ContainsKey("Strict-Transport-Security"))
                context.Response.Headers.Add("Strict-Transport-Security", "max-age=31536000");

            if (context.Response.Headers.ContainsKey("X-AspNet-Version"))
                context.Response.Headers.Remove("X-AspNet-Version");
            if (context.Response.Headers.ContainsKey("X-Powered-By"))
                context.Response.Headers.Remove("X-Powered-By");
            if (context.Response.Headers.ContainsKey("Server"))
                context.Response.Headers.Remove("Server");

            context.Response.Headers[HeaderNames.CacheControl] = "no-cache, no-store, must-revalidate";
            context.Response.Headers[HeaderNames.Expires] = "0";
            context.Response.Headers[HeaderNames.Pragma] = "no-cache";
            return _next(context);
        }
    }
}
