var student = new Student();
student.name = "Enter student's name";
System.Console.WriteLine(student.GetName());

class Person
{
    public  string? name;
    public string GetName()
    {
        return $"Hello from {name}";
    }
}

class Student : Person
{

}