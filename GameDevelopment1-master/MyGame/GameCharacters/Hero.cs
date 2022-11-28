
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MyGame.Animations;
using MyGame.BaseClasses;
using MyGame.Enums;
using MyGame.FiniteStates.HeroStates;
using MyGame.inputreader;
using MyGame.inputreaders;
using MyGame.interfaces;
using MyGame.Movers;
using IDrawable = MyGame.interfaces.IDrawable;

namespace MyGame.GameCharacters
{
    public class Hero : Sprite, IMoveable
    {
        #region Fields
        private static Hero hero;
        private readonly IInputReader<CharacterStatus> _inputReader;
        private readonly IMover _mover;
        #endregion
        #region Properties

        public Vector2 Speed { get; private set; }
        public CharacterStatus InputStatus { get; set; }

        public bool
            IsShooted { get; set; } //later to check when the arrow is shooted so it can be actually added to the game

        #endregion
        #region Methods
        private Hero(Texture2D texture,int xCoordinate,int yCoordinate,IMover mover) : base(texture)
        {
          
            State = new IdleRight(this);
            this.Position = new Vector2(xCoordinate,yCoordinate+(((BaseCharacterState)this.State).Animation.CurrentFrame.SourceRectangle.Height-27));
            _inputReader = new KeyBoardReader();
            _mover = mover;
        }
        public static Hero GetInstance(Texture2D texture,int xCoordinate,int yCoordinate,IMover mover)
        {
            if (hero == null)
                return new Hero(texture,xCoordinate,yCoordinate,mover);
            return hero;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (State is IDrawable s)
                s.Draw(spriteBatch);
        }
        public override void Update(GameTime time)
        {
            if (InputStatus != CharacterStatus.Falling&&InputStatus!=CharacterStatus.jumping)
                InputStatus = _inputReader.ReadInput();
            _mover.Move(InputStatus, this, Speed);       
            if (State is IStateWithTime s)
                s.Handle(time);
            else if (State is IStateWithoutTime t)
                t.Handle();
        }

        #endregion
    }
}