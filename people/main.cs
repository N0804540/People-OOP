using People;

class Controller
{
    static void Main(string[] args)
    {
        Person steve = new Person("Steve", 25, "Hello");
        Person jack = new Person("Jack", 23, "Hi");
        Person sarah = new Person("Sarah", 32, "Howdy");
        Console.WriteLine(steve.GetAge());
        steve.NameFriends();
        steve.AddFriend(jack);
        steve.AddFriend(sarah);
        steve.NameFriends();

        GrumpyPerson bob = new GrumpyPerson("Bob", 30, "Not interested");
        bob.Speak();
        bob.AddFriend(steve);
    }
}