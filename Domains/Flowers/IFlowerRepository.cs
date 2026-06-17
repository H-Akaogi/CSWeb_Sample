namespace CSWeb_Sample.Domains.Flowers;
/// <summary>
/// Flower(花)をアクセスするRepositoryインターフェイス
/// </summary>
public interface IFlowerRepository
{
    /// <summary>
    /// すべての花情報を取得する
    /// </summary>
    /// <returns>Flowerのリスト</returns>
    List<Flower> FindAll();
}