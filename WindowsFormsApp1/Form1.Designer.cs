namespace WindowsFormsApp1
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
            this.labelForTime = new System.Windows.Forms.Label();
            this.buttonShowTime = new System.Windows.Forms.Button();
            this.buttonAnother = new System.Windows.Forms.Button();
            this.comboBoxTimeFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerForTime = new System.Windows.Forms.Timer(this.components);
            this.richTextBoxForTime = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelForTime
            // 
            this.labelForTime.AutoSize = true;
            this.labelForTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForTime.Location = new System.Drawing.Point(417, 21);
            this.labelForTime.Name = "labelForTime";
            this.labelForTime.Size = new System.Drawing.Size(160, 24);
            this.labelForTime.TabIndex = 0;
            this.labelForTime.Text = "Текущее время";
            // 
            // buttonShowTime
            // 
            this.buttonShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowTime.Location = new System.Drawing.Point(100, 19);
            this.buttonShowTime.Name = "buttonShowTime";
            this.buttonShowTime.Size = new System.Drawing.Size(75, 23);
            this.buttonShowTime.TabIndex = 1;
            this.buttonShowTime.Text = "Время";
            this.buttonShowTime.UseVisualStyleBackColor = true;
            this.buttonShowTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonShowTime_MouseClick);
            this.buttonShowTime.MouseLeave += new System.EventHandler(this.buttonShowTime_MouseLeave);
            this.buttonShowTime.MouseHover += new System.EventHandler(this.buttonShowTime_MouseHover);
            // 
            // buttonAnother
            // 
            this.buttonAnother.Location = new System.Drawing.Point(23, 96);
            this.buttonAnother.Name = "buttonAnother";
            this.buttonAnother.Size = new System.Drawing.Size(130, 23);
            this.buttonAnother.TabIndex = 2;
            this.buttonAnother.Text = "Ещё одна кнопка";
            this.buttonAnother.UseVisualStyleBackColor = true;
            this.buttonAnother.Click += new System.EventHandler(this.buttonAnother_Click);
            // 
            // comboBoxTimeFormat
            // 
            this.comboBoxTimeFormat.FormattingEnabled = true;
            this.comboBoxTimeFormat.Items.AddRange(new object[] {
            "Полное время",
            "Только дата",
            "Краткое время"});
            this.comboBoxTimeFormat.Location = new System.Drawing.Point(246, 21);
            this.comboBoxTimeFormat.Name = "comboBoxTimeFormat";
            this.comboBoxTimeFormat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTimeFormat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // timerForTime
            // 
            this.timerForTime.Enabled = true;
            this.timerForTime.Interval = 1000;
            this.timerForTime.Tick += new System.EventHandler(this.timerForTime_Tick);
            // 
            // richTextBoxForTime
            // 
            this.richTextBoxForTime.Location = new System.Drawing.Point(356, 93);
            this.richTextBoxForTime.Name = "richTextBoxForTime";
            this.richTextBoxForTime.Size = new System.Drawing.Size(221, 26);
            this.richTextBoxForTime.TabIndex = 5;
            this.richTextBoxForTime.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 193);
            this.Controls.Add(this.richTextBoxForTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTimeFormat);
            this.Controls.Add(this.buttonAnother);
            this.Controls.Add(this.buttonShowTime);
            this.Controls.Add(this.labelForTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForTime;
        private System.Windows.Forms.Button buttonShowTime;
        private System.Windows.Forms.Button buttonAnother;
        private System.Windows.Forms.ComboBox comboBoxTimeFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerForTime;
        private System.Windows.Forms.RichTextBox richTextBoxForTime;
    }
}

