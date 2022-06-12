namespace OpenClosedPrincipal
{
    partial class CardForm
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
            this.CardNoTextBox = new System.Windows.Forms.TextBox();
            this.ReadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CardNoTextBox
            // 
            this.CardNoTextBox.Location = new System.Drawing.Point(48, 79);
            this.CardNoTextBox.Name = "CardNoTextBox";
            this.CardNoTextBox.Size = new System.Drawing.Size(192, 23);
            this.CardNoTextBox.TabIndex = 0;
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(272, 78);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(75, 23);
            this.ReadButton.TabIndex = 1;
            this.ReadButton.Text = "読み込み";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 194);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.CardNoTextBox);
            this.Name = "CardForm";
            this.Text = "CardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox CardNoTextBox;
        private Button ReadButton;
    }
}