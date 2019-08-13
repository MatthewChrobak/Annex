﻿using Annex.Graphics.Contexts;

namespace Annex.Graphics
{
    public interface IDrawableContext
    {
        void Draw(TextContext ctx);
        void Draw(TextureContext ctx);

        void BeginDrawing();
        void EndDrawing();

        void SetVisible(bool visible);
    }
}
