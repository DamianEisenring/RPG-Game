﻿namespace LiverDestroyer
{
    partial class LiverDestroyer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblExperience = new Label();
            lblLevel = new Label();
            lblhitpoints = new Label();
            lblGold = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Hit Points:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 46);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Gold:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 74);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Experience: ";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 100);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Level:";
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Location = new Point(110, 73);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(0, 20);
            lblExperience.TabIndex = 4;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Location = new Point(110, 99);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(0, 20);
            lblLevel.TabIndex = 5;
            // 
            // lblhitpoints
            // 
            lblhitpoints.AutoSize = true;
            lblhitpoints.Location = new Point(110, 20);
            lblhitpoints.Name = "lblhitpoints";
            lblhitpoints.Size = new Size(0, 20);
            lblhitpoints.TabIndex = 7;
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Location = new Point(110, 46);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(0, 20);
            lblGold.TabIndex = 8;
            // 
            // LiverDestroyer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 643);
            Controls.Add(lblGold);
            Controls.Add(lblhitpoints);
            Controls.Add(lblLevel);
            Controls.Add(lblExperience);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LiverDestroyer";
            Text = "My Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblExperience;
        private Label lblLevel;
        private Label lblhitpoints;
        private Label lblGold;
    }
}
