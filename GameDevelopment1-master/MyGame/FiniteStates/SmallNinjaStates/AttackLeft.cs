using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.BaseClasses.SpecificCharacterStates;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;

namespace MyGame.FiniteStates.SmallNinjaStates
{
 public   class AttackLeft:SmallNinjaLeftBase
    {
        #region Methods
        public AttackLeft(SmallNinja ninja) : base(ninja)
        {
            Animation = new SmallNinjaAnimationFactory().CreateAnimation(AnimationType.AttackLeft, instance.Position);
        }
        public override void Handle(GameTime time)
        {
            if (Animation.CurrentFrame == Animation.Frames[Animation.Frames.Count - 1])
            {
                ((SmallNinja)instance).ChangeState(new IdleLeft((SmallNinja)instance));
            }

            base.Handle(time);
        } 
        #endregion
    }
}
