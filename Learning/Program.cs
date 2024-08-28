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

            Console.WriteLine("Iveskite zodi:");

            var word = Console.ReadLine();
            try
            {
                if (word.Length < 5)
                {
                    throw new MyException();
                }
                else
                {
                    throw new Exception("Per ilgas zodis.");
                }
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Info);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Nieko daryt nereikia, situacija kontroliuojama.");
            }

            Console.WriteLine("Kodas toliau vykdomas.");

            #endregion

        }
    }
}
