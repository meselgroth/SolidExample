using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DownloadsOrganiser.Test
{
    [TestClass]
    public class FolderHandlerTest
    {
        [TestMethod]
        public void LoopFoldersTest()
        {
            var mockFileIo = new Mock<IFileIoWrapper>();
            const string abcMp3 = "abc.mp3";
            const string cdeMp3 = "cde.mp3";

            var files = new[] { abcMp3, cdeMp3 };
            mockFileIo.Setup(m => m.EnumerateFiles(It.IsAny<string>())).Returns(files);
            mockFileIo.Setup(m => m.GetExtension(It.IsAny<string>())).Returns(".mp3");
            
            var sut = new FolderHandler(mockFileIo.Object);

            var mockMp3Handler = new Mock<IFileHandler>();
            sut.AddHandler(".mp3", mockMp3Handler.Object);
            sut.AddHandler(".mp4", new Mock<IFileHandler>().Object);

            sut.LoopFolder();

            mockMp3Handler.Verify(m => m.Handle(abcMp3), Times.Once);
            mockMp3Handler.Verify(m => m.Handle(cdeMp3), Times.Once);
        }
    }
}
