﻿// ---------------------------------------------------------------------------- 
// Copyright (c) Microsoft Corporation. All rights reserved.
// ---------------------------------------------------------------------------- 

using System.Data.Entity;
using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;
using Owin;
using AutoMapper;
using ContosoMoments.MobileServer.Models;
using Newtonsoft.Json;

namespace ContosoMoments.MobileServer
{
    public partial class Startup
    {
        public static void ConfigureMobileApp(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            config.EnableCors();
            config.MapHttpAttributeRoutes();
            config.EnableSystemDiagnosticsTracing();
            config.Formatters.JsonFormatter.SerializerSettings.Re‌​ferenceLoopHandling = ReferenceLoopHandling.Ignore;
            new MobileAppConfiguration()
                .UseDefaultConfiguration()
                .ApplyTo(config);

           
            Mapper.Initialize(cfg =>
            {
                //cfg.CreateMap<Album, Album>()
                //    .ForMember(dst => dst.Id, map => map.MapFrom(src => SqlFuncs.StringConvert((double)src.OrderId).Trim()));

                //cfg.CreateMap<BrownOnline, Order>();

                //cfg.CreateMap<PersonEntity, Person>();

                //cfg.CreateMap<Person, PersonEntity>();
            });

            Database.SetInitializer(new ContosoMomentsDBInitializer());
          

          //  app.UseAppServiceAuthentication(config, AppServiceAuthenticationMode.LocalOnly);
            app.UseWebApi(config);
            
          
        }
    }

   
}