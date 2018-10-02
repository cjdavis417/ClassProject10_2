using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject10_2
{
    public class FileUtility : IFileUtility
    {
        // Make sure the class impliments IFileUtility
        // Add a private string field called _filePath
        private readonly string _filePath; // you could use get/ set, but doing it this way allows it to be set once, in the constructor and that's the only time.

        // Add a constructor that takes a string parameter called path
        // Set your private field to the path passed in
        public FileUtility(string path)
        {
            _filePath = path;
        }

        public string ReadFromFile()
        {
            // Add a string variable called fileContents
            string fileContents;

            // Add a using statement
            // Inside of the using statment, create a StreamReader.  The stream read constructor will take the path property
            // Set the fileContents variable to the file using stream readers 'ReadToEnd' method
            using (var reader = new StreamReader(_filePath))
            {
                fileContents = reader.ReadToEnd();
            }

            // Return the fileContents
            return fileContents;

        }

        public void WriteToFile(string value)
        {
            // Add a using statement
            // Inside of the using, create a new StreamWriter.  The stream writer's constructor take the private file path field
            // Write the value parameter to the file using the writer's 'Write' method
            using (var writer = new StreamWriter(_filePath))
            {
                writer.Write(value);
            }
           

        }


    }
}
