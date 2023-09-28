namespace MethodsDemoCSharp_41
{
    public class Program
    {
        static void Main(string[] args)
        {            

            //Use the method (calling a method)
            GreetPerson("Seth");
            GreetPerson("Jeremy");

            int twoPlusTwo = Add(2, 2);

            Console.WriteLine(twoPlusTwo + Add(5, 5));

            GreetByName();

            
        }

        //Parts of a method
        //Access modifier - Return Type - Name - Parameter list - Scope (body)
        //Creating the method (definition)
        public static void GreetPerson(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void GreetByName()
        {
            Console.WriteLine("Give me your name:");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");
        }

    }
}