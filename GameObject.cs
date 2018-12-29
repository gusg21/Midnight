using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Midnight
{
    public abstract class GameObject
    {
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(GameTime gameTime, SpriteBatch batch);

        public GameObject parent;

        public bool Alive { get; private set; } = true;

        public void Kill()
        {
            Alive = false;
        }

        public void Revive()
        {
            Alive = true;
        }
    }
}
