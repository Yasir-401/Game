using System;
using System.Collections.Generic;
using System.Text;
using MyGame.BaseClasses;
using MyGame.BaseClasses.SpecificCharacterStates;
using MyGame.Enums;
using MyGame.Factory_Classes;
using MyGame.GameCharacters;
using MyGame.interfaces;

namespace MyGame.FiniteStates.ArrowStates
{
   public class IdleLeft:ArrowLeftBase
    {
        #region Methods
        public IdleLeft(Arrow arrow) : base(arrow)
        {
            Animation = new ArrowAnimationFactory().CreateAnimation(AnimationType.IdleLeft, instance.Position);
        } 
        #endregion
    }
}
