public class Employee
{
    private string name;
    private decimal salary;
    private string position;
    private string department;
    public string Email { get; set; }
    public int Age { get; set; }

    public Employee(string name, decimal salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.Email = "n/a";
        this.Age = -1;
    }

    public string Name => this.name;
    public decimal Salary => this.salary;
    public string Department => this.department;
}
