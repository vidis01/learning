namespace Learning
{
    internal class Program
    {
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
            #endregion
        }
    }
}
