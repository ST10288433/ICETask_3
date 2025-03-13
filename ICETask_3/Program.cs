namespace ICETask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instance of Rectangle class
            Rectangle rt = new Rectangle("Lewis", 24.5, 4.7);
            rt.CalculateArea();
            rt.Display();

            Console.WriteLine();

            // instance of Circle class
            Circle cl = new Circle("Jane", 36.5);
            cl.CalculateArea();
            cl.Display();

            Console.ReadKey();
        }
    }
}
