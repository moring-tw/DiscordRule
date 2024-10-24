namespace DiscordRule
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnEnableRule = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbTopMost = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnEnableRule
            // 
            this.btnEnableRule.Location = new System.Drawing.Point(139, 32);
            this.btnEnableRule.Name = "btnEnableRule";
            this.btnEnableRule.Size = new System.Drawing.Size(75, 23);
            this.btnEnableRule.TabIndex = 0;
            this.btnEnableRule.Text = "button1";
            this.btnEnableRule.UseVisualStyleBackColor = true;
            this.btnEnableRule.Click += new System.EventHandler(this.btnEnableRule_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbTopMost
            // 
            this.cbTopMost.AutoSize = true;
            this.cbTopMost.Location = new System.Drawing.Point(12, 7);
            this.cbTopMost.Name = "cbTopMost";
            this.cbTopMost.Size = new System.Drawing.Size(86, 19);
            this.cbTopMost.TabIndex = 2;
            this.cbTopMost.Text = "最上方顯示";
            this.cbTopMost.UseVisualStyleBackColor = true;
            this.cbTopMost.CheckedChanged += new System.EventHandler(this.cbTopMost_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 67);
            this.Controls.Add(this.cbTopMost);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnEnableRule);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEnableRule;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
        private CheckBox cbTopMost;
    }
}