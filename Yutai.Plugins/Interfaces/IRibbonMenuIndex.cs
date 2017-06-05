﻿using System;
using System.Collections.Generic;
using Yutai.Plugins.Concrete;
using Yutai.Plugins.Events;

namespace Yutai.Plugins.Interfaces
{
    public interface IRibbonMenuIndex
    {
        event EventHandler<MenuItemEventArgs> ItemClicked;
        bool NeedsToolTip { get; }
        string GetParentName(string pName);
        void AddItem(YutaiCommand command);
        bool ItemExists(string itemName);
        IRibbonMenuItem FindItem(string key);
        void Remove(string key);
        void RemoveItemsForPlugin(PluginIdentity pluginIdentity);
        IEnumerable<IRibbonMenuItem> ItemsForPlugin(PluginIdentity pluginIdentity);
        void FireItemClicked(object sender, MenuItemEventArgs e);
        void Clear();
        void ReorderTabs();
        void UpdateMenu();
        IEnumerable<IRibbonMenuItem> RibbonMenuItems { get; }
    }
}