
int numberOfSongs = int.Parse(Console.ReadLine());

List<Songs> songsList = new List<Songs>();

for (int i = 1; i <= numberOfSongs; i++)
{
    string[] currentSong = Console.ReadLine().Split("_").ToArray();

    string currentTypeList = currentSong[0];
    string currentName = currentSong[1];
    string currentTime = currentSong[2];

    Songs songs = new Songs(currentTypeList, currentName, currentTime);
    songsList.Add(songs);
}
string command = Console.ReadLine();

if (command == "all")
{
    foreach (Songs songs in songsList)
    {
        Console.WriteLine(songs.NameOfSong);
    }
}
else
{
    foreach (Songs songs in songsList.Where(s => s.TypeList == command))
    {
        Console.WriteLine(songs.NameOfSong);
    }
}



