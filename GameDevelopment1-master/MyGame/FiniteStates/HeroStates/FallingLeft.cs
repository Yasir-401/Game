using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.BaseClasses.SpecificCharacterStates;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;

namespace MyGame.FiniteStates.HeroStates
{
  public  class FallingLeft:HeroLeftStateBase
    {
        #region Methods
        public FallingLeft(Hero hero) : base(hero)
        {
            Animation = new HeroAnimationFactory().CreateAnimation(AnimationType.FallingLeft, instance.Position);
        }
        public override void Handle(GameTime time)
        {
            switch (((Hero)instance).InputStatus)
            {
                case CharacterStatus.Idle:
                    ((Hero)instance).ChangeState(new IdleLeft((Hero)instance));
                    break;
            }
            base.Handle(time);
        } 
        #endregion
    }
}
