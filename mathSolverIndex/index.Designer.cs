namespace mathSolverIndex
{
    partial class index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.triangleSolverButton = new System.Windows.Forms.Button();
            this.rad_conversion_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // triangleSolverButton
            // 
            this.triangleSolverButton.Location = new System.Drawing.Point(29, 240);
            this.triangleSolverButton.Name = "triangleSolverButton";
            this.triangleSolverButton.Size = new System.Drawing.Size(92, 23);
            this.triangleSolverButton.TabIndex = 0;
            this.triangleSolverButton.Text = "Triangle Solver";
            this.triangleSolverButton.UseVisualStyleBackColor = true;
            this.triangleSolverButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rad_conversion_button
            // 
            this.rad_conversion_button.Location = new System.Drawing.Point(231, 240);
            this.rad_conversion_button.Name = "rad_conversion_button";
            this.rad_conversion_button.Size = new System.Drawing.Size(75, 23);
            this.rad_conversion_button.TabIndex = 1;
            this.rad_conversion_button.Text = "Radians & Degree Conversion";
            this.rad_conversion_button.UseVisualStyleBackColor = true;
            this.rad_conversion_button.Click += new System.EventHandler(this.rad_conversion_button_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.rad_conversion_button);
            this.Controls.Add(this.triangleSolverButton);
            this.Name = "index";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button triangleSolverButton;
        private System.Windows.Forms.Button rad_conversion_button;
    }
}

