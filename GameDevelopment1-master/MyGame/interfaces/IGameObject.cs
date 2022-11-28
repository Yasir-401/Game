using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MyGame.interfaces
{
    public interface IGameObject : IDrawable
    {
        public Vector2 Position { get; set; }
        public void Update(GameTime time);
        public void Draw(SpriteBatch spriteBatch);
    }
}