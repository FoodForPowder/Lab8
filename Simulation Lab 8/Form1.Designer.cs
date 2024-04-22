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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(120, 22);
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
            this.tbAsk.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tbAnswer.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer.Location = new System.Drawing.Point(221, 180);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(134, 42);
            this.tbAnswer.TabIndex = 3;
            this.tbAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
    }
}

