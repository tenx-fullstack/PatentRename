﻿namespace patentrename
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
            this.button1 = new System.Windows.Forms.Button();
            this.directoryPathTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryPathBt = new System.Windows.Forms.Button();
            this.prefixTb = new System.Windows.Forms.TextBox();
            this.endfixTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.originFileNameLb = new System.Windows.Forms.Label();
            this.changedfileNameLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // directoryPathTb
            // 
            this.directoryPathTb.Location = new System.Drawing.Point(60, 83);
            this.directoryPathTb.Name = "directoryPathTb";
            this.directoryPathTb.Size = new System.Drawing.Size(399, 20);
            this.directoryPathTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select directory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // directoryPathBt
            // 
            this.directoryPathBt.Location = new System.Drawing.Point(465, 80);
            this.directoryPathBt.Name = "directoryPathBt";
            this.directoryPathBt.Size = new System.Drawing.Size(75, 23);
            this.directoryPathBt.TabIndex = 3;
            this.directoryPathBt.Text = "browse";
            this.directoryPathBt.UseVisualStyleBackColor = true;
            this.directoryPathBt.Click += new System.EventHandler(this.directoryPathBt_Click);
            // 
            // prefixTb
            // 
            this.prefixTb.Location = new System.Drawing.Point(95, 138);
            this.prefixTb.Name = "prefixTb";
            this.prefixTb.Size = new System.Drawing.Size(72, 20);
            this.prefixTb.TabIndex = 4;
            // 
            // endfixTb
            // 
            this.endfixTb.Location = new System.Drawing.Point(222, 138);
            this.endfixTb.Name = "endfixTb";
            this.endfixTb.Size = new System.Drawing.Size(63, 20);
            this.endfixTb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "prefix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "endfix";
            // 
            // originFileNameLb
            // 
            this.originFileNameLb.AutoSize = true;
            this.originFileNameLb.Location = new System.Drawing.Point(171, 185);
            this.originFileNameLb.Name = "originFileNameLb";
            this.originFileNameLb.Size = new System.Drawing.Size(0, 13);
            this.originFileNameLb.TabIndex = 8;
            // 
            // changedfileNameLb
            // 
            this.changedfileNameLb.AutoSize = true;
            this.changedfileNameLb.Location = new System.Drawing.Point(171, 215);
            this.changedfileNameLb.Name = "changedfileNameLb";
            this.changedfileNameLb.Size = new System.Drawing.Size(0, 13);
            this.changedfileNameLb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Original File Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Changed File Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 298);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.changedfileNameLb);
            this.Controls.Add(this.originFileNameLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endfixTb);
            this.Controls.Add(this.prefixTb);
            this.Controls.Add(this.directoryPathBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.directoryPathTb);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox directoryPathTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button directoryPathBt;
        private System.Windows.Forms.TextBox prefixTb;
        private System.Windows.Forms.TextBox endfixTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label originFileNameLb;
        private System.Windows.Forms.Label changedfileNameLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

