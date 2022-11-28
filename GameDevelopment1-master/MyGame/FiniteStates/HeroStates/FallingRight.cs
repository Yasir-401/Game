using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;
using MyGame.interfaces;

namespace MyGame.FiniteStates.HeroStates
{
   public class FallingRight:HeroState
    {
        #region Methods
        public FallingRight(Hero hero) : base(hero)
        {
            Animation = new HeroAnimationFactory().CreateAnimation(AnimationType.FallingRight, instance.Position);
        }

        public override void Handle(GameTime time)
        {
            switch (((Hero)instance).InputStatus)
            {
                case CharacterStatus.Idle:
                    ((Hero)instance).ChangeState(new IdleRight((Hero)instance));
                    break;
            }
            base.Handle(time);
        } 
        #endregion
    }
}
