using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_War
{
    public partial class Tmain : Form
    {
        Fmain gameForm;
        public Tmain()
        {
            InitializeComponent();
            gameForm = new Fmain(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            gameForm.Show();
            this.Hide();
        }
    }
}
