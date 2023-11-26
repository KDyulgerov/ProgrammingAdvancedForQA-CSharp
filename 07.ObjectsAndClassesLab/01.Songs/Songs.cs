
public class Songs
{
    private string typelist;

    private string nameOfSong;

    private string time;

    public string TypeList
    {
        get { return typelist; }
        set { typelist = value; }
    }

    public string NameOfSong
    {
        get { return nameOfSong; }
        set { nameOfSong = value; }
    }

    public string Time
    {
        get { return time; }
        set { time = value; }
    }

    public Songs(string typeList, string nameOfSong, string time)
    {
        TypeList = typeList;
        NameOfSong = nameOfSong;
        Time = time;
    }
}

