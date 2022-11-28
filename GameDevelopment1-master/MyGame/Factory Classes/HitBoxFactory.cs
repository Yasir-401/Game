using System;
using Microsoft.Xna.Framework;
using MyGame.Enums;
using MyGame.Hitboxes;

namespace MyGame.Factory_Classes
{
    /// <summary>
    ///     applying of the simple factory
    /// </summary>
    public  class HitBoxFactory
    {
        #region Methods
        public static HitBox CreateHitbox(Vector2 position, Tuple<int, int> widthAndHeight, HitBoxType type,
            Rectangle substractionValues)
        {
            var hitbox = new Rectangle((int)position.X + substractionValues.X, (int)position.Y + substractionValues.Y,
                widthAndHeight.Item1 - substractionValues.Width, widthAndHeight.Item2 - substractionValues.Height);
            return new HitBox(hitbox, type, substractionValues, widthAndHeight);
        } 
        #endregion
    }
}