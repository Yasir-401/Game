using Microsoft.Xna.Framework;
using MyGame.Animations;
using MyGame.Enums;

namespace MyGame.interfaces
{
    public interface IAnimationFactory
    {
        public Animation CreateAnimation(AnimationType type, Vector2 position);
    }
}