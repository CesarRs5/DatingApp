

namespace API.Entities;

public class Photo
{
    public int ID { get; set; }
    public required string Url { get; set; }
    public bool IsMain { get; set; }
    public string? PublicId { get; set; }
}