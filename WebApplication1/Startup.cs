//using Business.Abstract;
//using Business.Concrete;
//using DataAccess.Abstract;
//using DataAccess.Concrete.EntityFramework;
//using Microsoft.AspNetCore.Builder;

//namespace WebAPI
//{
//    public class Startup
//    {
//        public void Configure(IApplicationBuilder app)
//        {
//            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
//        }
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddControllers();
//            services.AddSingleton<IProductService, ProductManager>();
//            services.AddSingleton<IProductDal, EfProductDal>();
//        }
//    }
//}
