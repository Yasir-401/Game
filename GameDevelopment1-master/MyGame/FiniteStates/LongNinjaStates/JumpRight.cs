using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;
using MyGame.interfaces;

namespace MyGame.FiniteStates.LongNinjaStates
{
    public  class JumpRight:LongNinjaState
    {
        #region Methods
        public JumpRight(LongNinja ninja) : base(ninja)
        {
            Animation = new LongNinjaAnimationFactory().CreateAnimation(AnimationType.JumpRight, instance.Position);
        }

        public override void Handle(GameTime time)
        {
            switch (((LongNinja)instance).InputStatus)
            {
                case CharacterStatus.Falling:
                    ((LongNinja)instance).ChangeState(new FallingRight((LongNinja)instance));
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
