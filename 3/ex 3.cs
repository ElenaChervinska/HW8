//Порушено принцип єдиної відповідальності. Тому що, сеттер полів класу Square мав кілька відповідальності:
//зміни ширини і довжини одночасно. Виходячи з цього, розрахунки проводили невірні,
//оскільки при привласненні значення висоті присвоювалося значення і ширині.
class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square : Rectangle
{
    public override int Width
    {
        get { return base.Width; }
        set
        {
            base.Width = value;
        }
    }
    public override int Height
    {
        get { return base.Height; }
        set
        {
            base.Height = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Square();
            rect.Width = 5;
            rect.Height = 10;
            Console.WriteLine(rect.GetRectangleArea());
            Console.ReadKey();
        }
    }
}