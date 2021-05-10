using System;
using System.IO;

namespace FileOperations
{
    class Program
    {
        private static string path1 = Directory.GetCurrentDirectory();
        static void Main(string[] args)
        {
            //Set Path
            var path2 = Path.GetFullPath(Path.Combine(path1, @"..\..\..\Lyrics\"));

            ////Read all text in file
            //string lyrics = File.ReadAllText($@"{path2}/Wonderwall.txt");
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.WriteLine(lyrics);
            //Console.Beep();

            ////WriteAllText(string, string) Create a new file which writes a specified text string to the file
            //File.WriteAllText(path2 + "ChampagneSupernovae.txt", "Some day you will find me");

            ////WriteAllLines(string, string[]) Creates a new file which writes an array as lines
            //string[] lyrics = { "So", "Sally", "Can", "Wait" };
            //File.WriteAllLines(path2 + "Don'tlookbackinanger.txt", lyrics);

            ////Checking if file exists
            //if (!File.Exists(path2 + "My Lyrics.txt"))
            //{
            //    string[] createText = { "Hello", "I'm", "Nish" };
            //    File.WriteAllLines(path2 + "My Lyrics.txt", createText);
            //}

            ////Open the file to read from
            //string[] readText = File.ReadAllLines(path2 + "My Lyrics.txt");
            //foreach (var line in readText)
            //{
            //    Console.WriteLine(line);
            //}

            ////Appending a file
            //string appendText = "\nAnd Well";
            //File.AppendAllText(path2 + "My Lyrics.txt", appendText);

            ////Copy
            //File.WriteAllText(path2 + "OldLyrics.txt", "Hey now I'm an allstar");
            //var oldLyrics = path2 + "OldLyrics.txt";
            //var newLyrics = path2 + "NewLyrics.txt";
            ////Copy to new locations but do not overwrite if it already exists
            //File.Copy(oldLyrics, newLyrics, false);

            ////Delete
            //File.Delete(path2 + "oldLyrics.txt");

            ////Dates of creation and modification
            //DateTime lastWriteTime = File.GetLastWriteTime(path2 + "NewLyrics.txt");
            //DateTime creationTime = File.GetCreationTime(path2 + "NewLyrics.txt");

            ////File Info
            //var fileInfo = new FileInfo(path2 + "Newlyrics.txt");
            //var direcotry = fileInfo.Directory;
            //var extension = fileInfo.Extension;

            ///////////////////////////FOLDER OPERATIONS//////////////////////////////////
            /////GET FILES
            //var fileArray = Directory.GetFiles(path2);
            //foreach (var file in fileArray)
            //{
            //    Console.WriteLine(file);
            //}

            ////Delete Folder
            //Directory.Delete(path2, true);
        }
    }
}
