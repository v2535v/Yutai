﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;

namespace Yutai.ArcGIS.Carto.DesignLib
{
    public partial class YTElementWizardForm : Form
    {
        private ElementPosition elementPosition_0 = new ElementPosition();
        private ElementSymbolSetPage elementSymbolSetPage_0 = new ElementSymbolSetPage();
        private ElementTypeSelectPage elementTypeSelectPage_0 = new ElementTypeSelectPage();
        private frmTLConfig frmTLConfig_0 = new frmTLConfig();
        private IContainer components = null;
        private int int_0 = 0;
        private LegendFormatSetupCtrl legendFormatSetupCtrl_0 = new LegendFormatSetupCtrl();
        private LegendFrameUserControl legendFrameUserControl_0 = new LegendFrameUserControl();
        private LegendTitleUserControl legendTitleUserControl_0 = new LegendTitleUserControl();
        private PictureSelectPage pictureSelectPage_0 = new PictureSelectPage();
        private TextElementValueSetPage textElementValueSetPage_0 = new TextElementValueSetPage();

        public YTElementWizardForm()
        {
            this.InitializeComponent();
            CartoTemplateClass.Reset();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            switch (this.int_0)
            {
                case 0:
                    return;

                case 1:
                    this.elementTypeSelectPage_0.Visible = true;
                    this.elementPosition_0.Visible = false;
                    if ((ElementWizardHelp.ElementType < ElementType.JoinTable) ||
                        (ElementWizardHelp.ElementType >= ElementType.CustomLegend))
                    {
                        if (ElementWizardHelp.ElementType == ElementType.Legend)
                        {
                            this.btnNext.Text = "下一步>";
                        }
                        break;
                    }
                    this.btnNext.Text = "下一步>";
                    break;

                case 2:
                    this.elementPosition_0.Visible = true;
                    if (ElementWizardHelp.ElementType != ElementType.CustomLegend)
                    {
                        if (ElementWizardHelp.ElementType == ElementType.Legend)
                        {
                            this.legendTitleUserControl_0.Visible = false;
                        }
                        else if (((ElementWizardHelp.ElementType == ElementType.ScaleBar) ||
                                  (ElementWizardHelp.ElementType == ElementType.ScaleText)) ||
                                 (ElementWizardHelp.ElementType == ElementType.North))
                        {
                            this.btnNext.Text = "下一步>";
                            this.elementSymbolSetPage_0.Visible = false;
                        }
                        else if (ElementWizardHelp.ElementType == ElementType.Picture)
                        {
                            this.btnNext.Text = "下一步>";
                            this.pictureSelectPage_0.Visible = false;
                        }
                        else
                        {
                            this.elementSymbolSetPage_0.Visible = false;
                        }
                        break;
                    }
                    this.frmTLConfig_0.Visible = false;
                    this.btnNext.Text = "下一步>";
                    break;

                case 3:
                    this.btnNext.Text = "下一步>";
                    if (ElementWizardHelp.ElementType != ElementType.Legend)
                    {
                        this.elementSymbolSetPage_0.Visible = true;
                        this.textElementValueSetPage_0.Visible = false;
                        break;
                    }
                    this.legendTitleUserControl_0.Visible = true;
                    this.legendFormatSetupCtrl_0.Visible = false;
                    break;
            }
            this.int_0--;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (this.int_0)
            {
                case 0:
                    this.elementTypeSelectPage_0.Apply();
                    this.elementTypeSelectPage_0.Visible = false;
                    if ((ElementWizardHelp.ElementType < ElementType.JoinTable) ||
                        (ElementWizardHelp.ElementType >= ElementType.CustomLegend))
                    {
                        if (ElementWizardHelp.ElementType == ElementType.OLE)
                        {
                            this.btnNext.Text = "完成";
                        }
                        break;
                    }
                    this.btnNext.Text = "完成";
                    break;

                case 1:
                    this.elementPosition_0.Apply();
                    this.elementPosition_0.Visible = false;
                    if ((ElementWizardHelp.ElementType < ElementType.JoinTable) ||
                        (ElementWizardHelp.ElementType >= ElementType.CustomLegend))
                    {
                        if (ElementWizardHelp.ElementType == ElementType.OLE)
                        {
                            base.DialogResult = DialogResult.OK;
                        }
                        else if (ElementWizardHelp.ElementType == ElementType.CustomLegend)
                        {
                            this.frmTLConfig_0.Visible = true;
                            this.btnNext.Text = "完成";
                        }
                        else if (ElementWizardHelp.ElementType == ElementType.Legend)
                        {
                            this.legendTitleUserControl_0.Legend = ElementWizardHelp.Style as ILegend;
                            this.legendTitleUserControl_0.Visible = true;
                        }
                        else if (((ElementWizardHelp.ElementType == ElementType.ScaleBar) ||
                                  (ElementWizardHelp.ElementType == ElementType.ScaleText)) ||
                                 (ElementWizardHelp.ElementType == ElementType.North))
                        {
                            this.elementSymbolSetPage_0.SetObjects(null);
                            this.elementSymbolSetPage_0.Visible = true;
                            this.btnNext.Text = "完成";
                        }
                        else if (ElementWizardHelp.ElementType == ElementType.Picture)
                        {
                            this.pictureSelectPage_0.Visible = true;
                            this.btnNext.Text = "完成";
                        }
                        else
                        {
                            this.elementSymbolSetPage_0.SetObjects(null);
                            this.elementSymbolSetPage_0.Visible = true;
                        }
                    }
                    else
                    {
                        base.DialogResult = DialogResult.OK;
                    }
                    goto Label_02C7;

                case 2:
                    if (ElementWizardHelp.ElementType != ElementType.CustomLegend)
                    {
                        if (ElementWizardHelp.ElementType == ElementType.Legend)
                        {
                            this.legendTitleUserControl_0.Visible = false;
                            this.legendFormatSetupCtrl_0.Legend = ElementWizardHelp.Style as ILegend;
                            this.legendFormatSetupCtrl_0.Visible = true;
                            this.btnNext.Text = "完成";
                        }
                        else
                        {
                            if (ElementWizardHelp.ElementType == ElementType.Picture)
                            {
                                this.pictureSelectPage_0.Apply();
                                base.DialogResult = DialogResult.OK;
                                return;
                            }
                            if (((ElementWizardHelp.ElementType == ElementType.ScaleBar) ||
                                 (ElementWizardHelp.ElementType == ElementType.ScaleText)) ||
                                (ElementWizardHelp.ElementType == ElementType.North))
                            {
                                base.DialogResult = DialogResult.OK;
                                return;
                            }
                            this.btnNext.Text = "完成";
                            this.elementSymbolSetPage_0.Visible = false;
                            this.textElementValueSetPage_0.Visible = true;
                        }
                        goto Label_02C7;
                    }
                    this.frmTLConfig_0.Apply();
                    base.DialogResult = DialogResult.OK;
                    return;

                case 3:
                    if (ElementWizardHelp.ElementType != ElementType.Legend)
                    {
                        this.textElementValueSetPage_0.Apply();
                    }
                    base.DialogResult = DialogResult.OK;
                    return;

                default:
                    goto Label_02C7;
            }
            this.elementPosition_0.Visible = true;
            Label_02C7:
            this.int_0++;
        }

