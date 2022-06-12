namespace OpenClosedPrincipal
{
    partial class PointForm
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
            this.PointButton = new System.Windows.Forms.Button();
            this.PointLabel = new System.Windows.Forms.Label();
            this.DeadLineLabel = new System.Windows.Forms.Label();
            this.DeadLineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PointButton
            // 
            this.PointButton.Location = new System.Drawing.Point(135, 28);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(182, 57);
            this.PointButton.TabIndex = 0;
            this.PointButton.Text = "ポイント";
            this.PointButton.UseVisualStyleBackColor = true;
            this.PointButton.Click += new System.EventHandler(this.PointButton_Click);
            // 
            // PointLabel
            // 
            this.PointLabel.AutoSize = true;
            this.PointLabel.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PointLabel.Location = new System.Drawing.Point(198, 88);
            this.PointLabel.Name = "PointLabel";
            this.PointLabel.Size = new System.Drawing.Size(46, 45);
            this.PointLabel.TabIndex = 1;
            this.PointLabel.Text = "--";
            // 
            // DeadLineLabel
            // 
            this.DeadLineLabel.AutoSize = true;
            this.DeadLineLabel.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeadLineLabel.Location = new System.Drawing.Point(198, 224);
            this.DeadLineLabel.Name = "DeadLineLabel";
            this.DeadLineLabel.Size = new System.Drawing.Size(46, 45);
            this.DeadLineLabel.TabIndex = 3;
            this.DeadLineLabel.Text = "--";
            // 
            // DeadLineButton
            // 
            this.DeadLineButton.Location = new System.Drawing.Point(135, 164);
            this.DeadLineButton.Name = "DeadLineButton";
            this.DeadLineButton.Size = new System.Drawing.Size(182, 57);
            this.DeadLineButton.TabIndex = 2;
            this.DeadLineButton.Text = "使用期限";
            this.DeadLineButton.UseVisualStyleBackColor = true;
            this.DeadLineButton.Click += new System.EventHandler(this.DeadLineButton_Click);
            // 
            // PointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 278);
            this.Controls.Add(this.DeadLineLabel);
            this.Controls.Add(this.DeadLineButton);
            this.Controls.Add(this.PointLabel);
            this.Controls.Add(this.PointButton);
            this.Name = "PointForm";
            this.Text = "PointForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PointButton;
        private Label PointLabel;
        private Label DeadLineLabel;
        private Button DeadLineButton;
    }
}