using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace ModelMatchSys
{
    public partial class ScoreDetails : Skin_Mac
    {
        TeamModel teamModel = new TeamModel();
        public ScoreDetails(TeamModel _teamModel)
        {
            this.teamModel = _teamModel;
            InitializeComponent();
        }

        private void ScoreDetails_Load(object sender, EventArgs e)
        {
            detailText_tb.Text = "一级加载重量：" + teamModel.FirstLoadWeight + "\n"
                + "二级加载重量：" + teamModel.SecondLoadWeight + "\n"
                + "三级加载重量：" + teamModel.ThirdLoadWeight + "\n"
                + "自身重量：" + teamModel.OwnWeight + "\n"
                + "一级加载分值：" + teamModel.FirstScore + "\n"
                + "二级加载分值：" + teamModel.SecondScore + "\n"
                + "三级加载分值：" + teamModel.ThirdLoadWeight + "\n"
                + "加载总分：" + teamModel.AllLoadScore + "\n"
                + "理论答案分值：" + teamModel.D1Score + "\n"
                + "现场陈述与答辩分值：" + teamModel.D2Score + "\n"
                + "现场制作的模型：" + teamModel.D3Score + "\n";
            teamName_lbl.Text = teamModel.TeamName;
        }

        private void richTxtControl1_Load(object sender, EventArgs e)
        {

        }

        private void teamName_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
