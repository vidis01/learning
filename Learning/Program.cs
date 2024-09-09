using Learning.Manto;

namespace Learning
{
    internal class Program
    {
        #region paskaita apie exceptions 2024-08-28
        //private static bool LogException(Exception e)
        //{
        //    Console.WriteLine($"\tIn the log routine. Caught {e.GetType()}");
        //    Console.WriteLine($"\tMessage: {e.Message}");
        //    return true;
        //}
        #endregion

        static void Main(string[] args)
        {
            #region paskaita apie abstrakcias klases ir interface 2024-08-27
            //var a = new MyClass(8);
            //Console.WriteLine(a.Name);
            //Console.WriteLine(((IName)a).Name);

            //var b = new MyClass2(8);

            //var myList = new List<IName> { a, b };

            //foreach (var item in myList)
            //{
            //    if (item is IPrototype)
            //    {
            //        Console.WriteLine(((BaseClassA)item).Name);
            //    }
            //}
            #endregion

            #region paskaita apie exceptions 2024-08-28

            //Console.WriteLine("Iveskite zodi:");

            //var word = Console.ReadLine();

            //try
            //{
            //    if (word.Length < 5)
            //    {
            //        throw new MyException();
            //    }
            //    else
            //    {
            //        throw new Exception("Per ilgas zodis.");
            //    }
            //}
            //catch (MyException e)
            //{
            //    Console.WriteLine(e.Info);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //finally
            //{
            //    Console.WriteLine("Nieko daryt nereikia, situacija kontroliuojama.");
            //}

            //Console.WriteLine("Kodas toliau vykdomas.");

            //try
            //{
            //    string? s = null;
            //    Console.WriteLine(s.Length);
            //}
            //catch (Exception e) when (LogException(e))
            //{
            //}
            //Console.WriteLine("Exception must have been handled");

            #endregion

            #region paskaita apie failus read/write 2024-08-28
            //try
            //{
            //    // Open the text file using a stream reader.
            //    using StreamReader reader = new("TestFile.txt");

            //    // Read the stream as a string.
            //    string text = reader.ReadToEnd();

            //    // Write the text to the console.
            //    Console.WriteLine(text);
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("The file could not be read:");
            //    Console.WriteLine(e.Message);
            //}

            //1
            //// Create a string array with the lines of text
            //string[] lines = { "First line", "Second line", "Third line" };

            //// Set a variable to the Documents path.
            ////string docPath =
            ////  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //// Write the string array to a new file named "WriteLines.txt".
            ////using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteToFile.txt")))
            //using (StreamWriter outputFile = new StreamWriter("WriteToFile.txt"))
            //{
            //    foreach (string line in lines)
            //        outputFile.WriteLine(line);
            //}

            //2
            //// Create a string with a line of text.
            //string text = "First line" + Environment.NewLine;

            //// Set a variable to the Documents path.
            //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //// Write the text to a new file named "WriteFile.txt".
            //File.WriteAllText(Path.Combine(docPath, "WriteFile.txt"), text);

            //// Create a string array with the additional lines of text
            //string[] lines = { "New line 1", "New line 2" };

            //// Append new lines of text to the file
            //File.AppendAllLines(Path.Combine(docPath, "WriteFile.txt"), lines);
            #endregion


            //var textAnalyzer = new TextAnalyzer();
            //textAnalyzer.AnalyzedText("TestFile.txt");
            //textAnalyzer.MainMenuChoice();            
        }
    }
}
