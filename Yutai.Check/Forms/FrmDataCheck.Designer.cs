﻿namespace Yutai.Check.Forms
{
    partial class FrmDataCheck
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxPipelineLayers = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxFieldFull = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.checkBoxFieldRepeat = new System.Windows.Forms.CheckBox();
            this.checkBoxSingleLine = new System.Windows.Forms.CheckBox();
            this.checkBoxSinglePoint = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxPipelineLayers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据源";
            // 
            // checkedListBoxPipelineLayers
            // 
            this.checkedListBoxPipelineLayers.CheckOnClick = true;
            this.checkedListBoxPipelineLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxPipelineLayers.FormattingEnabled = true;
            this.checkedListBoxPipelineLayers.Location = new System.Drawing.Point(3, 17);
            this.checkedListBoxPipelineLayers.Name = "checkedListBoxPipelineLayers";
            this.checkedListBoxPipelineLayers.Size = new System.Drawing.Size(290, 367);
            this.checkedListBoxPipelineLayers.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxFieldRepeat);
            this.groupBox2.Controls.Add(this.checkBoxFieldFull);
            this.groupBox2.Location = new System.Drawing.Point(314, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "属性检查";
            // 
            // checkBoxFieldFull
            // 
            this.checkBoxFieldFull.AutoSize = true;
            this.checkBoxFieldFull.Location = new System.Drawing.Point(6, 20);
            this.checkBoxFieldFull.Name = "checkBoxFieldFull";
            this.checkBoxFieldFull.Size = new System.Drawing.Size(84, 16);
            this.checkBoxFieldFull.TabIndex = 0;
            this.checkBoxFieldFull.Text = "字段完整性";
            this.checkBoxFieldFull.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxSingleLine);
            this.groupBox3.Controls.Add(this.checkBoxSinglePoint);
            this.groupBox3.Location = new System.Drawing.Point(314, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 55);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "空间检查";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(625, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(544, 376);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "检查";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // checkBoxFieldRepeat
            // 
            this.checkBoxFieldRepeat.AutoSize = true;
            this.checkBoxFieldRepeat.Location = new System.Drawing.Point(127, 20);
            this.checkBoxFieldRepeat.Name = "checkBoxFieldRepeat";
            this.checkBoxFieldRepeat.Size = new System.Drawing.Size(84, 16);
            this.checkBoxFieldRepeat.TabIndex = 0;
            this.checkBoxFieldRepeat.Text = "字段重复值";
            this.checkBoxFieldRepeat.UseVisualStyleBackColor = true;
            // 
            // checkBoxSingleLine
            // 
            this.checkBoxSingleLine.AutoSize = true;
            this.checkBoxSingleLine.Location = new System.Drawing.Point(127, 20);
            this.checkBoxSingleLine.Name = "checkBoxSingleLine";
            this.checkBoxSingleLine.Size = new System.Drawing.Size(60, 16);
            this.checkBoxSingleLine.TabIndex = 1;
            this.checkBoxSingleLine.Text = "孤立线";
            this.checkBoxSingleLine.UseVisualStyleBackColor = true;
            // 
            // checkBoxSinglePoint
            // 
            this.checkBoxSinglePoint.AutoSize = true;
            this.checkBoxSinglePoint.Location = new System.Drawing.Point(6, 20);
            this.checkBoxSinglePoint.Name = "checkBoxSinglePoint";
            this.checkBoxSinglePoint.Size = new System.Drawing.Size(60, 16);
            this.checkBoxSinglePoint.TabIndex = 2;
            this.checkBoxSinglePoint.Text = "孤立点";
            this.checkBoxSinglePoint.UseVisualStyleBackColor = true;
            // 
            // FrmDataCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(712, 411);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDataCheck";
            this.Text = "数据检查";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxPipelineLayers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox checkBoxFieldFull;
        private System.Windows.Forms.CheckBox checkBoxFieldRepeat;
        private System.Windows.Forms.CheckBox checkBoxSingleLine;
        private System.Windows.Forms.CheckBox checkBoxSinglePoint;
    }
}