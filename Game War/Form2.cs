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
    public partial class Fmain : Form
    {
        Tmain fplay;
        public Fmain(Form f)
        {
            InitializeComponent();
            fplay = (Tmain)f;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fplay.Show();
        }

        
    }
}
