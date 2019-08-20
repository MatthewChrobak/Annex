﻿namespace Annex.Scenes.Controllers
{
    public abstract class InputController
    {
        public virtual void HandleCloseButtonPressed() {

        }

        public virtual void HandleMouseButtonPressed(MouseButton button, float worldX, float worldY, int mouseX, int mouseY) {

        }

        public virtual void HandleMouseButtonReleased(MouseButton button, float worldX, float worldY, int mouseX, int mouseY) {

        }

        public virtual void HandleKeyboardKeyPressed(KeyboardKey key) {

        }
        
        public virtual void HandleKeyboardKeyReleased(KeyboardKey key) {

        }

        internal virtual bool HandleSceneFocusMouseDown(int x, int y) {
            return false;
        }
    }
}
