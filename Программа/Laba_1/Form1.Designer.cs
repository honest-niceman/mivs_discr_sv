namespace Laba_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TBX1 = new System.Windows.Forms.TextBox();
            this.TBP1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBDelta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelOfP = new System.Windows.Forms.Label();
            this.RBVariant1 = new System.Windows.Forms.RadioButton();
            this.RBVariant2 = new System.Windows.Forms.RadioButton();
            this.RBVariant4 = new System.Windows.Forms.RadioButton();
            this.RBVariant3 = new System.Windows.Forms.RadioButton();
            this.RBVariant5 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.LBX = new System.Windows.Forms.ListBox();
            this.LBP = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBDel = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LB = new System.Windows.Forms.ListBox();
            this.labelOfHiSquare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "x1 =";
            // 
            // TBX1
            // 
            this.TBX1.Location = new System.Drawing.Point(59, 16);
            this.TBX1.Name = "TBX1";
            this.TBX1.Size = new System.Drawing.Size(40, 20);
            this.TBX1.TabIndex = 1;
            this.TBX1.Text = "1";
            this.TBX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TBP1
            // 
            this.TBP1.Location = new System.Drawing.Point(187, 16);
            this.TBP1.Name = "TBP1";
            this.TBP1.Size = new System.Drawing.Size(40, 20);
            this.TBP1.TabIndex = 3;
            this.TBP1.Text = "0,18";
            this.TBP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(140, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "p1 =";
            // 
            // TBDelta
            // 
            this.TBDelta.Location = new System.Drawing.Point(302, 16);
            this.TBDelta.Name = "TBDelta";
            this.TBDelta.Size = new System.Drawing.Size(40, 20);
            this.TBDelta.TabIndex = 5;
            this.TBDelta.Text = "0,3";
            this.TBDelta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(256, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Δ  =";
            // 
            // TBL
            // 
            this.TBL.Location = new System.Drawing.Point(59, 66);
            this.TBL.Name = "TBL";
            this.TBL.Size = new System.Drawing.Size(40, 20);
            this.TBL.TabIndex = 7;
            this.TBL.Text = "11";
            this.TBL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(20, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "l  =";
            // 
            // LabelOfP
            // 
            this.LabelOfP.AutoSize = true;
            this.LabelOfP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LabelOfP.Location = new System.Drawing.Point(256, 66);
            this.LabelOfP.Name = "LabelOfP";
            this.LabelOfP.Size = new System.Drawing.Size(33, 20);
            this.LabelOfP.TabIndex = 8;
            this.LabelOfP.Text = "p =";
            // 
            // RBVariant1
            // 
            this.RBVariant1.Location = new System.Drawing.Point(619, 64);
            this.RBVariant1.Name = "RBVariant1";
            this.RBVariant1.Size = new System.Drawing.Size(104, 24);
            this.RBVariant1.TabIndex = 31;
            // 
            // RBVariant2
            // 
            this.RBVariant2.Location = new System.Drawing.Point(619, 64);
            this.RBVariant2.Name = "RBVariant2";
            this.RBVariant2.Size = new System.Drawing.Size(104, 24);
            this.RBVariant2.TabIndex = 30;
            // 
            // RBVariant4
            // 
            this.RBVariant4.Location = new System.Drawing.Point(619, 64);
            this.RBVariant4.Name = "RBVariant4";
            this.RBVariant4.Size = new System.Drawing.Size(104, 24);
            this.RBVariant4.TabIndex = 28;
            // 
            // RBVariant3
            // 
            this.RBVariant3.Location = new System.Drawing.Point(619, 64);
            this.RBVariant3.Name = "RBVariant3";
            this.RBVariant3.Size = new System.Drawing.Size(104, 24);
            this.RBVariant3.TabIndex = 29;
            // 
            // RBVariant5
            // 
            this.RBVariant5.Location = new System.Drawing.Point(619, 64);
            this.RBVariant5.Name = "RBVariant5";
            this.RBVariant5.Size = new System.Drawing.Size(104, 24);
            this.RBVariant5.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "Сгенирировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBX
            // 
            this.LBX.FormattingEnabled = true;
            this.LBX.Location = new System.Drawing.Point(16, 188);
            this.LBX.Name = "LBX";
            this.LBX.Size = new System.Drawing.Size(45, 238);
            this.LBX.TabIndex = 15;
            // 
            // LBP
            // 
            this.LBP.FormattingEnabled = true;
            this.LBP.Location = new System.Drawing.Point(78, 188);
            this.LBP.Name = "LBP";
            this.LBP.Size = new System.Drawing.Size(61, 238);
            this.LBP.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(33, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(88, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "P";
            // 
            // Chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.Chart1.Legends.Add(legend9);
            this.Chart1.Location = new System.Drawing.Point(368, 19);
            this.Chart1.Name = "Chart1";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.Chart1.Series.Add(series9);
            this.Chart1.Size = new System.Drawing.Size(544, 407);
            this.Chart1.TabIndex = 19;
            this.Chart1.Text = "chart1";
            // 
            // TBN
            // 
            this.TBN.Location = new System.Drawing.Point(180, 66);
            this.TBN.Name = "TBN";
            this.TBN.Size = new System.Drawing.Size(40, 20);
            this.TBN.TabIndex = 21;
            this.TBN.Text = "200";
            this.TBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(141, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "N  =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(151, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "ΔP";
            // 
            // LBDel
            // 
            this.LBDel.FormattingEnabled = true;
            this.LBDel.Location = new System.Drawing.Point(145, 188);
            this.LBDel.Name = "LBDel";
            this.LBDel.Size = new System.Drawing.Size(75, 238);
            this.LBDel.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label9.Location = new System.Drawing.Point(246, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Выборка";
            // 
            // LB
            // 
            this.LB.FormattingEnabled = true;
            this.LB.Location = new System.Drawing.Point(235, 188);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(112, 238);
            this.LB.TabIndex = 24;
            // 
            // labelOfHiSquare
            // 
            this.labelOfHiSquare.AutoSize = true;
            this.labelOfHiSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelOfHiSquare.Location = new System.Drawing.Point(88, 107);
            this.labelOfHiSquare.Name = "labelOfHiSquare";
            this.labelOfHiSquare.Size = new System.Drawing.Size(119, 20);
            this.labelOfHiSquare.TabIndex = 26;
            this.labelOfHiSquare.Text = "ХиКвадрат =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(933, 455);
            this.Controls.Add(this.labelOfHiSquare);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LBDel);
            this.Controls.Add(this.TBN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBP);
            this.Controls.Add(this.LBX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RBVariant5);
            this.Controls.Add(this.RBVariant4);
            this.Controls.Add(this.RBVariant3);
            this.Controls.Add(this.RBVariant2);
            this.Controls.Add(this.RBVariant1);
            this.Controls.Add(this.LabelOfP);
            this.Controls.Add(this.TBL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBDelta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBP1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBX1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBX1;
        private System.Windows.Forms.TextBox TBP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBDelta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelOfP;
        private System.Windows.Forms.RadioButton RBVariant1;
        private System.Windows.Forms.RadioButton RBVariant2;
        private System.Windows.Forms.RadioButton RBVariant4;
        private System.Windows.Forms.RadioButton RBVariant3;
        private System.Windows.Forms.RadioButton RBVariant5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox LBX;
        private System.Windows.Forms.ListBox LBP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.TextBox TBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox LBDel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox LB;
        private System.Windows.Forms.Label labelOfHiSquare;
    }
}

