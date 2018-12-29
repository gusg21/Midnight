using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Midnight
{
    public class GameObjectGroup : GameObject
    {
        public List<GameObject> children;

        public GameObjectGroup()
        {
            children = new List<GameObject>();
        }

        public void Add(GameObject child)
        {
            children.Add(child);
            child.parent = this;
        }

        public override void Update(GameTime gameTime)
        {
            foreach (GameObject @object in children)
            {
                @object.Update(gameTime);
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch batch)
        {
            foreach (GameObject @object in children)
            {
                @object.Draw(gameTime, batch);
            }
        }
    }
}
