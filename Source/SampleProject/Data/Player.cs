﻿using Annex.Data;
using Annex.Graphics;
using Annex.Graphics.Contexts;

namespace SampleProject.Data
{
    public class Player : Entity, IDrawableObject
    {
        public readonly PString PlayerName;
        public readonly PString PlayerSprite;

        private readonly SurfaceContext _sprite;
        private readonly TextContext _hoverName;
        private readonly PString _hoverNameFont;

        public Player() {
            this.PlayerName = new PString("Dragon Player");
            this.PlayerSprite = new PString("dragon.png");
            this._hoverNameFont = new PString("Augusta.ttf");

            this.EntityPosition.Set(300, 300);
            this.EntitySize.Set(150, 150);
            this._sprite = new SurfaceContext(this.PlayerSprite) {
                SourceSurfaceRect = new IntRect(0, 0, 384 / 4, 384 / 4),
                RenderSize = this.EntitySize,
                RenderPosition = this.EntityPosition
            };
            this._hoverName = new TextContext(this.PlayerName, this._hoverNameFont) {
                RenderPosition = this.EntityPosition,
                Alignment = new TextAlignment() {
                    Size = new Vector2f(this.EntitySize.X, - 26),
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Bottom
                },
                FontColor = new RGBA(255, 255, 255),
                FontSize = 26
            };
        }

        public void Draw(IDrawableContext surfaceContext) {
            surfaceContext.Draw(this._sprite);
            surfaceContext.Draw(this._hoverName);
        }
    }
}
