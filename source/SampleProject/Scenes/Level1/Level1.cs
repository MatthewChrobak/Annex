﻿using Annex.Events;
using Annex.Graphics;
using Annex.Scenes;
using Annex.Scenes.Components;
using SampleProject.Models;

namespace SampleProject.Scenes.Level1
{
    public class Level1 : Scene
    {
        private readonly GrassyPlain _grassyPlain;
        private readonly Player _player;

        public Level1() {
            this._grassyPlain = new GrassyPlain();
            this._player = new Player();

            var camera = GameWindow.Singleton.Context.GetCamera();
            camera.Follow(this._player.Position);

            this.Events.AddEvent(PriorityType.INPUT, HandlePlayerInput, 10);
        }

        private ControlEvent HandlePlayerInput() {
            var ctx = GameWindow.Singleton.Context;

            float speed = 1;
            if (ctx.IsKeyDown(KeyboardKey.Up)) {
                this._player.Position.Y -= speed;
            }
            if (ctx.IsKeyDown(KeyboardKey.Down)) {
                this._player.Position.Y += speed;
            }
            if (ctx.IsKeyDown(KeyboardKey.Left)) {
                this._player.Position.X -= speed;
            }
            if (ctx.IsKeyDown(KeyboardKey.Right)) {
                this._player.Position.X += speed;
            }

            return ControlEvent.NONE;
        }

        public override void HandleCloseButtonPressed() {
            SceneManager.Singleton.LoadScene<GameClosing>();
        }

        public override void DrawScene(IDrawableContext surfaceContext) {
            this._grassyPlain.Draw(surfaceContext);
            this._player.Draw(surfaceContext);
        }
    }
}