﻿using LibCommonControl;
using LibCommonForm;

namespace LibPanels
{
    partial class MineDataSimple
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
            this.txtCoordinateZ = new System.Windows.Forms.TextBox();
            this.txtCoordinateY = new System.Windows.Forms.TextBox();
            this.lblWorkStyle = new System.Windows.Forms.Label();
            this.txtCoordinateX = new System.Windows.Forms.TextBox();
            this.cboSubmitter = new System.Windows.Forms.ComboBox();
            this.labCoordinateZ = new System.Windows.Forms.Label();
            this.lblWorkTime = new System.Windows.Forms.Label();
            this.lblSubmiter = new System.Windows.Forms.Label();
            this.rbtn38 = new System.Windows.Forms.RadioButton();
            this.cboTeamName = new System.Windows.Forms.ComboBox();
            this.rbtn46 = new System.Windows.Forms.RadioButton();
            this.lblTeam = new System.Windows.Forms.Label();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.cboWorkTime = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbxCoordinate = new System.Windows.Forms.GroupBox();
            this.labCoordinateY = new System.Windows.Forms.Label();
            this.labCoordinateX = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectTunnelSimple1 = new LibCommonForm.SelectTunnelSimple();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbxCoordinate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCoordinateZ
            // 
            this.txtCoordinateZ.Location = new System.Drawing.Point(61, 84);
            this.txtCoordinateZ.Name = "txtCoordinateZ";
            this.txtCoordinateZ.Size = new System.Drawing.Size(104, 22);
            this.txtCoordinateZ.TabIndex = 5;
            this.txtCoordinateZ.Text = "0";
            // 
            // txtCoordinateY
            // 
            this.txtCoordinateY.Location = new System.Drawing.Point(61, 52);
            this.txtCoordinateY.Name = "txtCoordinateY";
            this.txtCoordinateY.Size = new System.Drawing.Size(104, 22);
            this.txtCoordinateY.TabIndex = 4;
            this.txtCoordinateY.Text = "0";
            // 
            // lblWorkStyle
            // 
            this.lblWorkStyle.AutoSize = true;
            this.lblWorkStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWorkStyle.Location = new System.Drawing.Point(7, 22);
            this.lblWorkStyle.Name = "lblWorkStyle";
            this.lblWorkStyle.Size = new System.Drawing.Size(55, 14);
            this.lblWorkStyle.TabIndex = 31;
            this.lblWorkStyle.Text = "工作制式";
            // 
            // txtCoordinateX
            // 
            this.txtCoordinateX.Location = new System.Drawing.Point(61, 21);
            this.txtCoordinateX.Name = "txtCoordinateX";
            this.txtCoordinateX.Size = new System.Drawing.Size(104, 22);
            this.txtCoordinateX.TabIndex = 3;
            this.txtCoordinateX.Text = "0";
            // 
            // cboSubmitter
            // 
            this.cboSubmitter.FormattingEnabled = true;
            this.cboSubmitter.Location = new System.Drawing.Point(79, 76);
            this.cboSubmitter.Name = "cboSubmitter";
            this.cboSubmitter.Size = new System.Drawing.Size(109, 22);
            this.cboSubmitter.TabIndex = 36;
            // 
            // labCoordinateZ
            // 
            this.labCoordinateZ.AutoSize = true;
            this.labCoordinateZ.Location = new System.Drawing.Point(36, 89);
            this.labCoordinateZ.Name = "labCoordinateZ";
            this.labCoordinateZ.Size = new System.Drawing.Size(14, 14);
            this.labCoordinateZ.TabIndex = 2;
            this.labCoordinateZ.Text = "Z";
            // 
            // lblWorkTime
            // 
            this.lblWorkTime.AutoSize = true;
            this.lblWorkTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWorkTime.Location = new System.Drawing.Point(6, 83);
            this.lblWorkTime.Name = "lblWorkTime";
            this.lblWorkTime.Size = new System.Drawing.Size(47, 14);
            this.lblWorkTime.TabIndex = 0;
            this.lblWorkTime.Text = "班    次";
            // 
            // lblSubmiter
            // 
            this.lblSubmiter.AutoSize = true;
            this.lblSubmiter.BackColor = System.Drawing.Color.Transparent;
            this.lblSubmiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSubmiter.Location = new System.Drawing.Point(8, 79);
            this.lblSubmiter.Name = "lblSubmiter";
            this.lblSubmiter.Size = new System.Drawing.Size(43, 14);
            this.lblSubmiter.TabIndex = 35;
            this.lblSubmiter.Text = "填报人";
            // 
            // rbtn38
            // 
            this.rbtn38.AutoSize = true;
            this.rbtn38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn38.Location = new System.Drawing.Point(100, 20);
            this.rbtn38.Name = "rbtn38";
            this.rbtn38.Size = new System.Drawing.Size(60, 18);
            this.rbtn38.TabIndex = 32;
            this.rbtn38.TabStop = true;
            this.rbtn38.Text = "三八制";
            this.rbtn38.UseVisualStyleBackColor = true;
            this.rbtn38.CheckedChanged += new System.EventHandler(this.rbtn38_CheckedChanged);
            // 
            // cboTeamName
            // 
            this.cboTeamName.FormattingEnabled = true;
            this.cboTeamName.Location = new System.Drawing.Point(79, 23);
            this.cboTeamName.Name = "cboTeamName";
            this.cboTeamName.Size = new System.Drawing.Size(108, 22);
            this.cboTeamName.TabIndex = 40;
            this.cboTeamName.SelectedIndexChanged += new System.EventHandler(this.cboTeamName_SelectedIndexChanged);
            // 
            // rbtn46
            // 
            this.rbtn46.AutoSize = true;
            this.rbtn46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn46.Location = new System.Drawing.Point(100, 55);
            this.rbtn46.Name = "rbtn46";
            this.rbtn46.Size = new System.Drawing.Size(60, 18);
            this.rbtn46.TabIndex = 33;
            this.rbtn46.TabStop = true;
            this.rbtn46.Text = "四六制";
            this.rbtn46.UseVisualStyleBackColor = true;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.BackColor = System.Drawing.Color.Transparent;
            this.lblTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTeam.Location = new System.Drawing.Point(13, 27);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(31, 14);
            this.lblTeam.TabIndex = 39;
            this.lblTeam.Text = "队别";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Location = new System.Drawing.Point(506, 14);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(156, 22);
            this.dtpDateTime.TabIndex = 38;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDateTime.Location = new System.Drawing.Point(439, 21);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(55, 14);
            this.lblDateTime.TabIndex = 37;
            this.lblDateTime.Text = "提交日期";
            // 
            // cboWorkTime
            // 
            this.cboWorkTime.FormattingEnabled = true;
            this.cboWorkTime.Location = new System.Drawing.Point(77, 79);
            this.cboWorkTime.Name = "cboWorkTime";
            this.cboWorkTime.Size = new System.Drawing.Size(102, 22);
            this.cboWorkTime.TabIndex = 34;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(544, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 27);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(405, 290);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 27);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbxCoordinate
            // 
            this.gbxCoordinate.BackColor = System.Drawing.Color.Transparent;
            this.gbxCoordinate.Controls.Add(this.txtCoordinateZ);
            this.gbxCoordinate.Controls.Add(this.txtCoordinateY);
            this.gbxCoordinate.Controls.Add(this.txtCoordinateX);
            this.gbxCoordinate.Controls.Add(this.labCoordinateZ);
            this.gbxCoordinate.Controls.Add(this.labCoordinateY);
            this.gbxCoordinate.Controls.Add(this.labCoordinateX);
            this.gbxCoordinate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxCoordinate.Location = new System.Drawing.Point(14, 63);
            this.gbxCoordinate.Name = "gbxCoordinate";
            this.gbxCoordinate.Padding = new System.Windows.Forms.Padding(1);
            this.gbxCoordinate.Size = new System.Drawing.Size(204, 117);
            this.gbxCoordinate.TabIndex = 24;
            this.gbxCoordinate.TabStop = false;
            this.gbxCoordinate.Text = "坐标";
            // 
            // labCoordinateY
            // 
            this.labCoordinateY.AutoSize = true;
            this.labCoordinateY.Location = new System.Drawing.Point(36, 57);
            this.labCoordinateY.Name = "labCoordinateY";
            this.labCoordinateY.Size = new System.Drawing.Size(15, 14);
            this.labCoordinateY.TabIndex = 1;
            this.labCoordinateY.Text = "Y";
            // 
            // labCoordinateX
            // 
            this.labCoordinateX.AutoSize = true;
            this.labCoordinateX.Location = new System.Drawing.Point(36, 26);
            this.labCoordinateX.Name = "labCoordinateX";
            this.labCoordinateX.Size = new System.Drawing.Size(14, 14);
            this.labCoordinateX.TabIndex = 0;
            this.labCoordinateX.Text = "X";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectTunnelSimple1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gbxCoordinate);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.dtpDateTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 331);
            this.panel1.TabIndex = 42;
            // 
            // selectTunnelSimple1
            // 
            this.selectTunnelSimple1.Location = new System.Drawing.Point(14, 12);
            this.selectTunnelSimple1.Name = "selectTunnelSimple1";
            this.selectTunnelSimple1.Size = new System.Drawing.Size(302, 38);
            this.selectTunnelSimple1.TabIndex = 44;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboTeamName);
            this.groupBox2.Controls.Add(this.lblTeam);
            this.groupBox2.Controls.Add(this.cboSubmitter);
            this.groupBox2.Controls.Add(this.lblSubmiter);
            this.groupBox2.Location = new System.Drawing.Point(455, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 117);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWorkStyle);
            this.groupBox1.Controls.Add(this.cboWorkTime);
            this.groupBox1.Controls.Add(this.rbtn38);
            this.groupBox1.Controls.Add(this.lblWorkTime);
            this.groupBox1.Controls.Add(this.rbtn46);
            this.groupBox1.Location = new System.Drawing.Point(234, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 117);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(13, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 84);
            this.panel2.TabIndex = 42;
            // 
            // MineDataSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 331);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MineDataSimple";
            this.Text = "工作面瓦斯涌出动态特征井下数据";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MineDataSimple_FormClosing);
            this.Load += new System.EventHandler(this.MineDataSimple_Load);
            this.gbxCoordinate.ResumeLayout(false);
            this.gbxCoordinate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCoordinateZ;
        private System.Windows.Forms.TextBox txtCoordinateY;
        private System.Windows.Forms.Label lblWorkStyle;
        private System.Windows.Forms.TextBox txtCoordinateX;
        private System.Windows.Forms.ComboBox cboSubmitter;
        private System.Windows.Forms.Label labCoordinateZ;
        private System.Windows.Forms.Label lblWorkTime;
        private System.Windows.Forms.Label lblSubmiter;
        private System.Windows.Forms.RadioButton rbtn38;
        private System.Windows.Forms.ComboBox cboTeamName;
        private System.Windows.Forms.RadioButton rbtn46;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.ComboBox cboWorkTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbxCoordinate;
        private System.Windows.Forms.Label labCoordinateY;
        private System.Windows.Forms.Label labCoordinateX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private SelectTunnelSimple selectTunnelSimple1;
    }
}