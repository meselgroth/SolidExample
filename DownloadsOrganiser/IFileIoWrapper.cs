using System.Collections.Generic;

namespace DownloadsOrganiser
{
    public interface IFileIoWrapper
    {
        IEnumerable<string> EnumerateFiles(string directoryName);
        string GetExtension(string file);
    }
}