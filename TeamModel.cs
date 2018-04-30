using System;
using System.Collections.Generic;
using System.Text;

namespace ModelMatchSys
{
    public class TeamModel
    {
        private string teamName;
        private int rank;
        private double totalScore;
        //重量
        private double firstLoadWeight;
        private double secondLoadWeight;
        private double thirdLoadWeight;
        private double ownWeight;
        //加载分值
        private double firstScore;
        private double secondScore;
        private double thirdScore;
        private double allLoadScore;
        //其他分值
        private double d1Score;
        private double d2Score;
        private double d3Score;
        //用时
        public string usingTime;

        public TeamModel()
        {
            teamName = "";
            rank = 0;
            totalScore = 0;
            usingTime = "";
        }

        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }

        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public double TotalScore
        {
            get { return totalScore; }
            set { totalScore = value; }
        }

        public double FirstLoadWeight
        {
            get { return firstLoadWeight; }
            set { firstLoadWeight = value; }
        }

        public double SecondLoadWeight
        {
            get { return secondLoadWeight; }
            set { secondLoadWeight = value; }
        }

        public double ThirdLoadWeight
        {
            get { return thirdLoadWeight; }
            set { thirdLoadWeight = value; }
        }

        public double OwnWeight
        {
            get { return ownWeight; }
            set { ownWeight = value; }
        }

        public double FirstScore
        {
            get { return firstScore; }
            set { firstScore = value; }
        }

        public double SecondScore
        {
            get { return secondScore; }
            set { secondScore = value; }
        }

        public double ThirdScore
        {
            get { return thirdScore; }
            set { thirdScore = value; }
        }

        public double AllLoadScore
        {
            get { return allLoadScore; }
            set { allLoadScore = value; }
        }

        public double D1Score
        {
            get { return d1Score; }
            set { d1Score = value; }
        }

        public double D2Score
        {
            get { return d2Score; }
            set { d2Score = value; }
        }

        public double D3Score
        {
            get { return d3Score; }
            set { d3Score = value; }
        }
    }
}
