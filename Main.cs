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
        int timerMinute = 0;
        int timerSecond = 0;
        bool timerStarted = false;
        bool paused = false;
        Main mainPage = null;
        List<TeamModel> allTeams = new List<TeamModel>();
        //列表排序用
        private mySorter sorter;
        public Main()
        {
            sorter = new mySorter();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainPage = this;
            startBtnCheck();
            teamBtnCheck();
        }

        private void minute_tb_TextChanged(object sender, EventArgs e)
        {
            startBtnCheck();
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

        public void addNew_updateList(string _newTeamName)
        {
            score_lv.Items.Clear();
            TeamModel _tm = new TeamModel();
            _tm.TeamName = _newTeamName;
            _tm.Rank = 0;
            _tm.TotalScore = 0;
            allTeams.Add(_tm);
            foreach(TeamModel _tempTM in allTeams)
            {
                ListViewItem lvi = new ListViewItem(_tempTM.Rank.ToString());
                lvi.SubItems.Add(_tempTM.TeamName);
                lvi.SubItems.Add(_tempTM.TotalScore.ToString());
                score_lv.Items.Add(lvi);
            }
            score_lv.Update();
        }

        public void delete_updateList()
        {
            try
            {
                allTeams.RemoveAt(score_lv.SelectedItems[0].Index);
                score_lv.Items.Clear();
                foreach (TeamModel _tempTM in allTeams)
                {
                    ListViewItem lvi = new ListViewItem(_tempTM.Rank.ToString());
                    lvi.SubItems.Add(_tempTM.TeamName);
                    lvi.SubItems.Add(_tempTM.TotalScore.ToString());
                    score_lv.Items.Add(lvi);
                }
                score_lv.Update();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }

        private void teamBtnCheck()
        {
            if(score_lv.SelectedItems.Count == 0)
            {
                modify_btn.Enabled = false;
                delete_btn.Enabled = false;
            }
            else
            {
                modify_btn.Enabled = true;
                delete_btn.Enabled = true;
            }
        }

        private void startBtnCheck()
        {
            //如果分钟和秒都是0
            try
            {
                if(minute_tb.Text.Length == 0 || second_tb.Text.Length == 0)
                {
                    start_btn.Enabled = false;
                }
                if (int.Parse(minute_tb.Text.ToString()) == 0 && int.Parse(second_tb.Text.ToString()) == 0 )
                {
                    start_btn.Enabled = false;
                }
                else
                {
                    start_btn.Enabled = true;

                }
            }
            catch (Exception e)
            {

            }


        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (!timerStarted)
            {
                if (paused)
                {
                    timerTick();
                    paused = false;
                    timeCount_timer.Start();
                    timerStarted = true;
                    start_btn.Text = "停止";
                }
                else
                {
                    timerSecond = int.Parse(second_tb.Text.ToString());
                    timerMinute = int.Parse(minute_tb.Text.ToString());
                    timerTick();
                    timeCount_timer.Start();
                    timerStarted = true;
                    start_btn.Text = "停止";
                }
            }
            else
            {
                timerMinute = 0;
                timerSecond = 0;
                timer_lbl.Text = "00:00";
                timerStarted = false;
                timeCount_timer.Stop();
                start_btn.Text = "开始";
            }
            
        }

        private void timeCount_timer_Tick(object sender, EventArgs e)
        {
            timerTick();
        }

        private void timerTick()
        {
            string minStr;
            string secStr;
            if (timerMinute == 0 && timerSecond == 0)
            {
                timeCount_timer.Stop();
                start_btn.Text = "开始";
                timerStarted = false;
            }
            if (timerMinute < 10)
            {
                minStr = "0" + timerMinute;
            }
            else
            {
                minStr = timerMinute.ToString();
            }
            if (timerSecond < 10)
            {
                secStr = "0" + timerSecond;
            }
            else
            {
                secStr = timerSecond.ToString();
            }
            if (timerSecond == 0 && timerMinute != 0)
            {
                timerSecond = 60;
                timerMinute = timerMinute - 1;
            }
            timerSecond = timerSecond - 1;
            timer_lbl.Text = minStr + ":" + secStr;
        }

        private void second_tb_TextChanged(object sender, EventArgs e)
        {
            startBtnCheck();
            try
            {
                if(int.Parse(second_tb.Text.ToString()) > 59)
                {
                    second_tb.Text = "59";
                }
            }
            catch (Exception e1)
            {

            }
        }

        private void pauseTimer_btn_Click(object sender, EventArgs e)
        {
            timeCount_timer.Stop();
            paused = true;
            start_btn.Text = "开始";
            timerStarted = false;
        }

        private void AddTeamName_btn_Click(object sender, EventArgs e)
        {
            AddTeam form = new AddTeam(mainPage);
            form.Show();
        }

        private void score_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamBtnCheck();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (score_lv.SelectedItems.Count != 0 && result == DialogResult.OK)
            {
                delete_updateList();
            }
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            if(score_lv.SelectedItems.Count != 0)
            {
                try
                {
                    ScoreDetails _detailPage = new ScoreDetails(allTeams[score_lv.SelectedItems[0].Index]);
                    _detailPage.Show();
                    teamBtnCheck();
                }
                catch(Exception _e)
                {
                    MessageBox.Show(_e.ToString());
                }

            }
          
        }
    }
}
