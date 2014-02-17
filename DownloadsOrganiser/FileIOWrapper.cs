using System.Collections.Generic;
using System.IO;

namespace DownloadsOrganiser
{
    public class FileIoWrapper : IFileIoWrapper
    {
        public IEnumerable<string> EnumerateFiles(string directoryName)
        {
            return Directory.EnumerateFiles(directoryName);
        }

        public string GetExtension(string file)
        {
            return Path.GetExtension(file);
        }
    }
}
