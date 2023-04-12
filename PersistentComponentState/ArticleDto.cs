namespace PersistentComponentState;

public class ArticleDto
{
    public Guid Id { get; set; }
    public string Status { get; set; } = string.Empty;
    public string Culture { get; set; } = string.Empty;
    //public List<string>? Cultures { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool Nsfw { get; set; } = false;
    public bool Sponsor { get; set; } = false;
    public string? Permission { get; set; }
    public TimeSpan ReadingTime { get; set; }
    public bool ShowAuthor { get; set; } = false;
    public Guid AuthorId { get; set; } = Guid.Empty;
    public string? AuthorName { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public DateTime? Expirated { get; set; }
    public List<string>? Tags { get; set; }
    public string? ImageHeader { get; set; }

    public ArticleDto() { }
}
