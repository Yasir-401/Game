using System;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;
using MyGame.interfaces;

namespace MyGame.FiniteStates.HeroStates
{
    public class JumpRight : HeroState, IStateWithTime
    {
        #region Methods
        public JumpRight(Hero hero) : base(hero)
        {
            Animation = new HeroAnimationFactory().CreateAnimation(AnimationType.JumpRight, instance.Position);
        }

        public void Handle(GameTime time)
        {
            switch (((Hero)instance).InputStatus)
            {
                case CharacterStatus.Falling:
                    ((Hero)instance).ChangeState(new FallingRight((Hero)instance));
                    break;
                case CharacterStatus.Idle:
                    ((Hero)instance).ChangeState(new IdleRight((Hero)instance));
                    break;
            }
            if (((Hero)instance).State != this)
                return;
            base.Handle(time);

        } 
        #endregion
    }
}