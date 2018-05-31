using System;
using System.IO;

namespace FileManipulation
{
    class Manipulation
    {
        static void Main(string[] args)
        {
            FileStream F = new FileStream("test.bat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for(int i=0; i<=70; i++)
            {
                F.WriteByte((byte)i);
            }
            F.Position = 0;
            for(int i=0; i<=70; i++)
            {
                Console.WriteLine("Output {0}", F.ReadByte());
            }
            F.Close();
            Console.ReadKey();
        }
       
    }
}
