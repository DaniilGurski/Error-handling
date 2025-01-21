internal class Program
{
    private static void Main(string[] args)
    {
        // Assigment1();
        // Assigment2();
        // Assigment3();
        Assigment4();
    }

    static void Assigment1() {
        Console.Write("Enter your age: ");

        int.TryParse(Console.ReadLine(), out int age);

        if (age > 18) {
            Console.WriteLine("Welcome");
        } else {
            throw new Exception("Too young");
        }
    }


    static void Assigment2() {
        Console.Write("Enter index: ");
        int[] arr = new int[1000];
        int index = Convert.ToInt32(Console.ReadLine());
        
        try {
            Console.WriteLine(arr[index]);
        } catch (IndexOutOfRangeException) {
            Console.WriteLine("Index was outside the bounds of the array");
        }
    }


    static void Assigment3() {
        double number1 = 12; 
        double number2 = 0; 


        try {
            double result = number1 / number2;
            Console.WriteLine($"The result of {number1} / {number2} is: {result}");
        } catch (DivideByZeroException) {
            Console.WriteLine("Error: Cannot devide by zero");
        }


    }


    static void Assigment4() {
        Console.Write("Please enter the first number: ");
        bool isFirstValid = double.TryParse(Console.ReadLine(), out double first);

        Console.Write("Please enter the second number: ");
        bool isSecondValid = double.TryParse(Console.ReadLine(), out double second);

        try {
            if (!isFirstValid || !isSecondValid) {
                // invalid type
                throw new Exception("One of the inputs was not a valid number");
            } else if (second == 0) {
                // devide by zero
                throw new Exception("Cannot devide by zero");
            }
            double result = first / second;
            Console.WriteLine($"The result of {first} / {second} is {result}");
        } catch (Exception err) {
            Console.WriteLine($"Error: {err}");
        }
    }
}