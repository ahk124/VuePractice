using System;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            test1();
            Console.WriteLine("finish");
            Console.ReadKey();
        }
        static void test1()
        {
            try
            {
                Console.WriteLine("come to test 1");
                test2();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("come to exeption test 1");
                Console.WriteLine(ex.Message);

            }
        }
        static void test2()
        {
            try
            {
                Console.WriteLine("come to test 2");
                throw new InvalidOperationException("Logfile cannot be read-only");
            }
            catch (System.Exception)
            {
                Console.WriteLine("come to exeption test 2");
                throw;
            }
        }
    }
}
