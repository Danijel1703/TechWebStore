using TWS.Service.Common;
using TWS.Service;
using TWS.Repository.Common;
using TWS.Repository;
using TWS.DAL;
using TWS.Model.Common;
using TWS.Model;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    // Register dependencies
    builder.RegisterType<Mapper>().As<IMapper>();
    builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>));
    builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
    builder.RegisterType<ProductRepository>().As<IProductRepository>();
    builder.RegisterType<ProductService>().As<IProductService>();
    builder.RegisterType<ManufacturerRepository>().As<IManufacturerRepository>();
    builder.RegisterType<ManufacturerService>().As<IManufacturerService>();
    builder.RegisterType<Product>().As<IProduct>();
    builder.RegisterType<Manufacturer>().As<IManufacturer>();
    builder.RegisterType<TWSContext>();
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
