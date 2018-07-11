using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Starte Spiel in einer 2. Form
        private void btnStart_Click(object sender, EventArgs e)
        {
            Form newForm = new Form2();
            newForm.Show(this);
            
            
        }

        //Highscore einsehen in 3. Form
        private void btnScore_Click(object sender, EventArgs e)
        {
            Form newForm = new Form3();
            newForm.Show(this);
        }

        //Programm beenden
        private void btnStop_Click(object sender, EventArgs e)
        {
                     
                this.Close();
         }
    }
}

