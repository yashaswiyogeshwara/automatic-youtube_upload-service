using System;
using VideoEditor;
using Xunit;

namespace VideoEditorTest
{
    public class UnitTest1
    {
        public VideoCreator creator;
        public UnitTest1()
        {
            Arrange();
            Act();
        }

        private void Arrange()
        {
            creator = new VideoCreator();
        }

        private void Act()
        {
            creator.CreateVideo();
        }

        [Fact]
        public void Test1()
        {
            Assert.True(1 == 1);
        }
    }
}
