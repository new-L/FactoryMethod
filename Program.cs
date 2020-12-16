using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            IShape shape;
            shape = creator.FactoryMethod("Square", 2, 10);

            Console.WriteLine("{0} area: {1}", (shape as Square).Name, shape.GetArea());
            
            shape = creator.FactoryMethod("Circle", 2, 10);

            Console.WriteLine("\n{0} area: {1}", (shape as Circle).Name, shape.GetArea());

            Console.ReadKey();
        }
    }


}
