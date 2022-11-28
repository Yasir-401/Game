using Microsoft.Xna.Framework;
using MyGame.BaseClasses.SpecificCharacterStates;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;
using MyGame.interfaces;

namespace MyGame.FiniteStates.HeroStates
{
    public class JumpLeft : HeroLeftStateBase, IStateWithTime
    {
        #region Methods

        public JumpLeft(Hero hero) : base(hero)
        {
            Animation = new HeroAnimationFactory().CreateAnimation(AnimationType.JumpLeft, instance.Position);
        }

        public void Handle(GameTime time)
        {
            switch (((Hero)instance).InputStatus)
            {
                case CharacterStatus.Falling:
                    ((Hero)instance).ChangeState(new FallingLeft((Hero)instance));
                    break;
                    case CharacterStatus.Idle:
                    ((Hero)instance).ChangeState(new IdleLeft((Hero)instance));
                    break;
            }
            if(((Hero)instance).State!=this)
                return;
            base.Handle(time);
        }

        #endregion
    }
}