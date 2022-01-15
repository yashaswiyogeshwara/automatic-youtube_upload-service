using PixabayClient;
using System;
using System.Threading.Tasks;
using VideoEditor;
using Xunit;

namespace VideoEditorTest
{
    public class UnitTest1
    {
        public VideoCreator creator;
        public Client client;
        public UnitTest1()
        {
            Arrange();
            Act();
        }

        private void Arrange()
        {
            //creator = new VideoCreator();
             client = new Client();
               
        }

        private void Act()
        {
            
        }

        [Fact]
        public async Task Test1()
        {
            //await creator.CreateVideo();
            await client.GetImages();
            Assert.True(1 == 1);
        }
    }
}
