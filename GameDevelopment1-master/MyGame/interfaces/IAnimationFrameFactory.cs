using MyGame.Animations;
using MyGame.Enums;

namespace MyGame.interfaces
{
    public interface IAnimationFrameFactory
    {
        public Animation CreateAnimation(AnimationType type);
    }
}