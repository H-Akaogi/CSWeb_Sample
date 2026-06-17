using CSWeb_Sample.Domains.Flowers;
using CSWeb_Sample.Infrastructures;
using CSWeb_Sample.Services;
using Microsoft.EntityFrameworkCore;
namespace CSWeb_Sample.Configs;
/// <summary>
/// DIコンテナへの依存関係登録を集約する
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// アプリケーション全体の依存関係を登録する
    /// </summary>
    public static IServiceCollection AddApplication(
        this IServiceCollection services, IConfiguration configuration)
    {
        // AppDbContextの依存定義
        services.AddDbContext<AppDbContext>(options =>
        {
            // appsetting.jsonの接続文字列を設定する
            options.UseNpgsql(configuration.GetConnectionString("AppDb"));
            // SQLログ出力する
            options.LogTo(Console.WriteLine);
        });

        // ドメイン層のIFlowerRepositoryインターフェイス実装クラスFlowerRepositoryの依存定義
        services.AddScoped<IFlowerRepository, FlowerRepository>();
        // サービス層のIFlowerServiceインターフェイス実装クラスFlowerServiceの依存定義
        services.AddScoped<IFlowerService, FlowerService>();

        return services;
    }
}