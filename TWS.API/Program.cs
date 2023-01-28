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
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    // Register dependencies
    builder.RegisterType<Mapper>().As<IMapper>();
    builder.RegisterType<Paging>().As<IPaging>();
    builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
    builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
    builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerLifetimeScope();
    builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
    builder.RegisterType<ManufacturerRepository>().As<IManufacturerRepository>().InstancePerLifetimeScope();
    builder.RegisterType<ManufacturerService>().As<IManufacturerService>().InstancePerLifetimeScope();
    builder.RegisterType<Product>().As<IProduct>();
    builder.RegisterType<Manufacturer>().As<IManufacturer>();
    builder.RegisterType<TWSContext>().InstancePerLifetimeScope();
});

builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(AutoMapperProfiles)));
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

app.UseCors(builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
