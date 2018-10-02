using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user what they would like to call their file. 
            Console.Write("What do you want to call this file? ");

            // Store the input in variable called "fileName"
            var fileName = Console.ReadLine();

            // Append .txt to the end of fileName
            fileName = fileName + ".txt";

            // Create a File utility object here
            // Give it the fileName object.
            FileUtility myFileName = new FileUtility(fileName);

            // Ask the user for data to put into the file
            Console.WriteLine();
            Console.WriteLine("Great!  Now we need some content.");
            Console.Write("Please Type some random 'data': ");

            // Store the user input in a variable called data
            var data = Console.ReadLine();

            // Write the data to the file using your fileUtility
            myFileName.WriteToFile(data);

            // Give a message to the user telling them data was written to the file
            Console.WriteLine();
            Console.WriteLine("Your Data is now saved to file.  \nThe file name is {0}.", fileName);

            // Display the data from the file
            Console.WriteLine();
            Console.WriteLine("And here it is:");

            Console.WriteLine(myFileName.ReadFromFile());

            // Add Console.ReadKey to make sure that the console window doesn't close
            Console.ReadKey();
        }
    }
}
