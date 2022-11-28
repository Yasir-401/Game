using System.Collections.Generic;
using MyGame.BaseClasses;

namespace MyGame.interfaces
{
    public interface IMenu
    {
        public List<Button> Buttons { get; set; }
        public IButtonToStateBinder StateBinder { get; set; }
    }
}