using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses.SpecificCharacterStates;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;

namespace MyGame.FiniteStates.LongNinjaStates
{
  public  class JumpLeft:LongNinjaLeftStateBase
    {
        #region Methods
        public JumpLeft(LongNinja ninja) : base(ninja)
        {
            Animation = new LongNinjaAnimationFactory().CreateAnimation(AnimationType.JumpLeft, instance.Position);
        }

        public override void Handle(GameTime time)
        {
            switch (((LongNinja)instance).InputStatus)
            {
                case CharacterStatus.Falling:
                    ((LongNinja)instance).ChangeState(new FallingLeft((LongNinja)instance));
                    break;
                case CharacterStatus.Idle:
                    ((LongNinja)instance).ChangeState(new IdleLeft((LongNinja)instance));

                    break;
            }
            if(((LongNinja)instance).State!=this)
                return;
            base.Handle(time);
        } 
        #endregion
    }
}
