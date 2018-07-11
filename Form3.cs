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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }
        //Zurück zum Hauptmenü, Form 1
        private void btnClose_Click(object sender, EventArgs e)
        {
            Form newForm = new Form1();
            newForm.Show(this);
        }

       
    }
}