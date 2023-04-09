using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Ask for the path to the music files
        Console.WriteLine("Welcome to Awooochy's annoying text remover.");
        Console.WriteLine("Do you ever had to search mp3 youtube downloader and they mess up the file name?");
        Console.WriteLine("Do you have to many and you're lazy to change em?");
        Console.WriteLine("This program will clean your music files name on the targeted folder.");
        Console.WriteLine("-");
        Console.WriteLine("-");
        Console.WriteLine("-");
        Console.WriteLine("-");
        Console.WriteLine("-");
        Console.WriteLine("Enter the path to the music files:");
        string path = Console.ReadLine();

        // Ask if the user wants to remove the website's text
        Console.WriteLine("Do you want to remove the website's text from the file names? (y/n)");
        string answer = Console.ReadLine();

        int count = 0;

        if (answer.ToLower() == "y")
        {
            // Get a list of all the mp3 files in the directory
            string[] files = Directory.GetFiles(path, "*.mp3");

            foreach (string file in files)
            {
                // Check if the file name starts with the website's text
                string fileName = Path.GetFileName(file);
                if (fileName.StartsWith("[YT2mp3.info] - "))
                {
                    // Remove the website's text from the file name
                    string newName = Path.Combine(Path.GetDirectoryName(file), fileName.Substring("[YT2mp3.info] - ".Length));
                    File.Move(file, newName);
                    count++;
                }
                else if (fileName.StartsWith("yt1s.com - "))
                {
                    // Remove the website's text from the file name
                    string newName = Path.Combine(Path.GetDirectoryName(file), fileName.Substring("yt1s.com - ".Length));
                    File.Move(file, newName);
                    count++;
                }
            }

            Console.WriteLine($"Done! The website's text has been removed from the file names of {count} files.");
        }
        else
        {
            Console.WriteLine("No changes were made to the file names.");
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
