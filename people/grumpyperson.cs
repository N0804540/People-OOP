namespace People
{
    public class GrumpyPerson : IPerson
    {
        // properties

        private string name;

        private int age;

        private string catchphrase;

        // methods

        public GrumpyPerson()
        {
            name = "Name";
            age = 0;
            catchphrase = "Catchphrase";
        }

        public GrumpyPerson(string aName, int aAge, string aCatchphrase)
        {
            name = aName;
            age = aAge;
            catchphrase = aCatchphrase;
        }

        public void Speak()
        {
            Console.WriteLine("{0} miserably says: {1}.", GetName(), catchphrase);
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

        // POLYMORPHISM
        // GrumpyPerson uses AddFriend in a different way to Person, but asks for the same base parameter as outlined in the interface.
        public void AddFriend(Person newFriend)
        {
            Console.WriteLine("{0} does not want to be friends with {1}!", GetName(), newFriend.GetName());
        }
    }
}