using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CrapEngine;

namespace Crapulator
{
    partial class FormMain
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
            textBoxFirstNumber = new TextBox();
            textBoxSecondNumber = new TextBox();
            textBoxTotal = new TextBox();
            buttonPartyTime = new Button();
            buttonMult = new Button();
            buttonFrom = new Button();
            buttonInto = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxFirstNumber
            // 
            textBoxFirstNumber.BackColor = SystemColors.ActiveCaptionText;
            textBoxFirstNumber.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstNumber.ForeColor = SystemColors.Menu;
            textBoxFirstNumber.Location = new Point(26, 24);
            textBoxFirstNumber.Name = "textBoxFirstNumber";
            textBoxFirstNumber.Size = new Size(80, 46);
            textBoxFirstNumber.TabIndex = 1;
            textBoxFirstNumber.Text = "0";
            // 
            // textBoxSecondNumber
            // 
            textBoxSecondNumber.BackColor = SystemColors.ActiveCaptionText;
            textBoxSecondNumber.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSecondNumber.ForeColor = SystemColors.Menu;
            textBoxSecondNumber.Location = new Point(310, 24);
            textBoxSecondNumber.Name = "textBoxSecondNumber";
            textBoxSecondNumber.Size = new Size(80, 46);
            textBoxSecondNumber.TabIndex = 3;
            textBoxSecondNumber.Text = "0";
            // 
            // textBoxTotal
            // 
            textBoxTotal.BackColor = SystemColors.ActiveCaptionText;
            textBoxTotal.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTotal.ForeColor = SystemColors.Menu;
            textBoxTotal.Location = new Point(310, 130);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(80, 46);
            textBoxTotal.TabIndex = 5;
            textBoxTotal.Text = "0";
            // 
            // buttonPartyTime
            // 
            buttonPartyTime.BackColor = SystemColors.ActiveCaptionText;
            buttonPartyTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPartyTime.ForeColor = SystemColors.Control;
            buttonPartyTime.Location = new Point(133, 24);
            buttonPartyTime.Name = "buttonPartyTime";
            buttonPartyTime.Size = new Size(59, 33);
            buttonPartyTime.TabIndex = 8;
            buttonPartyTime.Text = "plus";
            buttonPartyTime.UseVisualStyleBackColor = false;
            buttonPartyTime.Click += buttonPartyTime_Click;
            // 
            // buttonMult
            // 
            buttonMult.BackColor = SystemColors.ActiveCaptionText;
            buttonMult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMult.ForeColor = SystemColors.Control;
            buttonMult.Location = new Point(133, 64);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(59, 33);
            buttonMult.TabIndex = 10;
            buttonMult.Text = "times";
            buttonMult.UseVisualStyleBackColor = false;
            buttonMult.Click += buttonMult_Click;
            // 
            // buttonFrom
            // 
            buttonFrom.BackColor = SystemColors.ActiveCaptionText;
            buttonFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFrom.ForeColor = SystemColors.Control;
            buttonFrom.Location = new Point(216, 24);
            buttonFrom.Name = "buttonFrom";
            buttonFrom.Size = new Size(59, 33);
            buttonFrom.TabIndex = 11;
            buttonFrom.Text = "from";
            buttonFrom.UseVisualStyleBackColor = false;
            buttonFrom.Click += buttonFrom_Click;
            // 
            // buttonInto
            // 
            buttonInto.BackColor = SystemColors.ActiveCaptionText;
            buttonInto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInto.ForeColor = SystemColors.Control;
            buttonInto.Location = new Point(216, 64);
            buttonInto.Name = "buttonInto";
            buttonInto.Size = new Size(58, 34);
            buttonInto.TabIndex = 12;
            buttonInto.Text = "into";
            buttonInto.UseVisualStyleBackColor = false;
            buttonInto.Click += buttonInto_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.source;
            pictureBox1.Location = new Point(-7, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 206);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(133, 134);
            button1.Name = "button1";
            button1.Size = new Size(142, 34);
            button1.TabIndex = 14;
            button1.Text = "is (rounded)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 180);
            Controls.Add(button1);
            Controls.Add(buttonInto);
            Controls.Add(buttonFrom);
            Controls.Add(buttonMult);
            Controls.Add(buttonPartyTime);
            Controls.Add(textBoxTotal);
            Controls.Add(textBoxSecondNumber);
            Controls.Add(textBoxFirstNumber);
            Controls.Add(pictureBox1);
            Name = "FormMain";
            Text = "The Crapulator";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxFirstNumber;
        private TextBox textBoxSecondNumber;
        private TextBox textBoxTotal;
        private Button buttonPartyTime;
        private Button buttonMult;
        private Button buttonFrom;
        private Button buttonInto;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
