using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Fttbll.Services
{
    public class ServicesMiddleware
    {
        private readonly RequestDelegate _next;
        private int i = 0; // счетчик запросов
        public ServicesMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, ICounter counter, IAutor autor, CounterService counterService)
        {
            i++;
            httpContext.Response.ContentType = "text/html;charset=utf-8";
            await httpContext.Response.WriteAsync($"Номер запроса = {i}; Рандомное число: {counter.Value}; Информация об авторе: {autor.Send()}; Номер сервиса: {counterService.Counter.Value}");
        }
    }
}
