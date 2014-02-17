namespace DownloadsOrganiser
{
    public class VideoHandler:IFileHandler
    {
        private readonly IVideoMetadaExtractor _metadataExtractor;
        private readonly IMediaOrganiser _mediaOrganiser;

        public VideoHandler(IVideoMetadaExtractor metadataExtractor, IMediaOrganiser mediaOrganiser)
        {
            _metadataExtractor = metadataExtractor;
            _mediaOrganiser = mediaOrganiser;
        }

        public void Handle(string filename)
        {
            _metadataExtractor.GetScreenShot(filename);
            _metadataExtractor.GetReleaseDate(filename);
            _mediaOrganiser.OrganiseFile(filename);
        }
    }
}
