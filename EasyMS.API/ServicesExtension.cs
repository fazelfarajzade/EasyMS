using EasyMS.API.Repositories.Interfaces;
using EasyMS.API.Repositories.SqlServer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;


namespace EasyMS.API
{
    public static class ServicesExtension
    {
        public static void LoadServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

            // Repositories
            builder.Services.AddSingleton<IDbContext, DapperContext>();
            builder.Services.AddTransient<IAccountsRepository, AccountsRepository>();
            builder.Services.AddTransient<ICategoriesRepository, CategoriesRepository>();
            builder.Services.AddTransient<ICommentsRepository, CommentsRepository>();
            builder.Services.AddTransient<IFilesRepository, FilesRepository>();
            builder.Services.AddTransient<ILayoutsRepository, LayoutsRepository>();
            builder.Services.AddTransient<IPagesRepository, PagesRepository>();
            builder.Services.AddTransient<ISettingsRepository, SettingsRepository>();
            builder.Services.AddTransient<ISitesRepository, SitesRepository>();

            // Authentication
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
                        ValidAudience = builder.Configuration["JwtSettings:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:SecretKey"]))
                    };
                });
        }
    }
}
