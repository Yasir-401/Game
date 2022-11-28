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
  public  class FallingLeft:LongNinjaLeftStateBase
    {
        #region Methods
        public FallingLeft(LongNinja ninja) : base(ninja)
        {
            Animation = new LongNinjaAnimationFactory().CreateAnimation(AnimationType.FallingLeft, instance.Position);
        }

        public override void Handle(GameTime time)
        {
            switch (((LongNinja)instance).InputStatus)
            {
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
