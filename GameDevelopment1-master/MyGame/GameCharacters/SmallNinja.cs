using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.FiniteStates.SmallNinjaStates;
using MyGame.inputreader;
using MyGame.inputreaders;
using MyGame.interfaces;
using MyGame.Movers;
using SharpDX.Direct3D11;
using IDrawable = MyGame.interfaces.IDrawable;
using Texture2D = Microsoft.Xna.Framework.Graphics.Texture2D;

namespace MyGame.GameCharacters
{
    public class SmallNinja : Sprite,IMoveable
    {
        #region Fields
        private readonly IMover _mover;

        #endregion
        #region Properties
        public Vector2 Speed { get; }
        public CharacterStatus InputStatus { get; set; } = CharacterStatus.WalkingRight;
        #endregion
        #region Methods
        public SmallNinja(Texture2D texture,int xCoordinate,int yCoordinate,IMover mover) : base(texture)
        {
           
            State = new WalkingRight(this);
            this.Position = new Vector2(xCoordinate,yCoordinate+(((BaseCharacterState)this.State).Animation.CurrentFrame.SourceRectangle.Height+20));
            State = new WalkingRight(this);
            _mover = mover;
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            if(State is IDrawable d) 
                d.Draw(spriteBatch);
        }
        public override void Update(GameTime time)
        {
           
            Position =_mover.Move(InputStatus, this, Speed);   
            if (State is IStateWithTime s)
                s.Handle(time);
            else if (State is IStateWithoutTime t)
                t.Handle();
             
        }
        #endregion

    }
}