using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class InitMenu : Form
    {
        private int m_RowsAndColsValue = 3;
        private string m_PlayerOneName = "Player One";
        private string m_PlayerTwoName = "Computer";
        private bool m_IsHuman = false;
        private bool m_Start = false;

        public string PlayerOneName
        {
            get
            {
                return m_PlayerOneName;
            }
        }

        public string PlayerTwoName
        {
            get
            {
                return m_PlayerTwoName;
            }
        }

        public bool IsHumanPlayer
        {
            get
            {
                return m_IsHuman;
            }
        }

        public int BoardSize
        {
            get
            {
                return m_RowsAndColsValue;
            }
        }

        public bool isStartButtonPressed
        {
            get
            {
                return m_Start;
            }
        }

        public InitMenu()
        {
            InitializeComponent();
        }

        private void InitMenu_Load(object sender, EventArgs e)
        {
        }

        private void labelPlayerOne_Click(object sender, EventArgs e)
        {
        }

        private void checkBoxIsHuman_CheckedChanged(object sender, EventArgs e)
        {
            if(isHuman.Checked)
            {
                player2Name.Enabled = true;
                player2Name.Text = string.Empty;
            }
            else
            {
                player2Name.Enabled = false;
                player2Name.Text = "[Computer]";
            }
        }

        private void textBoxPlayerOneName_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelPlayersHeadLine_Click_1(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDownRow_ValueChanged(object sender, EventArgs e)
        {
            ColsUpAndDown.Value = RowsUpAndDown.Value;
        }

        private void numericUpDownCol_ValueChanged(object sender, EventArgs e)
        {
            RowsUpAndDown.Value = ColsUpAndDown.Value;
        }

        private void textBoxPlayerTwoName_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if((player1name.Text == string.Empty) || (player2Name.Text == string.Empty))
            {
                string message = "Please don't leave player's name empty";
                string title = "warning";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, title, button);
            }
            else
            {
                m_RowsAndColsValue = (int)RowsUpAndDown.Value;
                m_PlayerOneName = player1name.Text;
                if (isHuman.Checked)
                {
                    m_PlayerTwoName = player2Name.Text;
                    m_IsHuman = true;
                }
                else
                {
                    m_IsHuman = false;
                }

                m_Start = true;
                this.Close();
            }
        }
    }
}
