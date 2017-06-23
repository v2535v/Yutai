﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using Yutai.ArcGIS.Catalog.UI;

namespace Yutai.ArcGIS.Catalog.Geodatabase.UI
{
    partial class CoordinateControl
    {
        protected override void Dispose(bool bool_3)
        {
            if (bool_3 && (this.container_0 != null))
            {
                this.container_0.Dispose();
            }
            base.Dispose(bool_3);
        }

       
 private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.contextMenu_0 = new ContextMenu();
            this.menuItem_0 = new MenuItem();
            this.menuItem_1 = new MenuItem();
            this.textBoxDetail = new MemoEdit();
            this.textBoxName = new TextEdit();
            this.btnSelect = new SimpleButton();
            this.btnNew = new SimpleButton();
            this.btnClear = new SimpleButton();
            this.btnModify = new SimpleButton();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.btnSaveAs = new SimpleButton();
            this.label8 = new Label();
            this.btnImport = new SimpleButton();
            this.btnSet = new SimpleButton();
            this.label9 = new Label();
            this.textBoxDetail.Properties.BeginInit();
            this.textBoxName.Properties.BeginInit();
            base.SuspendLayout();
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名字:";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "详细信息";
            this.contextMenu_0.MenuItems.AddRange(new MenuItem[] { this.menuItem_0, this.menuItem_1 });
            this.menuItem_0.Index = 0;
            this.menuItem_0.Text = "地理坐标系";
            this.menuItem_0.Click += new EventHandler(this.menuItem_0_Click);
            this.menuItem_1.Index = 1;
            this.menuItem_1.Text = "投影坐标系";
            this.menuItem_1.Click += new EventHandler(this.menuItem_1_Click);
            this.textBoxDetail.EditValue = "";
            this.textBoxDetail.Location = new System.Drawing.Point(10, 56);
            this.textBoxDetail.Name = "textBoxDetail";
            this.textBoxDetail.Properties.Appearance.BackColor = SystemColors.InactiveBorder;
            this.textBoxDetail.Properties.Appearance.Options.UseBackColor = true;
            this.textBoxDetail.Properties.ReadOnly = true;
            this.textBoxDetail.Size = new Size(264, 165);
            this.textBoxDetail.TabIndex = 10;
            this.textBoxName.EditValue = "";
            this.textBoxName.Location = new System.Drawing.Point(56, 8);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Properties.ReadOnly = true;
            this.textBoxName.Size = new Size(216, 21);
            this.textBoxName.TabIndex = 11;
            this.textBoxName.EditValueChanged += new EventHandler(this.textBoxName_EditValueChanged);
            this.btnSelect.Location = new System.Drawing.Point(5, 257);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new Size(69, 24);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "选择";
            this.btnSelect.Click += new EventHandler(this.btnSelect_Click);
            this.btnNew.Location = new System.Drawing.Point(5, 321);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new Size(69, 24);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "新建...";
            this.btnNew.Click += new EventHandler(this.btnNew_Click);
            this.btnClear.Location = new System.Drawing.Point(5, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(69, 24);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "清空";
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            this.btnModify.Location = new System.Drawing.Point(5, 353);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new Size(69, 24);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "修改...";
            this.btnModify.Click += new EventHandler(this.btnModify_Click);
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 263);
            this.label3.Name = "label3";
            this.label3.Size = new Size(149, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "选择一个预定义的坐标系统";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 327);
            this.label4.Name = "label4";
            this.label4.Size = new Size(101, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "新建一个坐标系统";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 359);
            this.label5.Name = "label5";
            this.label5.Size = new Size(161, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "编辑当前选择的坐标系统属性";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 392);
            this.label6.Name = "label6";
            this.label6.Size = new Size(113, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "设置坐标系统到未知";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 424);
            this.label7.Name = "label7";
            this.label7.Size = new Size(113, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "保存坐标系统到文件";
            this.btnSaveAs.Location = new System.Drawing.Point(5, 417);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new Size(69, 24);
            this.btnSaveAs.TabIndex = 20;
            this.btnSaveAs.Text = "另存为...";
            this.btnSaveAs.Click += new EventHandler(this.btnSaveAs_Click);
            this.label8.Location = new System.Drawing.Point(80, 290);
            this.label8.Name = "label8";
            this.label8.Size = new Size(208, 32);
            this.label8.TabIndex = 23;
            this.label8.Text = "从已存在的数据中导入坐标系统和X/Y,Z和M域值";
            this.btnImport.Location = new System.Drawing.Point(5, 289);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new Size(69, 24);
            this.btnImport.TabIndex = 22;
            this.btnImport.Text = "导入";
            this.btnImport.Click += new EventHandler(this.btnImport_Click);
            this.btnSet.Location = new System.Drawing.Point(5, 227);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new Size(69, 24);
            this.btnSet.TabIndex = 24;
            this.btnSet.Text = "快速选择...";
            this.btnSet.Click += new EventHandler(this.btnSet_Click);
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 233);
            this.label9.Name = "label9";
            this.label9.Size = new Size(101, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "快速设置坐标系统";
            base.Controls.Add(this.label9);
            base.Controls.Add(this.btnSet);
            base.Controls.Add(this.label8);
            base.Controls.Add(this.btnImport);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.btnSaveAs);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.btnModify);
            base.Controls.Add(this.btnClear);
            base.Controls.Add(this.btnNew);
            base.Controls.Add(this.btnSelect);
            base.Controls.Add(this.textBoxName);
            base.Controls.Add(this.textBoxDetail);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Name = "CoordinateControl";
            base.Size = new Size(296, 448);
            base.Load += new EventHandler(this.CoordinateControl_Load);
            this.textBoxDetail.Properties.EndInit();
            this.textBoxName.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

       
        private SimpleButton btnClear;
        private SimpleButton btnImport;
        private SimpleButton btnModify;
        private SimpleButton btnNew;
        private SimpleButton btnSaveAs;
        private SimpleButton btnSelect;
        private SimpleButton btnSet;
        private ContextMenu contextMenu_0;
        private ISpatialReference ispatialReference_0;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private MenuItem menuItem_0;
        private MenuItem menuItem_1;
        private MemoEdit textBoxDetail;
        private TextEdit textBoxName;
    }
}