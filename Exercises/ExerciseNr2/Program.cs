using struktura.Models;

namespace struktura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var company1 = new Company(
                "Sugar",
                CompanyType.UAB,
                "303178491",
                "LT100012922915",
                new List<Department>()
                {
                    new Department(
                        new Person("Jon", "Smith"),
                        DepartmentType.IT,
                        new List<Section>()
                        {
                            new Section(
                                new Person("Jane", "Smurf"),
                                new List<Person>()
                                {
                                    new Person("Cody", "Jobs"),
                                    new Person("Joly", "Jolyn")
                                }
                            )
                        }
                    )
                },
                new Person("Jon", "Smith")
            );

            Console.WriteLine(company1.GetAllEmployees());

        }
    }
}