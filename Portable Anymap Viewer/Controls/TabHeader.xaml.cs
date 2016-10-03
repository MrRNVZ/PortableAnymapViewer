﻿using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Portable_Anymap_Viewer.Controls
{
    public sealed partial class TabHeader : UserControl
    {
        public string Glyph
        {
            get { return GetValue(GlyphProperty) as string; }
            set { SetValue(GlyphProperty, value); }
        }

        public static readonly DependencyProperty GlyphProperty = DependencyProperty.Register("Glyph", typeof(string), typeof(TabHeader), null);

        public string Label
        {
            get { return GetValue(LabelProperty) as string; }
            set { SetValue(LabelProperty, value); }
        }

        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(TabHeader), null);

        public TabHeader()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }
    }
}
