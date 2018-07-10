namespace GameOfLife
{
    partial class Form_Principal
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
            this.pictureBox_LifeBoard = new System.Windows.Forms.PictureBox();
            this.button_New = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LifeBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_LifeBoard
            // 
            this.pictureBox_LifeBoard.Location = new System.Drawing.Point(9, 10);
            this.pictureBox_LifeBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_LifeBoard.Name = "pictureBox_LifeBoard";
            this.pictureBox_LifeBoard.Size = new System.Drawing.Size(500, 500);
            this.pictureBox_LifeBoard.TabIndex = 0;
            this.pictureBox_LifeBoard.TabStop = false;
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(206, 514);
            this.button_New.Margin = new System.Windows.Forms.Padding(2);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(98, 19);
            this.button_New.TabIndex = 2;
            this.button_New.Text = "New";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 536);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.pictureBox_LifeBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form_Principal";
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.Form_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LifeBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_LifeBoard;
        private System.Windows.Forms.Button button_New;
    }
}

