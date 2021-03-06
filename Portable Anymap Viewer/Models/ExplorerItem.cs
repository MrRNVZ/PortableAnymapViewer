﻿using Windows.UI.Xaml.Media.Imaging;

namespace Portable_Anymap_Viewer.Models
{
    public class ExplorerItem
    {
        public BitmapImage Thumbnail { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string DisplayName { get; set; }
        public string DisplayType { get; set; }
        public string Path { get; set; }
        public string Token { get; set; }
    }
}
