
using Microsoft.Xna.Framework;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;

namespace MyGame.FiniteStates.LongNinjaStates
{
  public  class FallingRight:LongNinjaState
    {
        #region Methods
        public FallingRight(LongNinja ninja) : base(ninja)
        {
            Animation = new LongNinjaAnimationFactory().CreateAnimation(AnimationType.FallingRight, instance.Position);
        }
        public override void Handle(GameTime time)
        {
            switch (((LongNinja)instance).InputStatus)
            {
                case CharacterStatus.Idle:
                    ((LongNinja)instance).ChangeState(new IdleRight((LongNinja)instance));
                    break;
            }
             if(((LongNinja)instance).State!=this)
                return;
            base.Handle(time);
        } 
        #endregion
    }
}
