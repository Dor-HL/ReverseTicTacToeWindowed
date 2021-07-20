using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameLogic
{
    public partial class GameBoardForm : Form
    {
        private readonly Button[,] r_ButtonMatrix;
        private readonly int r_BoardSize;
        private readonly MyGameLogic r_GameLogic;
        private Label m_Scores;

        public GameBoardForm(int i_BoardSize, string i_PlayerOneName, string i_PlayerTwoName, ref MyGameLogic io_Logic)
        { 
            InitializeComponent();
            r_ButtonMatrix = CreateBoardBySize(i_BoardSize, i_PlayerOneName, i_PlayerTwoName);
            r_BoardSize = i_BoardSize;
            r_GameLogic = io_Logic;
        }

        public Button[,] CreateBoardBySize(int i_BoardSize, string i_PlayerOneName, string i_PlayerTwoName)
        {
            this.Text = "Reverse Tic Tac Toe";
            this.BackColor = Color.LightGray;
            Button[,] buttonMatrix = new Button[i_BoardSize, i_BoardSize];
            Point lastLocation = new Point(10, 10);
            Point newLocation = new Point();
            StringBuilder buttonName = new StringBuilder();
            for(int r = 0; r < i_BoardSize; r++)
            {
                for(int c = 0; c < i_BoardSize; c++)
                {
                    if(c == 0)
                    {
                        newLocation.X = 10;
                        if(r != 0)
                        {
                            newLocation.Y = lastLocation.Y + 55;
                        }
                    }
                    else if(r != 0 || c != 0)
                    {
                        newLocation.X = lastLocation.X + 55;
                    } 
                    
                    buttonMatrix[r, c] = new Button();
                    buttonMatrix[r, c].Tag = new Point(r + 1, c + 1);
                    buttonMatrix[r, c].Location = newLocation;
                    lastLocation = newLocation;
                    buttonMatrix[r, c].Click += matrixButtonClicked;
                    buttonMatrix[r, c].Visible = true;
                    buttonMatrix[r, c].Size = new Size(50, 50);
                    Controls.Add(buttonMatrix[r, c]);
                }
            }

            int x = (i_BoardSize * 55) + 30;
            int y = (i_BoardSize * 55) + 80;

            this.Size = new Size(x, y);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false; 
            m_Scores = new Label();
            m_Scores.AutoSize = true;
            string scoreString = string.Format("{0} :0, {1} :0", i_PlayerOneName, i_PlayerTwoName);
            m_Scores.Text = scoreString;
            int scoresX = this.Left;
            int scoresY = (i_BoardSize * 55) + 25;
            m_Scores.Location = new Point(scoresX, scoresY);
            this.Controls.Add(m_Scores);

            this.CenterToScreen();
            return buttonMatrix;
        }

        private void matrixButtonClicked(object ob, EventArgs e)
        {
            Button sender = ob as Button;
            int computerRow = 0;
            int computerCol = 0;
            bool isComputerMove = false;
            char symbol = ' ';
            if (r_GameLogic.IsFirstPlayerTurn)
            {
                sender.Text = char.ToString(r_GameLogic.PlayerOne.Symbol);
                symbol = r_GameLogic.PlayerOne.Symbol;

                if(!r_GameLogic.PlayerTwo.IsPlayerHuman)
                {
                    isComputerMove = true;
                }
                else
                {
                    r_GameLogic.IsFirstPlayerTurn = false;
                }
            }
            else 
            {
                sender.Text = char.ToString(r_GameLogic.PlayerTwo.Symbol);
                r_GameLogic.IsFirstPlayerTurn = true;
                symbol = r_GameLogic.PlayerTwo.Symbol;
            }
            
            sender.Enabled = false;
            Point senderTag = (Point)sender.Tag;
            int row = senderTag.X;
            int col = senderTag.Y;
            bool isGameOver = makeMove(symbol, row, col);

            if(isComputerMove && !isGameOver)
            {
                r_GameLogic.PlayerTwo.ComputerMove(r_GameLogic.PlayerOne.Symbol, r_GameLogic, ref computerRow, ref computerCol);
                Point tagToFind = new Point(computerRow, computerCol);
                foreach(Button button in r_ButtonMatrix)
                {
                    Point currentTag = (Point)button.Tag;
                    if(currentTag == tagToFind)
                    {
                        button.Enabled = false;
                        button.Text = char.ToString(r_GameLogic.PlayerTwo.Symbol);
                        break;
                    }
                }

                makeMove(r_GameLogic.PlayerTwo.Symbol, computerRow, computerCol);
            }
        }

        private bool makeMove(char i_Symbol, int i_Row, int i_Col)
        {
            string message = string.Empty;
            string title = string.Empty;
            r_GameLogic.GameBoard.Counter += 1;
            r_GameLogic.GameBoard.AddSymbolToBoard(i_Symbol, i_Row, i_Col);
            bool isGameOver = false;
            if (r_GameLogic.CheckIfLost(i_Symbol))
            {
                title = "A Win!";
                isGameOver = true;
                string winner;
                if (i_Symbol == r_GameLogic.PlayerOne.Symbol)
                {
                    r_GameLogic.PlayerTwo.CurrentScore += 1;
                    winner = r_GameLogic.PlayerTwo.PlayerName;
                }
                else
                {
                    r_GameLogic.PlayerOne.CurrentScore += 1;
                    winner = r_GameLogic.PlayerOne.PlayerName;
                }

                string newScores = string.Format(
                    "{0} : {1}  {2} : {3}",
                    r_GameLogic.PlayerOne.PlayerName,
                    r_GameLogic.PlayerOne.CurrentScore,
                    r_GameLogic.PlayerTwo.PlayerName,
                    r_GameLogic.PlayerTwo.CurrentScore);
                m_Scores.Text = newScores;
                 message = string.Format(
                    "The winner is {0}! {1} Would you like to play another round?",
                    winner,
                    Environment.NewLine);
            }
            else if(r_GameLogic.IsTie(r_GameLogic.GameBoard.Counter))
            {
                title = "A Tie!";
                isGameOver = true;
                message = string.Format("Tie! {0} Would you like to play another round?", Environment.NewLine);
            }

            if(isGameOver)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult userChoice = MessageBox.Show(message, title, buttons);
                if(userChoice == DialogResult.Yes)
                {
                    emptyBoard();
                }
                else
                {
                    message = "Thank you for playing!";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    title = "Goodbye!";
                    DialogResult OkPressed = MessageBox.Show(message, title, button);
                    if(OkPressed == DialogResult.OK)
                    {
                        Close();
                    }
                }
            }

            return isGameOver;
        }

        private void emptyBoard()
        {
            r_GameLogic.GameBoard.Counter = 0;
            r_GameLogic.GameBoard.EmptyBoard();
            for (int row = 0; row < r_BoardSize; row++)
            {
                for(int col = 0; col < r_BoardSize; col++)
                {
                    r_ButtonMatrix[row, col].Text = char.ToString(' ');
                    r_ButtonMatrix[row, col].Enabled = true;
                }
            }

            r_GameLogic.IsFirstPlayerTurn = true;
        }

        private void GameBoardForm_Load(object sender, EventArgs e)
        {
        }
    }
}
