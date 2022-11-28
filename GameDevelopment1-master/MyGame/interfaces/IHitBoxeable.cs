using Microsoft.Xna.Framework;
using MyGame.Enums;

namespace MyGame.interfaces
{
    public interface IHitBoxeable
    {
        public Rectangle Source { get; set; }
        public HitBoxType Type { get; set; }
    }
}