namespace Simulation_Lab_8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAsk = new System.Windows.Forms.TextBox();
            this.btAnswer = new System.Windows.Forms.Button();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAsk2 = new System.Windows.Forms.TextBox();
            this.btAnswer2 = new System.Windows.Forms.Button();
            this.tbAnswer2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ed1 = new System.Windows.Forms.NumericUpDown();
            this.ed3 = new System.Windows.Forms.NumericUpDown();
            this.ed4 = new System.Windows.Forms.NumericUpDown();
            this.ed2 = new System.Windows.Forms.NumericUpDown();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edN = new System.Windows.Forms.NumericUpDown();
            this.btStart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задай мне вопрос в формате да/нет";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbAsk
            // 
            this.tbAsk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAsk.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.tbAsk.Location = new System.Drawing.Point(26, 68);
            this.tbAsk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAsk.Multiline = true;
            this.tbAsk.Name = "tbAsk";
            this.tbAsk.Size = new System.Drawing.Size(373, 43);
            this.tbAsk.TabIndex = 1;
            this.tbAsk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAnswer
            // 
            this.btAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAnswer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAnswer.Location = new System.Drawing.Point(148, 132);
            this.btAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAnswer.Name = "btAnswer";
            this.btAnswer.Size = new System.Drawing.Size(141, 40);
            this.btAnswer.TabIndex = 2;
            this.btAnswer.Text = "Спросить";
            this.btAnswer.UseVisualStyleBackColor = true;
            this.btAnswer.Click += new System.EventHandler(this.btAnswer_Click);
            // 
            // tbAnswer
            // 
            this.tbAnswer.BackColor = System.Drawing.SystemColors.Control;
            this.tbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnswer.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.tbAnswer.Location = new System.Drawing.Point(171, 194);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.ReadOnly = true;
            this.tbAnswer.Size = new System.Drawing.Size(102, 42);
            this.tbAnswer.TabIndex = 3;
            this.tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(153, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Спроси меня";
            // 
            // tbAsk2
            // 
            this.tbAsk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAsk2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAsk2.Location = new System.Drawing.Point(26, 320);
            this.tbAsk2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAsk2.Multiline = true;
            this.tbAsk2.Name = "tbAsk2";
            this.tbAsk2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAsk2.Size = new System.Drawing.Size(373, 43);
            this.tbAsk2.TabIndex = 5;
            this.tbAsk2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAnswer2
            // 
            this.btAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAnswer2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAnswer2.Location = new System.Drawing.Point(148, 383);
            this.btAnswer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAnswer2.Name = "btAnswer2";
            this.btAnswer2.Size = new System.Drawing.Size(141, 40);
            this.btAnswer2.TabIndex = 6;
            this.btAnswer2.Text = "Спросить";
            this.btAnswer2.UseVisualStyleBackColor = true;
            this.btAnswer2.Click += new System.EventHandler(this.btAnswer2_Click);
            // 
            // tbAnswer2
            // 
            this.tbAnswer2.BackColor = System.Drawing.SystemColors.Control;
            this.tbAnswer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnswer2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.tbAnswer2.Location = new System.Drawing.Point(26, 444);
            this.tbAnswer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAnswer2.Multiline = true;
            this.tbAnswer2.Name = "tbAnswer2";
            this.tbAnswer2.ReadOnly = true;
            this.tbAnswer2.Size = new System.Drawing.Size(373, 47);
            this.tbAnswer2.TabIndex = 7;
            this.tbAnswer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(464, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Финальная часть";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(447, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prob 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(447, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Prob 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(447, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Prob 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(447, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Prob 5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(447, 204);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prob 3";
            // 
            // ed1
            // 
            this.ed1.DecimalPlaces = 2;
            this.ed1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ed1.Location = new System.Drawing.Point(582, 106);
            this.ed1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ed1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed1.Name = "ed1";
            this.ed1.Size = new System.Drawing.Size(70, 26);
            this.ed1.TabIndex = 15;
            this.ed1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed1.Value = new decimal(new int[] {
            13,
            0,
            0,
            131072});
            this.ed1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ed3
            // 
            this.ed3.DecimalPlaces = 2;
            this.ed3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ed3.Location = new System.Drawing.Point(582, 198);
            this.ed3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ed3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed3.Name = "ed3";
            this.ed3.Size = new System.Drawing.Size(70, 26);
            this.ed3.TabIndex = 16;
            this.ed3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed3.Value = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            // 
            // ed4
            // 
            this.ed4.DecimalPlaces = 2;
            this.ed4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ed4.Location = new System.Drawing.Point(582, 248);
            this.ed4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ed4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed4.Name = "ed4";
            this.ed4.Size = new System.Drawing.Size(70, 26);
            this.ed4.TabIndex = 17;
            this.ed4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed4.Value = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            // 
            // ed2
            // 
            this.ed2.DecimalPlaces = 2;
            this.ed2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ed2.Location = new System.Drawing.Point(582, 153);
            this.ed2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ed2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ed2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ed2.Name = "ed2";
            this.ed2.Size = new System.Drawing.Size(70, 26);
            this.ed2.TabIndex = 18;
            this.ed2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ed2.Value = new decimal(new int[] {
            9,
            0,
            0,
            131072});
            // 
            // tb5
            // 
            this.tb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb5.Location = new System.Drawing.Point(582, 293);
            this.tb5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb5.Multiline = true;
            this.tb5.Name = "tb5";
            this.tb5.ReadOnly = true;
            this.tb5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb5.Size = new System.Drawing.Size(70, 24);
            this.tb5.TabIndex = 19;
            this.tb5.Text = "auto";
            this.tb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(447, 343);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Number of trials";
            // 
            // edN
            // 
            this.edN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edN.Location = new System.Drawing.Point(583, 338);
            this.edN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edN.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.edN.Name = "edN";
            this.edN.Size = new System.Drawing.Size(70, 26);
            this.edN.TabIndex = 21;
            this.edN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.edN.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // btStart
            // 
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btStart.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btStart.Location = new System.Drawing.Point(461, 392);
            this.btStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(173, 40);
            this.btStart.TabIndex = 22;
            this.btStart.Text = "Запуск";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.ForeColor = System.Drawing.Color.DarkGray;
            legend1.HeaderSeparatorColor = System.Drawing.Color.Gainsboro;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(688, 143);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(397, 289);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F);
            this.textBox1.Location = new System.Drawing.Point(688, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(397, 61);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 521);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.edN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.ed2);
            this.Controls.Add(this.ed4);
            this.Controls.Add(this.ed3);
            this.Controls.Add(this.ed1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAnswer2);
            this.Controls.Add(this.btAnswer2);
            this.Controls.Add(this.tbAsk2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.btAnswer);
            this.Controls.Add(this.tbAsk);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAsk;
        private System.Windows.Forms.Button btAnswer;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAsk2;
        private System.Windows.Forms.Button btAnswer2;
        private System.Windows.Forms.TextBox tbAnswer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ed1;
        private System.Windows.Forms.NumericUpDown ed3;
        private System.Windows.Forms.NumericUpDown ed4;
        private System.Windows.Forms.NumericUpDown ed2;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown edN;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

