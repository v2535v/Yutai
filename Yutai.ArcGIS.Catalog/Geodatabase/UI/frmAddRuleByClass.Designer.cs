﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using Yutai.ArcGIS.Common.Wrapper;

namespace Yutai.ArcGIS.Catalog.Geodatabase.UI
{
    partial class frmAddRuleByClass
    {
        protected override void Dispose(bool bool_1)
        {
            if (bool_1 && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(bool_1);
        }

       
        private void InitializeComponent()
        {
            this.icontainer_0 = new Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRuleByClass));
            this.label1 = new Label();
            this.label2 = new Label();
            this.comboRule = new System.Windows.Forms.ComboBox();
            this.btnOK = new Button();
            this.btnCancel = new Button();
            this.imageList_0 = new ImageList(this.icontainer_0);
            this.groupBox1 = new GroupBox();
            this.lblTopoInfo2 = new Label();
            this.lblTopoInfo1 = new Label();
            this.chkShowError = new CheckEdit();
            this.imageComboBoxEdit1 = new ImageComboBoxEdit();
            this.checkedListBox1 = new CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.chkShowError.Properties.BeginInit();
            this.imageComboBoxEdit1.Properties.BeginInit();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 62);
            this.label1.Name = "label1";
            this.label1.Size = new Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "要素类的要素";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 8);
            this.label2.Name = "label2";
            this.label2.Size = new Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "规则";
            this.comboRule.Location = new System.Drawing.Point(1, 32);
            this.comboRule.Name = "comboRule";
            this.comboRule.Size = new Size(192, 20);
            this.comboRule.TabIndex = 3;
            this.comboRule.SelectedIndexChanged += new EventHandler(this.comboRule_SelectedIndexChanged);
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(336, 192);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new Size(56, 24);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new EventHandler(this.btnOK_Click);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(408, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new Size(64, 24);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
            this.imageList_0.ImageStream = (ImageListStreamer) resources.GetObject("imageList1.ImageStream");
            this.imageList_0.TransparentColor = Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "");
            this.imageList_0.Images.SetKeyName(1, "");
            this.imageList_0.Images.SetKeyName(2, "");
            this.imageList_0.Images.SetKeyName(3, "");
            this.imageList_0.Images.SetKeyName(4, "");
            this.imageList_0.Images.SetKeyName(5, "");
            this.imageList_0.Images.SetKeyName(6, "");
            this.imageList_0.Images.SetKeyName(7, "");
            this.imageList_0.Images.SetKeyName(8, "");
            this.imageList_0.Images.SetKeyName(9, "");
            this.imageList_0.Images.SetKeyName(10, "");
            this.imageList_0.Images.SetKeyName(11, "");
            this.imageList_0.Images.SetKeyName(12, "");
            this.imageList_0.Images.SetKeyName(13, "");
            this.imageList_0.Images.SetKeyName(14, "");
            this.imageList_0.Images.SetKeyName(15, "");
            this.imageList_0.Images.SetKeyName(16, "");
            this.imageList_0.Images.SetKeyName(17, "");
            this.imageList_0.Images.SetKeyName(18, "");
            this.imageList_0.Images.SetKeyName(19, "");
            this.groupBox1.Controls.Add(this.lblTopoInfo2);
            this.groupBox1.Controls.Add(this.lblTopoInfo1);
            this.groupBox1.Controls.Add(this.chkShowError);
            this.groupBox1.Controls.Add(this.imageComboBoxEdit1);
            this.groupBox1.Location = new System.Drawing.Point(208, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(272, 176);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "规则描述";
            this.lblTopoInfo2.Location = new System.Drawing.Point(104, 104);
            this.lblTopoInfo2.Name = "lblTopoInfo2";
            this.lblTopoInfo2.Size = new Size(160, 48);
            this.lblTopoInfo2.TabIndex = 13;
            this.lblTopoInfo1.Location = new System.Drawing.Point(104, 32);
            this.lblTopoInfo1.Name = "lblTopoInfo1";
            this.lblTopoInfo1.Size = new Size(160, 48);
            this.lblTopoInfo1.TabIndex = 12;
            this.chkShowError.EditValue = true;
            this.chkShowError.Location = new System.Drawing.Point(8, 152);
            this.chkShowError.Name = "chkShowError";
            this.chkShowError.Properties.Caption = "显示错误";
            this.chkShowError.Size = new Size(75, 19);
            this.chkShowError.TabIndex = 11;
            this.chkShowError.CheckedChanged += new EventHandler(this.chkShowError_CheckedChanged);
            this.imageComboBoxEdit1.EditValue = 0;
            this.imageComboBoxEdit1.Location = new System.Drawing.Point(9, 24);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.imageComboBoxEdit1.Properties.Items.AddRange(new ImageComboBoxItem[] { 
                new ImageComboBoxItem("", 0, 0), new ImageComboBoxItem("", 1, 1), new ImageComboBoxItem("", 2, 2), new ImageComboBoxItem("", 3, 3), new ImageComboBoxItem("", 4, 4), new ImageComboBoxItem("", 5, 5), new ImageComboBoxItem("", 6, 6), new ImageComboBoxItem("", 7, 7), new ImageComboBoxItem("", 8, 8), new ImageComboBoxItem("", 9, 9), new ImageComboBoxItem("", 10, 10), new ImageComboBoxItem("", 11, 11), new ImageComboBoxItem("", 12, 12), new ImageComboBoxItem("", 13, 13), new ImageComboBoxItem("", 14, 14), new ImageComboBoxItem("", 15, 15), 
                new ImageComboBoxItem("", 16, 16), new ImageComboBoxItem("", 17, 17), new ImageComboBoxItem("", 18, 18), new ImageComboBoxItem("", 19, 19), new ImageComboBoxItem("", 20, 20), new ImageComboBoxItem("", 21, 21), new ImageComboBoxItem("", 22, 22), new ImageComboBoxItem("", 23, 23), new ImageComboBoxItem("", 24, 24), new ImageComboBoxItem("", 25, 25), new ImageComboBoxItem("", 26, 26), new ImageComboBoxItem("", 27, 27), new ImageComboBoxItem("", 28, 28), new ImageComboBoxItem("", 29, 29), new ImageComboBoxItem("", 30, 30), new ImageComboBoxItem("", 31, 31), 
                new ImageComboBoxItem("", 32, 32), new ImageComboBoxItem("", 33, 33), new ImageComboBoxItem("", 34, 34), new ImageComboBoxItem("", 35, 35), new ImageComboBoxItem("", 36, 36), new ImageComboBoxItem("", 37, 37), new ImageComboBoxItem("", 38, 38), new ImageComboBoxItem("", 39, 39), new ImageComboBoxItem("", 40, 40), new ImageComboBoxItem("", 41, 41), new ImageComboBoxItem("", 42, 42), new ImageComboBoxItem("", 43, 43), new ImageComboBoxItem("", 44, 44), new ImageComboBoxItem("", 45, 45), new ImageComboBoxItem("", 46, 46), new ImageComboBoxItem("", 47, 47), 
                new ImageComboBoxItem("", 48, 48), new ImageComboBoxItem("", 49, 49)
             });
            this.imageComboBoxEdit1.Properties.LargeImages = this.imageList_0;
            this.imageComboBoxEdit1.Properties.ReadOnly = true;
            this.imageComboBoxEdit1.Properties.ShowDropDown = ShowDropDown.Never;
            this.imageComboBoxEdit1.Properties.SmallImages = this.imageList_0;
            this.imageComboBoxEdit1.Size = new Size(88, 122);
            this.imageComboBoxEdit1.TabIndex = 9;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 77);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new Size(187, 84);
            this.checkedListBox1.TabIndex = 10;
            this.AutoScaleBaseSize = new Size(6, 14);
            base.ClientSize = new Size(488, 228);
            base.Controls.Add(this.checkedListBox1);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.btnCancel);
            base.Controls.Add(this.btnOK);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.comboRule);
            
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "frmAddRuleByClass";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "添加规则";
            base.Load += new EventHandler(this.frmAddRuleByClass_Load);
            this.groupBox1.ResumeLayout(false);
            this.chkShowError.Properties.EndInit();
            this.imageComboBoxEdit1.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

       
        private bool bool_0;
        private Button btnCancel;
        private Button btnOK;
        private CheckedListBox checkedListBox1;
        private CheckEdit chkShowError;
        private System.Windows.Forms.ComboBox comboRule;
        private GroupBox groupBox1;
        private IArray iarray_0;
        private IContainer icontainer_0;
        private ImageComboBoxEdit imageComboBoxEdit1;
        private ImageList imageList_0;
        private int int_0;
        private Label label1;
        private Label label2;
        private Label lblTopoInfo1;
        private Label lblTopoInfo2;
    }
}