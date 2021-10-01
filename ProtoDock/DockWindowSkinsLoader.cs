﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;

namespace ProtoDock {
	public class DockWindowSkinsLoader {
		public static List<DockSkin> LoadSkins()
        {
            var list = new List<DockSkin>();
            
            list.Add(
                new DockSkin{
                    Name = "Classic",
                    VOffset = 0,
                    Padding = new Padding(14, 14, 14, 14),
                    PanelPadding = new Padding(2, 2, 2, 2),
                    Dock = new DockSkinImage(
                        DockSkinImageAlign.Scale9,
                        new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("ProtoDock.Embeded.Default.png")),
                        new Padding(32, 32, 32, 32)
                    ),
                    Panel = new DockSkinImage(
                        DockSkinImageAlign.Scale9,
                        new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("ProtoDock.Embeded.Default_panel.png")),
                        new Padding(8,8,8,8)
                    ),
                    SelectedBg = new DockSkinImage(
                        DockSkinImageAlign.Bottom,
                        new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("ProtoDock.Embeded.Default_selected.png")),
                        new Padding()
                    ),
                    SelectedFg = new DockSkinImage(
                        DockSkinImageAlign.BottomRaw,
                        new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("ProtoDock.Embeded.Default_selected_fg.png")),
                        new Padding()
                    ),
                    SelectedBgOffset = new Point(0, 0),
                    HighlightBg = new DockSkinImage(
                        DockSkinImageAlign.Bottom,
                        new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("ProtoDock.Embeded.Default_highlight.png")),
                        new Padding(32, 32, 32, 32)
                    ),
                    SelectedFgOffset = new Point(0, 16),
                    HighlightFg = null
                }
            );

            try
            {
                foreach (var file in Directory.GetFiles("./Skins/", "*.json"))
                {
                    try
                    {
                        var data = File.ReadAllText(file);
                        var skin = JsonSerializer.Deserialize<DockSkin>(data);
                        skin.Name = file;
                        list.Add(skin);
                    }
                    catch (Exception exc)
                    {
                        Debug.WriteLine(exc);
                    }
                }
            } catch
            {
                //
            }

            return list;
        }
	}
}