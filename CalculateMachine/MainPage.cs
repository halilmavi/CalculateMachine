using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateMachine
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            PageColorControl();
            txtBxDisplay.Text = "0";
        }
        private void PageColorControl()
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f1f1f");
            btnNine.BackColor = System.Drawing.ColorTranslator.FromHtml("#060606");
            btnZero.BackColor = System.Drawing.ColorTranslator.FromHtml("#060606");
            btnOne.BackColor = System.Drawing.ColorTranslator.FromHtml("#060606");
            btnTwo.BackColor = System.Drawing.ColorTranslator.FromHtml("#060606");
            btnThree.BackColor = System.Drawing.ColorTranslator.FromHtml("#060606");
            btnFour.BackColor = System.Drawing.ColorTranslator.FromHtml("#060606");
            btnFive.BackColor = System.Drawing.ColorTranslator.FromHtml("#060606");
            btnSix.BackColor = System.Drawing.ColorTranslator.FromHtml("#060606");
            btnSeven.BackColor = System.Drawing.ColorTranslator.FromHtml("#060606");
            btnEight.BackColor = System.Drawing.ColorTranslator.FromHtml("#060606");
            btnNine.BackColor = System.Drawing.ColorTranslator.FromHtml("#060606");
            btnComma.BackColor = System.Drawing.ColorTranslator.FromHtml("#060606");
            txtBxDisplay.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f1f1f");
            btnWindowBig.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f1f1f");
            btnWindowDown.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f1f1f");
            btnApplicationExit.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f1f1f");



            //btnEqual.BackColor = System.Drawing.ColorTranslator.FromHtml("#131313");
            btnCollection.BackColor = System.Drawing.ColorTranslator.FromHtml("#131313");
            btnSubtraction.BackColor = System.Drawing.ColorTranslator.FromHtml("#131313");
            btnMultiplication.BackColor = System.Drawing.ColorTranslator.FromHtml("#131313");
            btnDivide.BackColor = System.Drawing.ColorTranslator.FromHtml("#131313");
            btnDelete.BackColor = System.Drawing.ColorTranslator.FromHtml("#131313");
            btnBirBoluX.BackColor = System.Drawing.ColorTranslator.FromHtml("#131313");
            btnKarekok.BackColor = System.Drawing.ColorTranslator.FromHtml("#131313");
            btnXKare.BackColor = System.Drawing.ColorTranslator.FromHtml("#131313");
            btnC.BackColor = System.Drawing.ColorTranslator.FromHtml("#131313");
            btnCe.BackColor = System.Drawing.ColorTranslator.FromHtml("#131313");
            btnYuzde.BackColor = System.Drawing.ColorTranslator.FromHtml("#131313");

        }

        double result;
        double firstdigit;
        string abbb;
        bool isoptr = false;
        
        private void controlOfAllButtons(object sender, EventArgs e)
        {
            if (txtBxDisplay.Text == "0" || isoptr)
            {
                txtBxDisplay.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (txtBxDisplay.Text == ".")
            {
                if (!txtBxDisplay.Text.Contains("."))
                {
                    txtBxDisplay.Text += button.Text;
                }
            }
            else
                txtBxDisplay.Text += button.Text;
            //textBox.Text = button.Text;
        }


        // 
        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (abbb)
            {
                case "+":
                    txtBxDisplay.Text = (firstdigit + double.Parse(txtBxDisplay.Text)).ToString("0.########");
                    break;
                case "-":
                    txtBxDisplay.Text = (firstdigit - double.Parse(txtBxDisplay.Text)).ToString("0.########");
                    break;
                case "x":
                    txtBxDisplay.Text = (firstdigit * double.Parse(txtBxDisplay.Text)).ToString("0.########");
                    break;
                case "÷":
                    txtBxDisplay.Text = (firstdigit / double.Parse(txtBxDisplay.Text)).ToString("0.########");
                    break;
            }
        }

        private void fourProcess(object sender, EventArgs e)
        {
            firstdigit = double.Parse(txtBxDisplay.Text);
            Button Optr = (Button)sender;
            abbb = Optr.Text;
            isoptr = true;
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = txtBxDisplay.Text.Length;
            index--;
            txtBxDisplay.Text = txtBxDisplay.Text.Remove(index);
            if (txtBxDisplay.Text == "")
            {
                txtBxDisplay.Text = "0";
            }
        }

        private void btnApplicationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnApplicationExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnApplicationExit.BackColor = System.Drawing.ColorTranslator.FromHtml("#FC0000");
        }

        // Windows penceresini taşıma işlemleri için tanımlanan değişkenler.
        bool move;
        int movX, movY;
        private void btnApplicationExit_MouseLeave(object sender, EventArgs e)
        {
            btnApplicationExit.BackColor = System.Drawing.ColorTranslator.FromHtml("#1f1f1f");
        }
  
        private void MainPage_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            movX = e.X;
            movY = e.Y;
        }

        private void MainPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                // Pencerenin son konumlandığı lokasyonu tanımladık.
                this.SetDesktopLocation(MousePosition.X-movX,MousePosition.Y-movY);
            }
        }
        private void MainPage_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void btnYuzde_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtBxDisplay.Text);
            result = result / 100;
            txtBxDisplay.Text = result.ToString();
        }

        private void btnBirBoluX_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtBxDisplay.Text);
            result = 1 / result;
            txtBxDisplay.Text = result.ToString();
        }

        private void btnXKare_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtBxDisplay.Text);
            result = Math.Pow(result, 2);
            txtBxDisplay.Text = result.ToString();
        }

        private void btnKarekok_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtBxDisplay.Text);
            result = Math.Sqrt(result);
            txtBxDisplay.Text = result.ToString();
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtBxDisplay.Text);
            result = result * -1;
            txtBxDisplay.Text = result.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtBxDisplay.Text = "0";
        }

        private void btnWindowBig_Click(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location= new Point(0, 0);
            this.Size=new Size(w, h);
        }



    }
}
