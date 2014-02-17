using System;
using System.IO;

namespace DownloadsOrganiser
{
    public class MusicOrganiser : IMediaOrganiser
    {
        public void OrganiseFile(string file)
        {
            Console.WriteLine("Copying music file " + file);
            File.Copy(file, Path.Combine(@"c:\Music\", Path.GetFileName(file)), true);
        }
    }

}
