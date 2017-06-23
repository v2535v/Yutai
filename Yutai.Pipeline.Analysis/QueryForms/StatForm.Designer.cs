﻿using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Styles;
using Infragistics.Win;
using Infragistics.Win.Printing;
using Infragistics.Win.UltraWinChart;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Yutai.Pipeline.Analysis.QueryForms
{
	    partial class StatForm
    {
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

	
	private void InitializeComponent()
		{
			this.components = new Container();
			PaintElement paintElement = new PaintElement();
			ChartLayerAppearance chartLayerAppearance = new ChartLayerAppearance();
			ChartLayerAppearance chartLayerAppearance2 = new ChartLayerAppearance();
			GradientEffect effect = new GradientEffect();
			View3DAppearance view3DAppearance = new View3DAppearance();
			Infragistics.Win.Appearance appearance = new Infragistics.Win.Appearance();
			UltraGridBand ultraGridBand = new UltraGridBand("", -1);
			Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
			Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatForm));
			this.label1 = new Label();
			this.ChartKind = new ComboBox();
			this.DoIt = new Button();
			this.ultraChart1 = new UltraChart();
			this.ultraGrid1 = new UltraGrid();
			this.CountRadio = new RadioButton();
			this.sumRadio = new RadioButton();
			this.SizeBut = new Button();
			this.label2 = new Label();
			this.trackBar1 = new TrackBar();
			this.trackBar2 = new TrackBar();
			this.trackBar3 = new TrackBar();
			this.label3 = new Label();
			this.label4 = new Label();
			this.SizeBar = new TrackBar();
			this.label5 = new Label();
			this.imageList1 = new ImageList(this.components);
			this.groupBox1 = new GroupBox();
			this.printDialog1 = new PrintDialog();
			this.ultraPrintPreviewDialog1 = new UltraPrintPreviewDialog(this.components);
			this.ShowLegendBox = new CheckBox();
			this.LegendBox = new ComboBox();
			this.label6 = new Label();
			((ISupportInitialize)this.ultraChart1).BeginInit();
			((ISupportInitialize) this.ultraGrid1).BeginInit();
			((ISupportInitialize)this.trackBar1).BeginInit();
			((ISupportInitialize)this.trackBar2).BeginInit();
			((ISupportInitialize)this.trackBar3).BeginInit();
			((ISupportInitialize)this.SizeBar).BeginInit();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 5);
			this.label1.Name = "label1";
			this.label1.Size = new Size(53, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "图表类型";
			this.ChartKind.DropDownStyle = ComboBoxStyle.DropDownList;
			this.ChartKind.FormattingEnabled = true;
			this.ChartKind.Items.AddRange(new object[]
			{
				"柱状图",
				"饼图"
			});
			this.ChartKind.Location = new System.Drawing.Point(68, 0);
			this.ChartKind.Name = "ChartKind";
			this.ChartKind.Size = new Size(115, 20);
			this.ChartKind.TabIndex = 1;
			this.ChartKind.SelectedIndexChanged += new EventHandler(this.ChartType_SelectedIndexChanged);
			this.DoIt.Location = new System.Drawing.Point(189, 0);
			this.DoIt.Name = "DoIt";
			this.DoIt.Size = new Size(69, 23);
			this.DoIt.TabIndex = 2;
			this.DoIt.Text = "打印预览";
			this.DoIt.UseVisualStyleBackColor = true;
			this.DoIt.Visible = false;
			this.DoIt.Click += new EventHandler(this.DoIt_Click);
			this.ultraChart1.ChartType = ChartType.CylinderColumnChart3D;
			this.ultraChart1.Axis.BackColor = Color.FromArgb(255, 248, 220);
			paintElement.ElementType = PaintElementType.None;
			paintElement.Fill = Color.FromArgb(255, 248, 220);
			this.ultraChart1.Axis.PE = paintElement;
			this.ultraChart1.Axis.X.Labels.Font = new Font("Verdana", 7f);
			this.ultraChart1.Axis.X.Labels.FontColor = Color.DimGray;
			this.ultraChart1.Axis.X.Labels.HorizontalAlign = StringAlignment.Near;
			this.ultraChart1.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>";
			this.ultraChart1.Axis.X.Labels.Layout.Behavior = AxisLabelLayoutBehaviors.Auto;
			this.ultraChart1.Axis.X.Labels.Orientation = TextOrientation.VerticalLeftFacing;
			this.ultraChart1.Axis.X.Labels.SeriesLabels.Font = new Font("Verdana", 7f);
			this.ultraChart1.Axis.X.Labels.SeriesLabels.FontColor = Color.DimGray;
			this.ultraChart1.Axis.X.Labels.SeriesLabels.FormatString = "";
			this.ultraChart1.Axis.X.Labels.SeriesLabels.HorizontalAlign = StringAlignment.Near;
			this.ultraChart1.Axis.X.Labels.SeriesLabels.Layout.Behavior = AxisLabelLayoutBehaviors.Auto;
			this.ultraChart1.Axis.X.Labels.SeriesLabels.Orientation = TextOrientation.VerticalLeftFacing;
			this.ultraChart1.Axis.X.Labels.SeriesLabels.VerticalAlign = StringAlignment.Center;
			this.ultraChart1.Axis.X.Labels.VerticalAlign = StringAlignment.Center;
			this.ultraChart1.Axis.X.LineThickness = 1;
			this.ultraChart1.Axis.X.MajorGridLines.AlphaLevel = 255;
			this.ultraChart1.Axis.X.MajorGridLines.Color = Color.Gainsboro;
			this.ultraChart1.Axis.X.MajorGridLines.DrawStyle = LineDrawStyle.Dot;
			this.ultraChart1.Axis.X.MajorGridLines.Visible = true;
			this.ultraChart1.Axis.X.Margin.Far.Value = 1.2820512820512819;
			this.ultraChart1.Axis.X.MinorGridLines.AlphaLevel = 255;
			this.ultraChart1.Axis.X.MinorGridLines.Color = Color.LightGray;
			this.ultraChart1.Axis.X.MinorGridLines.DrawStyle = LineDrawStyle.Dot;
			this.ultraChart1.Axis.X.MinorGridLines.Visible = false;
			this.ultraChart1.Axis.X.TickmarkInterval = 40.0;
			this.ultraChart1.Axis.X.TickmarkIntervalType = AxisIntervalType.Hours;
			this.ultraChart1.Axis.X.TickmarkStyle = AxisTickStyle.Smart;
			this.ultraChart1.Axis.X.Visible = true;
			this.ultraChart1.Axis.X2.Labels.Font = new Font("Verdana", 7f);
			this.ultraChart1.Axis.X2.Labels.FontColor = Color.Gray;
			this.ultraChart1.Axis.X2.Labels.HorizontalAlign = StringAlignment.Far;
			this.ultraChart1.Axis.X2.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
			this.ultraChart1.Axis.X2.Labels.Layout.Behavior = AxisLabelLayoutBehaviors.Auto;
			this.ultraChart1.Axis.X2.Labels.Orientation = TextOrientation.VerticalLeftFacing;
			this.ultraChart1.Axis.X2.Labels.SeriesLabels.Font = new Font("Verdana", 7f);
			this.ultraChart1.Axis.X2.Labels.SeriesLabels.FontColor = Color.Gray;
			this.ultraChart1.Axis.X2.Labels.SeriesLabels.FormatString = "";
			this.ultraChart1.Axis.X2.Labels.SeriesLabels.HorizontalAlign = StringAlignment.Far;
			this.ultraChart1.Axis.X2.Labels.SeriesLabels.Layout.Behavior = AxisLabelLayoutBehaviors.Auto;
			this.ultraChart1.Axis.X2.Labels.SeriesLabels.Orientation = TextOrientation.VerticalLeftFacing;
			this.ultraChart1.Axis.X2.Labels.SeriesLabels.VerticalAlign = StringAlignment.Center;
			this.ultraChart1.Axis.X2.Labels.VerticalAlign = StringAlignment.Center;
			this.ultraChart1.Axis.X2.Labels.Visible = false;
			this.ultraChart1.Axis.X2.LineThickness = 1;
			this.ultraChart1.Axis.X2.MajorGridLines.AlphaLevel = 255;
			this.ultraChart1.Axis.X2.MajorGridLines.Color = Color.Gainsboro;
			this.ultraChart1.Axis.X2.MajorGridLines.DrawStyle = LineDrawStyle.Dot;
			this.ultraChart1.Axis.X2.MajorGridLines.Visible = true;
			this.ultraChart1.Axis.X2.MinorGridLines.AlphaLevel = 255;
			this.ultraChart1.Axis.X2.MinorGridLines.Color = Color.LightGray;
			this.ultraChart1.Axis.X2.MinorGridLines.DrawStyle = LineDrawStyle.Dot;
			this.ultraChart1.Axis.X2.MinorGridLines.Visible = false;
			this.ultraChart1.Axis.X2.TickmarkInterval = 40.0;
			this.ultraChart1.Axis.X2.TickmarkIntervalType = AxisIntervalType.Hours;
			this.ultraChart1.Axis.X2.TickmarkStyle = AxisTickStyle.Smart;
			this.ultraChart1.Axis.X2.Visible = false;
			this.ultraChart1.Axis.Y.Extent = 87;
			this.ultraChart1.Axis.Y.Labels.Font = new Font("Verdana", 7f);
			this.ultraChart1.Axis.Y.Labels.FontColor = Color.DimGray;
			this.ultraChart1.Axis.Y.Labels.HorizontalAlign = StringAlignment.Far;
			this.ultraChart1.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
			this.ultraChart1.Axis.Y.Labels.Layout.Behavior = AxisLabelLayoutBehaviors.Auto;
			this.ultraChart1.Axis.Y.Labels.Orientation = TextOrientation.Horizontal;
			this.ultraChart1.Axis.Y.Labels.SeriesLabels.Font = new Font("Verdana", 7f);
			this.ultraChart1.Axis.Y.Labels.SeriesLabels.FontColor = Color.DimGray;
			this.ultraChart1.Axis.Y.Labels.SeriesLabels.FormatString = "";
			this.ultraChart1.Axis.Y.Labels.SeriesLabels.HorizontalAlign = StringAlignment.Far;
			this.ultraChart1.Axis.Y.Labels.SeriesLabels.Layout.Behavior = AxisLabelLayoutBehaviors.Auto;
			this.ultraChart1.Axis.Y.Labels.SeriesLabels.Orientation = TextOrientation.Horizontal;
			this.ultraChart1.Axis.Y.Labels.SeriesLabels.VerticalAlign = StringAlignment.Near;
			this.ultraChart1.Axis.Y.Labels.VerticalAlign = StringAlignment.Center;
			this.ultraChart1.Axis.Y.LineThickness = 1;
			this.ultraChart1.Axis.Y.MajorGridLines.AlphaLevel = 255;
			this.ultraChart1.Axis.Y.MajorGridLines.Color = Color.Gainsboro;
			this.ultraChart1.Axis.Y.MajorGridLines.DrawStyle = LineDrawStyle.Dot;
			this.ultraChart1.Axis.Y.MajorGridLines.Visible = true;
			this.ultraChart1.Axis.Y.Margin.Far.Value = 15.294117647058824;
			this.ultraChart1.Axis.Y.MinorGridLines.AlphaLevel = 255;
			this.ultraChart1.Axis.Y.MinorGridLines.Color = Color.LightGray;
			this.ultraChart1.Axis.Y.MinorGridLines.DrawStyle = LineDrawStyle.Dot;
			this.ultraChart1.Axis.Y.MinorGridLines.Visible = true;
			this.ultraChart1.Axis.Y.TickmarkStyle = AxisTickStyle.Smart;
			this.ultraChart1.Axis.Y.Visible = true;
			this.ultraChart1.Axis.Y2.Labels.Font = new Font("Verdana", 7f);
			this.ultraChart1.Axis.Y2.Labels.FontColor = Color.Gray;
			this.ultraChart1.Axis.Y2.Labels.HorizontalAlign = StringAlignment.Near;
			this.ultraChart1.Axis.Y2.Labels.ItemFormatString = "<ITEM_LABEL>";
			this.ultraChart1.Axis.Y2.Labels.Layout.Behavior = AxisLabelLayoutBehaviors.Auto;
			this.ultraChart1.Axis.Y2.Labels.Orientation = TextOrientation.Horizontal;
			this.ultraChart1.Axis.Y2.Labels.SeriesLabels.Font = new Font("Verdana", 7f);
			this.ultraChart1.Axis.Y2.Labels.SeriesLabels.FontColor = Color.Gray;
			this.ultraChart1.Axis.Y2.Labels.SeriesLabels.FormatString = "";
			this.ultraChart1.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = StringAlignment.Near;
			this.ultraChart1.Axis.Y2.Labels.SeriesLabels.Layout.Behavior = AxisLabelLayoutBehaviors.Auto;
			this.ultraChart1.Axis.Y2.Labels.SeriesLabels.Orientation = TextOrientation.Horizontal;
			this.ultraChart1.Axis.Y2.Labels.SeriesLabels.VerticalAlign = StringAlignment.Center;
			this.ultraChart1.Axis.Y2.Labels.VerticalAlign = StringAlignment.Center;
			this.ultraChart1.Axis.Y2.Labels.Visible = false;
			this.ultraChart1.Axis.Y2.LineThickness = 1;
			this.ultraChart1.Axis.Y2.MajorGridLines.AlphaLevel = 255;
			this.ultraChart1.Axis.Y2.MajorGridLines.Color = Color.Gainsboro;
			this.ultraChart1.Axis.Y2.MajorGridLines.DrawStyle = LineDrawStyle.Dot;
			this.ultraChart1.Axis.Y2.MajorGridLines.Visible = true;
			this.ultraChart1.Axis.Y2.MinorGridLines.AlphaLevel = 255;
			this.ultraChart1.Axis.Y2.MinorGridLines.Color = Color.LightGray;
			this.ultraChart1.Axis.Y2.MinorGridLines.DrawStyle = LineDrawStyle.Dot;
			this.ultraChart1.Axis.Y2.MinorGridLines.Visible = false;
			this.ultraChart1.Axis.Y2.TickmarkStyle = AxisTickStyle.Smart;
			this.ultraChart1.Axis.Y2.Visible = false;
			this.ultraChart1.Axis.Z.Labels.Font = new Font("Verdana", 7f);
			this.ultraChart1.Axis.Z.Labels.FontColor = Color.DimGray;
			this.ultraChart1.Axis.Z.Labels.HorizontalAlign = StringAlignment.Far;
			this.ultraChart1.Axis.Z.Labels.ItemFormatString = "<ITEM_LABEL>";
			this.ultraChart1.Axis.Z.Labels.Layout.Behavior = AxisLabelLayoutBehaviors.Auto;
			this.ultraChart1.Axis.Z.Labels.Orientation = TextOrientation.Horizontal;
			this.ultraChart1.Axis.Z.Labels.SeriesLabels.Font = new Font("Verdana", 7f);
			this.ultraChart1.Axis.Z.Labels.SeriesLabels.FontColor = Color.DimGray;
			this.ultraChart1.Axis.Z.Labels.SeriesLabels.HorizontalAlign = StringAlignment.Far;
			this.ultraChart1.Axis.Z.Labels.SeriesLabels.Layout.Behavior = AxisLabelLayoutBehaviors.Auto;
			this.ultraChart1.Axis.Z.Labels.SeriesLabels.Orientation = TextOrientation.Horizontal;
			this.ultraChart1.Axis.Z.Labels.SeriesLabels.VerticalAlign = StringAlignment.Center;
			this.ultraChart1.Axis.Z.Labels.VerticalAlign = StringAlignment.Center;
			this.ultraChart1.Axis.Z.LineThickness = 1;
			this.ultraChart1.Axis.Z.MajorGridLines.AlphaLevel = 255;
			this.ultraChart1.Axis.Z.MajorGridLines.Color = Color.Gainsboro;
			this.ultraChart1.Axis.Z.MajorGridLines.DrawStyle = LineDrawStyle.Dot;
			this.ultraChart1.Axis.Z.MajorGridLines.Visible = true;
			this.ultraChart1.Axis.Z.MinorGridLines.AlphaLevel = 255;
			this.ultraChart1.Axis.Z.MinorGridLines.Color = Color.LightGray;
			this.ultraChart1.Axis.Z.MinorGridLines.DrawStyle = LineDrawStyle.Dot;
			this.ultraChart1.Axis.Z.MinorGridLines.Visible = false;
			this.ultraChart1.Axis.Z.TickmarkStyle = AxisTickStyle.Smart;
			this.ultraChart1.Axis.Z.Visible = true;
			this.ultraChart1.Axis.Z2.Labels.Font = new Font("Verdana", 7f);
			this.ultraChart1.Axis.Z2.Labels.FontColor = Color.Gray;
			this.ultraChart1.Axis.Z2.Labels.HorizontalAlign = StringAlignment.Near;
			this.ultraChart1.Axis.Z2.Labels.ItemFormatString = "";
			this.ultraChart1.Axis.Z2.Labels.Layout.Behavior = AxisLabelLayoutBehaviors.Auto;
			this.ultraChart1.Axis.Z2.Labels.Orientation = TextOrientation.Horizontal;
			this.ultraChart1.Axis.Z2.Labels.SeriesLabels.Font = new Font("Verdana", 7f);
			this.ultraChart1.Axis.Z2.Labels.SeriesLabels.FontColor = Color.Gray;
			this.ultraChart1.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = StringAlignment.Near;
			this.ultraChart1.Axis.Z2.Labels.SeriesLabels.Layout.Behavior = AxisLabelLayoutBehaviors.Auto;
			this.ultraChart1.Axis.Z2.Labels.SeriesLabels.Orientation = TextOrientation.Horizontal;
			this.ultraChart1.Axis.Z2.Labels.SeriesLabels.VerticalAlign = StringAlignment.Center;
			this.ultraChart1.Axis.Z2.Labels.VerticalAlign = StringAlignment.Center;
			this.ultraChart1.Axis.Z2.Labels.Visible = false;
			this.ultraChart1.Axis.Z2.LineThickness = 1;
			this.ultraChart1.Axis.Z2.MajorGridLines.AlphaLevel = 255;
			this.ultraChart1.Axis.Z2.MajorGridLines.Color = Color.Gainsboro;
			this.ultraChart1.Axis.Z2.MajorGridLines.DrawStyle = LineDrawStyle.Dot;
			this.ultraChart1.Axis.Z2.MajorGridLines.Visible = true;
			this.ultraChart1.Axis.Z2.MinorGridLines.AlphaLevel = 255;
			this.ultraChart1.Axis.Z2.MinorGridLines.Color = Color.LightGray;
			this.ultraChart1.Axis.Z2.MinorGridLines.DrawStyle = LineDrawStyle.Dot;
			this.ultraChart1.Axis.Z2.MinorGridLines.Visible = false;
			this.ultraChart1.Axis.Z2.TickmarkStyle = AxisTickStyle.Smart;
			this.ultraChart1.Axis.Z2.Visible = true;
			this.ultraChart1.BackgroundImageLayout = ImageLayout.Center;
			this.ultraChart1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ultraChart1.ColorModel.AlphaLevel = 255;
			this.ultraChart1.ColorModel.ModelStyle = ColorModels.CustomLinear;
			chartLayerAppearance.ChartType = ChartType.ColumnChart;
			chartLayerAppearance.Key = "chartLayer1";
			chartLayerAppearance2.ChartType = ChartType.AreaChart;
			chartLayerAppearance2.Key = "chartLayer2";
			this.ultraChart1.CompositeChart.ChartLayers.AddRange(new ChartLayerAppearance[]
			{
				chartLayerAppearance,
				chartLayerAppearance2
			});
			this.ultraChart1.Data.UseRowLabelsColumn = true;
			this.ultraChart1.Data.ZeroAligned = true;
			this.ultraChart1.Effects.Effects.Add(effect);
			this.ultraChart1.Legend.Visible = true;
			this.ultraChart1.Location = new System.Drawing.Point(3, 27);
			this.ultraChart1.Name = "ultraChart1";
			this.ultraChart1.Size = new Size(513, 237);
			this.ultraChart1.TabIndex = 3;
			this.ultraChart1.Tooltips.HighlightFillColor = Color.DimGray;
			this.ultraChart1.Tooltips.HighlightOutlineColor = Color.DarkGray;
			view3DAppearance.Perspective = 55f;
			view3DAppearance.Scale = 62f;
			view3DAppearance.XRotation = 124f;
			view3DAppearance.YRotation = 90f;
			this.ultraChart1.Transform3D = view3DAppearance;
			appearance.BackColor = SystemColors.Window;
			appearance.BorderColor = SystemColors.InactiveCaption;
			this.ultraGrid1.DisplayLayout.Appearance=(appearance);
			this.ultraGrid1.DisplayLayout.AutoFitStyle=(AutoFitStyle.ResizeAllColumns) ;
			ultraGridBand.CardView=(true);
			this.ultraGrid1.DisplayLayout.BandsSerializer.Add(ultraGridBand);
			this.ultraGrid1.DisplayLayout.BorderStyle=(UIElementBorderStyle.Solid);
			this.ultraGrid1.DisplayLayout.CaptionVisible=(DefaultableBoolean.False);
			appearance2.BackColor = SystemColors.ActiveBorder;
			appearance2.BackColor2 = SystemColors.ControlDark;
			appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
			appearance2.BorderColor = SystemColors.Window;
			this.ultraGrid1.DisplayLayout.GroupByBox.Appearance=(appearance2);
			appearance3.ForeColor = SystemColors.GrayText;
			this.ultraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance=(appearance3);
			this.ultraGrid1.DisplayLayout.GroupByBox.BorderStyle=(UIElementBorderStyle.Solid);
			appearance4.BackColor = SystemColors.ControlLightLight;
			appearance4.BackColor2 = SystemColors.Control;
			appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
			appearance4.ForeColor = SystemColors.GrayText;
			this.ultraGrid1.DisplayLayout.GroupByBox.PromptAppearance=(appearance4);
			appearance5.BackColor = SystemColors.Window;
			appearance5.ForeColor = SystemColors.ControlText;
			this.ultraGrid1.DisplayLayout.Override.ActiveCellAppearance=(appearance5);
			appearance6.BackColor = SystemColors.Highlight;
			appearance6.ForeColor = SystemColors.HighlightText;
			this.ultraGrid1.DisplayLayout.Override.ActiveRowAppearance=(appearance6);
		    this.ultraGrid1.DisplayLayout.Override.AllowColSizing = AllowColSizing.Free;
			this.ultraGrid1.DisplayLayout.Override.BorderStyleCell=(UIElementBorderStyle.Dotted);
			this.ultraGrid1.DisplayLayout.Override.BorderStyleRow=(UIElementBorderStyle.Dotted);
			appearance7.BackColor = SystemColors.Window;
			this.ultraGrid1.DisplayLayout.Override.CardAreaAppearance=(appearance7);
			appearance8.BorderColor = Color.Silver;
			appearance8.TextTrimming = TextTrimming.EllipsisCharacter;
			this.ultraGrid1.DisplayLayout.Override.CellAppearance=(appearance8);
			this.ultraGrid1.DisplayLayout.Override.CellClickAction=CellClickAction.EditAndSelectText;
			this.ultraGrid1.DisplayLayout.Override.CellPadding=(0);
			this.ultraGrid1.DisplayLayout.Override.ColumnSizingArea=(ColumnSizingArea.EntireColumn);
			appearance9.BackColor = SystemColors.Control;
			appearance9.BackColor2 = SystemColors.ControlDark;
			appearance9.BackGradientAlignment = GradientAlignment.Element;
			appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
			appearance9.BorderColor = SystemColors.Window;
			this.ultraGrid1.DisplayLayout.Override.GroupByRowAppearance=(appearance9);
			appearance10.TextHAlignAsString = "Left";
			this.ultraGrid1.DisplayLayout.Override.HeaderAppearance=(appearance10);
			this.ultraGrid1.DisplayLayout.Override.HeaderClickAction=(HeaderClickAction.SortMulti);
			this.ultraGrid1.DisplayLayout.Override.HeaderStyle=(HeaderStyle.WindowsXPCommand);
			appearance11.BackColor = SystemColors.Window;
			appearance11.BorderColor = Color.Silver;
			this.ultraGrid1.DisplayLayout.Override.RowAppearance=(appearance11);
			this.ultraGrid1.DisplayLayout.Override.RowSelectors=(DefaultableBoolean.False);
			appearance12.BackColor = SystemColors.ControlLight;
			this.ultraGrid1.DisplayLayout.Override.TemplateAddRowAppearance=(appearance12);
			this.ultraGrid1.DisplayLayout.ScrollStyle=(ScrollStyle.Immediate);
			this.ultraGrid1.Location = new System.Drawing.Point(5, 270);
			this.ultraGrid1.Name = "ultraGrid1";
			this.ultraGrid1.Size = new Size(513, 110);
			this.ultraGrid1.TabIndex = 5;
			this.ultraGrid1.Text = "ultraGrid1";
			this.CountRadio.AutoSize = true;
			this.CountRadio.Checked = true;
			this.CountRadio.Location = new System.Drawing.Point(300, 3);
			this.CountRadio.Name = "CountRadio";
			this.CountRadio.Size = new Size(83, 16);
			this.CountRadio.TabIndex = 7;
			this.CountRadio.TabStop = true;
			this.CountRadio.Text = "个数分布图";
			this.CountRadio.UseVisualStyleBackColor = true;
			this.CountRadio.CheckedChanged += new EventHandler(this.CountRadio_CheckedChanged);
			this.sumRadio.AutoSize = true;
			this.sumRadio.Location = new System.Drawing.Point(399, 4);
			this.sumRadio.Name = "sumRadio";
			this.sumRadio.Size = new Size(83, 16);
			this.sumRadio.TabIndex = 8;
			this.sumRadio.Text = "数量分布图";
			this.sumRadio.UseVisualStyleBackColor = true;
			this.sumRadio.CheckedChanged += new EventHandler(this.sumRadio_CheckedChanged);
			this.SizeBut.BackgroundImageLayout = ImageLayout.Center;
			this.SizeBut.ImageIndex = 0;
			this.SizeBut.ImageList = this.imageList1;
			this.SizeBut.Location = new System.Drawing.Point(495, 2);
			this.SizeBut.Name = "SizeBut";
			this.SizeBut.Size = new Size(21, 21);
			this.SizeBut.TabIndex = 11;
			this.SizeBut.UseVisualStyleBackColor = true;
			this.SizeBut.Click += new EventHandler(this.button1_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 20);
			this.label2.Name = "label2";
			this.label2.Size = new Size(29, 12);
			this.label2.TabIndex = 12;
			this.label2.Text = "X轴:";
			this.trackBar1.Location = new System.Drawing.Point(33, 14);
			this.trackBar1.Maximum = 180;
			this.trackBar1.Minimum = -180;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new Size(104, 45);
			this.trackBar1.TabIndex = 13;
			this.trackBar1.TickFrequency = 36;
			this.trackBar1.Scroll += new EventHandler(this.trackBar1_Scroll);
			this.trackBar2.Location = new System.Drawing.Point(33, 47);
			this.trackBar2.Maximum = 180;
			this.trackBar2.Minimum = -180;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new Size(104, 45);
			this.trackBar2.TabIndex = 14;
			this.trackBar2.TickFrequency = 36;
			this.trackBar2.Scroll += new EventHandler(this.trackBar2_Scroll);
			this.trackBar3.Location = new System.Drawing.Point(33, 86);
			this.trackBar3.Maximum = 180;
			this.trackBar3.Minimum = -180;
			this.trackBar3.Name = "trackBar3";
			this.trackBar3.Size = new Size(104, 45);
			this.trackBar3.TabIndex = 15;
			this.trackBar3.TickFrequency = 36;
			this.trackBar3.Scroll += new EventHandler(this.trackBar3_Scroll);
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 59);
			this.label3.Name = "label3";
			this.label3.Size = new Size(29, 12);
			this.label3.TabIndex = 16;
			this.label3.Text = "Y轴:";
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 96);
			this.label4.Name = "label4";
			this.label4.Size = new Size(29, 12);
			this.label4.TabIndex = 17;
			this.label4.Text = "Z轴:";
			this.SizeBar.Location = new System.Drawing.Point(32, 134);
			this.SizeBar.Maximum = 100;
			this.SizeBar.Name = "SizeBar";
			this.SizeBar.Size = new Size(104, 45);
			this.SizeBar.TabIndex = 18;
			this.SizeBar.TickFrequency = 10;
			this.SizeBar.Value = 30;
			this.SizeBar.Scroll += new EventHandler(this.SizeBar_Scroll);
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(2, 139);
			this.label5.Name = "label5";
			this.label5.Size = new Size(35, 12);
			this.label5.TabIndex = 19;
			this.label5.Text = "大小:";
			this.imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "btnPicSetting.Image.png");
			this.imageList1.Images.SetKeyName(1, "");
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.SizeBar);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.trackBar3);
			this.groupBox1.Controls.Add(this.trackBar2);
			this.groupBox1.Controls.Add(this.trackBar1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(525, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(139, 184);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "图表控制栏";
			this.printDialog1.UseEXDialog = true;
			this.ultraPrintPreviewDialog1.Name = "ultraPrintPreviewDialog1";
			this.ShowLegendBox.AutoSize = true;
			this.ShowLegendBox.Location = new System.Drawing.Point(526, 237);
			this.ShowLegendBox.Name = "ShowLegendBox";
			this.ShowLegendBox.Size = new Size(72, 16);
			this.ShowLegendBox.TabIndex = 25;
			this.ShowLegendBox.Text = "显示图例";
			this.ShowLegendBox.UseVisualStyleBackColor = true;
			this.ShowLegendBox.CheckedChanged += new EventHandler(this.ShowLegendBox_CheckedChanged);
			this.LegendBox.FormattingEnabled = true;
			this.LegendBox.Location = new System.Drawing.Point(561, 259);
			this.LegendBox.Name = "LegendBox";
			this.LegendBox.Size = new Size(90, 20);
			this.LegendBox.TabIndex = 26;
			this.LegendBox.SelectedIndexChanged += new EventHandler(this.LegendBox_SelectedIndexChanged);
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(524, 262);
			this.label6.Name = "label6";
			this.label6.Size = new Size(35, 12);
			this.label6.TabIndex = 27;
			this.label6.Text = "位置:";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new Size(674, 380);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.sumRadio);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.LegendBox);
			base.Controls.Add(this.ShowLegendBox);
			base.Controls.Add(this.ultraChart1);
			base.Controls.Add(this.SizeBut);
			base.Controls.Add(this.DoIt);
			base.Controls.Add(this.CountRadio);
			base.Controls.Add(this.ChartKind);
			base.Controls.Add(this.ultraGrid1);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "StatForm";
			base.ShowInTaskbar = false;
			this.Text = "统计图表";
			base.FormClosed += new FormClosedEventHandler(this.StatForm_FormClosed);
			base.Load += new EventHandler(this.StatForm_Load);
			((ISupportInitialize)this.ultraChart1).EndInit();
			((ISupportInitialize) this.ultraGrid1).EndInit();
			((ISupportInitialize)this.trackBar1).EndInit();
			((ISupportInitialize)this.trackBar2).EndInit();
			((ISupportInitialize)this.trackBar3).EndInit();
			((ISupportInitialize)this.SizeBar).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

	
		private IContainer components = null;
		private Label label1;
		private ComboBox ChartKind;
		private Button DoIt;
		private UltraGrid ultraGrid1;
		private RadioButton CountRadio;
		private RadioButton sumRadio;
		private Button SizeBut;
		private Label label2;
		private TrackBar trackBar1;
		private TrackBar trackBar2;
		private TrackBar trackBar3;
		private Label label3;
		private Label label4;
		private TrackBar SizeBar;
		private Label label5;
		private ImageList imageList1;
		private GroupBox groupBox1;
		private CheckBox ShowLegendBox;
		private ComboBox LegendBox;
		private Label label6;
		private DataTable dt;
		private DataTable AllTable;
		private DataTable CalTable;
		private string statWay;
		private string calField;
		private string statField;
		private bool bExtent;
		private UltraChart ultraChart1;
		private PrintDialog printDialog1;
		private UltraPrintPreviewDialog ultraPrintPreviewDialog1;
    }
}