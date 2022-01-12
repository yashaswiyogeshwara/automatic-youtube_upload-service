using FFMpegCore;
using System;

namespace VideoEditor
{
    public class VideoCreator
    {
        public void CreateVideo() {
            
            ImageInfo[] images = GetImages();
            ImageInfo image2 = ImageInfo.FromPath(@"C:\Users\yogeshwaray\Pictures\Screenshots\Screenshot1.png");
            ImageInfo image1 = ImageInfo.FromPath(@"C:\Users\yogeshwaray\Pictures\Screenshots\Screenshot2.png");
            ImageInfo image = ImageInfo.FromPath(@"C:\Users\yogeshwaray\Pictures\Screenshots\Screenshot3.png");
            FFMpeg.JoinImageSequence("SampleOutput1.mp4", 1, image,
                image1,image,image1,image2);
            FFMpeg.ReplaceAudio("SampleOutput1.mp4", @"E:\YashaswiYogeshwara\Youtube\The Thought of You - TrackTribe.mp3", "SampleOutputWithAudioNew.mp4");
            
        }
        public ImageInfo[] GetImages() {
           ImageInfo image2 =  ImageInfo.FromPath(@"C:\Users\yogeshwaray\Pictures\Screenshots\Screenshot1.png");
            ImageInfo image1 = ImageInfo.FromPath(@"C:\Users\yogeshwaray\Pictures\Screenshots\Screenshot2.png");
            ImageInfo image =  ImageInfo.FromPath(@"C:\Users\yogeshwaray\Pictures\Screenshots\Screenshot3.png");
            ImageInfo[] info = new ImageInfo[3];
            info[0] = image2;
            info[1] = image1;
            info[2] = image;
            return info;
        }

    }
}
