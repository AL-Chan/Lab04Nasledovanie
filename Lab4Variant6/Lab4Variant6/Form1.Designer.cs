
namespace Lab4Variant6
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
            this.RefillButton = new System.Windows.Forms.Button();
            this.GrabButton = new System.Windows.Forms.Button();
            this.MenuText = new System.Windows.Forms.RichTextBox();
            this.InfoLog = new System.Windows.Forms.RichTextBox();
            this.NAME = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RefillButton
            // 
            this.RefillButton.Location = new System.Drawing.Point(296, 85);
            this.RefillButton.Name = "RefillButton";
            this.RefillButton.Size = new System.Drawing.Size(116, 45);
            this.RefillButton.TabIndex = 0;
            this.RefillButton.Text = "Заполнить автомат";
            this.RefillButton.UseVisualStyleBackColor = true;
            this.RefillButton.Click += new System.EventHandler(this.RefillButton_Click);
            // 
            // GrabButton
            // 
            this.GrabButton.Location = new System.Drawing.Point(296, 150);
            this.GrabButton.Name = "GrabButton";
            this.GrabButton.Size = new System.Drawing.Size(116, 57);
            this.GrabButton.TabIndex = 1;
            this.GrabButton.Text = "Взять еду";
            this.GrabButton.UseVisualStyleBackColor = true;
            this.GrabButton.Click += new System.EventHandler(this.GrabButton_Click);
            // 
            // MenuText
            // 
            this.MenuText.BackColor = System.Drawing.Color.SkyBlue;
            this.MenuText.Location = new System.Drawing.Point(30, 46);
            this.MenuText.Name = "MenuText";
            this.MenuText.Size = new System.Drawing.Size(241, 66);
            this.MenuText.TabIndex = 2;
            this.MenuText.Text = "";
            // 
            // InfoLog
            // 
            this.InfoLog.Location = new System.Drawing.Point(30, 150);
            this.InfoLog.Name = "InfoLog";
            this.InfoLog.Size = new System.Drawing.Size(222, 78);
            this.InfoLog.TabIndex = 3;
            this.InfoLog.Text = "";
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME.ForeColor = System.Drawing.Color.Maroon;
            this.NAME.Location = new System.Drawing.Point(77, 9);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(175, 25);
            this.NAME.TabIndex = 4;
            this.NAME.Text = "наПолдничёк";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(419, 253);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.InfoLog);
            this.Controls.Add(this.MenuText);
            this.Controls.Add(this.GrabButton);
            this.Controls.Add(this.RefillButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Автомат со сладостями";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefillButton;
        private System.Windows.Forms.Button GrabButton;
        private System.Windows.Forms.RichTextBox MenuText;
        private System.Windows.Forms.RichTextBox InfoLog;
        private System.Windows.Forms.Label NAME;
    }
}

