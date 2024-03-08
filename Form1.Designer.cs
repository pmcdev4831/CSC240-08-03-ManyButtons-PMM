namespace CSC240_08_03_ManyButtons_PMM
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
            UxRedButton = new Button();
            UxWhiteButton = new Button();
            UxBlueButton = new Button();
            UxFavoriteButton = new Button();
            SuspendLayout();
            // 
            // UxRedButton
            // 
            UxRedButton.Location = new Point(83, 43);
            UxRedButton.Name = "UxRedButton";
            UxRedButton.Size = new Size(75, 23);
            UxRedButton.TabIndex = 0;
            UxRedButton.Text = "Red";
            UxRedButton.UseVisualStyleBackColor = true;
            // 
            // UxWhiteButton
            // 
            UxWhiteButton.Location = new Point(214, 43);
            UxWhiteButton.Name = "UxWhiteButton";
            UxWhiteButton.Size = new Size(75, 23);
            UxWhiteButton.TabIndex = 1;
            UxWhiteButton.Text = "White";
            UxWhiteButton.UseVisualStyleBackColor = true;
            // 
            // UxBlueButton
            // 
            UxBlueButton.Location = new Point(368, 43);
            UxBlueButton.Name = "UxBlueButton";
            UxBlueButton.Size = new Size(75, 23);
            UxBlueButton.TabIndex = 2;
            UxBlueButton.Text = "Blue";
            UxBlueButton.UseVisualStyleBackColor = true;
            // 
            // UxFavoriteButton
            // 
            UxFavoriteButton.Location = new Point(533, 29);
            UxFavoriteButton.Name = "UxFavoriteButton";
            UxFavoriteButton.Size = new Size(134, 50);
            UxFavoriteButton.TabIndex = 3;
            UxFavoriteButton.Text = "My Favorite Color";
            UxFavoriteButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 153);
            Controls.Add(UxFavoriteButton);
            Controls.Add(UxBlueButton);
            Controls.Add(UxWhiteButton);
            Controls.Add(UxRedButton);
            Name = "Form1";
            Text = "Many Buttons";
            ResumeLayout(false);
        }

        #endregion

        private Button UxRedButton;
        private Button UxWhiteButton;
        private Button UxBlueButton;
        private Button UxFavoriteButton;
    }
}
