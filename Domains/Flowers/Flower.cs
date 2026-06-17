using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSWeb_Sample.Domains.Flowers;
/// <summary>
/// Flower(花)を表すドメインモデル(Entityクラス)
/// </summary>
public class Flower
{

    /// <summary>
    /// 花の識別子
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 花の名前
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 花の季節（例：Spring, Summer）
    /// </summary>
    public string Season { get; set; } = string.Empty;

    /// <summary>
    /// 花の画像URL
    /// </summary>
    public string ImageUrl { get; set; } = string.Empty;

    /// <summary>
    /// 登録日時
    /// </summary>
    public DateTime CreatedAt { get; set; }
}