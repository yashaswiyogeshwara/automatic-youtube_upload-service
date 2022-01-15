using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xabe.FFmpeg;

namespace VideoEditor
{
    public class VideoCreator
    {
        public async Task  CreateVideo() {
            IEnumerable<string> files = Directory.EnumerateFiles(@"E:\Projects\automatic-youtube_upload-service\Files\Images\13-01-2022\");

            await FFmpeg.Conversions.New()
                .SetInputFrameRate(0.2)
                .BuildVideoFromImages(files)
                .SetFrameRate(1)
                .SetPixelFormat(PixelFormat.yuvj411p)
                .SetOutput(@"E:\Projects\automatic-youtube_upload-service\Files\outputfile.mp4")
                .Start();
            IConversion conversion = await FFmpeg.Conversions.FromSnippet
                  .AddAudio(@"E:\Projects\automatic-youtube_upload-service\Files\outputfile.mp4",
                  @"E:\Projects\automatic-youtube_upload-service\Files\Audio\hidden-place-extended-version-13891.mp3",
                  @"E:\Projects\automatic-youtube_upload-service\Files\Output\14-01-2021\HiddenPlaceVideo.mp4");
            await conversion.Start();
        }


       

    }
}
