using System;
using System.Windows.Forms;
using GameLogic;

namespace UserInterface
{
    public class Ui
    {
        private MyGameLogic m_GameLogic;
        private GameBoardForm m_Board;

        public void RunGame()
        {
            InitMenu gameSettingMenu = new InitMenu();
            gameSettingMenu.ShowDialog();
            if(gameSettingMenu.isStartButtonPressed == true)
            {
                m_GameLogic = new MyGameLogic(gameSettingMenu.PlayerOneName, gameSettingMenu.PlayerTwoName, gameSettingMenu.IsHumanPlayer, gameSettingMenu.BoardSize);
                m_Board = new GameBoardForm(gameSettingMenu.BoardSize, gameSettingMenu.PlayerOneName, gameSettingMenu.PlayerTwoName, ref m_GameLogic);
                m_Board.ShowDialog();
                m_Board.Close();
            }
        }
    }
}
