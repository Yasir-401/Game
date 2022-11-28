using System.Collections.Generic;
using MyGame.BaseClasses;
using MyGame.Buttons;
using MyGame.FiniteStates.GameStates;
using MyGame.interfaces;
using MyGame.Inventories;
using MyGame.TrulyGame;

namespace MyGame.Binders
{
    public class ButtonToStateBinder : IButtonToStateBinder
    {
        #region Fields
        private static readonly Dictionary<Button, GameState> relations = new Dictionary<Button, GameState>
        {
            {
                new StartButton(TextureInventory.GetInstance().GiveRequestedResource("StartButton")),
                new Running((MyGameWrapper)CurrentMachineInventory.GetInstance().Items[0])
            }
        };
        private static  ButtonToStateBinder Instance = new ButtonToStateBinder();
        #endregion
        #region Methods
        public GameState BindButtonToState(Button button)
        {
            GameState wantedGameState = null;
            foreach (var key in relations.Keys)
                if (key.GetType() == button.GetType())
                    return wantedGameState = relations[key];
            return wantedGameState;
        }
        private ButtonToStateBinder() { }
        public static ButtonToStateBinder GetInstance()
        {
            return Instance;
        }
        #endregion
    }
}