using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixabayClient.Model
{
    public class ImageResponse
    {   
        public int Total { get; set; }
        public long TotalHits { get; set; }
        public List<ImageInfo> Hits { get; set; }
    }
    public class ImageInfo
    { 
            public long Id{get; set;}
            public string PageURL{get; set;}
            public string Type{get; set;}
            public string Tags{get; set;}
            public string PreviewURL{get; set;}
            public int PreviewWidth{get; set;}
            public int PreviewHeight{get; set;}
            public string WebformatURL{get; set;}
            public int WebformatWidth{get; set;}
            public int WebformatHeight{get; set;}
            public string LargeImageURL{get; set;}
            public int ImageWidth{get; set;}
            public int ImageHeight{get; set;}
            public int ImageSize{get; set;}
            public long Views{get; set;}
            public long Downloads{get; set;}
            public long Collections{get; set;}
            public long Likes{get; set;}
            public long Comments{get; set;}
            public long User_id{get; set;}
            public string User{get; set;}
            public string UserImageURL{get; set;}
    }
}
