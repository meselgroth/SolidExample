using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DownloadsOrganiser.Test
{
    [TestClass]
    public class VideoHelperTest
    {
        [TestMethod]
        public void Handle_ExtractsScreenShotandReleaseDate()
        {
            //Setup
            var mockedMetaDataExtractor = new Mock<IVideoMetadaExtractor>();
            var mockedMediaOrganiser = new Mock<IMediaOrganiser>();

            var videoHandler = new VideoHandler(mockedMetaDataExtractor.Object, mockedMediaOrganiser.Object);

            //Act
            string policeAcadamyMp4 = "police acadamy 6.mp4";
            videoHandler.Handle(policeAcadamyMp4);

            //Assert
            mockedMetaDataExtractor.Verify(x => x.GetReleaseDate(policeAcadamyMp4), Times.Once());
            

        }
    }
}
