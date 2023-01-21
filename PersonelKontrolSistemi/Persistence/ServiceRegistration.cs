using Microsoft.EntityFrameworkCore;
using Application.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Concretes;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Repositories;
using Persistence.Repositories;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersitenceSevices(this IServiceCollection services)
        {
            //services.AddSingleton<IFirmaService, FirmaService>();
            services.AddDbContext<PersonelKontrolSistemiDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            services.AddScoped<IFirmaReadRepository,FirmaReadRepository>();
            services.AddScoped<IFirmaWriteRepository,FirmaWriteRepository>();

            services.AddScoped<IPersonelReadRepository,PersonelReadRepository>();
            services.AddScoped<IPersonelWriteRepository, PersonelWriteRepository>();

            services.AddScoped<IPersonelHareketleriReadRepository, PersonelHareketleriReadRepository>();
            services.AddScoped<IPersonelHareketleriWriteRepository, PersonelHareketleriWriteRepository>();

            services.AddScoped<ISubeReadRepository,SubeReadRepository>();
            services.AddScoped<ISubeWriteRepository,SubeWriteRepository>();



        }
    }
}
