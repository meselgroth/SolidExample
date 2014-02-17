namespace DownloadsOrganiser
{
    public class Mp3Handler:IFileHandler
    {
        private IMusicMetadataExtractor metadaExtractor;
        private IMediaOrganiser mediaOrganiser;

        public Mp3Handler(IMusicMetadataExtractor metadaExtractor, IMediaOrganiser mediaOrganiser)
        {
            this.metadaExtractor = metadaExtractor;
            this.mediaOrganiser = mediaOrganiser;
        }

        public void Handle(string filename)
        {
            metadaExtractor.GetArtist(filename);
            metadaExtractor.GetReleaseDate(filename);
            mediaOrganiser.OrganiseFile(filename);
        }
    }
}
