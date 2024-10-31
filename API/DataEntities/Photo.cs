

namespace API.DataEntities;

using System.ComponentModel.DataAnnotations.Schema;

[Table("Photos")]
public class Photo
{
    public int ID { get; set; }
    public required string Url { get; set; }
    public bool IsMain { get; set; }
    public string? PublicId { get; set; }

    //Ef navigations Properties
    //required one to many realtion
    public int AppUserId { get; set; }

    public AppsUser AppsUser { get; set; } = null!;

}