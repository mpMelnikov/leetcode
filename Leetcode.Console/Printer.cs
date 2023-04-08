using System.Collections;

public static class Printer
{
    public static void Print(object obj)
    {
        if (obj is IEnumerable enumerable)
        {
            foreach(var item in enumerable)
            {
                Console.WriteLine(item);
            }

            return;
        }

        Console.WriteLine(obj);
    }
}
