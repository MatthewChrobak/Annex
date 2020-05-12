﻿using Annex.Assets;
using SFML.Graphics;
using System.IO;

namespace Annex.Graphics.Sfml
{
    public class SfmlFontLoader : IAssetInitializer
    {
        public readonly string AssetPath;

        public SfmlFontLoader(string path) {
            this.AssetPath = path;
        }

        public object Load(IAssetInitializerArgs args, IAssetLoader assetLoader) {
            Debug.Assert(args is SfmlFontLoaderArgs, $"{nameof(SfmlFontLoader)} requires {nameof(SfmlFontLoaderArgs)} args");
            return new Font(assetLoader.GetString(args.Key));
        }

        public bool Validate(IAssetInitializerArgs args) {
            args.Key = Path.Combine(this.AssetPath, args.Key);
            return args.Key.EndsWith(".ttf");
        }
    }
}
