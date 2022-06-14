using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLogic;
namespace UI
{
    internal static class WindowsFormUi
    {
        internal static void Start()
        {

            FormGameSettings gameSettingsForm = new FormGameSettings();
            getGameSettingsFromUser(gameSettingsForm);
           // if (gameSettingsForm.IsClosebByDone)
           // {
                //checkIfNamesAreNotEmpty();
                Game game = createNewGame(gameSettingsForm);
                FormCheckers formCheckers = new FormCheckers(game);
                formCheckers.ShowDialog();

          //  }

        }
        private static void getGameSettingsFromUser(FormGameSettings i_GameSettingsForm)
        {
            i_GameSettingsForm.ShowDialog();
        }
        private static Game createNewGame(FormGameSettings i_GameSettingsForm)
        {
            string playerFirstName = i_GameSettingsForm.GetFirstPlayerName();
            string playerSecondName = i_GameSettingsForm.GetSecondPlayerName();
            int boardSize = i_GameSettingsForm.GetBoardSize();
            int gameMode = i_GameSettingsForm.GetGameMode();
            Game newGame = new Game(playerFirstName, playerSecondName, boardSize, gameMode);
            return newGame;
        }
    }
}
