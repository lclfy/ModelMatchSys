using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using CCWin;
using System.Windows.Forms;

namespace ModelMatchSys
{
    public partial class Main : Skin_Mac
    {
        int timerMinue = 0;
        int timerSecond = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void minute_tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void minute_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void second_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            //如果分钟和秒都是0
            if(int.Parse(minute_tb.Text.ToString()) == 0 && int.Parse(second_tb.Text.ToString()) == 0)
        }

        private void timeCount_timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
