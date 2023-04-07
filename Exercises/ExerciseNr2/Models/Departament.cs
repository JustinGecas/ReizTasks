namespace struktura.Models
{
    internal class Department
    {
        public Department(
        Person director,
            DepartmentType type)
        {
            Director = director;
            Type = type;
            Sections = new List<Section>();
        }

        public Department(
        Person director,
            DepartmentType type,
            List<Section> sections)
        {
            Director = director;
            Type = type;
            Sections = sections;
        }

        public Person Director { get; }
        public DepartmentType Type { get; }
        public List<Section> Sections { get; }

        public int GetEmployeesCount()
        {
            var emplyeesCount = 0;

            foreach (var section in Sections)
            {
                emplyeesCount += section.GetEmployeesCount();
            }

            return emplyeesCount + 1;
        }
    }
}
