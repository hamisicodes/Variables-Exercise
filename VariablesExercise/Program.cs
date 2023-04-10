namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Salim";
            int age = 15;
            char midInitial = 'N';
            bool isHappy = true;
            double doubleNum = 1.33d;
            decimal decNum = 10.898m;

            Console.WriteLine($"His name is {name} {midInitial} and he is {age} yaers old");
            Console.WriteLine($"It's {isHappy} that the cat is happy");
            Console.WriteLine($"Double value is {doubleNum} whereas decimal value is {decNum}");
        }
    }
}
