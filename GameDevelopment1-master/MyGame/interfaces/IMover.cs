using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.Enums;

namespace MyGame.interfaces
{
    public interface IMover
    {
        public Vector2 Move(CharacterStatus status, Sprite sprite, Vector2 speed);
    }
}