using CSWeb_Sample.Domains.Flowers;
using Microsoft.EntityFrameworkCore;
namespace CSWeb_Sample.Infrastructures;
/// <summary>
/// Flower(花)をアクセスするRepositoryインターフェイスの実装
/// </summary>
public class FlowerRepository : IFlowerRepository
{
    // アプリケーション用DbContext
    private readonly AppDbContext _context;
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="context">アプリケーション用DbContext</param>
    public FlowerRepository(AppDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// すべての花情報を取得する
    /// </summary>
    /// <returns>花情報のリスト</returns>
    public List<Flower> FindAll()
    {
        // flowersテーブルからすべての花情報を取得する
        var flowerEntities = _context.Flowers.AsNoTracking().ToList();
        // FlowerEntityからFlowerに変換する
        var flowers = new List<Flower>();
        foreach (var flowerEntity in flowerEntities)
        {
            var flower = new Flower();
            flower.Id = flowerEntity.Id;
            flower.Name = flowerEntity.Name;
            flower.Season = flowerEntity.Season;
            flower.ImageUrl = flowerEntity.ImageUrl;
            flower.CreatedAt = flowerEntity.CreatedAt;
            flowers.Add(flower);
        }
        // Flowerのリストを返す
        return flowers;
    }
}