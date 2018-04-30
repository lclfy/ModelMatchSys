using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ModelMatchSys
{
    public partial class AddTeam : Skin_Mac
    {
        Main main;
        public AddTeam(Main _main)
        {
            main = _main;
            InitializeComponent();
        }

        private void AddTeam_Load(object sender, EventArgs e)
        {

        }

        private void skinWaterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if(skinWaterTextBox1.Text.Length == 0)
            {
                MessageBox.Show("队名不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                main.addNew_updateList(skinWaterTextBox1.Text);
            }
        }
    }
}
