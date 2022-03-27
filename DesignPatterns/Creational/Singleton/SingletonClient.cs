namespace DesignPatterns.Creational.Singleton;

public class SingletonClient : ClientTemplate
{
    public override string Pattern => "Singleton";

    public override void RunClient()
    {
        var teacher = Singleton.GetInstance;
        teacher.PrintDetails("Teacher");

        var student = Singleton.GetInstance;
        student.PrintDetails("Student");
    }
}