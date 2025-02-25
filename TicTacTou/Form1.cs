namespace TicTacTou
{
    public partial class Form1 : Form
    {
        private Button[,] _boxes = new Button[3, 3];
        private bool _isXTurn = true;
        private int _countX = 1;
        private int _countY = 1;

        public Form1()
        {
            GenerateBoxes();
            InitializeComponent();
            lblResultMessage.Text = string.Empty;
        }
        private void GenerateBoxes()
        {
            for (int i = 0; i < _boxes.GetLength(0); i++)
            {
                for (int j = 0; j < _boxes.GetLength(1); j++)
                {
                    var box = new Button();
                    box.Height = 45;
                    box.Width = 45;
                    box.Top = 50 + i * 50;
                    box.Left = 50 + j * 50;

                    box.Click += Box_Click;
                    box.BackColor = Color.AntiqueWhite;

                    _boxes[i, j] = box;
                    Controls.Add(box);

                }
            }
        }

        private void Box_Click(object? sender, EventArgs e)
        {
            var box = sender as Button;
            if (box == null)
                return;

            if (box.Text != "")
                return;


            box.Text = _isXTurn ? "X" : "O";
            _isXTurn = !_isXTurn;
            CheckWin();

        }
        private void CheckWin()
        {
            // row checking..

            for (int i = 0; i < 3; i++)
            {
                bool isWin = _boxes[i, 0].Text == _boxes[i, 1].Text &&
                    _boxes[i, 1].Text == _boxes[i, 2].Text && _boxes[i, 0].Text != "";

                if (isWin)
                {
                    ChangeColor([_boxes[i, 0], _boxes[i, 1], _boxes[i, 2]]);
                    //MessageBox.Show($"{_boxes[i, 0].Text}  Win !!!");
                    lblResultMessage.Text = $"{_boxes[i, 0].Text}  Win !!!";
                    if(_boxes[i, 0].Text=="X")
                    {
                      lblXWin.Text = $"{_boxes[i, 0].Text}{_countX++}";

                    }
                    else if(_boxes[i, 0].Text == "O")
                    {
                        lblOWin.Text= $"{_boxes[i, 0].Text}{_countY++}";
                    }

                    return;
                }
            }

            // column checking..

            for (int i = 0; i < 3; i++)
            {
                bool isWin = _boxes[0, i].Text == _boxes[1, i].Text &&
                    _boxes[1, i].Text == _boxes[2, i].Text && _boxes[0, i].Text != "";

                if (isWin)
                {
                    ChangeColor([_boxes[0, i], _boxes[1, i], _boxes[2, i]]);
                    //MessageBox.Show($"{_boxes[0, i].Text}  Win !!!");
                    lblResultMessage.Text = $"{_boxes[0, i].Text}  Win !!!";

                    if (_boxes[0, i].Text == "X")
                    {
                        lblXWin.Text = $"{_boxes[0, i].Text}{_countX++}";

                    }
                    else if (_boxes[0, i].Text == "O")
                    {
                        lblOWin.Text = $"{_boxes[0, i].Text}{_countY++}";
                    }


                    return;
                }
            }

            //diagonal checking..

            for (int i = 0; i < 3; i++)
            {

                bool isDiagonalWin = _boxes[0, 0].Text == _boxes[1, 1].Text && _boxes[1, 1].Text == _boxes[2, 2].Text
                    && _boxes[0, 0].Text != "";

                if (isDiagonalWin)
                {
                    ChangeColor([_boxes[0, 0], _boxes[1, 1], _boxes[2, 2]]);
                    // MessageBox.Show($"{_boxes[0, 0].Text} Win !!!");
                    lblResultMessage.Text = $"{_boxes[0, 0].Text}  Win !!!";

                    if (_boxes[0, 0].Text == "X")
                    {
                        lblXWin.Text = $"{_boxes[0, 0].Text}{_countX++}";

                    }
                    else if (_boxes[0, 0].Text == "O")
                    {
                        lblOWin.Text = $"{_boxes[0, 0].Text}{_countY++}";
                    }

                    return;
                }
                isDiagonalWin = _boxes[2, 0].Text == _boxes[1, 1].Text && _boxes[1, 1].Text == _boxes[0, 2].Text
                    && _boxes[2, 0].Text != "";

                if (isDiagonalWin)
                {
                    ChangeColor([_boxes[2, 0], _boxes[1, 1], _boxes[0, 2]]);
                    //MessageBox.Show($"{_boxes[2, 0].Text} Win !!!");
                    lblResultMessage.Text = $"{_boxes[2, 0].Text}  Win !!!";

                    if (_boxes[2, 0].Text == "X")
                    {
                        lblXWin.Text = $"{_boxes[2, 0].Text}{_countX++}";

                    }
                    else if (_boxes[2, 0].Text == "O")
                    {
                        lblOWin.Text = $"{_boxes[2, 0].Text}{_countY++}";
                    }
                    
                    return;
                }

            }

        }
        private void ChangeColor(Button[] button)
        {
            foreach (var box in button)
            {
                box.BackColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResultMessage.Text = string.Empty;
            for (int i = 0; i < _boxes.GetLength(0); i++)
            {
                for (int j = 0; j < _boxes.GetLength(1); j++)
                {
                    _boxes[i, j].Text = string.Empty;
                    _boxes[i, j].BackColor = Color.AntiqueWhite;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
