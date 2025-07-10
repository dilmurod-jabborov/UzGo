namespace UzGo.Domain.PathHolder;

public class PathHolder
{
    private static readonly string parent = 
        Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
    public static readonly string UserPath = Path.Combine(parent, "Database", "User.txt"); 
    public static readonly string DriverPath = Path.Combine(parent, "Database", "Driver.txt"); 
    public static readonly string AdminPath = Path.Combine(parent, "Database", "Admin.txt"); 
}
