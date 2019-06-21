using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hola_mundo_WFA
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_mensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Push Visual Studio");
        }
    }
}
