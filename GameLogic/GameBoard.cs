using System;

namespace GameLogic
{
    public class GameBoard
    {
        private int m_SizeOfBoard;
        private char[,] m_GameBoard;
        private int m_GameBoardCounter = 0;

        public int Counter
        {
            get
            {
                return m_GameBoardCounter;
            }

            set
            {
                m_GameBoardCounter = value;
            }
        }

        public char[,] Board
        {
            get
            {
                return m_GameBoard;
            }

            set
            {
                m_GameBoard = value;
            }
        }

        public int SizeOfBoard
        {
            get
            {
                return m_SizeOfBoard;
            }

            set
            {
                m_SizeOfBoard = value;
            }
        }

        public GameBoard(int i_SizeOfBoard)
        {
            m_SizeOfBoard = i_SizeOfBoard;
            m_GameBoard = new char[m_SizeOfBoard, m_SizeOfBoard]; 
            EmptyBoard();
        }

        public void EmptyBoard()
        {
            for (int i = 0; i < m_SizeOfBoard; i++)
            {
                for (int j = 0; j < m_SizeOfBoard; j++)
                {
                    m_GameBoard[i, j] = ' ';
                }
            }
        }

        public void AddSymbolToBoard(char i_Symbol, int i_Row, int i_Col)
        {
            m_GameBoard[i_Row - 1, i_Col - 1] = i_Symbol;
        }
    }
}
