namespace struktura.Models
{
    internal class Company
    {
        public Company(
            string name,
            CompanyType type,
            string code,
            string vat,
            Person ceo)
        {
            Name = name;
            Type = type;
            Code = code;
            Vat = vat;
            Departments = new List<Department>();
            Ceo = ceo;
        }

        public Company(
            string name,
            CompanyType type,
        string code,
            List<Department> departments,
            Person ceo)
        {
            Name = name;
            Type = type;
            Code = code;
            Departments = departments;
            Ceo = ceo;
        }

        public Company(
            string name,
            CompanyType type,
            string code,
        string vat,
            List<Department> departments,
            Person ceo)
        {
            Name = name;
            Type = type;
            Code = code;
            Vat = vat;
            Departments = departments;
            Ceo = ceo;
        }

        public string Name { get; }
        public CompanyType Type { get; }
        public string Code { get; }
        public string Vat { get; }
        public List<Department> Departments { get; }
        public Person Ceo { get; }

        public string GetInfo()
        {
            var deparmentCount = 0;

            if (Departments != null)
            {
                deparmentCount = Departments.Count;
            }

            return $"Kompanijos pavadinimas: {Name}. Departamentų skaičius: {deparmentCount}";
        }

        public int GetAllEmployees()
        {
            var emplyeesCount = 0;

            foreach (var department in Departments)
            {
                emplyeesCount += department.GetEmployeesCount();
            }

            return emplyeesCount + 1;
        }
    }
}
