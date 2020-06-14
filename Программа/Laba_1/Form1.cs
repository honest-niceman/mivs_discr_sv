using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laba_1
{
    public partial class Form1 : Form
    {
        RandomValue randomValue;
        public Form1()
        {
            InitializeComponent();
            randomValue = new RandomValue(double.Parse(TBX1.Text), double.Parse(TBP1.Text), double.Parse(TBDelta.Text), int.Parse(TBL.Text), int.Parse(TBN.Text));
            LabelOfP.Text = ("p =" + randomValue.ValueOfP).Substring(0, 10);
            ListToListBox();
            DrawChart();
            labelOfHiSquare.Text = "ХиКвадрат  =" + randomValue.CalculateHiSquare();
        }
        private void ListToListBox()
        {
            LBP.Items.Clear();
            LBX.Items.Clear();
            LB.Items.Clear();
            LBDel.Items.Clear();
            LBDel.Items.Add($"{0}) {randomValue.ListDelP[0]}");
            for (int i = 0; i < randomValue.ListX.Count; i++)
            {
                LBX.Items.Add($"{i + 1}) {randomValue.ListX[i]}");
                LBP.Items.Add($"{i + 1}) {randomValue.ListP[i]}");
                LBDel.Items.Add($"{i + 1}) {randomValue.ListDelP[i + 1]}");
            }
            //randomValue.Selection.Sort();
            for (int i = 0; i < randomValue.Selection.Count; i++)
            {
                LB.Items.Add($"{i + 1}) {randomValue.Selection[i]}");
            }
        }
        private void DrawChart()
        {
            Chart1.Series.Clear();
            Series series1 = this.Chart1.Series.Add("Гистограмма частот");
            Series series2 = this.Chart1.Series.Add("Полигон частот");
            Chart1.Legends.Clear();
            Chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            series1.ChartType = SeriesChartType.Column;
            series1.Points.DataBindXY(randomValue.ListX, randomValue.ArrayOfX);
            series2.Color = Color.Orange;
            series2.BorderWidth = 3;
            series2.ChartType = SeriesChartType.Line;
            series2.Points.DataBindXY(randomValue.ListX, randomValue.ArrayOfX);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            randomValue = new RandomValue(double.Parse(TBX1.Text), double.Parse(TBP1.Text), double.Parse(TBDelta.Text), int.Parse(TBL.Text), int.Parse(TBN.Text));
            LabelOfP.Text = ("p =" + randomValue.ValueOfP).Substring(0, 10);
            ListToListBox();
            DrawChart();
            labelOfHiSquare.Text = "ХиКвадрат  =" + randomValue.CalculateHiSquare();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
