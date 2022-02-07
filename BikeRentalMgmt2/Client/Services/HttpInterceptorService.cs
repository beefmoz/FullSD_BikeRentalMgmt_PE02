﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Toolbelt.Blazor;
using Toolbelt.Blazor.Extensions.DependencyInjection;

namespace BikeRentalMgmt2.Client.Services
{
    public class HttpInterceptorService
    {
        private readonly HttpClientInterceptor interceptor;
        private readonly NavigationManager navManager;

        public void DisposeEvent() => interceptor.AfterSend -=InterceptResponse;
        public void MonitorEvent() => interceptor.AfterSend +=InterceptResponse;
        private void InterceptResponse(object sender,HttpClientInterceptorEventArgs e)
        {
            string message = string.Empty;
            if (!e.Response.IsSuccessStatusCode)
            {
                var responseCode = e.Response.StatusCode;
                switch (responseCode)
                {
                    case HttpStatusCode.NotFound:
                        navManager.NavigateTo("/404");
                        message = "The requested resource was not found.";
                        break;
                    case HttpStatusCode.Unauthorized:
                    case HttpStatusCode.Forbidden:
                        navManager.NavigateTo("/unauthorized");
                        message = "You are not authorized to access this resource. ";
                        break;
                    default:
                        navManager.NavigateTo("/500");
                        message = "Something went wrong, please contactAdministrator";
                        break;
                }
            }
        }

        public HttpInterceptorService(HttpClientInterceptor interceptor, NavigationManager navManager)
        {
            this.interceptor = interceptor;
            this.navManager = navManager;
        }

    }
}
