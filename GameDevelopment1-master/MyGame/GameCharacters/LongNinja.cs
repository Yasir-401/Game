using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.FiniteStates.LongNinjaStates;
using MyGame.interfaces;
using MyGame.Movers;
using IDrawable = MyGame.interfaces.IDrawable;

namespace MyGame.GameCharacters
{
    public class LongNinja : Sprite,IMoveable
    {
        #region Fields
        private readonly IMover _mover;
        #endregion
        #region Properties
        public Vector2 Speed { get; }
        public CharacterStatus InputStatus { get; set; } = CharacterStatus.WalkingRight;
        #endregion
        #region Methods
        public LongNinja(Texture2D texture,int xCoordinate,int yCoordinate,IMover mover) : base(texture)
        {
            
            State = new WalkingRight(this);
            this.Position = new Vector2(xCoordinate,yCoordinate+(((BaseCharacterState)this.State).Animation.CurrentFrame.SourceRectangle.Height)); 
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
            _mover.Move(InputStatus, this, Speed); 
            if (State is IStateWithTime s)
                s.Handle(time);
            else if (State is IStateWithoutTime t)
                t.Handle();
           
        } 
        #endregion
    }
}