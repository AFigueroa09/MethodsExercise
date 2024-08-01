namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 5, 7, 7 };
            int currentYear = 2024;

            Console.WriteLine("What is your name?"); 
            string name = Console.ReadLine();
            string nameCapitalized = ToUpperFirstLetter(name);

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine(); 

            Console.WriteLine("What is your age?"); 
            string age = Console.ReadLine(); 
            int ageInt = Int32.Parse(age);
            int[] ageEquationList = { currentYear, ageInt };
            int birthYear = Substract(ageEquationList);

            Console.WriteLine("On " + birthYear + ", " + nameCapitalized + " was born. He/She determined early on that " + color + " was his/her favorite color.");

            Console.WriteLine("Time for a challenge!");
            Console.WriteLine("Sum: " + Add(numbers));
            Console.WriteLine("Substract: " + Substract(numbers));
            Console.WriteLine("Multiply: " + Multiply(numbers));
            Console.WriteLine("Divide: " + Divide(numbers));
        }

        public static int Add(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++) {
                result += numbers[i]; 
            }
            return result;
        }

        public static int Substract(int[] numbers)
        {
            int result = numbers[0]; //Assign the first item on the list
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                result -= numbers[i+1]; // subsctract the second item on the list and so on...
            }
            return result;
        }

        public static int Multiply(int[] numbers)
        {
            int result = numbers[0]; //Assign the first item on the list
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                result *= numbers[i + 1]; // subsctract the second item on the list and so on...
            }
            return result;
        }

        public static double Divide(int[] numbers)
        {
            double result = numbers[0]; //Assign the first item on the list
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                result /= numbers[i + 1]; // subsctract the second item on the list and so on...
            }
            return result;
        }

        public static string ToUpperFirstLetter(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return string.Empty;
            }
            char[] letters = source.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            return new string(letters);
        }
    }
}
