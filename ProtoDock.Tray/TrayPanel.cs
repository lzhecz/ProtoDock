﻿using ProtoDock.Api;
using PInvoke;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ProtoDock.Tray
{
    internal class TrayPanel : IDockPanel
    {
        public IDockPlugin Plugin { get; private set; }

        private IDockPanelApi _api;

        public TrayPanel(IDockPlugin plugin)
        {
            Plugin = plugin;
        }

        public void Setup(IDockPanelApi api)
        {
            _api = api;
        }

        public void RestoreIcon(int version, string data)
        {

        }

        public void Awake()
        {
            //_api.Add(new TrayIcon(this, Icon.ExtractAssociatedIcon(@"D:\Projects\ProtoDock\Assets\Skins\PanelDark.png")));
            //_api.Add(new TrayIcon(this, Icon.ExtractAssociatedIcon(@"D:\Projects\ProtoDock\Assets\Skins\PanelDark.xcf")));
            //_api.Add(new TrayIcon(this, Icon.ExtractAssociatedIcon(@"c:\go\favicon.ico")));
        }

        public void Destroy()
        {
            
        }

        public bool DragCanAccept(IDataObject data)
        {
            return false;
        }

        public void DragAccept(int index, IDataObject data)
        {

        }
    }
}
