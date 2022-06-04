using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using AbacusWebAPI.Helpers;

namespace AbacusWebAPI.Middleware
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                string result = string.Empty;
                switch (error)
                {
                    case CustomException e:
                        // custom application error
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        result = JsonSerializer.Serialize(new { message = error?.Message });
                        break;
                    default:
                        // unhandled error
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        result = JsonSerializer.Serialize(new { message = "Internal Server Error" });
                        break;
                }

                await response.WriteAsync(result);
            }
        }
    }
}
