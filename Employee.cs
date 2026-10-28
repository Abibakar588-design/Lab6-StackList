
namespace Lab5StackList
{
    internal class Employee
    {
        // Egenskaper för den anställda
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        // Skapar en ny anställd
        public Employee(int id, string name, string gender, decimal salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        // Skriver ut information om den anställda
        public override string ToString()
        {
            return $"ID: {Id}, Namn: {Name}, Kön: {Gender}, Lön: {Salary}";
        }



    }
}
