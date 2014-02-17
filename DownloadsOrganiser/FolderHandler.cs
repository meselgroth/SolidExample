using System.Collections.Generic;

namespace DownloadsOrganiser
{
    public class FolderHandler
    {
        private readonly Dictionary<string, IFileHandler> _filehandlers;
        private readonly IFileIoWrapper _fileIoWrapper;

        public FolderHandler(IFileIoWrapper fileIoWrapper)
        {
            _filehandlers = new Dictionary<string, IFileHandler>();
            _fileIoWrapper = fileIoWrapper;
        }

        public void AddHandler(string extension, IFileHandler fileHandler)
        {
            _filehandlers.Add(extension, fileHandler);
        }

        public void LoopFolder()
        {
            foreach (var file in _fileIoWrapper.EnumerateFiles(@"c:\Downloads"))
            {
                var extension = _fileIoWrapper.GetExtension(file);

                if (_filehandlers.ContainsKey(extension))
                {
                    var filehandler = _filehandlers[extension];
                    filehandler.Handle(file); 
                }
            }
        }
    }
}
