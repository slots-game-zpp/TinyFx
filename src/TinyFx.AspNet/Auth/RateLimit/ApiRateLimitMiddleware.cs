﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyFx.AspNet.Auth.RateLimit
{
    internal class ApiRateLimitMiddleware: IMiddleware
    {
        private readonly SlidingWindow _window;

        public ApiRateLimitMiddleware()
        {
            _window = new SlidingWindow(10, 60);
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (!_window.PassRequest())
            {
                context.SetEndpoint(new Endpoint((context) =>
                {
                    context.Response.StatusCode = StatusCodes.Status403Forbidden;
                    return Task.CompletedTask;
                },
                            EndpointMetadataCollection.Empty,
                            "限流"));
            }

            await next(context);
        }
    }
}
