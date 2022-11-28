using System.Collections.Generic;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.interfaces;

namespace MyGame.Animations
{
    public class Animation
    {
        #region Fields
        private int _counter;
        private double _frameMovement;
        private int _counterForJumping = 0;
        #endregion
        #region Properties

        public List<AnimationFrame> Frames { get; }
        public AnimationFrame CurrentFrame { get; set; }

        #endregion
        #region Methods
        public Animation()
        {
            Frames = new List<AnimationFrame>();
        }
        public void AddFrame(AnimationFrame animationFrame)
        {
            Frames.Add(animationFrame);
            CurrentFrame = Frames[0]; //Take last element because we want the currentframe the last added one!!!!
        }
        public void Update(GameTime gameTime, Sprite sprite)
        {
            #region Must an update method in hitbox self (later to be added!!!!)
            for (var i = 0; i < CurrentFrame.HitBoxes.Count; i++)
                CurrentFrame.HitBoxes[i].Source = new Rectangle(
                    (int)sprite.Position.X + CurrentFrame.HitBoxes[i].ValuesOfSubstraction.X,
                    (int)sprite.Position.Y + CurrentFrame.HitBoxes[i].ValuesOfSubstraction.Y,
                    CurrentFrame.HitBoxes[i].Measures.Item1 - CurrentFrame.HitBoxes[i].ValuesOfSubstraction.Width,
                    CurrentFrame.HitBoxes[i].Measures.Item2 - CurrentFrame.HitBoxes[i].ValuesOfSubstraction.Height);
            #endregion
            CurrentFrame = Frames?[_counter];
            _frameMovement += CurrentFrame.SourceRectangle.Width * gameTime.ElapsedGameTime.TotalSeconds;
           
            if (_frameMovement >= CurrentFrame.SourceRectangle.Width / 15)
            {
                _counter++;
                _frameMovement = 0;
            }
            if (_counter >= Frames.Count)
                _counter = 0;
            if (sprite is IMoveable moveAbleObject)
            {
                if (moveAbleObject.InputStatus == CharacterStatus.jumping)
                    if (++_counterForJumping > 10)
                        moveAbleObject.InputStatus = CharacterStatus.Falling;
            }
        }
        #endregion
    }
}