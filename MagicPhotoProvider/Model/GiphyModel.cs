using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicPhotoProvider.Model
{
    public class Gighy
    {
        public GiphyModel[] data { get; set; }
    }
    public class GiphyModel
    {
        public string id { get; set; }
        public string title { get; set; }
        public image images { get; set; }
    }
    public class image
    {
        public original original_still { get; set; }
    }
    public class original
    {
        public string url { get; set; }
        public string width { get; set; }
        public string height { get; set; }
    }
}
