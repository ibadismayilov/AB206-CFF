using System.Reflection;

namespace ReflectionLesson;

public class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        Assembly assembly = Assembly.GetExecutingAssembly();

        Type type = assembly.GetType("ReflectionLesson.Student");

        PropertyInfo propertyInfos = type.GetProperty("Name");

        propertyInfos.SetValue(student, "ibad");
        Console.WriteLine(propertyInfos.GetValue(student));

    }

}