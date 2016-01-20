namespace Tic_tac_toe
{
    using System;
    using System.Linq;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Tic_tac_toe : System.Web.UI.Page
    {
        private string boardAsString;
        private const string BoardKey = "board";
        private const string BoardInitialState = "---------";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState[BoardKey] != null)
            {
                boardAsString = (string)ViewState[BoardKey];
            }
            else
            {
                boardAsString = BoardInitialState;
                ViewState.Add(BoardKey, boardAsString);
            }
        }

        private void GetButtonValue(Button button)
        {
            char[] board = boardAsString.ToCharArray();
            int position = int.Parse(button.Attributes["position"]);
            if (button.Text == string.Empty)
            {
                board[position - 1] = 'X';
            }

            boardAsString = string.Join(string.Empty, board);
            ComputerPlay();
            ViewState[BoardKey] = boardAsString;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GetButtonValue(this.Button1);
            FillMatrix();
            CheckGameResult();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GetButtonValue(this.Button2);
            FillMatrix();
            CheckGameResult();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            GetButtonValue(this.Button3);
            FillMatrix();
            CheckGameResult();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            GetButtonValue(this.Button4);
            FillMatrix();
            CheckGameResult();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            GetButtonValue(this.Button5);
            FillMatrix();
            CheckGameResult();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            GetButtonValue(this.Button6);
            FillMatrix();
            CheckGameResult();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            GetButtonValue(this.Button7);
            FillMatrix();
            CheckGameResult();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            GetButtonValue(this.Button8);
            FillMatrix();
            CheckGameResult();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            GetButtonValue(this.Button9);
            FillMatrix();
            CheckGameResult();
        }

        private void FillMatrix()
        {
            foreach (Control control in this.FormTicTacToe.Controls)
            {
                if (control.SkinID == "cell")
                {
                    Button button = (Button)control;
                    int position = int.Parse(button.Attributes["position"]);
                    if(boardAsString[position - 1] != '-')
                    {
                        button.Text = boardAsString[position - 1].ToString();
                    }
                }
            }
        }

        private void CheckGameResult()
        {
            SetWinner(boardAsString[0], boardAsString[4], boardAsString[8]);
            SetWinner(boardAsString[2], boardAsString[4], boardAsString[6]);

            SetWinner(boardAsString[0], boardAsString[1], boardAsString[2]);
            SetWinner(boardAsString[3], boardAsString[4], boardAsString[5]);
            SetWinner(boardAsString[6], boardAsString[7], boardAsString[8]);

            SetWinner(boardAsString[0], boardAsString[3], boardAsString[6]);
            SetWinner(boardAsString[1], boardAsString[4], boardAsString[7]);
            SetWinner(boardAsString[2], boardAsString[5], boardAsString[8]);
        }

        private void SetWinner(char first, char second, char third)
        {
            if (first == second && second == third)
            {
                if (first == 'X' && first != '-')
                {
                    Response.Write("X wins!");
                    ClearField();
                }
                else if (first == 'O' && first != '-')
                {
                    Response.Write("O wins!");
                    ClearField();
                }
            }
        }

        private void ComputerPlay()
        {
            Random rand = new Random();
            char[] board = boardAsString.ToCharArray();
            int index = rand.Next(0, 8);

            if (!board.Contains('-'))
            {
                ClearField();
                return;
            }

            while (board[index] != '-')
            {
                index = rand.Next(0, 8);
            }

            board[index] = 'O';
            boardAsString = string.Join(string.Empty, board);
        }

        private void ClearField()
        {
            foreach (Control control in this.FormTicTacToe.Controls)
            {
                if (control.SkinID == "cell")
                {
                    Button button = (Button)control;
                    button.Text = string.Empty;
                }
            }

            boardAsString = BoardInitialState;
            ViewState[BoardKey] = boardAsString;
        }
    }
}