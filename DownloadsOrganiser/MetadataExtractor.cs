using System;

namespace DownloadsOrganiser
{
    public class MetadataExtractor : IMusicMetadataExtractor, IVideoMetadaExtractor
    {

        public void GetReleaseDate(string file)
        {
            Console.WriteLine("Extracting release date for music file " + file);
        }

        public void GetArtist(string file)
        {
            Console.WriteLine("Extracting artist for music file " + file);
        }

        public void GetScreenShot(string file)
        {
            Console.WriteLine("Extracting screenshot for video file " + file);
        }
    }


    public interface IMusicMetadataExtractor
    {
        void GetReleaseDate(string file);

        void GetArtist(string file);
     
    }

    public interface IVideoMetadaExtractor
    {
        void GetReleaseDate(string file);

        void GetScreenShot(string file);
    
    }
}
