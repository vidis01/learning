namespace Learning.Manto
{
    public class MantoBubbleSort
    {
        public static int[] Sort(int[] intArray)
        {
            int temp = 0;

            for (int write = 0; write < intArray.Length; write++)
            {
                for (int sort = 0; sort < intArray.Length - 1; sort++)
                {
                    if (intArray[sort] > intArray[sort + 1])
                    {
                        temp = intArray[sort + 1];
                        intArray[sort + 1] = intArray[sort];
                        intArray[sort] = temp;
                    }
                }
            }

            //blogas kodas
            for (int a = 1; a < intArray.Length; a++)
            {
                Console.WriteLine(intArray[a]);
            }
            //blogas kodas

            return intArray;
        }
    }
}
