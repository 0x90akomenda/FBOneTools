﻿using System.Windows.Controls;

namespace BFBC2ModLoader.Data
{
    public class UIElements
    {
        public static RichTextBox TxtBoxEventLog { get; set; }
        public static RichTextBox TxtBoxModInfo { get; set; }
        public static RichTextBox TxtBoxServerInfo { get; set; }
        public static RichTextBox TxtBoxMapInfo { get; set; }
        public static DataGrid DataGridModManager { get; set; }
        public static DataGrid DataGridServerBrowser { get; set; }
        public static DataGrid DataGridMapBrowser { get; set; }

        public static void SetElements(RichTextBox rtbEventLog, RichTextBox rtbModInfo, RichTextBox rtbServerInfo, RichTextBox rtbMapInfo, DataGrid dgModManager, DataGrid dgServerBrowser, DataGrid dgMapBrowser)
        {
            TxtBoxEventLog = rtbEventLog;
            TxtBoxModInfo = rtbModInfo;
            TxtBoxServerInfo = rtbServerInfo;
            TxtBoxMapInfo = rtbMapInfo;
            DataGridModManager = dgModManager;
            DataGridServerBrowser = dgServerBrowser;
            DataGridMapBrowser = dgMapBrowser;
        }
    }
}
