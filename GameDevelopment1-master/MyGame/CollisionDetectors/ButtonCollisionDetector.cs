using Microsoft.Xna.Framework;
using MyGame.interfaces;

namespace MyGame.CollisionDetectors
{
    public class ButtonCollisionDetector : ISimpleCollider
    {
        public bool HasCollided(Rectangle rectangle, Rectangle rectangle2)
        {
            if (rectangle2.X >= rectangle.X && rectangle2.Y >= rectangle.Y &&
                rectangle2.X <= rectangle.X + rectangle.Width && rectangle2.Y <= rectangle.Y + rectangle.Height)
                return true;
            return false;
        }
    }
}