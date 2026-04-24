namespace StringConcatenationExample
{
    internal class StringConcatenationExample
    {
        static void Main(string[] args)
        {
            const int sLen = 30, Loops = 5000;
            int i;
            string sSource = new String('X', sLen);
            string sDest = "";

            // Time string concatenation.
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            for (i = 0; i < Loops; i++) sDest += sSource;
            stopwatch.Stop();
            Console.WriteLine($"Concatenation took {stopwatch.ElapsedMilliseconds} ms.");

            // Time StringBuilder.
            stopwatch.Restart();
            System.Text.StringBuilder sb = new System.Text.StringBuilder((int)(sLen * Loops * 1.1));
            for (i = 0; i < Loops; i++)
                sb.AppendLine(sSource);
                //Console.WriteLine(sb.ToString());
            sDest = sb.ToString();
            Console.WriteLine(sDest);
            stopwatch.Stop();
            Console.WriteLine($"String Builder took {stopwatch.ElapsedMilliseconds} ms.");

            //Time string interpolation

            stopwatch.Restart();
            for (i = 0; i < Loops; i++) sDest += $"{sSource}";
            stopwatch.Stop();
            Console.WriteLine($"String interpolation took {stopwatch.ElapsedMilliseconds} ms");

            // Make the console window stay open
            // so that you can see the results when running from the IDE.
            Console.WriteLine();
            Console.Write("Press Enter to finish ... ");
            Console.Read();
        }
    }
}
