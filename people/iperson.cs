namespace People
{
    // POLYMORPHISM
    // The IPerson methods are implemented by different person classes in different ways,
    // but the methods are accessed and called in the same way regardless of class.
    interface IPerson
    {
        // methods

        public void Speak();

        public void AddFriend(Person newFriend);
    }
}