namespace Chatio.Api;

public class Startup
{
    public IConfiguration Configuration;

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
    }

    public void Configure(
        IApplicationBuilder applicationBuilder,
        IWebHostEnvironment webHostEnvironment
    )
    {
        if (webHostEnvironment.IsDevelopment())
        {
            applicationBuilder.UseSwagger();
            applicationBuilder.UseSwaggerUI();
        }
        applicationBuilder.UseHttpsRedirection();
        applicationBuilder.UseRouting();
        applicationBuilder.UseAuthorization();
        applicationBuilder.UseEndpoints(endpoints => {
            endpoints.MapControllers();
        });
    }
}
