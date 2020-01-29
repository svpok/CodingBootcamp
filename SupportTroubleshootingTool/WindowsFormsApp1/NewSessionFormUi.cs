using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewSessionFormUi : Form
    {
        public NewSessionFormUi()
        {
            InitializeComponent();
        }

        private void butStart_Click(object sender, EventArgs e)
        {

            ExistingSessionFormUi window1=new ExistingSessionFormUi();
            this.Hide();
            
           window1.ShowDialog();
           this.Close();


                }

    }
}
