using Database.Learning;
using Database.Learning.DbModels;
using Learning.Classes;
using Learning.Manto;
using Microsoft.EntityFrameworkCore;

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

            #region Manto text analyzer
            //var textAnalyzer = new TextAnalyzer();
            //textAnalyzer.AnalyzedText("TestFile.txt");
            //textAnalyzer.MainMenuChoice();
            #endregion

            #region 2024-09-12 Linq, Inclde, ThenInclude naudojimas norint užkrauti susijusius duomenis

            //using (var db = new MyDBContext())
            //{
            //    var result = db.Customers
            //        .Where(dd => dd.City == "London")
            //        .Include(c => c.Orders)
            //        .ThenInclude(o => o.Employee)
            //        .Include(o => o.Orders)
            //        .ThenInclude(o => o.Shipper);

            //    if (result != null)
            //    {
            //        foreach (var customer in result)
            //        {
            //            Console.WriteLine($"{customer.CustomerName} {customer.Orders.Count}");
            //        }

            //    }
            //}
            #endregion

            #region 2024-09-19 Linq methods
            //using (var db = new MyDBContext())
            //{
            //db.Shippers.Add(new Shipper { Phone = "12345", ShipperName = "Jonaitis" });

            //db.Shippers.Remove(db.Shippers.Single(s => s.ShipperID == 6));

            //var result = db.Customers
            //    .Where(dd => dd.City == "London")
            //    .Select(s => new { s.ContactName, s.CustomerName , s.Orders.Count});

            //var shipper2 = db.Shippers.Where(s => s.ShipperID > 4);
            //var shipper3 = shipper2.SingleOrDefault(s => s.ShipperID ==  6);
            //var a = shipper2.Count();

            //var shipper = db.Shippers.FirstOrDefault(s => s.ShipperID ==  6);

            //var s = result.ToArray();

            //foreach (var item in s)
            //{
            //    Console.WriteLine($"{item.ContactName} {item.CustomerName} {item.Count}");
            //}

            //db.SaveChanges();
            //}
            #endregion

            #region 2024-09-25 SOLID priciples, depend on abstraction

            //var game = new Game(new WordSelectorFromFile(new ReadFromfile()));
            //game.Play();

            #endregion
        }
    }
}
