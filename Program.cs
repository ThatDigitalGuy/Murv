using Murv.Classes;

namespace Murv;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        AccessCommanderPlugin user = new AccessCommanderPlugin();

        user.Name = "John Doe";
        user.Id = "testtest";

        user.ListUser(user);
    }
}
