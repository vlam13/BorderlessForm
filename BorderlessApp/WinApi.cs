﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BorderlessApp
{
    static class WinApi
    {
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr hWnd, int time, int flags);

        #region Windows messages

        public const uint WM_NULL = 0x000;
        public const uint WM_CREATE = 0x001;
        public const uint WM_DESTROY = 0x002;
        public const uint WM_MOVE = 0x003;
        public const uint WM_SIZE = 0x005;
        public const uint WM_ACTIVATE = 0x006;
        public const uint WM_SETFOCUS = 0x007;
        public const uint WM_KILLFOCUS = 0x008;
        public const uint WM_ENABLE = 0x00A;
        public const uint WM_SETREDRAW = 0x00B;
        public const uint WM_SETTEXT = 0x00C;
        public const uint WM_GETTEXT = 0x00D;
        public const uint WM_GETTEXTLENGTH = 0x00E;
        public const uint WM_PAINT = 0x00F;
        public const uint WM_CLOSE = 0x010;
        public const uint WM_QUERYENDSESSION = 0x011;
        public const uint WM_QUIT = 0x012;
        public const uint WM_QUERYOPEN = 0x013;
        public const uint WM_ERASEBKGND = 0x014;
        public const uint WM_SYSCOLORCHANGE = 0x015;
        public const uint WM_ENDSESSION = 0x016;
        public const uint WM_SHOWWINDOW = 0x018;
        public const uint WM_WININICHANGE = 0x01A;
        public const uint WM_DEVMODECHANGE = 0x01B;
        public const uint WM_ACTIVATEAPP = 0x01C;
        public const uint WM_FONTCHANGE = 0x01D;
        public const uint WM_TIMECHANGE = 0x01E;
        public const uint WM_CANCELMODE = 0x01F;
        public const uint WM_SETCURSOR = 0x020;
        public const uint WM_MOUSEACTIVATE = 0x021;
        public const uint WM_CHILDACTIVATE = 0x022;
        public const uint WM_QUEUESYNC = 0x023;
        public const uint WM_GETMINMAXINFO = 0x024;
        public const uint WM_PAuintICON = 0x026;
        public const uint WM_ICONERASEBKGND = 0x027;
        public const uint WM_NEXTDLGCTL = 0x028;
        public const uint WM_SPOOLERSTATUS = 0x02A;
        public const uint WM_DRAWITEM = 0x02B;
        public const uint WM_MEASUREITEM = 0x02C;
        public const uint WM_DELETEITEM = 0x02D;
        public const uint WM_VKEYTOITEM = 0x02E;
        public const uint WM_CHARTOITEM = 0x02F;
        public const uint WM_SETFONT = 0x030;
        public const uint WM_GETFONT = 0x031;
        public const uint WM_SETHOTKEY = 0x032;
        public const uint WM_GETHOTKEY = 0x033;
        public const uint WM_QUERYDRAGICON = 0x037;
        public const uint WM_COMPAREITEM = 0x039;
        public const uint WM_COMPACTING = 0x041;
        public const uint WM_COMMNOTIFY = 0x044; /* no longer suported */
        public const uint WM_WINDOWPOSCHANGING = 0x046;
        public const uint WM_WINDOWPOSCHANGED = 0x047;
        public const uint WM_POWER = 0x048;
        public const uint WM_COPYDATA = 0x04A;
        public const uint WM_CANCELJOURNAL = 0x04B;
        public const uint WM_NOTIFY = 0x04E;
        public const uint WM_INPUTLANGCHANGEREQUEST = 0x050;
        public const uint WM_INPUTLANGCHANGE = 0x051;
        public const uint WM_TCARD = 0x052;
        public const uint WM_HELP = 0x053;
        public const uint WM_USERCHANGED = 0x054;
        public const uint WM_NOTIFYFORMAT = 0x055;
        public const uint WM_CONTEXTMENU = 0x07B;
        public const uint WM_STYLECHANGING = 0x07C;
        public const uint WM_STYLECHANGED = 0x07D;
        public const uint WM_DISPLAYCHANGE = 0x07E;
        public const uint WM_GETICON = 0x07F;
        public const uint WM_SETICON = 0x080;
        public const uint WM_NCCREATE = 0x081;
        public const uint WM_NCDESTROY = 0x082;
        public const uint WM_NCCALCSIZE = 0x083;
        public const uint WM_NCHITTEST = 0x084;
        public const uint WM_NCPAINT = 0x085;
        public const uint WM_NCACTIVATE = 0x086;
        public const uint WM_GETDLGCODE = 0x087;
        public const uint WM_SYNCPAuint = 0x088;
        public const uint WM_NCMOUSEMOVE = 0x0A0;
        public const uint WM_NCLBUTTONDOWN = 0x0A1;
        public const uint WM_NCLBUTTONUP = 0x0A2;
        public const uint WM_NCLBUTTONDBLCLK = 0x0A3;
        public const uint WM_NCRBUTTONDOWN = 0x0A4;
        public const uint WM_NCRBUTTONUP = 0x0A5;
        public const uint WM_NCRBUTTONDBLCLK = 0x0A6;
        public const uint WM_NCMBUTTONDOWN = 0x0A7;
        public const uint WM_NCMBUTTONUP = 0x0A8;
        public const uint WM_NCMBUTTONDBLCLK = 0x0A9;
        public const uint WM_NCXBUTTONDOWN = 0x0AB;
        public const uint WM_NCXBUTTONUP = 0x0AC;
        public const uint WM_NCXBUTTONDBLCLK = 0x0AD;
        public const uint WM_INPUT = 0x0FF;
        public const uint WM_KEYFIRST = 0x100;
        public const uint WM_KEYDOWN = 0x100;
        public const uint WM_KEYUP = 0x101;
        public const uint WM_CHAR = 0x102;
        public const uint WM_DEADCHAR = 0x103;
        public const uint WM_SYSKEYDOWN = 0x104;
        public const uint WM_SYSKEYUP = 0x105;
        public const uint WM_SYSCHAR = 0x106;
        public const uint WM_SYSDEADCHAR = 0x107;
        public const uint WM_UNICHAR = 0x109;
        public const uint WM_KEYLAST = 0x109;
        public const uint WM_IME_STARTCOMPOSITION = 0x10D;
        public const uint WM_IME_ENDCOMPOSITION = 0x10E;
        public const uint WM_IME_COMPOSITION = 0x10F;
        public const uint WM_IME_KEYLAST = 0x10F;
        public const uint WM_INITDIALOG = 0x110;
        public const uint WM_COMMAND = 0x111;
        public const uint WM_SYSCOMMAND = 0x112;
        public const uint WM_TIMER = 0x113;
        public const uint WM_HSCROLL = 0x114;
        public const uint WM_VSCROLL = 0x115;
        public const uint WM_INITMENU = 0x116;
        public const uint WM_INITMENUPOPUP = 0x117;
        public const uint WM_SYSTIMER = 0x118;
        public const uint WM_MENUSELECT = 0x11F;
        public const uint WM_MENUCHAR = 0x120;
        public const uint WM_ENTERIDLE = 0x121;
        public const uint WM_MENURBUTTONUP = 0x122;
        public const uint WM_MENUDRAG = 0x123;
        public const uint WM_MENUGETOBJECT = 0x124;
        public const uint WM_UNINITMENUPOPUP = 0x125;
        public const uint WM_MENUCOMMAND = 0x126;
        public const uint WM_CHANGEUISTATE = 0x127;
        public const uint WM_UPDATEUISTATE = 0x128;
        public const uint WM_QUERYUISTATE = 0x129;
        public const uint WM_CTLCOLORMSGBOX = 0x132;
        public const uint WM_CTLCOLOREDIT = 0x133;
        public const uint WM_CTLCOLORLISTBOX = 0x134;
        public const uint WM_CTLCOLORBTN = 0x135;
        public const uint WM_CTLCOLORDLG = 0x136;
        public const uint WM_CTLCOLORSCROLLBAR = 0x137;
        public const uint WM_CTLCOLORSTATIC = 0x138;
        public const uint MN_GETHMENU = 0x1E1;
        public const uint WM_MOUSEFIRST = 0x200;
        public const uint WM_MOUSEMOVE = 0x200;
        public const uint WM_LBUTTONDOWN = 0x201;
        public const uint WM_LBUTTONUP = 0x202;
        public const uint WM_LBUTTONDBLCLK = 0x203;
        public const uint WM_RBUTTONDOWN = 0x204;
        public const uint WM_RBUTTONUP = 0x205;
        public const uint WM_RBUTTONDBLCLK = 0x206;
        public const uint WM_MBUTTONDOWN = 0x207;
        public const uint WM_MBUTTONUP = 0x208;
        public const uint WM_MBUTTONDBLCLK = 0x209;
        public const uint WM_MOUSEWHEEL = 0x20A;
        public const uint WM_XBUTTONDOWN = 0x20B;
        public const uint WM_XBUTTONUP = 0x20C;
        public const uint WM_XBUTTONDBLCLK = 0x20D;
        public const uint WM_MOUSELAST = 0x20A;
        public const uint WM_PARENTNOTIFY = 0x210;
        public const uint WM_ENTERMENULOOP = 0x211;
        public const uint WM_EXITMENULOOP = 0x212;
        public const uint WM_NEXTMENU = 0x213;
        public const uint WM_SIZING = 0x214;
        public const uint WM_CAPTURECHANGED = 0x215;
        public const uint WM_MOVING = 0x216;
        public const uint WM_POWERBROADCAST = 0x218;
        public const uint WM_DEVICECHANGE = 0x219;
        public const uint WM_MDICREATE = 0x220;
        public const uint WM_MDIDESTROY = 0x221;
        public const uint WM_MDIACTIVATE = 0x222;
        public const uint WM_MDIRESTORE = 0x223;
        public const uint WM_MDINEXT = 0x224;
        public const uint WM_MDIMAXIMIZE = 0x225;
        public const uint WM_MDITILE = 0x226;
        public const uint WM_MDICASCADE = 0x227;
        public const uint WM_MDIICONARRANGE = 0x228;
        public const uint WM_MDIGETACTIVE = 0x229;
        public const uint WM_MDISETMENU = 0x230;
        public const uint WM_ENTERSIZEMOVE = 0x231;
        public const uint WM_EXITSIZEMOVE = 0x232;
        public const uint WM_DROPFILES = 0x233;
        public const uint WM_MDIREFRESHMENU = 0x234;
        public const uint WM_IME_SETCONTEXT = 0x281;
        public const uint WM_IME_NOTIFY = 0x282;
        public const uint WM_IME_CONTROL = 0x283;
        public const uint WM_IME_COMPOSITIONFULL = 0x284;
        public const uint WM_IME_SELECT = 0x285;
        public const uint WM_IME_CHAR = 0x286;
        public const uint WM_IME_REQUEST = 0x288;
        public const uint WM_IME_KEYDOWN = 0x290;
        public const uint WM_IME_KEYUP = 0x291;
        public const uint WM_MOUSEHOVER = 0x2A1;
        public const uint WM_MOUSELEAVE = 0x2A3;
        public const uint WM_NCMOUSEHOVER = 0x2A0;
        public const uint WM_NCMOUSELEAVE = 0x2A2;
        public const uint WM_WTSSESSION_CHANGE = 0x2B1;
        public const uint WM_TABLET_FIRST = 0x2c0;
        public const uint WM_TABLET_LAST = 0x2df;
        public const uint WM_CUT = 0x300;
        public const uint WM_COPY = 0x301;
        public const uint WM_PASTE = 0x302;
        public const uint WM_CLEAR = 0x303;
        public const uint WM_UNDO = 0x304;
        public const uint WM_RENDERFORMAT = 0x305;
        public const uint WM_RENDERALLFORMATS = 0x306;
        public const uint WM_DESTROYCLIPBOARD = 0x307;
        public const uint WM_DRAWCLIPBOARD = 0x308;
        public const uint WM_PAuintCLIPBOARD = 0x309;
        public const uint WM_VSCROLLCLIPBOARD = 0x30A;
        public const uint WM_SIZECLIPBOARD = 0x30B;
        public const uint WM_ASKCBFORMATNAME = 0x30C;
        public const uint WM_CHANGECBCHAIN = 0x30D;
        public const uint WM_HSCROLLCLIPBOARD = 0x30E;
        public const uint WM_QUERYNEWPALETTE = 0x30F;
        public const uint WM_PALETTEISCHANGING = 0x310;
        public const uint WM_PALETTECHANGED = 0x311;
        public const uint WM_HOTKEY = 0x312;
        public const uint WM_PRINT = 0x317;
        public const uint WM_PRINTCLIENT = 0x0318;
        public const uint WM_APPCOMMAND = 0x319;
        public const uint WM_THEMECHANGED = 0x31A;
        public const uint WM_HANDHELDFIRST = 0x358;
        public const uint WM_HANDHELDLAST = 0x35F;
        public const uint WM_AFXFIRST = 0x360;
        public const uint WM_AFXLAST = 0x37F;
        public const uint WM_PENWINFIRST = 0x380;
        public const uint WM_PENWINLAST = 0x38F;

        #endregion

        public const int SC_RESTORE = 0xF120;
        public const int SC_MINIMIZE = 0xF020;

        internal enum WindowStyles : uint
        {
            WS_OVERLAPPED = 0x00000000,
            WS_POPUP = 0x80000000,
            WS_CHILD = 0x40000000,
            WS_MINIMIZE = 0x20000000,
            WS_VISIBLE = 0x10000000,
            WS_DISABLED = 0x08000000,
            WS_CLIPSIBLINGS = 0x04000000,
            WS_CLIPCHILDREN = 0x02000000,
            WS_MAXIMIZE = 0x01000000,
            WS_CAPTION = 0x00C00000,
            WS_BORDER = 0x00800000,
            WS_DLGFRAME = 0x00400000,
            WS_VSCROLL = 0x00200000,
            WS_HSCROLL = 0x00100000,
            WS_SYSMENU = 0x00080000,
            WS_THICKFRAME = 0x00040000,
            WS_GROUP = 0x00020000,
            WS_TABSTOP = 0x00010000,
            WS_MINIMIZEBOX = 0x00020000,
            WS_MAXIMIZEBOX = 0x00010000,
            WS_TILED = 0x00000000,
            WS_ICONIC = 0x20000000,
            WS_SIZEBOX = 0x00040000,
            WS_POPUPWINDOW = 0x80880000,
            WS_OVERLAPPEDWINDOW = 0x00CF0000,
            WS_TILEDWINDOW = 0x00CF0000,
            WS_CHILDWINDOW = 0x40000000
        }

        internal enum WindowExStyles
        {
            WS_EX_DLGMODALFRAME = 0x00000001,
            WS_EX_NOPARENTNOTIFY = 0x00000004,
            WS_EX_TOPMOST = 0x00000008,
            WS_EX_NOACTIVATE = 0x08000000,
            WS_EX_ACCEPTFILES = 0x00000010,
            WS_EX_TRANSPARENT = 0x00000020,
            WS_EX_MDICHILD = 0x00000040,
            WS_EX_TOOLWINDOW = 0x00000080,
            WS_EX_WINDOWEDGE = 0x00000100,
            WS_EX_CLIENTEDGE = 0x00000200,
            WS_EX_CONTEXTHELP = 0x00000400,
            WS_EX_RIGHT = 0x00001000,
            WS_EX_LEFT = 0x00000000,
            WS_EX_RTLREADING = 0x00002000,
            WS_EX_LTRREADING = 0x00000000,
            WS_EX_LEFTSCROLLBAR = 0x00004000,
            WS_EX_RIGHTSCROLLBAR = 0x00000000,
            WS_EX_CONTROLPARENT = 0x00010000,
            WS_EX_STATICEDGE = 0x00020000,
            WS_EX_APPWINDOW = 0x00040000,
            WS_EX_OVERLAPPEDWINDOW = 0x00000300,
            WS_EX_PALETTEWINDOW = 0x00000188,
            WS_EX_LAYERED = 0x00080000,
            WS_EX_COMPOSITED = 0x02000000
        }

        internal enum ActivateWindowFlags : int
        {
            AW_ACTIVATE = 0x00020000,
            AW_BLEND = 0x00080000,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_SLIDE = 0x00040000,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008
        }

        [DllImport("user32.dll")]
        public static extern int FindWindow(string className, string windowText);
        [DllImport("user32.dll")]
        public static extern int ShowWindow(int hwnd, int command);
        [DllImport("user32.dll")]
        public static extern void SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter,
                 int X, int Y, int width, int height, uint flags);

        internal const int SW_HIDE = 0;
        internal const int SW_SHOWNORMAL = 1;
        internal const int SW_NORMAL = 1;
        internal const int SW_SHOWMINIMIZED = 2;
        internal const int SW_SHOWMAXIMIZED = 3;
        internal const int SW_MAXIMIZE = 3;
        internal const int SW_SHOWNOACTIVATE = 4;
        internal const int SW_SHOW = 5;
        internal const int SW_MINIMIZE = 6;
        internal const int SW_SHOWMINNOACTIVE = 7;
        internal const int SW_SHOWNA = 8;
        internal const int SW_RESTORE = 9;
        internal const int SW_SHOWDEFAULT = 10;
        internal const int SW_FORCEMINIMIZE = 11;
        internal const int SW_MAX = 11;

    }
}
