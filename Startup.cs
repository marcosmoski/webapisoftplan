using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApiSoftplan.Options;
using WebApiSoftplan.Services;

namespace WebApiSoftplan
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
      services.AddSwaggerGen(x =>
      {
        x.SwaggerDoc("v1", new Info{ Title = "Api do teste da softplan", Version = "v1" });
      });

      services.AddTransient<IApiService, ApiService>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseHsts();
      }

      var swaggerOptions = new SwaggerOptions();
      Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOptions);
      app.UseSwagger(option =>
      {
        option.RouteTemplate = swaggerOptions.JsonRoute;
      });

      app.UseSwaggerUI(option =>
      {
        option.SwaggerEndpoint(swaggerOptions.UiEndpoint, swaggerOptions.Description);
      });

      app.UseHttpsRedirection();
      app.UseStaticFiles();
      

      app.UseMvc(routes =>
      {
        routes.MapRoute(
                  name: "default",
                  template: "/swagger");
      });
    }
  }
}
