using Microsoft.Extensions.DependencyInjection;
using Onion.Application.Abstraction;
using Onion.Persistance.Concretes;
using Onion.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Onion.Persistance
{
    public static class ServiceRegistration
    {
       public static void AddPersistanceServices(this IServiceCollection services)
       {
            services.AddDbContext<ECommenceDbContext>(options => options.UseSqlServer("Server=DESKTOP-5EJQMOF;Database=ECommenceOnionArchDb;User Id=root;Password=123456;"));
       }
    }
}
