namespace Pong
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aPaddle1 = new System.Windows.Forms.PictureBox();
            this.aPaddle2 = new System.Windows.Forms.PictureBox();
            this.aBall = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.aLabelPlayer1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aLabelPlayer2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).BeginInit();
            this.SuspendLayout();
            // 
            // aPaddle1
            // 
            this.aPaddle1.Image = ((System.Drawing.Image)(resources.GetObject("aPaddle1.Image")));
            this.aPaddle1.Location = new System.Drawing.Point(12, 214);
            this.aPaddle1.Name = "aPaddle1";
            this.aPaddle1.Size = new System.Drawing.Size(30, 123);
            this.aPaddle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aPaddle1.TabIndex = 0;
            this.aPaddle1.TabStop = false;
            // 
            // aPaddle2
            // 
            this.aPaddle2.Image = ((System.Drawing.Image)(resources.GetObject("aPaddle2.Image")));
            this.aPaddle2.Location = new System.Drawing.Point(1041, 214);
            this.aPaddle2.Name = "aPaddle2";
            this.aPaddle2.Size = new System.Drawing.Size(30, 123);
            this.aPaddle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aPaddle2.TabIndex = 1;
            this.aPaddle2.TabStop = false;
            // 
            // aBall
            // 
            this.aBall.Image = ((System.Drawing.Image)(resources.GetObject("aBall.Image")));
            this.aBall.Location = new System.Drawing.Point(503, 244);
            this.aBall.Name = "aBall";
            this.aBall.Size = new System.Drawing.Size(52, 54);
            this.aBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.aBall.TabIndex = 2;
            this.aBall.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(498, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Score";
            // 
            // aLabelPlayer1
            // 
            this.aLabelPlayer1.AutoSize = true;
            this.aLabelPlayer1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelPlayer1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aLabelPlayer1.Location = new System.Drawing.Point(486, 38);
            this.aLabelPlayer1.Name = "aLabelPlayer1";
            this.aLabelPlayer1.Size = new System.Drawing.Size(26, 29);
            this.aLabelPlayer1.TabIndex = 5;
            this.aLabelPlayer1.Text = "0";
            this.aLabelPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(518, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "|";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aLabelPlayer2
            // 
            this.aLabelPlayer2.AutoSize = true;
            this.aLabelPlayer2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelPlayer2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aLabelPlayer2.Location = new System.Drawing.Point(544, 38);
            this.aLabelPlayer2.Name = "aLabelPlayer2";
            this.aLabelPlayer2.Size = new System.Drawing.Size(26, 29);
            this.aLabelPlayer2.TabIndex = 7;
            this.aLabelPlayer2.Text = "0";
            this.aLabelPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 70);
            this.label3.TabIndex = 8;
            this.label3.Text = "Project members:\r\nTalha Irshad - Ep 1849122\r\nSheikh Raees Raza - Ep 1849100\r\nZees" +
    "han Noorullah - Ep 1849137\r\nHassan Alam - Ep 1849027";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1083, 588);
            this.Controls.Add(this.aLabelPlayer2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aLabelPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aBall);
            this.Controls.Add(this.aPaddle2);
            this.Controls.Add(this.aPaddle1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox aPaddle1;
        private System.Windows.Forms.PictureBox aPaddle2;
        private System.Windows.Forms.PictureBox aBall;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label aLabelPlayer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label aLabelPlayer2;
        private System.Windows.Forms.Label label3;
    }
}

