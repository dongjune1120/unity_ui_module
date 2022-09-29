public struct UserData
{
    public int level;
    public string name;
}

public class GameManager : Singleton<GameManager>
{
    private UserData myData = new UserData()
    {
        level = 1,
        name = "Jade"
    };
    public UserData MyData { get => myData; }
}
