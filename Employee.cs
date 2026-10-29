namespace AccessDemo;
public class Employee {
public string Name = "Ashwin";
private int salary = 50000;
protected string dept="CSE";
internal int id=101;
public void ShowDetails()
    {
        Console.WriteLine($"Name: {Name}, Salary: {salary}, Dept: {dept}, Id: {id}");
    }
}
