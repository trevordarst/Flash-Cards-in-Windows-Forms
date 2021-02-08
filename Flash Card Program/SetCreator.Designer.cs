
namespace Flash_Card_Program
{
    partial class SetCreator
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
            this.cardTextInputBoxFront = new System.Windows.Forms.TextBox();
            this.addCardButton = new System.Windows.Forms.Button();
            this.aboveDisplayLabel = new System.Windows.Forms.Label();
            this.inputInidicatorLabel = new System.Windows.Forms.Label();
            this.cardTextInputBoxBack = new System.Windows.Forms.TextBox();
            this.deckCreatorLenLabel = new System.Windows.Forms.Label();
            this.saveAndExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cardTextInputBoxFront
            // 
            this.cardTextInputBoxFront.Location = new System.Drawing.Point(53, 145);
            this.cardTextInputBoxFront.Name = "cardTextInputBoxFront";
            this.cardTextInputBoxFront.Size = new System.Drawing.Size(199, 27);
            this.cardTextInputBoxFront.TabIndex = 0;
            // 
            // addCardButton
            // 
            this.addCardButton.Location = new System.Drawing.Point(106, 301);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(94, 29);
            this.addCardButton.TabIndex = 2;
            this.addCardButton.Text = "Next";
            this.addCardButton.UseVisualStyleBackColor = true;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
            // 
            // aboveDisplayLabel
            // 
            this.aboveDisplayLabel.AutoSize = true;
            this.aboveDisplayLabel.Location = new System.Drawing.Point(134, 209);
            this.aboveDisplayLabel.Name = "aboveDisplayLabel";
            this.aboveDisplayLabel.Size = new System.Drawing.Size(40, 20);
            this.aboveDisplayLabel.TabIndex = 4;
            this.aboveDisplayLabel.Text = "Back";
            // 
            // inputInidicatorLabel
            // 
            this.inputInidicatorLabel.AutoSize = true;
            this.inputInidicatorLabel.Location = new System.Drawing.Point(134, 104);
            this.inputInidicatorLabel.Name = "inputInidicatorLabel";
            this.inputInidicatorLabel.Size = new System.Drawing.Size(43, 20);
            this.inputInidicatorLabel.TabIndex = 5;
            this.inputInidicatorLabel.Text = "Front";
            // 
            // cardTextInputBoxBack
            // 
            this.cardTextInputBoxBack.Location = new System.Drawing.Point(53, 242);
            this.cardTextInputBoxBack.Name = "cardTextInputBoxBack";
            this.cardTextInputBoxBack.Size = new System.Drawing.Size(199, 27);
            this.cardTextInputBoxBack.TabIndex = 6;
            // 
            // deckCreatorLenLabel
            // 
            this.deckCreatorLenLabel.AutoSize = true;
            this.deckCreatorLenLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deckCreatorLenLabel.Location = new System.Drawing.Point(120, 21);
            this.deckCreatorLenLabel.Name = "deckCreatorLenLabel";
            this.deckCreatorLenLabel.Size = new System.Drawing.Size(54, 20);
            this.deckCreatorLenLabel.TabIndex = 7;
            this.deckCreatorLenLabel.Text = "Card 1";
            // 
            // saveAndExitButton
            // 
            this.saveAndExitButton.Location = new System.Drawing.Point(87, 420);
            this.saveAndExitButton.Name = "saveAndExitButton";
            this.saveAndExitButton.Size = new System.Drawing.Size(131, 29);
            this.saveAndExitButton.TabIndex = 8;
            this.saveAndExitButton.Text = "Save and Exit";
            this.saveAndExitButton.UseVisualStyleBackColor = true;
            this.saveAndExitButton.Click += new System.EventHandler(this.saveAndExitButton_Click);
            // 
            // SetCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 492);
            this.Controls.Add(this.saveAndExitButton);
            this.Controls.Add(this.deckCreatorLenLabel);
            this.Controls.Add(this.cardTextInputBoxBack);
            this.Controls.Add(this.inputInidicatorLabel);
            this.Controls.Add(this.aboveDisplayLabel);
            this.Controls.Add(this.addCardButton);
            this.Controls.Add(this.cardTextInputBoxFront);
            this.Name = "SetCreator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cardTextInputBoxFront;
        private System.Windows.Forms.Button addCardButton;
        private System.Windows.Forms.Label aboveDisplayLabel;
        private System.Windows.Forms.Label inputInidicatorLabel;
        private System.Windows.Forms.TextBox cardTextInputBoxBack;
        private System.Windows.Forms.Label deckCreatorLenLabel;
        private System.Windows.Forms.Button saveAndExitButton;
    }
}

