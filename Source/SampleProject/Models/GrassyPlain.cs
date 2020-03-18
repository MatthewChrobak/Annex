﻿using Annex.Graphics;
using Annex.Graphics.Contexts;

namespace SampleProject.Models
{
    public class GrassyPlain : IDrawableObject
    {
        private readonly TextureContext _plainTexture;

        public GrassyPlain() {
            this._plainTexture = new TextureContext("plain.png");
        }

        public void Draw(Canvas canvas) {
            canvas.Draw(this._plainTexture);
        }
    }
}