using Microsoft.Xna.Framework;

namespace MyGame.interfaces
{
    public interface IDrawableUpdateWithTime : IDrawable
    {
        public void Update(GameTime gameTime);
    }
}