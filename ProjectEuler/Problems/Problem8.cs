using System;

namespace ProjectEuler
{
    public partial class Problems
    {
        private void Problem8()
        {
            char[] numArr = GetString().ToCharArray();
            long greatestProduct = 0;

            for (int i = 0; i < numArr.Length - 13; i++)
            {
                long product = 1;
                for (int j = 0; j < 13; j++)
                {
                    product *= int.Parse(numArr[i + j].ToString());
                }

                if (product > greatestProduct)
                    greatestProduct = product;
            }

            Console.WriteLine(greatestProduct);
        }

        private string GetString()
        {
            string[] numString;
            string num = "";
            try
            {
                numString = fileReader.ReadFileArray("Problem8");
                foreach (var line in numString)
                {
                    num += line;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return num;
        }
    }
}
