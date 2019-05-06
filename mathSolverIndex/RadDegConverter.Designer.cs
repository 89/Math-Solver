namespace mathSolverIndex
{
    partial class RadDegConverter
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
            this.resetButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radianButton = new System.Windows.Forms.Button();
            this.degreeButton = new System.Windows.Forms.Button();
            this.solvingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(445, 248);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(223, 248);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Location = new System.Drawing.Point(434, 222);
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.Size = new System.Drawing.Size(100, 20);
            this.ResultTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Result";
            // 
            // resultType
            // 
            this.resultType.AutoSize = true;
            this.resultType.Location = new System.Drawing.Point(541, 228);
            this.resultType.Name = "resultType";
            this.resultType.Size = new System.Drawing.Size(0, 13);
            this.resultType.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Value";
            // 
            // radianButton
            // 
            this.radianButton.Location = new System.Drawing.Point(301, 119);
            this.radianButton.Name = "radianButton";
            this.radianButton.Size = new System.Drawing.Size(75, 23);
            this.radianButton.TabIndex = 8;
            this.radianButton.Text = "Radians";
            this.radianButton.UseVisualStyleBackColor = true;
            this.radianButton.Click += new System.EventHandler(this.radianButton_Click);
            // 
            // degreeButton
            // 
            this.degreeButton.Location = new System.Drawing.Point(382, 119);
            this.degreeButton.Name = "degreeButton";
            this.degreeButton.Size = new System.Drawing.Size(75, 23);
            this.degreeButton.TabIndex = 9;
            this.degreeButton.Text = "Degrees";
            this.degreeButton.UseVisualStyleBackColor = true;
            this.degreeButton.Click += new System.EventHandler(this.degreeButton_Click);
            // 
            // solvingLabel
            // 
            this.solvingLabel.AutoSize = true;
            this.solvingLabel.Location = new System.Drawing.Point(295, 103);
            this.solvingLabel.Name = "solvingLabel";
            this.solvingLabel.Size = new System.Drawing.Size(162, 13);
            this.solvingLabel.TabIndex = 10;
            this.solvingLabel.Text = "Which value are you solving for?";
            // 
            // RadDegConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solvingLabel);
            this.Controls.Add(this.degreeButton);
            this.Controls.Add(this.radianButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.resetButton);
            this.Name = "RadDegConverter";
            this.Text = "RadDegConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ResultTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button radianButton;
        private System.Windows.Forms.Button degreeButton;
        private System.Windows.Forms.Label solvingLabel;
    }
}