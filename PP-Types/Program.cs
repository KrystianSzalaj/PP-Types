using System;

class Program
{
    // Prints the elements in groups, with `perLine` elements per line.
    void PrintGroups(string[] t, int perLine)
    {
        for (int i = 0; i < t.Length; i++)
        {
            Console.Write(t[i]);
            
            // Print a comma and space for all elements except the last one in each group or the last element overall.
            if (i != t.Length - 1)
            {
                Console.Write(", ");
            }

            // Move to the next line after `perLine` elements
            if ((i + 1) % perLine == 0 && i != t.Length - 1)
            {
                Console.WriteLine();
            }
        }

        // Print a period after the last element.
        Console.WriteLine(".");
    }

    // Prints the elements in columns, each with a fixed width.
    void PrintColumns(string[] t, int perLine, int width)
    {
        for (int i = 0; i < t.Length; i++)
        {
            // Trim the element if it exceeds the given width
            string element = t[i].Length > width ? t[i].Substring(0, width) : t[i];

            // Left-align the element and pad it to the specified width
            Console.Write(element.PadRight(width));

            // Print a column separator, but not after the last column on each line
            if ((i + 1) % perLine != 0 && i != t.Length - 1)
            {
                Console.Write(" | ");
            }

            // Move to the next line after `perLine` elements
            if ((i + 1) % perLine == 0)
            {
                Console.WriteLine();
            }
        }

        // Print a new line if the last row was incomplete (i.e., did not fill all columns).
        if (t.Length % perLine != 0)
        {
            Console.WriteLine();
        }
    }

    // Test the functions
    static void Main(string[] args)
    {
        string[] names = {
            "Mickey Mouse", "Minnie Mouse", "Donald Duck", "Goofy", "Pluto", "Daisy Duck", "Simba", "Nala", 
            "Timon", "Pumbaa", "Mufasa", "Ariel", "Flounder", "Sebastian", "Ursula", "Belle", "Beast", "Gaston", 
            "Cinderella", "Prince Charming", "Aurora", "Maleficent", "Rapunzel", "Flynn Rider", "Elsa", "Anna", 
            "Olaf", "Moana", "Maui", "Hercules"
        };

        Program program = new Program();

        Console.WriteLine("\nPrintGroups(names, 3):\n");
        program.PrintGroups(names, 3);

        Console.WriteLine("\nPrintGroups(names, 5):\n");
        program.PrintGroups(names, 5);

        Console.WriteLine("\nPrintGroups(names, 7):\n");
        program.PrintGroups(names, 7);

        Console.WriteLine("\nPrintGroups(names, 40):\n");
        program.PrintGroups(names, 40);

        Console.WriteLine("\n\nPrintColumns(names, 4, 17):\n");
        program.PrintColumns(names, 4, 17);

        Console.WriteLine("\n\nPrintColumns(names, 5, 15):\n");
        program.PrintColumns(names, 5, 15);

        Console.WriteLine("\n\nPrintColumns(names, 7, 10):\n");
        program.PrintColumns(names, 8, 10);
    }
}
