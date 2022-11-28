using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses.SpecificCharacterStates;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;

namespace MyGame.FiniteStates.SmallNinjaStates
{
  public  class JumpLeft:SmallNinjaLeftBase
    {
        #region Methods
        public JumpLeft(SmallNinja ninja) : base(ninja)
        {
            Animation = new SmallNinjaAnimationFactory().CreateAnimation(AnimationType.JumpLeft, instance.Position);
        }

        public override void Handle(GameTime time)
        {
            switch (((SmallNinja)instance).InputStatus)
            {
                case CharacterStatus.Falling:
                    ((SmallNinja)instance).ChangeState(new FallingLeft((SmallNinja)instance));
                    break;
                case CharacterStatus.Idle:
                    ((SmallNinja)instance).ChangeState(new IdleLeft((SmallNinja)instance));
                    break;
            }
            if (((SmallNinja)instance).State != this)
                return;
            base.Handle(time);
        } 
        #endregion
    }
}
