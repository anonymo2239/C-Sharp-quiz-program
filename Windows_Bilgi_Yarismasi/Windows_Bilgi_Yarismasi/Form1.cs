namespace Windows_Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        int questionNumber = 0, right = 0, wrong = 0;
        int timerCounter = 0;
        int again = 0;

        private void btnA_Click(object sender, EventArgs e)
        {
            label2.Text = btnA.Text;
            if (label1.Text == label2.Text)
            {
                right++;
                label5.Text = Convert.ToString(right);
                pictureBox1.Visible = true;
                btnA.BackColor = Color.Green;
            }
            else
            {
                wrong++;
                label4.Text = Convert.ToString(wrong);
                pictureBox2.Visible = true;
                if (questionNumber == 1)
                {
                    btnC.BackColor = Color.Green;
                }
                if (questionNumber == 2)
                {
                    btnA.BackColor = Color.Green;
                    
                }
                if (questionNumber == 3)
                {
                    btnD.BackColor = Color.Green;
                }
                if (questionNumber == 4)
                {
                    btnC.BackColor = Color.Green;
                }
                if (questionNumber == 5)
                {
                    btnA.BackColor = Color.Green;
                }

                btnA.BackColor = Color.Red;
            }
            btnNext.Enabled = true;
            btnNext.Text = "Next";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            label2.Text = btnB.Text;
            if (label1.Text == label2.Text)
            {
                right++;
                label5.Text = Convert.ToString(right);
                pictureBox1.Visible = true;
                btnB.BackColor = Color.Green;
            }
            else
            {
                wrong++;
                label4.Text = Convert.ToString(wrong);
                pictureBox2.Visible = true;
                if (questionNumber == 1)
                {
                    btnC.BackColor = Color.Green;
                }
                if (questionNumber == 2)
                {
                    btnA.BackColor = Color.Green;
                }
                if (questionNumber == 3)
                {
                    btnD.BackColor = Color.Green;
                }
                if (questionNumber == 4)
                {
                    btnC.BackColor = Color.Green;
                }
                if (questionNumber == 5)
                {
                    btnA.BackColor = Color.Green;
                }

                btnB.BackColor = Color.Red;
            }
            btnNext.Enabled = true;
            btnNext.Text = "Next";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            label2.Text = btnC.Text;
            if (label1.Text == label2.Text)
            {
                right++;
                label5.Text = Convert.ToString(right);
                pictureBox1.Visible = true;
                btnC.BackColor = Color.Green;
            }
            else
            {
                wrong++;
                label4.Text = Convert.ToString(wrong);
                pictureBox2.Visible = true;
                if (questionNumber == 1)
                {
                    btnC.BackColor = Color.Green;
                }
                if (questionNumber == 2)
                {
                    btnA.BackColor = Color.Green;
                }
                if (questionNumber == 3)
                {
                    btnD.BackColor = Color.Green;
                }
                if (questionNumber == 4)
                {
                    btnC.BackColor = Color.Green;
                }
                if (questionNumber == 5)
                {
                    btnA.BackColor = Color.Green;
                }

                btnC.BackColor = Color.Red;
            }
            btnNext.Enabled = true;
            btnNext.Text = "Next";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void dontpush_Click(object sender, EventArgs e)
        {
            questionNumber++;
            label6.Text = Convert.ToString(questionNumber);
            if(questionNumber == 10)
            {
                label3.Visible = true;
            }
            if(questionNumber == 21)
            {
                richTextBox1.Text = "Enough my friend.";
            }
            if(questionNumber == 42)
            {
                richTextBox1.Text = "YOU ASKED FOR IT!!";
                timer1.Start();
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCounter++;
            if (timerCounter == 15)
            {
                pictureBox3.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            label2.Text = btnD.Text;
            if (label1.Text == label2.Text)
            {
                right++;
                label5.Text = Convert.ToString(right);
                pictureBox1.Visible = true;
                btnD.BackColor = Color.Green;
            }

            else {
                wrong++;
                label4.Text = Convert.ToString(wrong);
                pictureBox2.Visible = true;
                if (questionNumber == 1)
                {
                    btnC.BackColor = Color.Green;
                }
                if (questionNumber == 2)
                {
                    btnA.BackColor = Color.Green;
                }
                if (questionNumber == 3)
                {
                    btnD.BackColor = Color.Green;
                }
                if (questionNumber == 4)
                {
                    btnC.BackColor = Color.Green;
                }
                if (questionNumber == 5)
                {
                    btnA.BackColor = Color.Green;
                }

                btnD.BackColor = Color.Red;
            }
            btnNext.Enabled = true;
            btnNext.Text = "Next";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }
        

        private void btnNext_Click(object sender, EventArgs e)
        {

            questionNumber++;
            label6.Text = Convert.ToString(questionNumber);
            btnNext.Enabled = false;

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            btnA.BackColor = SystemColors.ButtonFace;
            btnB.BackColor = SystemColors.ButtonFace;
            btnC.BackColor = SystemColors.ButtonFace;
            btnD.BackColor = SystemColors.ButtonFace;
            if (questionNumber == 7)
            {
                questionNumber = 0;
                wrong = 0;
                right = 0;

                label5.Text = Convert.ToString(right);
                label4.Text = Convert.ToString(wrong);
                label6.Text = Convert.ToString(questionNumber);
                btnNext.Text = "Start";
                btnNext.Enabled = true;
                dontpush.Visible = false;
                again++;
            }

            if (questionNumber == 1)
            {
                richTextBox1.Text = "How many oceans are there in the World?";
                btnA.Text = "1";
                btnB.Text = "2";
                btnC.Text = "3";
                btnD.Text = "4";
                label1.Text = "3";
                btnNext.Enabled = false;
                if(again != 0)
                {
                    btnNext.Enabled = true;
                    if(questionNumber == 1)
                    {
                        btnNext.Enabled = false;
                    }
                }
                
                dontpush.Visible = false;
            }
            if (questionNumber == 2)
            {
                richTextBox1.Text = "Which number is not in Roman Numeral?";
                btnA.Text = "0";
                btnB.Text = "50";
                btnC.Text = "100";
                btnD.Text = "1000";
                label1.Text = "0";
                btnNext.Enabled = false;
            }

            if(questionNumber == 3)
            {
                richTextBox1.Text = "Which country's flag does not have a star?";
                btnA.Text = "Senegal";
                btnB.Text = "Israel";
                btnC.Text = "Singapore";
                btnD.Text = "Romania";
                label1.Text = "Romania";
                btnNext.Enabled = false;
            }
            if (questionNumber == 4)
            {
                richTextBox1.Text = "How many seconds in a day?";
                btnA.Text = "86000";
                btnB.Text = "88600";
                btnC.Text = "86400";
                btnD.Text = "84800";
                label1.Text = "86400";
                btnNext.Enabled = false;
              
            }
            if (questionNumber == 5)
            {
                richTextBox1.Text = "Which Country Has Two Capitals?";
                btnA.Text = "South Africa";
                btnB.Text = "Senegal";
                btnC.Text = "El Salvador";
                btnD.Text = "Venezuela";
                label1.Text = "South Africa";
                btnNext.Enabled = false;

            }
            if (questionNumber == 6)
            {
                btnNext.Enabled = true;
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                dontpush.Visible = true;
                MessageBox.Show("Quiz Over" + "\n" + "True: " + right + " False: " + wrong);
                btnNext.Text = "Start Again";
            }
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            
        }

        
    }
}