using object_oriented_program_of_area_of_different_shapes;

class Program
{
    static void Main(string[] args)
    {

        Drawing circle = new Circle();
        Drawing square = new Square();
        Drawing rectangle = new Rectangle();


        Console.WriteLine("Area :" + circle.Area());
        Console.WriteLine("Area :" + square.Area());
        Console.WriteLine("Area :" + rectangle.Area());
    }
}
