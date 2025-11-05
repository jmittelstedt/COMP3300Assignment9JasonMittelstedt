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
            SuspendLayout();
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(142, 118);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(94, 29);
            btnLoadFile.TabIndex = 0;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnShowChecking
            // 
            btnShowChecking.Location = new Point(242, 118);
            btnShowChecking.Name = "btnShowChecking";
            btnShowChecking.Size = new Size(121, 29);
            btnShowChecking.TabIndex = 1;
            btnShowChecking.Text = "Show Checking";
            btnShowChecking.UseVisualStyleBackColor = true;
            btnShowChecking.Click += btnShowChecking_Click;
            // 
            // btnShowSavings
            // 
            btnShowSavings.Location = new Point(369, 118);
            btnShowSavings.Name = "btnShowSavings";
            btnShowSavings.Size = new Size(110, 29);
            btnShowSavings.TabIndex = 2;
            btnShowSavings.Text = "Show Savings";
            btnShowSavings.UseVisualStyleBackColor = true;
            btnShowSavings.Click += btnShowSavings_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(142, 166);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(500, 238);
            txtDisplay.TabIndex = 4;
            // 
            // btnShowMoneyMarket
            // 
            btnShowMoneyMarket.Location = new Point(485, 118);
            btnShowMoneyMarket.Name = "btnShowMoneyMarket";
            btnShowMoneyMarket.Size = new Size(157, 29);
            btnShowMoneyMarket.TabIndex = 5;
            btnShowMoneyMarket.Text = "Show Money Market";
            btnShowMoneyMarket.UseVisualStyleBackColor = true;
            btnShowMoneyMarket.Click += btnShowMoneyMarket_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowMoneyMarket);
            Controls.Add(txtDisplay);
            Controls.Add(btnShowSavings);
            Controls.Add(btnShowChecking);
            Controls.Add(btnLoadFile);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadFile;
        private Button btnShowChecking;
        private Button btnShowSavings;
        private TextBox txtDisplay;
        private Button btnShowMoneyMarket;
    }
}
