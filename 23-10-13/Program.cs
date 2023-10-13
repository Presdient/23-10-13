namespace _23_10_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }


    }

}
        //Pros with Interface:
        //1. Contract. An interface is essentially a contract that specifies a group of relted functionalities that
        //a class MUST implement.
        //2. Interface enhances abstraction and polymorfism
        //3. Creates an relation objects that might not be realted

        //Benefits
        //4. Its very easy to test an object that implents an interface
        //5. Adds more flexible polynmorfism
        //6. Consistency.
    /*
    interface IExample
    {
        public void Method();
    }

    interface IAnotherExample
    {
        public void Method2();
    }

    class Example : IExample, IAnotherExample
    {
        public void Method() 
        {
            Console.Write("This is a method");
        }
        public void Method2()
        {
            Console.WriteLine("Potatoes are nice!");
        }
    }
    */