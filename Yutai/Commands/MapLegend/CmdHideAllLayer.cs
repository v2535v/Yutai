﻿// 项目名称 :  Yutai
// 项目描述 :  
// 类 名 称 :  CmdHideAllLayer.cs
// 版 本 号 :  
// 说    明 :  
// 作    者 :  
// 创建时间 :  2017/06/02  13:54
// 更新时间 :  2017/06/02  13:54

using System;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.SystemUI;
using Yutai.Controls;
using Yutai.Plugins.Concrete;
using Yutai.Plugins.Enums;
using Yutai.Plugins.Interfaces;

namespace Yutai.Commands.MapLegend
{
    public class CmdHideAllLayer : YutaiCommand
    {
        private IMapLegendView _view;


        public CmdHideAllLayer(IAppContext context, IMapLegendView view)
        {
            _context = context;
            _view = view;
            OnCreate();
        }

        private void OnCreate()
        {
            base.m_caption = "隐藏所有图层";
            base.m_category = "TOC";
            base.m_bitmap = null;
            base.m_name = "mnuHideAllLayer";
            base._key = "mnuHideAllLayer";
            base.m_toolTip = "隐藏所有图层";
            base.m_checked = false;
            base.m_enabled = true;
            base._itemType = RibbonItemType.Button;
        }

        public override void OnClick(object sender, EventArgs args)
        {
            OnClick();
        }

        public override void OnCreate(object hook)
        {
            OnCreate();
        }

        public void OnClick()
        {
            switch (_view.SelectedItemType)
            {
                case esriTOCControlItem.esriTOCControlItemMap:
                {
                    IEnumLayer pEnumLayer = _view.SelectedMap.Layers;

                    if (pEnumLayer == null) return;
                    ILayer pLayer;
                    pEnumLayer.Reset();
                    for (pLayer = pEnumLayer.Next(); pLayer != null; pLayer = pEnumLayer.Next())
                    {
                        ShowLayers(pLayer, false);
                    }
                }
                    break;
                default:
                    if (_view.SelectedLayer != null)
                        ShowLayers(_view.SelectedLayer, false);
                    break;
            }
            _view.TocControl.Update();
            IActiveView activeView = _view.SelectedMap as IActiveView;
            if (activeView != null) activeView.Refresh();
        }


        private void ShowLayers(ILayer layer, bool show)
        {
            if (layer is IGroupLayer)
            {
                ICompositeLayer pCompositeLayer = (ICompositeLayer) layer;
                for (int i = 0; i < pCompositeLayer.Count; i++)
                {
                    ILayer pLayer = pCompositeLayer.Layer[i];
                    ShowLayers(pLayer, show);
                }
                ((IGroupLayer) layer).Visible = show;
            }
            else
            {
                layer.Visible = show;
            }
        }
    }
}