namespace Voxsign1.Models;

public class SignItem
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsFavorite { get; set; }
    public bool IsOfflineAvailable { get; set; }
}

public class PhraseItem
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Text { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Tag { get; set; } = string.Empty;
    public bool IsFavorite { get; set; }
}

public class OfflinePack
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; } = string.Empty;
    public int SignsCount { get; set; }
    public int PhrasesCount { get; set; }
    public string SizeMb { get; set; } = string.Empty;
    public bool IsDownloaded { get; set; }
}

public class ChatMessage
{
    public string Sender { get; set; } = string.Empty;
    public string Time { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public bool IsMe { get; set; }
    public List<SignItem>? SignSequence { get; set; }
}