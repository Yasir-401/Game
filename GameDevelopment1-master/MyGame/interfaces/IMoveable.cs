using Microsoft.Xna.Framework;
using MyGame.Enums;

namespace MyGame.interfaces
{
    public interface IMoveable
    {
        public Vector2 Speed { get; }
        public CharacterStatus InputStatus { get; set; }
    }
}