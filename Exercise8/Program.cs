class Exercise8
{
    static void Main()
    {
        int start = 0, end = 0;
        bool error = true;

        try
        {
            Console.Write("Please enter the beginning element: ");
            start = int.Parse(Console.ReadLine());

            Console.Write("\nPlease enter the end of the range: ");
            end = int.Parse(Console.ReadLine());
            bool inRange = readNumber(start, end);

            if (inRange == false)
            {
                throw new NotFiniteNumberException();
            }

        }

        catch (FormatException)
        {
            Console.WriteLine("\nNumber is not an integer");
            error = false;
        }

        catch (NotFiniteNumberException)
        {
            Console.WriteLine("\nNumber is not in the specified range");
            error = false;
        }

        if (error)
        {
            Console.WriteLine("\nNumber is in the specified range");
        }
    }

    static bool readNumber(int start, int end)
    {
        bool inRange = true;
        int num = 0;

        Console.Write("\nPlease enter a positive integer: ");
        num = int.Parse(Console.ReadLine());

        if (num > end || num < start || start > end)
        {
            inRange = false;
        }

        return inRange;
    }
}