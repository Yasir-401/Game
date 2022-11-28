using Microsoft.Xna.Framework;

namespace MyGame.interfaces
{
    public interface ISimpleCollider
    {
        public bool HasCollided(Rectangle rectangle, Rectangle rectangle2);
    }
}