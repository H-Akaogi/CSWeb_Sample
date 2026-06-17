using CSWeb_Sample.Domains.Flowers;
namespace CSWeb_Sample.Services;
/// <summary>
/// Flower(花)に関するユースケースを提供するサービスインターフェイス
/// </summary>
public class FlowerService : IFlowerService
{
    private readonly IFlowerRepository _repository;
    /// <summary>
    /// コンストラクタ(RepositoryをDIで受け取る)
    /// </summary>
    public FlowerService(IFlowerRepository repository)
    {
        _repository = repository;
    }
    /// <summary>
    /// 花情報をすべて取得する(一覧表示用)
    /// </summary>
    /// <returns>花情報のリスト</returns>
    public List<Flower> GetAll()
    {
        return _repository.FindAll();
    }
}