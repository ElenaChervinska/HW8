//Було порушено принцип відкритості-закритості. Для того, щоб додати спосіб введення логування,
//потрібно було влазити до класу EmailSender, який повинен бути закритий для зміни.
//Для вирішення цієї проблеми було створено інтерфейс логера, який реалізують різні класи логерів.
class Email
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
}
interface ILogger
{
    void Log(string message);
}
class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        // ... sending...
        Console.WriteLine(message);
    }
}
class JSONLogger : ILogger
{
    public void Log(string message)
    {
        // ... write log message into .json file ...
    }
}
class EmailSender
{
    public ILogger Logger { get; set; }
    public EmailSender(ILogger logger)
    {
        this.Logger = logger;
    }
    public void Send(Email email)
    {
        // ... sending...
        this.Logger.Log("Email from '" + email.From + "' to'" + email.To + "' was send");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Email e1 = new Email()
        {
            From = "Me",
            To = "Vasya",
            Theme = "Who are you?"
        };
        Email e2 = new Email()
        {
            From = "Vasya",
            To = "Me",
            Theme = "vacuum cleaners!"
        };
        Email e3 = new Email()
        {
            From = "Kolya",
            To =
       "Vasya",
            Theme = "No! Thanks!"
        };
        Email e4 = new Email()
        {
            From = "Vasya",
            To = "Me",
            Theme = "washing machines!"
        };
        Email e5 = new Email()
        {
            From = "Me",
            To = "Vasya",
            Theme = "Yes"
        };
        Email e6 = new Email()
        {
            From = "Vasya",
            To =
       "Petya",
            Theme = "+2"
        };
        EmailSender es1 = new EmailSender(new ConsoleLogger());
        EmailSender es2 = new EmailSender(new JSONLogger());
        es1.Send(e1);
        es1.Send(e2);
        es1.Send(e3);
        es2.Send(e4);
        es2.Send(e5);
        es2.Send(e6);
        Console.ReadKey();
    }
}