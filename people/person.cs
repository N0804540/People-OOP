namespace People
{
    // INHERITANCE
    // Each Person is inheriting method references from the IPerson interface.
    public class Person : IPerson
    {
        // properties

        // ENCAPSULATION
        // Each person has private properties such as their name which cannot be directly accessed due to their private status.
        // The public getters and setters (where available) allow unrelated classes to access these properties.
        private string name;

        private int age;

        private string catchphrase;

        private List<Person> friends = new List<Person> {};

        // methods

        public Person()
        {
            name = "Name";
            age = 0;
            catchphrase = "Catchphrase";
        }

        public Person(string aName, int aAge, string aCatchphrase)
        {
            name = aName;
            age = aAge;
            catchphrase = aCatchphrase;
        }

        public void Speak()
        {
            Console.WriteLine("{0} says: {1}.", GetName(), catchphrase);
        }

        public void SetCatchphrase(string newPhrase)
        {
            catchphrase = newPhrase;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public void AddFriend(Person newFriend)
        {
            friends.Add(newFriend);
        }

        // ABSTRACTION
        // It is not important to other classes or the program user how friends are named. Nor do they
        // need to know whether or not a Person has any friends in advance.
        // All they need is the end result, and thus the one NameFriends function handles everything
        // without detailing its processes.

        // Implementation details are hidden and thus changes will not affect the user experience.
        public void NameFriends()
        {
            Console.WriteLine("{0}'s friends are:", GetName());

            if (friends.Count == 0)
            {
                Console.WriteLine("None!");
            }
            else
            {
                foreach (Person nextFriend in friends)
                {
                    Console.WriteLine(nextFriend.GetName());
                }
            }
        }
    }
}