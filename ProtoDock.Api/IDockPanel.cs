﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProtoDock.Api
{
    public interface IDockPanel
    {
        IDockPlugin Plugin { get; }
        void Setup(IDockPanelApi api);
        void RestoreIcon(int version, string data);
        void Awake();
        void Destroy();
        bool DragCanAccept(IDataObject data);
        void DragAccept(int index, IDataObject data);
    }
}
