using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.EF;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Container
{
    public static class StartUpService
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IBannerService, BannerService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IJobsService, JobsService>();
            services.AddScoped<IMessageService, MessageService>();

            //EF
            services.AddScoped<IAboutDal, EfAbout>();
            services.AddScoped<IBannerDal, EfBanner>();
            services.AddScoped<ICategoryDal, EfCategory>();
            services.AddScoped<IContactDal, EfContact>();
            services.AddScoped<IJobsDal, EfJobs>();
            services.AddScoped<IMessageDal, EfMessage>();
        }
    }
}
