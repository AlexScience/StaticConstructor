using System;
using SealedProperties;
using StaticConstructor;
using StaticConstructor_MyExtension;
internal class Program
{
    
    private static void Main(string[] args)
    {
        Class1.MyProperty.Say();
        
        //MyClass.Say();
        Student student = new Student()
        {
            FirstName = "Name",
            LastName = "email"
        };
        string fullName = student.GetName();
        Console.WriteLine(fullName);

        DateTime date1 = DateTime.Now;
        date1.Print();
        Console.WriteLine(date1.IsDayOfWeek(DayOfWeek.Monday));

    }
}
static class MyClass
{
    /*public MyClass()*///нельзя создать объект класса 
    //int a; нельзя создать не статическое поле или метод 
    static int number;

    static MyClass()//можно создать один статический констуктор 
    {
        Console.WriteLine("Ститический конструктор");
    }
    static int Print
    {
        get { return number; }

        set
        {
            if (value <= 0 || value >= 100)
            {
                throw new ArgumentException(nameof(value));
            }
            number = value;
        }
    }

    public static void Say()
    {
        MyClass.Print = int.Parse(Console.ReadLine());//set устанавливаем значение 
        Console.WriteLine(MyClass.Print);//get получаем значение 
    }






}