﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geometry;
using Yutai.ArcGIS.Common.SymbolLib;

namespace Yutai.ArcGIS.Controls.SymbolUI
{
    //[Guid("D80B76D7-E320-4d49-A984-60AFEBE6E374")]
    partial class frmStyleManagerDialog
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.components != null)
                {
                    this.components.Dispose();
                }
                if (this._license != null)
                {
                    this._license.Dispose();
                }
                this._license = null;
            }
            base.Dispose(disposing);
        }

       
        private void InitializeComponent()
        {
            this.components = new Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStyleManagerDialog));
            this.SymbolLibTreeView = new TreeView();
            this.imageList1 = new ImageList(this.components);
            this.btnClose = new SimpleButton();
            this.contextMenu1 = new ContextMenu();
            this.menuItemNew = new MenuItem();
            this.menuItem4 = new MenuItem();
            this.menuItemCut = new MenuItem();
            this.menuItemCopy = new MenuItem();
            this.menuItemPaste = new MenuItem();
            this.menuItem5 = new MenuItem();
            this.menuItemDelete = new MenuItem();
            this.menuItem9 = new MenuItem();
            this.menuItemProperty = new MenuItem();
            this.menuItemNewPointRepRule = new MenuItem();
            this.menuItemNewLineRepRule = new MenuItem();
            this.menuItemNewFillRepRule = new MenuItem();
            this.btnStyleSet = new SimpleButton();
            this.StyleSetManagerMenu = new ContextMenu();
            this.menuItemNewStyleSet = new MenuItem();
            this.menuItemAddStyleSet = new MenuItem();
            this.symbolListView1 = new SymbolListViewEx();
            this.radioButton1 = new RadioButton();
            this.radioButton2 = new RadioButton();
            this.radioButton3 = new RadioButton();
            this.barManager1 = new BarManager(this.components);
            this.barAndDockingController1 = new BarAndDockingController(this.components);
            this.barDockControlTop = new BarDockControl();
            this.barDockControlBottom = new BarDockControl();
            this.barDockControlLeft = new BarDockControl();
            this.barDockControlRight = new BarDockControl();
            this.popupMenu1 = new PopupMenu(this.components);
            this.label7 = new Label();
            this.comboBoxEdit = new ComboBoxEdit();
            this.barManager1.BeginInit();
            this.barAndDockingController1.BeginInit();
            this.popupMenu1.BeginInit();
            this.comboBoxEdit.Properties.BeginInit();
            base.SuspendLayout();
            this.SymbolLibTreeView.HideSelection = false;
            this.SymbolLibTreeView.ImageIndex = 0;
            this.SymbolLibTreeView.ImageList = this.imageList1;
            this.SymbolLibTreeView.Location = new System.Drawing.Point(1, 8);
            this.SymbolLibTreeView.Name = "SymbolLibTreeView";
            this.SymbolLibTreeView.SelectedImageIndex = 1;
            this.SymbolLibTreeView.Size = new Size(192, 368);
            this.SymbolLibTreeView.TabIndex = 0;
            this.SymbolLibTreeView.AfterSelect += new TreeViewEventHandler(this.SymbolLibTreeView_AfterSelect);
            this.imageList1.ImageStream = (ImageListStreamer) resources.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.btnClose.Location = new System.Drawing.Point(424, 352);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(48, 24);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new EventHandler(this.btnClose_Click);
            this.contextMenu1.MenuItems.AddRange(new MenuItem[] { this.menuItemNew, this.menuItem4, this.menuItemCut, this.menuItemCopy, this.menuItemPaste, this.menuItem5, this.menuItemDelete, this.menuItem9, this.menuItemProperty });
            this.menuItemNew.Index = 0;
            this.menuItemNew.Text = "新建";
            this.menuItemNew.Click += new EventHandler(this.menuItemNew_Click);
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            this.menuItemCut.Index = 2;
            this.menuItemCut.Text = "剪切";
            this.menuItemCut.Click += new EventHandler(this.menuItemCut_Click);
            this.menuItemCopy.Index = 3;
            this.menuItemCopy.Text = "拷贝";
            this.menuItemCopy.Click += new EventHandler(this.menuItemCopy_Click);
            this.menuItemPaste.Enabled = false;
            this.menuItemPaste.Index = 4;
            this.menuItemPaste.Text = "粘贴";
            this.menuItemPaste.Click += new EventHandler(this.menuItemPaste_Click);
            this.menuItem5.Index = 5;
            this.menuItem5.Text = "-";
            this.menuItemDelete.Index = 6;
            this.menuItemDelete.Text = "删除";
            this.menuItemDelete.Click += new EventHandler(this.menuItemDelete_Click);
            this.menuItem9.Index = 7;
            this.menuItem9.Text = "-";
            this.menuItemProperty.Index = 8;
            this.menuItemProperty.Text = "属性";
            this.menuItemProperty.Click += new EventHandler(this.menuItemProperty_Click);
            this.menuItemNewPointRepRule.Index = -1;
            this.menuItemNewPointRepRule.Text = "点表现规则";
            this.menuItemNewPointRepRule.Click += new EventHandler(this.menuItemNewPointRepRule_Click);
            this.menuItemNewLineRepRule.Index = -1;
            this.menuItemNewLineRepRule.Text = "线表现规则";
            this.menuItemNewLineRepRule.Click += new EventHandler(this.menuItemNewLineRepRule_Click);
            this.menuItemNewFillRepRule.Index = -1;
            this.menuItemNewFillRepRule.Text = "面表现规则";
            this.menuItemNewFillRepRule.Click += new EventHandler(this.menuItemNewFillRepRule_Click);
            this.btnStyleSet.Location = new System.Drawing.Point(368, 352);
            this.btnStyleSet.Name = "btnStyleSet";
            this.btnStyleSet.Size = new Size(48, 24);
            this.btnStyleSet.TabIndex = 3;
            this.btnStyleSet.Text = "样式";
            this.btnStyleSet.Click += new EventHandler(this.btnStyleSet_Click);
            this.StyleSetManagerMenu.MenuItems.AddRange(new MenuItem[] { this.menuItemNewStyleSet, this.menuItemAddStyleSet });
            this.menuItemNewStyleSet.Index = 0;
            this.menuItemNewStyleSet.Text = "新建";
            this.menuItemNewStyleSet.Click += new EventHandler(this.menuItemNewStyleSet_Click);
            this.menuItemAddStyleSet.Index = 1;
            this.menuItemAddStyleSet.Text = "添加";
            this.menuItemAddStyleSet.Click += new EventHandler(this.menuItemAddStyleSet_Click);
            this.symbolListView1.BackColor = SystemColors.Window;
            this.symbolListView1.CanEditLabel = true;
            this.symbolListView1.Location = new System.Drawing.Point(200, 56);
            this.symbolListView1.Name = "symbolListView1";
            this.symbolListView1.Size = new Size(300, 288);
            this.symbolListView1.TabIndex = 4;
            this.symbolListView1.UseCompatibleStateImageBehavior = false;
            this.symbolListView1.DoubleClick += new EventHandler(this.symbolListView1_DoubleClick);
            this.symbolListView1.MouseUp += new MouseEventHandler(this.symbolListView1_MouseUp);
            this.radioButton1.Appearance = Appearance.Button;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = FlatStyle.Popup;
            this.radioButton1.ImageIndex = 2;
            this.radioButton1.ImageList = this.imageList1;
            this.radioButton1.Location = new System.Drawing.Point(224, 352);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new Size(24, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Click += new EventHandler(this.radioButton1_Click);
            this.radioButton2.Appearance = Appearance.Button;
            this.radioButton2.FlatStyle = FlatStyle.Popup;
            this.radioButton2.ImageIndex = 3;
            this.radioButton2.ImageList = this.imageList1;
            this.radioButton2.Location = new System.Drawing.Point(248, 352);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new Size(24, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Click += new EventHandler(this.radioButton2_Click);
            this.radioButton3.Appearance = Appearance.Button;
            this.radioButton3.FlatStyle = FlatStyle.Popup;
            this.radioButton3.ImageIndex = 4;
            this.radioButton3.ImageList = this.imageList1;
            this.radioButton3.Location = new System.Drawing.Point(272, 352);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new Size(24, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Click += new EventHandler(this.radioButton3_Click);
            this.barManager1.Controller = this.barAndDockingController1;
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            this.barAndDockingController1.PaintStyleName = "Office2003";
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 16);
            this.label7.Name = "label7";
            this.label7.Size = new Size(35, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "类别:";
            this.comboBoxEdit.EditValue = "";
            this.comboBoxEdit.Location = new System.Drawing.Point(250, 14);
            this.comboBoxEdit.Name = "comboBoxEdit";
            this.comboBoxEdit.Properties.Buttons.AddRange(new EditorButton[] { new EditorButton(ButtonPredefines.Combo) });
            this.comboBoxEdit.Size = new Size(230, 21);
            this.comboBoxEdit.TabIndex = 19;
            this.comboBoxEdit.SelectedIndexChanged += new EventHandler(this.comboBoxEdit_SelectedIndexChanged);
            this.AutoScaleBaseSize = new Size(6, 14);
            base.ClientSize = new Size(505, 391);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.radioButton1);
            base.Controls.Add(this.comboBoxEdit);
            base.Controls.Add(this.radioButton3);
            base.Controls.Add(this.radioButton2);
            base.Controls.Add(this.symbolListView1);
            base.Controls.Add(this.btnStyleSet);
            base.Controls.Add(this.btnClose);
            base.Controls.Add(this.SymbolLibTreeView);
            base.Controls.Add(this.barDockControlLeft);
            base.Controls.Add(this.barDockControlRight);
            base.Controls.Add(this.barDockControlBottom);
            base.Controls.Add(this.barDockControlTop);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
           
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "frmStyleManagerDialog";
            base.StartPosition = FormStartPosition.CenterParent;
            this.Text = "符号库管理器";
            base.Load += new EventHandler(this.frmStyleManagerDialog_Load);
            this.barManager1.EndInit();
            this.barAndDockingController1.EndInit();
            this.popupMenu1.EndInit();
            this.comboBoxEdit.Properties.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

       
        private IContainer components;
        private BarAndDockingController barAndDockingController1;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarDockControl barDockControlTop;
        private BarManager barManager1;
        private SimpleButton btnClose;
        private SimpleButton btnStyleSet;
        private ComboBoxEdit comboBoxEdit;
        private ContextMenu contextMenu1;
        private ImageList imageList1;
        private Label label7;
        private MenuItem menuItem4;
        private MenuItem menuItem5;
        private MenuItem menuItem9;
        private MenuItem menuItemAddStyleSet;
        private MenuItem menuItemCopy;
        private MenuItem menuItemCut;
        private MenuItem menuItemDelete;
        private MenuItem menuItemNew;
        private MenuItem menuItemNewFillRepRule;
        private MenuItem menuItemNewLineRepRule;
        private MenuItem menuItemNewPointRepRule;
        private MenuItem menuItemNewStyleSet;
        private MenuItem menuItemPaste;
        private MenuItem menuItemProperty;
        private PopupMenu popupMenu1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ContextMenu StyleSetManagerMenu;
        private TreeView SymbolLibTreeView;
        private SymbolListViewEx symbolListView1;
    }
}