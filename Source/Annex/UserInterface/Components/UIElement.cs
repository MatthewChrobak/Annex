﻿using Annex.Data.Binding;
using Annex.Graphics;
using Annex.UserInterface.Controllers;

namespace Annex.UserInterface.Components
{
    public abstract class UIElement : InputController, IDrawableObject
    {
        private readonly string ElementID;
        public readonly PVector Size;
        public readonly PVector Position;
        public bool IsFocus { get; internal set; }

        public UIElement(string elementID) {
            this.ElementID = elementID;
            this.Size = new PVector(100, 100);
            this.Position = new PVector();
        }

        public abstract void Draw(IDrawableContext surfaceContext);

        public virtual UIElement? GetElementById(string id) {
            if (this.ElementID == id) {
                return this;
            }
            return null;
        }

        internal override bool HandleSceneFocusMouseDown(int x, int y) {
            if (x < this.Position.X) {
                return false;
            }
            if (y < this.Position.Y) {
                return false;
            }
            if (x > this.Position.X + this.Size.X) {
                return false;
            }
            if (y > this.Position.Y + this.Size.Y) {
                return false;
            }
            this.IsFocus = true;
            UI.Singleton.CurrentScene.FocusObject = this;
            return true;
        }
    }
}
