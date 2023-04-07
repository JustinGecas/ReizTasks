namespace struktura.Models
{
    internal class Section
    {
        public Section(
            Person chief,
            List<Person> employees)
        {
            Chief = chief;
            Employees = employees;
        }

        public Person Chief { get; }

        public List<Person> Employees { get; }

        public int GetEmployeesCount()
        {
            return Employees.Count + 1;
        }
    }
}