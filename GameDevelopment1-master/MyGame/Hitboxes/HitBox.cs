using System;
using Microsoft.Xna.Framework;
using MyGame.Enums;
using MyGame.interfaces;

namespace MyGame.Hitboxes
{
    public class HitBox : IHitBoxeable
    {
        #region Methods

        public HitBox(Rectangle rectangle, HitBoxType type, Rectangle valuesOfSubstraction,
            Tuple<int, int> widthAndHeight)
        {
            Source = rectangle;
            Type = type;
            ValuesOfSubstraction = valuesOfSubstraction;
            Measures = widthAndHeight;
        }

        #endregion

        #region Properties

        public Rectangle Source { get; set; }
        public HitBoxType Type { get; set; }
        public Rectangle ValuesOfSubstraction { get; }
        public Tuple<int, int> Measures { get; }

        #endregion
    }
}