using System;
using System.Runtime.Remoting.Messaging;

namespace GameLogic
{
    public class Player
    {
        private readonly string r_PlayerName;
        private int m_PlayerScore;
        private char m_PlayerSymbol;
        private bool m_IsHuman;
        private int m_PlayerNumber;

        public string PlayerName
        {
            get
            {
                return r_PlayerName;
            }
        }

        public int PlayerNumber
        {
            get
            {
                return m_PlayerNumber;
            }

            set
            {
                m_PlayerNumber = value;
            }
        }

        public int CurrentScore
        {
            get
            {
                return m_PlayerScore;
            }

            set
            {
                m_PlayerScore = value;
            }
        }

        public bool IsPlayerHuman
        {
            get
            {
                return m_IsHuman;
            }

            set
            {
                m_IsHuman = value;
            }
        }

        public char Symbol
        {
            get
            {
                return m_PlayerSymbol;
            }

            set
            {
                m_PlayerSymbol = value;
            }
        }

        public Player(char i_MySymbol, bool i_IsHuman, int i_PlayerNumber, string i_PlayerName)
        { 
            m_PlayerScore = 0;
            r_PlayerName = i_PlayerName;
            m_PlayerSymbol = i_MySymbol;
            m_IsHuman = i_IsHuman;
            m_PlayerNumber = i_PlayerNumber;
        }

        public void ComputerMove(char i_OpponentSymbol, MyGameLogic i_Logic, ref int io_ChosenRow, ref int io_ChosenCol)
        {
            int[] chosenLocation = new int[2];

            if (!i_Logic.CalculateComputerMoveAi(m_PlayerSymbol, i_OpponentSymbol, ref chosenLocation))
            {
                i_Logic.RandomComputerMove(ref io_ChosenRow, ref io_ChosenCol);
            }
            else
            {
                io_ChosenRow = chosenLocation[0];
                io_ChosenCol = chosenLocation[1];
            }
        }
    }
}