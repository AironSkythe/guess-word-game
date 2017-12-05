namespace guess_word_game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartPanel = new System.Windows.Forms.Panel();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.QuestLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.StartPanel.SuspendLayout();
            this.GamePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartPanel
            // 
            this.StartPanel.Controls.Add(this.StartButton);
            this.StartPanel.Location = new System.Drawing.Point(12, 12);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(755, 67);
            this.StartPanel.TabIndex = 0;
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.SubmitButton);
            this.GamePanel.Controls.Add(this.label1);
            this.GamePanel.Controls.Add(this.textBox1);
            this.GamePanel.Controls.Add(this.QuestLabel);
            this.GamePanel.Location = new System.Drawing.Point(12, 85);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(755, 222);
            this.GamePanel.TabIndex = 1;
            this.GamePanel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.resultLabel);
            this.panel3.Controls.Add(this.label);
            this.panel3.Location = new System.Drawing.Point(12, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 75);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(244, 19);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(292, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Почати гру";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // QuestLabel
            // 
            this.QuestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestLabel.AutoSize = true;
            this.QuestLabel.Location = new System.Drawing.Point(354, 39);
            this.QuestLabel.Name = "QuestLabel";
            this.QuestLabel.Size = new System.Drawing.Size(50, 13);
            this.QuestLabel.TabIndex = 0;
            this.QuestLabel.Text = "Питання";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Відповідь";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(357, 127);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Відповісти";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(297, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(71, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Ваш рахунок";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(419, 28);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(13, 13);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 400);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.StartPanel);
            this.Name = "Form1";
            this.Text = "Вгадай слово";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StartPanel.ResumeLayout(false);
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label QuestLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label;
    }
}

