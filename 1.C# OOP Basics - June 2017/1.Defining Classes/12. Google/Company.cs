public class Company
{
    private string name;
    private string department;
    private decimal salary;

    public Company(string name, string department, decimal salary)
    {
        this.Name = name;
        this.Department = department;
        this.Salary = salary;
    }

    public string Name
    {
        get => this.name;
        private set => this.name = value;
    }

    public string Department
    {
        get => this.department;
        private set => this.department = value;
    }

    public decimal Salary
    {
        get => this.salary;
        private set => this.salary = value;
    }
}