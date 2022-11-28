using Microsoft.Xna.Framework.Input;
using MyGame.Enums;
using MyGame.inputreader;

namespace MyGame.inputreaders
{
    public class KeyBoardReader : IInputReader<CharacterStatus>
    {
        #region Methods
        public CharacterStatus ReadInput()
        {
            var keyboardState = Keyboard.GetState();
            var status = CharacterStatus.Idle;
            if (keyboardState.IsKeyDown(Keys.Left))
                status = CharacterStatus.WalkingLeft;
            else if (keyboardState.IsKeyDown(Keys.Right))
                status = CharacterStatus.WalkingRight;
            else if (keyboardState.IsKeyDown(Keys.Up))
                status = CharacterStatus.jumping;
            else if (keyboardState.IsKeyDown(Keys.Down))
                status = CharacterStatus.Falling;
            else if (keyboardState.IsKeyDown(Keys.A))
                status = CharacterStatus.Attacking;

            return status;
        } 
        #endregion
    }
}