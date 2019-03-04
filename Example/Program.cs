using System;
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new SomeService();

            service.DoSmth();

            service.ShowCustomers();            

            Console.WriteLine(Environment.NewLine + "Main Completed");

            Console.ReadLine();
        }
    }
}
