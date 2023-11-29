
public class Article
{
    string Title { get; set; }
    string Content { get; set; }
    string Author { get; set; }

    public Article(string title, string content, string author)
    {
        this.Title = title;
        this.Content = content;
        this.Author = author;
    }

    public void Edit(string content)
    {
        Content = content;
    }

    public void CreateAuthor(string author)
    {
        Author = author;
    }

    public void RenameTitle(string title)
    {
        Title = title;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}
    
