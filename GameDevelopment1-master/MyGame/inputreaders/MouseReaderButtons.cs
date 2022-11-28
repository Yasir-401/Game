using Microsoft.Xna.Framework.Input;
using MyGame.inputreader;

namespace MyGame.inputreaders
{
    public class MouseReaderButtons : IInputReader<MouseState>
    {
        #region Methods
        public MouseState ReadInput()
        {
            return Mouse.GetState();
        } 
        #endregion
    }
}