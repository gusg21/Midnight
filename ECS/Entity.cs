using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Midnight.ECS.Builtins;

namespace Midnight.ECS
{
    public class Entity : GameObject
    {
        public CTransform transform;
        protected List<Component> components;

        public Entity()
        {
            transform = new CTransform();
            components = new List<Component>();
        }

        public void AddComponent(Component component)
        {
            components.Add(component);
            component.parent = this;
        }

        public List<Component> GetComponents(string type)
        {
            List<Component> returns = new List<Component>();

            foreach (Component component in components)
            {
                if (component.type == type)
                {
                    returns.Add(component);
                }
            }

            return returns;
        }

        public Component GetComponent(string type)
        {
            foreach (Component component in components)
            {
                if (component.type == type)
                {
                    return component;
                }
            }

            return null;
        }

        public override void Draw(GameTime gameTime, SpriteBatch batch)
        {
            foreach (Component component in components)
            {
                component.Draw(gameTime, batch);
            }
        }

        public override void Update(GameTime gameTime)
        {
            foreach (Component component in components)
            {
                component.Update(gameTime);
            }
        }
    }
}
