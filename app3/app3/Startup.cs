using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace app3
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {   // Adicionando servi�o de MVC
            services.AddMvc(options => options.EnableEndpointRouting = false);
            // OBS: Foi inserido dentro de "services.AddMvc()" o comando options para que ele execute a vers�o antiga 2.0 
            // para o funcionamento correto da aplica��o colocando como falso a aplica��o recente 3.0 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Usado para realizar uma defini��o da forma que os links devem ser escritos
            // ou seja controller = Home ou action = index ou uma nova��o fun��o criada pelo usu�rio
            app.UseMvcWithDefaultRoute();           
        }
    }
}
