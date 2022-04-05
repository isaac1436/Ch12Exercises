class Exercise7
{
    static void Main()
    {
        int num = 0; double root;

        Console.Write("Please enter a positive integer: ");

        try
        {
            num = int.Parse(Console.ReadLine());
            if (num <= 0) { throw new NotFiniteNumberException(); }
            root = Math.Sqrt(num);
            Console.WriteLine("\nThe root of {0} is {1}", num, root);
        }

        catch (FormatException e)
        {
            Console.WriteLine("\nNumber is not an integer");
        }

        catch (NotFiniteNumberException e)
        {
            Console.WriteLine("\nThe number entered is not positive"); ;
        }

        finally
        {
            Console.WriteLine("\n\"GoodBye\" ");
        }
    }

}
