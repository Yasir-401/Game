using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.FiniteStates.ArrowStates;
using MyGame.interfaces;
using MyGame.Movers;
using IDrawable = MyGame.interfaces.IDrawable;

namespace MyGame.GameCharacters
{
    public class Arrow:Sprite,IMoveable
    {
        private IMover _mover;
        #region Properties
        public Vector2 Speed { get; }
        public CharacterStatus InputStatus { get; set; }
        #endregion
        #region Methods
        public Arrow(Texture2D texture,string direction,int xCoordinate,int yCoordinate) : base(texture)
        {
            if (direction == "right")
            {
                InputStatus = CharacterStatus.WalkingRight;
                State = new IdleRight(this);
            }
            else
            {
                InputStatus = CharacterStatus.WalkingLeft;
                State = new IdleLeft(this);
            }
            this.Position = new Vector2(xCoordinate,yCoordinate);
            _mover = new ArrowMover();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (State is IDrawable s)
                s.Draw(spriteBatch);
            
        }
        public override void Update(GameTime time)
        {
            _mover.Move(InputStatus, this, Speed);
             if (State is IStateWithTime s)
                s.Handle(time);
            else if (State is IStateWithoutTime t)
                t.Handle();
        } 
        #endregion


    }
}
