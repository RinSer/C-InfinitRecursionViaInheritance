using System;

/*
    C# Infinit Recursion via Inheritance
 */
namespace SubRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("I am alive!");
                var superC = new SuperClass();
                var subC = new SubClass();
                Console.WriteLine("Instance of SuperClass calls the firstFunction method.");
                superC.firstFunction();
                Console.WriteLine("Instance of SuperClass has finished.");
                Console.WriteLine("Instance of SubClass calls the secondFunction method.");
                subC.secondFunction();
                Console.WriteLine("Instance of SubClass has finished.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Farewell!");
            }
        }
    }

    /*
        Parent class with the firstFunction method 
        calling overridable instance method secondFunction
        without any ado.
     */
    public class SuperClass
    {
        public void firstFunction()
        {
            Console.WriteLine("SuperClass -> firstFunction");
            this.secondFunction();
        }

        public virtual void secondFunction()
        {
            Console.WriteLine("SuperClass -> secondFunction");
        }
    }

    /*
        Child class that overrides secondFunction parent 
        method calling the instance method firstFunction 
        inside of it causes infinit recursion.
     */
    public class SubClass : SuperClass
    {
        public override void secondFunction()
        {
            Console.WriteLine("SubClass -> secondFunction");
            this.firstFunction();
        }
    }
}
