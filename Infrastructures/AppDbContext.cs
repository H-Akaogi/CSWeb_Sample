using Microsoft.EntityFrameworkCore;
namespace CSWeb_Sample.Infrastructures;
/// <summary>
/// アプリケーション用DbContext(Entity Framework CoreのDB接続とエンティティ管理を行う）
/// </summary>
public class AppDbContext : DbContext
{
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="options"></param>
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    /// <summary>
    /// flowersテーブル(FlowerEntity)を表すDbSetプロパティ
    /// </summary>
    public DbSet<FlowerEntity> Flowers => Set<FlowerEntity>();
}