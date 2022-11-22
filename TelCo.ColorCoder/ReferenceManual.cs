using System;
using System.IO;
using static TelCo.ColorCoder.ColorCoder;

namespace TelCo.ColorCoder
{
    class ReferenceManual
    {
        /// <summary>
        /// To create Reference Manual in a text file to print
        /// </summary>
        public void PrintManual()
        {
            using (StreamWriter streamWriter = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ReferenceManual.txt")))
            {
                streamWriter.WriteLine("Code\tColorPair (Major, Minor)");
                Console.WriteLine("Code\t\tColorPair (Major, Minor)");
                for (int colorCode = 1; colorCode <= colorMapMajor.Length * colorMapMinor.Length; colorCode++)
                {
                    ColorPair colorPair = GetColor.GetColorFromPairNumber(colorCode);
                    streamWriter.WriteLine(colorCode + "\t\t" + colorPair.majorColor.Name + "," + colorPair.minorColor.Name);
                    Console.WriteLine(colorCode + "\t\t" + colorPair.majorColor.Name + "," + colorPair.minorColor.Name);
                }
            }
        }
    }
}
