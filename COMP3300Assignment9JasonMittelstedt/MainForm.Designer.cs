namespace COMP3300Assignment9JasonMittelstedt
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoadFile = new Button();
            btnShowChecking = new Button();
            btnShowSavings = new Button();
            txtDisplay = new TextBox();
            btnShowMoneyMarket = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            statementBox = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            statementBox.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(47, 26);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(94, 29);
            btnLoadFile.TabIndex = 0;
            btnLoadFile.Text = "File";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnShowChecking
            // 
            btnShowChecking.Location = new Point(24, 72);
            btnShowChecking.Name = "btnShowChecking";
            btnShowChecking.Size = new Size(121, 29);
            btnShowChecking.TabIndex = 1;
            btnShowChecking.Text = "Checking";
            btnShowChecking.UseVisualStyleBackColor = true;
            btnShowChecking.Click += btnShowChecking_Click;
            // 
            // btnShowSavings
            // 
            btnShowSavings.Location = new Point(24, 130);
            btnShowSavings.Name = "btnShowSavings";
            btnShowSavings.Size = new Size(110, 29);
            btnShowSavings.TabIndex = 2;
            btnShowSavings.Text = "Savings";
            btnShowSavings.UseVisualStyleBackColor = true;
            btnShowSavings.Click += btnShowSavings_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(18, 42);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(514, 366);
            txtDisplay.TabIndex = 4;
            // 
            // btnShowMoneyMarket
            // 
            btnShowMoneyMarket.Location = new Point(24, 190);
            btnShowMoneyMarket.Name = "btnShowMoneyMarket";
            btnShowMoneyMarket.Size = new Size(157, 29);
            btnShowMoneyMarket.TabIndex = 5;
            btnShowMoneyMarket.Text = "Money Market";
            btnShowMoneyMarket.UseVisualStyleBackColor = true;
            btnShowMoneyMarket.Click += btnShowMoneyMarket_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoadFile);
            groupBox1.Location = new Point(12, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(199, 65);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Load";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnShowChecking);
            groupBox2.Controls.Add(btnShowSavings);
            groupBox2.Controls.Add(btnShowMoneyMarket);
            groupBox2.Location = new Point(12, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(199, 283);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Show";
            // 
            // statementBox
            // 
            statementBox.Controls.Add(txtDisplay);
            statementBox.Location = new Point(235, 12);
            statementBox.Name = "statementBox";
            statementBox.Size = new Size(553, 426);
            statementBox.TabIndex = 8;
            statementBox.TabStop = false;
            statementBox.Text = "Statement";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statementBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Bank Account";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            statementBox.ResumeLayout(false);
            statementBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadFile;
        private Button btnShowChecking;
        private Button btnShowSavings;
        private TextBox txtDisplay;
        private Button btnShowMoneyMarket;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox statementBox;
    }
}
