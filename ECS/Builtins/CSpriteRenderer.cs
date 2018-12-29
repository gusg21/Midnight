using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Midnight.ECS.Builtins
{
    public class CSpriteRenderer : Component
    {
        Sprite sprite;

        public CSpriteRenderer(Sprite sprite)
        {
            this.sprite = sprite;
        }

        public override void Draw(GameTime gameTime, SpriteBatch batch)
        {
            batch.Draw(sprite.texture, parent.transform.position, sprite.texture.Bounds, sprite.tint, sprite.angle, sprite.origin);
        }

        public override void Update(GameTime gameTime)
        {
        }
    }
}
