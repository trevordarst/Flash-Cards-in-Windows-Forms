
namespace Flash_Card_Program
{
    partial class MainMenu
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
            this.viewExistingSetButton = new System.Windows.Forms.Button();
            this.createNewSetButton = new System.Windows.Forms.Button();
            this.exitProgramButton = new System.Windows.Forms.Button();
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // viewExistingSetButton
            // 
            this.viewExistingSetButton.Location = new System.Drawing.Point(298, 161);
            this.viewExistingSetButton.Name = "viewExistingSetButton";
            this.viewExistingSetButton.Size = new System.Drawing.Size(154, 29);
            this.viewExistingSetButton.TabIndex = 0;
            this.viewExistingSetButton.Text = "View Existing Set";
            this.viewExistingSetButton.UseVisualStyleBackColor = true;
            this.viewExistingSetButton.Click += new System.EventHandler(this.viewExistingSetButton_Click);
            // 
            // createNewSetButton
            // 
            this.createNewSetButton.Location = new System.Drawing.Point(298, 222);
            this.createNewSetButton.Name = "createNewSetButton";
            this.createNewSetButton.Size = new System.Drawing.Size(154, 29);
            this.createNewSetButton.TabIndex = 1;
            this.createNewSetButton.Text = "Create New Set";
            this.createNewSetButton.UseVisualStyleBackColor = true;
            this.createNewSetButton.Click += new System.EventHandler(this.createNewSetButton_Click);
            // 
            // exitProgramButton
            // 
            this.exitProgramButton.Location = new System.Drawing.Point(298, 283);
            this.exitProgramButton.Name = "exitProgramButton";
            this.exitProgramButton.Size = new System.Drawing.Size(154, 29);
            this.exitProgramButton.TabIndex = 2;
            this.exitProgramButton.Text = "Exit Program";
            this.exitProgramButton.UseVisualStyleBackColor = true;
            this.exitProgramButton.Click += new System.EventHandler(this.exitProgramButton_Click);
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainMenuLabel.Location = new System.Drawing.Point(240, 52);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(274, 62);
            this.mainMenuLabel.TabIndex = 3;
            this.mainMenuLabel.Text = "Flash Cards";
            this.mainMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenuLabel);
            this.Controls.Add(this.exitProgramButton);
            this.Controls.Add(this.createNewSetButton);
            this.Controls.Add(this.viewExistingSetButton);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewExistingSetButton;
        private System.Windows.Forms.Button createNewSetButton;
        private System.Windows.Forms.Button exitProgramButton;
        private System.Windows.Forms.Label mainMenuLabel;
    }
}