using System.Diagnostics;
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;
using MyGame.inputreader;
using MyGame.inputreaders;
using MyGame.interfaces;

namespace MyGame.FiniteStates.HeroStates
{
    public class IdleRight : HeroState, IStateWithTime
    {
        #region Fields

        private IInputReader<CharacterStatus> _inputReader = new KeyBoardReader();

        #endregion

        #region Methods

        public IdleRight(Hero hero) : base(hero)
        {
            Animation = new HeroAnimationFactory().CreateAnimation(AnimationType.IdleRight, instance.Position);
        }

        public void Handle(GameTime time)
        {
            switch (((Hero)instance).InputStatus)
            {
                case CharacterStatus.WalkingRight:
                    ((Hero)instance).ChangeState(new WalkingRight((Hero)instance));
                    break;
                case CharacterStatus.WalkingLeft:
                    ((Hero)instance).ChangeState(new IdleLeft((Hero)instance));
                    break;
                case CharacterStatus.Falling:
                    ((Hero)instance).ChangeState(new FallingRight((Hero)instance));
                    break;
                case CharacterStatus.jumping:
                    ((Hero)instance).ChangeState(new JumpRight((Hero)instance));
                    break;
                case CharacterStatus.Attacking:
                    ((Hero)instance).ChangeState(new AttackRight((Hero)instance));
                    break;
            }
            if(((Hero)instance).State!=this)
                return;
            base.Handle(time);
        }

        #endregion
    }
}