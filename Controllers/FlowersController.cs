using CSWeb_Sample.Domains.Flowers;
using CSWeb_Sample.Services;
using Microsoft.AspNetCore.Mvc;
namespace CSWeb_Sample.Controllers;
/// <summary>
/// Flower(花)一覧を提供するControllerクラス
/// </summary>
[Route("flowers")]
public class FlowersController : Controller
{
    private readonly IFlowerService _service;
    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="service">Flower(花)に関するユースケースを提供するサービスインターフェイス</param>
    public FlowersController(IFlowerService service)
    {
        _service = service;
    }

    [HttpGet("list")]
    public IActionResult List()
    {
        // アプリケーション層(Service)を通じて花情報を取得
        List<Flower> flowers = _service.GetAll();
        // Viewに渡す
        return View(flowers);
    }
}