using System; 

public class Friend //Finn Marable Unit Test Q14 using public class Friend to generate the same output as the provided code.
{
    public string name;
    public string greeting;
    public DateTime birthdate;
    public string address;

    public Friend Clone()
    {
        return new Friend
        {
            name = this.name,
            greeting = this.greeting,
            birthdate = this.birthdate,
            address = this.address
        };
    }
}

class Program
{
    static void Main(string[] args)
    {
        Friend friend = new Friend();
        Friend enemy;

        // create my friend Charlie Sheen
        friend.name = "Charlie Sheen";
        friend.greeting = "Dear Charlie";
        friend.birthdate = DateTime.Parse("1967-12-25");
        friend.address = "123 Any Street, NY NY 12202";

        // Clone the friend to create an enemy
        enemy = friend.Clone();

        // set the enemy greeting and address without changing the friend variable
        enemy.greeting = "Sorry Charlie";
        enemy.address = "Return to sender.  Address unknown.";

        Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
        Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
    }
}

