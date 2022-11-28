using System.Collections.Generic;
using MyGame.BaseClasses;
using MyGame.interfaces;

namespace MyGame.Inventories
{
    public class CurrentMachineInventory:IInventory<FiniteStateMachine>
    {
        #region Fields

        private static readonly CurrentMachineInventory _instance = new CurrentMachineInventory();

        #endregion
        #region Properties
        public List<FiniteStateMachine> Items { get; set; } = new List<FiniteStateMachine>();
        #endregion
        #region Methods
        private CurrentMachineInventory()
        {
        }
        public static CurrentMachineInventory GetInstance()
        {
            return _instance;
        }
        #endregion
    }
}