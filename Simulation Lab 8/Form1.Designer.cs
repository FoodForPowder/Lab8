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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAsk = new System.Windows.Forms.TextBox();
            this.btAnswer = new System.Windows.Forms.Button();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAsk2 = new System.Windows.Forms.TextBox();
            this.btAnswer2 = new System.Windows.Forms.Button();
            this.tbAnswer2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 18);
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
            this.tbAsk.Location = new System.Drawing.Point(82, 61);
            this.tbAsk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAsk.Multiline = true;
            this.tbAsk.Name = "tbAsk";
            this.tbAsk.Size = new System.Drawing.Size(406, 43);
            this.tbAsk.TabIndex = 1;
            this.tbAsk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAnswer
            // 
            this.btAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAnswer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAnswer.Location = new System.Drawing.Point(204, 125);
            this.btAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAnswer.Name = "btAnswer";
            this.btAnswer.Size = new System.Drawing.Size(173, 40);
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
            this.tbAnswer.Location = new System.Drawing.Point(227, 187);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.ReadOnly = true;
            this.tbAnswer.Size = new System.Drawing.Size(134, 42);
            this.tbAnswer.TabIndex = 3;
            this.tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(206, 275);
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
            this.tbAsk2.Location = new System.Drawing.Point(82, 313);
            this.tbAsk2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAsk2.Multiline = true;
            this.tbAsk2.Name = "tbAsk2";
            this.tbAsk2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbAsk2.Size = new System.Drawing.Size(406, 43);
            this.tbAsk2.TabIndex = 5;
            this.tbAsk2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btAnswer2
            // 
            this.btAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAnswer2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAnswer2.Location = new System.Drawing.Point(204, 375);
            this.btAnswer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAnswer2.Name = "btAnswer2";
            this.btAnswer2.Size = new System.Drawing.Size(173, 40);
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
            this.tbAnswer2.Location = new System.Drawing.Point(82, 436);
            this.tbAnswer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAnswer2.Multiline = true;
            this.tbAnswer2.Name = "tbAnswer2";
            this.tbAnswer2.ReadOnly = true;
            this.tbAnswer2.Size = new System.Drawing.Size(405, 47);
            this.tbAnswer2.TabIndex = 7;
            this.tbAnswer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 527);
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
    }
}

