using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekeisFinalProject
{
    internal class GameController
    {
        public GameController()
        {
            MainUI mainUI = new MainUI();
            GameLogic gameLogic = new GameLogic();

            // Subscribe events
            gameLogic.AddEntityToBoard += mainUI.HandleAddEntityToBoard;
            gameLogic.UpdateEntityHealth += mainUI.HandleUpdateEntityHealth;
            mainUI.UpdateEntityAction += gameLogic.HandleUpdateEntityAction;
            mainUI.PlayTurn += gameLogic.HandlePlayTurn;

            gameLogic.AddEntitiesToBoard();



            Application.Run(mainUI);
        }
    }
}