        private void JLKElementWizardForm_Load(object sender, EventArgs e)
        {
            this.elementTypeSelectPage_0.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(this.elementTypeSelectPage_0);
            this.elementPosition_0.Dock = DockStyle.Fill;
            this.elementPosition_0.Visible = false;
            this.panel1.Controls.Add(this.elementPosition_0);
            this.elementSymbolSetPage_0.Dock = DockStyle.Fill;
            this.elementSymbolSetPage_0.Visible = false;
            this.panel1.Controls.Add(this.elementSymbolSetPage_0);
            this.textElementValueSetPage_0.Dock = DockStyle.Fill;
            this.textElementValueSetPage_0.Visible = false;
            this.panel1.Controls.Add(this.textElementValueSetPage_0);
            this.pictureSelectPage_0.Dock = DockStyle.Fill;
            this.pictureSelectPage_0.Visible = false;
            this.panel1.Controls.Add(this.pictureSelectPage_0);
            this.frmTLConfig_0.Dock = DockStyle.Fill;
            this.frmTLConfig_0.Visible = false;
            this.panel1.Controls.Add(this.frmTLConfig_0);
            this.legendTitleUserControl_0.Dock = DockStyle.Fill;
            this.legendTitleUserControl_0.Visible = false;
            this.panel1.Controls.Add(this.legendTitleUserControl_0);
            this.legendFrameUserControl_0.Dock = DockStyle.Fill;
            this.legendFrameUserControl_0.Visible = false;
            this.panel1.Controls.Add(this.legendFrameUserControl_0);
            this.legendFormatSetupCtrl_0.Dock = DockStyle.Fill;
            this.legendFormatSetupCtrl_0.Visible = false;
            this.panel1.Controls.Add(this.legendFormatSetupCtrl_0);
        }
    }
}