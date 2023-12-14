namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject)

            {
                case "Math":
                    Console.WriteLine("Math is awesome!");
                    break;
                case "Science":
                    Console.WriteLine("Science is a tough subject!");
                    break;

              default:
                    Console.WriteLine("Ah I haven't taken that subject before");
                    break;
                case "English":
                    Console.WriteLine("English is a interesting subject!");
                    break;
                defalut:
                    Console.WriteLine($"Oh wow! Ihaven't taken thay subject before {subject} sounds fun"!);
                    break;



            }

        }
    }
}