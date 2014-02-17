using System;
using System.IO;

namespace DownloadsOrganiser
{
    class Program
    {
        static void Main(string[] args)
        {
            Parse();
        }

        public static void Parse()
        {
            foreach (var file in Directory.EnumerateFiles(@"c:\Downloads"))
            {
                var extension = Path.GetExtension(file);

                switch (extension)
                {
                    case ".mp3":
                        Console.WriteLine("Extracting artist for music file " + file);
                        Console.WriteLine("Extracting release date for music file " + file);
                        Console.WriteLine("Extracting album cover for music file " + file);
                        Console.WriteLine("Copying music file " + file);
                        File.Copy(file, Path.Combine(@"c:\Music\", Path.GetFileName(file)), true);
                        break;
                    case ".mp4":
                        Console.WriteLine("Extracting director for video file " + file);
                        Console.WriteLine("Extracting screenshot for video file " + file);
                        Console.WriteLine("Extracting release date for music file " + file);
                        Console.WriteLine("Copying video file " + file);
                        File.Copy(file, Path.Combine(@"c:\Videos\", Path.GetFileName(file)), true);
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}