using System;
using System.IO;

namespace DownloadsOrganiser
{
    public class VideoOrganiser : IMediaOrganiser
    {
        public void OrganiseFile(string file)
        {
            Console.WriteLine("Copying video file " + file);
            File.Copy(file, Path.Combine(@"c:\Videos\", Path.GetFileName(file)), true);
        }
    }
}