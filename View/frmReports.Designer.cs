﻿namespace RM.View
{
    partial class frmReports
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalsCat = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reports";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoRoundedCorners = true;
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnMenu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMenu.CheckedState.Image = global::RM.Properties.Resources.home1;
            this.btnMenu.CustomizableEdges.BottomRight = false;
            this.btnMenu.CustomizableEdges.TopRight = false;
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::RM.Properties.Resources.menu;
            this.btnMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnMenu.Location = new System.Drawing.Point(41, 88);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(182, 107);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menu List";
            this.btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.TextOffset = new System.Drawing.Point(20, 0);
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.AutoRoundedCorners = true;
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnStaff.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStaff.CheckedState.Image = global::RM.Properties.Resources.home1;
            this.btnStaff.CustomizableEdges.BottomRight = false;
            this.btnStaff.CustomizableEdges.TopRight = false;
            this.btnStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStaff.FillColor = System.Drawing.Color.Transparent;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::RM.Properties.Resources.menu;
            this.btnStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnStaff.Location = new System.Drawing.Point(229, 88);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(182, 107);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Staff List";
            this.btnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.TextOffset = new System.Drawing.Point(20, 0);
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnSalsCat
            // 
            this.btnSalsCat.AutoRoundedCorners = true;
            this.btnSalsCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnSalsCat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalsCat.CheckedState.Image = global::RM.Properties.Resources.home1;
            this.btnSalsCat.CustomizableEdges.BottomRight = false;
            this.btnSalsCat.CustomizableEdges.TopRight = false;
            this.btnSalsCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSalsCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSalsCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSalsCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSalsCat.FillColor = System.Drawing.Color.Transparent;
            this.btnSalsCat.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSalsCat.ForeColor = System.Drawing.Color.White;
            this.btnSalsCat.Image = global::RM.Properties.Resources.menu;
            this.btnSalsCat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalsCat.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnSalsCat.Location = new System.Drawing.Point(417, 88);
            this.btnSalsCat.Name = "btnSalsCat";
            this.btnSalsCat.Size = new System.Drawing.Size(182, 107);
            this.btnSalsCat.TabIndex = 3;
            this.btnSalsCat.Text = "Sale By Category";
            this.btnSalsCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalsCat.TextOffset = new System.Drawing.Point(20, 0);
            this.btnSalsCat.Click += new System.EventHandler(this.btnSalsCat_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalsCat);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
        private Guna.UI2.WinForms.Guna2Button btnSalsCat;
    }
}