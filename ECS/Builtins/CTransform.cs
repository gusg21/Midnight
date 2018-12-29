using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Midnight.ECS.Builtins
{
    public class CTransform : Component
    {
        public Vector2 position;
        public Vector2 scale;

        public CTransform()
        {
            this.position = Vector2.Zero;
            this.scale = Vector2.One;
        }

        public CTransform(Vector2 position, Vector2 scale)
        {
            this.position = position;
            this.scale = scale;
        }

        public override void Draw(GameTime gameTime, SpriteBatch batch)
        {
        }

        public override void Update(GameTime gameTime)
        {
        }
    }
}
