using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CSWeb_Sample.Infrastructures;

/// <summary>
/// flowersテーブルの値を扱う、Entity Framework CoreのEntityクラス
/// </summary>
[Table("flowers")]
public class FlowerEntity
{
    /// <summary>
    /// 花の識別子(主キー)
    /// </summary>
    [Key]
    [Column("id")]
    public int Id { get; set; }

    /// <summary>
    /// 花の名前
    /// </summary>
    [Column("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 花の季節（例：Spring, Summer）
    /// </summary>
    [Column("season")]
    public string Season { get; set; } = string.Empty;

    /// <summary>
    /// 花の画像URL
    /// </summary>
    [Column("image_url")]
    public string ImageUrl { get; set; } = string.Empty;

    /// <summary>
    /// 登録日時
    /// </summary>
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}