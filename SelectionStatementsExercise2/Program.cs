namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite class?");
                var favClass = Console.ReadLine();
                switch (favClass.ToLower())
            {
                case "history":
                    Console.WriteLine("History");
                    break;
                case "math":
                    Console.WriteLine("Math");
                    break;
                case "science":
                    Console.WriteLine("Science");
                    break;
                case "gym":
                    Console.WriteLine("Gym");
                    break;
                case "foreign language":
                    Console.WriteLine("Foreign Language");
                    break;
                default:
                    Console.WriteLine("We don't have that class");
                    break;
            }
        }
    }
}