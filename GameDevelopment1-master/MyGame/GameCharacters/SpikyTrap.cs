using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.Animations;
using MyGame.BaseClasses;
using MyGame.FiniteStates.spikyTrapStates;
using MyGame.interfaces;

namespace MyGame.GameCharacters
{
    public class SpikyTrap : Sprite
    {
     
        #region Methods

        public SpikyTrap(Texture2D texture,int xCoordinate,int yCoordinate) : base(texture)
        {
            State = new IdleRight(this);
            this.Position = new Vector2(xCoordinate,yCoordinate-(((BaseCharacterState)this.State).Animation.CurrentFrame.SourceRectangle.Height));
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, Position, ((BaseCharacterState)State).Animation.CurrentFrame.SourceRectangle, Color.White);
        }
        public override void Update(GameTime time)
        {
            if(State is IStateWithTime d)
                d.Handle(time);
            else if(State is IStateWithoutTime t)
                t.Handle();
        }

        #endregion
    }
}