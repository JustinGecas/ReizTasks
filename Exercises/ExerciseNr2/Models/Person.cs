namespace struktura.Models
{
    internal class Person
    {
        public Person(
            string name,
            string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; }
        public string Surname { get; }

        public string GetFullName()
        {
            return $"{Name} {Surname}";
        }
    }
}