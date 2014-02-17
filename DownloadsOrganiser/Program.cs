using System;

namespace DownloadsOrganiser
{
    class Program
    {
        static void Main(string[] args)
        {
            var folderHandler = new FolderHandler(new FileIoWrapper());
            folderHandler.AddHandler(".mp3", new Mp3Handler( new MetadataExtractor(), new MusicOrganiser()));
            folderHandler.AddHandler(".mp4", new VideoHandler( new MetadataExtractor(), new VideoOrganiser()));
            folderHandler.LoopFolder();
            Console.ReadLine();
        }

    }
}