using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Midnight.Math
{
    public class Rectangle
    {
        public float x;
        public float y;
        public float width;
        public float height;

        public Vector2 Location { get { return new Vector2(x, y); } }
        public Vector2 TopLeft { get { return Location; } }
        public Vector2 TopCenter { get { return new Vector2(x + (width / 2), y); } }
        public Vector2 TopRight { get { return new Vector2(x + width, y); } }
        public Vector2 CenterLeft { get { return new Vector2(x, y + (height / 2)); } }
        public Vector2 Center { get { return new Vector2(x + (width / 2), y + (height / 2)); } }
        public Vector2 CenterRight { get { return new Vector2(x + width, y + (height / 2)); } }
        public Vector2 BottomLeft { get { return new Vector2(x, y + height); } }
        public Vector2 BottomCenter { get { return new Vector2(x + (width / 2), y + height); } }
        public Vector2 BottomRight { get { return new Vector2(x + width, y + height); } }

        public float Left { get { return x; } }
        public float Right { get { return x + width; } }
        public float Top { get { return y; } }
        public float Bottom { get { return y + height; } }

        public Rectangle(float x, float y, float width, float height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public bool Intersects(Rectangle other)
        {
            return (
                (Left < other.Right) && (Right > other.Left) && (Top < other.Bottom) && (Bottom > other.Top)
                );
        }
    }
}
