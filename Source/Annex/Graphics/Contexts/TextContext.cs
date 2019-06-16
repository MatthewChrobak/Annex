﻿using Annex.Data;
using Annex.Data.Shared;

namespace Annex.Graphics.Contexts
{
    public class TextContext
    {
        public String RenderText { get; set; }

        public Vector RenderPosition { get; set; }
        public TextAlignment? Alignment { get; set; }

        public String FontName { get; set; }
        public uint FontSize { get; set; }
        public RGBA FontColor { get; set; }

        public float BorderThickness { get; set; }
        public RGBA BorderColor { get; set; }

        public bool UseUIView { get; set; }

        public TextContext(String text, String font) {
            this.RenderText = text;

            this.RenderPosition = new Vector();
            this.Alignment = null;

            this.FontName = font;
            this.FontSize = 12;
            this.FontColor = new RGBA();

            this.BorderThickness = 0;
            this.BorderColor = new RGBA();

            this.UseUIView = false;
        }
    }
}
