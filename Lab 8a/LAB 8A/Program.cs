using System;

namespace LAB_8A
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                string s_TextContent;
                //Console.Write(AppContext.BaseDirectory);
                s_TextContent = System.IO.File.ReadAllText(AppContext.BaseDirectory + "\\TRIAL.ext");
                Console.WriteLine(s_TextContent);
            }
            catch
            {
                Console.WriteLine(" File not found!");
            }
            try
            {
                string[] as_TextContentByLines = System.IO.File.ReadAllLines(AppContext.BaseDirectory + "\\TRIAL.ext");
                for (int i_count = 0; i_count < as_TextContentByLines.Length; i_count++)
                {

                    Console.WriteLine(as_TextContentByLines[i_count]);
                }
                Console.WriteLine(as_TextContentByLines[2]);
            }
            catch
            {
                Console.WriteLine("File not found or array index out of bound!");
            }
        }
    }
}
