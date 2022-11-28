using System.Collections.Generic;
using Microsoft.Xna.Framework;
using MyGame.Hitboxes;

namespace MyGame.Animations
{
    public class AnimationFrame
    {
        #region Methods
        public AnimationFrame(Rectangle rectangle)
        {
            SourceRectangle = rectangle;
        }
        #endregion

        #region Properties
        public Rectangle SourceRectangle { get; set; }
        public List<HitBox> HitBoxes { get; set; } 
        #endregion
    }
}