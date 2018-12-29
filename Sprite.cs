using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Midnight.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Midnight
{
    public class Sprite
    {
        public Texture2D texture;
        public float angle;
        public Color tint;
        public Vector2 origin;

        static Sprite SpriteFromPath(string filePath, ContentManager content)
        {
            return new Sprite(TextureLoader.Load(filePath, content));
        }

        public Sprite(Texture2D texture)
        {
            this.texture = texture;
            angle = 0f;
            tint = Color.White;
        }

        public Sprite(Texture2D texture, float angle)
        {
            this.texture = texture;
            this.angle = angle;
            tint = Color.White;
        }

        public Sprite(Texture2D texture, float angle, Color tint)
        {
            this.texture = texture;
            this.angle = angle;
            this.tint = tint;
        }
    }
}
