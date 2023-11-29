string articleInput = Console.ReadLine();
int numberOfCommands = int.Parse(Console.ReadLine());

string title = articleInput.Split(", ")[0];
string content = articleInput.Split(", ")[1];
string author = articleInput.Split(", ")[2];

var article = new Article(title, content, author);

for (int i = 1; i <= numberOfCommands; i++)
{
    string command = Console.ReadLine();
    string action = command.Split(": ")[0];
    string change = command.Split(": ")[1];

    switch (action)
    {
        case "Edit":
            {
                article.Edit(change);
                break;
            }
        case "ChangeAuthor":
            {
                article.CreateAuthor(change);
                break;
            }
        case "Rename":
            {
                article.RenameTitle(change);
                break;
            }
    }
}

Console.WriteLine(article);