using System.Text;
using Arch.EntityFrameworkCore.UnitOfWork;
using ExtCore.WebApplication.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using UniPos.Models;
using UniPos.Models.Utils;
using UniPos.Utils;
using Swashbuckle.AspNetCore.SwaggerUI;
using UniPos.Hubs;
using UniPos.Core; 


namespace UniPos
{
    public class Startup
    {
        private string extensionsPath;

        public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            Configuration = configuration;
            this.extensionsPath = webHostEnvironment.ContentRootPath + configuration["Extensions:Path"];
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)//, ILoggerFactory loggerFactory)
        {
            services.AddExtCore(this.extensionsPath);

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders",
                        builder =>
                        {
                            builder.AllowAnyOrigin()
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                        });
            });

            services
                .AddDbContext<MyDbContext>(opt => opt.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
                                            ass => ass.MigrationsAssembly(typeof(MyDbContext).Assembly.FullName)))
                .AddUnitOfWork<MyDbContext>()
                .AddScoped<IAuditService, AuditService>()
                .AddCustomRepository<tbUser, UserService>();


            services.AddControllers()
                .AddNewtonsoftJson()
                .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

            services.AddSignalR();



            var key = Configuration["JwtToken:SecretKey"].ToString();
            var key_byte = Encoding.ASCII.GetBytes(key);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ClockSkew = System.TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(key_byte)
                };
            });



            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Online Orders",
                });
                c.EnableAnnotations();

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
                });
            });
            services.AddSwaggerGenNewtonsoftSupport();
             
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, MyDbContext dataContext)
        {
            app.UseCors("AllowAllHeaders");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

           // app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<WebrtcSignalingHub>("/signaling");
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Online Orders");
                c.DefaultModelExpandDepth(2);
                c.DefaultModelRendering(ModelRendering.Model);
                c.DefaultModelsExpandDepth(-1);
                c.DisplayOperationId();
                c.DisplayRequestDuration();
                c.DocExpansion(DocExpansion.None);
                c.EnableDeepLinking();
                c.EnableFilter();
                c.ShowExtensions();
                c.EnableValidator();
                c.SupportedSubmitMethods(SubmitMethod.Get, SubmitMethod.Post, SubmitMethod.Delete, SubmitMethod.Put, SubmitMethod.Head);

            });

            app.UseExtCore();

        }
    }
}
