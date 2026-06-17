using CSWeb_Sample.Domains.Flowers;
namespace CSWeb_Sample.Services;
/// <summary>
/// Flower(花)に関するユースケースを提供するサービスインターフェイス
/// </summary>
public interface IFlowerService
{
    /// <summary>
    /// 花情報をすべて取得する(一覧表示用)
    /// </summary>
    /// <returns>花情報のリスト</returns>
    List<Flower> GetAll();
}