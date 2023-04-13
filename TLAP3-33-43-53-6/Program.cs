namespace TLAP3_33_43_53_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 1, 3 ,6, 3, 2, 8 };
            bool result = ArrayIsSorted(numbers);
            Console.WriteLine(result);
            //SortDemo();
            string plaintext = Console.ReadLine();
            string cryptedMessage = CipherProblem(plaintext.ToUpper());
            Console.WriteLine(cryptedMessage);
            Console.WriteLine(DeCipher(cryptedMessage));
        }

        /*
        string minString = "kake";
        minString[0] = 'h';
        minString += "bake";
        
        char[] mittArr = new char[] { 'k', 'a', 'k', 'e' };
        console.WriteLine(mittArr[0]);
        mittArr[0] = 'h';

         */


        private static string CipherProblem(string plaintext)
        {
            // readonly char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string cryptedMessage = "";
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ\"'!#%&()*+<=>[]{},.;:/-´¨~^"; // \"\' !#%&()*+-:<=>[]{}=,.;/-´¨~^ 
            const string CipherKey = "Q\"W'F!P#G%J&L()U*+Y<A=>R[]S{}T,D.;H:N/E-I´¨O~ZXC^VBKM";

            for (int i = 0; i < plaintext.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (plaintext[i] == alphabet[j])
                    {
                        cryptedMessage += CipherKey[j];
                    }  
                }
                if (plaintext[i] == ' ')
                {
                    cryptedMessage += ' ';
                }
            }   
            return cryptedMessage;
        }

        private static string DeCipher(string cryptedMessage)
        {
            string DeCipherTxt = "";
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ\"'!#%&()*+<=>[]{},.;:/-´¨~^"; // \"\'!#%&()*+-:<=>[]{}=,.;/-´¨~^ 
            const string CipherKey = "Q\"W'F!P#G%J&L()U*+Y<A=>R[]S{}T,D.;H:N/E-I´¨O~ZXC^VBKM";

            for (int i = 0; i < cryptedMessage.Length; i++)
            {
                for (int j = 0; j < CipherKey.Length; j++)
                {
                    if (cryptedMessage[i] == CipherKey[j])
                    {
                        DeCipherTxt += alphabet[j];
                    }
                }
                if (cryptedMessage[i] == ' ')
                {
                    DeCipherTxt += ' ';
                }
            }
            return DeCipherTxt;
        }

        private static bool ArrayIsSorted(int[] numbers)
        {
            int[] sortedNums = new int [numbers.Length];
            CopyArray(sortedNums, numbers);
            SortArray(sortedNums);

            if (numbers == sortedNums)
            {
                return true;
            }
            return false;
        }

        private static void CopyArray(int[] sortedNums, int[] numbers) 
        { 
            for (int i = 0; i < numbers.Length; i++)
            {
                sortedNums[i] = numbers[i];
            }
        }

        private static void SortArray(int[] sortedNums)
        {
            Array.Sort(sortedNums);
        }

      


        //------------------------------------------------------------

        private static void SortDemo()
        {
            string[] txts = new[] { "Hei", "heio", "på", "deg", "hurramegrundt" };
            Console.WriteLine("Før sortering:");
            foreach (var txt in txts)
            {
                Console.WriteLine(txt);
            }
            Array.Sort(txts, Compare);
            Console.WriteLine("\nEtter sortering:");
            foreach (var txt in txts)
            {
                Console.WriteLine(txt);
            }

        }
        private static int Compare(string x, string y)
        {
            if (x.Length == y.Length) return x.CompareTo(y);
            if (x.Length > y.Length) return -1;
            return 1;
        }

    }
}