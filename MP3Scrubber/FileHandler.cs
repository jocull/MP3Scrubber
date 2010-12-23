using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

public class FileHandler
{
    //Contains information that the SHFileOperation function uses to perform file operations.
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct SHFILEOPSTRUCT
    {
        public IntPtr hwnd;
        public UInt32 wFunc;
        public string pFrom;
        public string pTo;
        public UInt16 fFlags;
        public Int32 fAnyOperationsAborted;
        public IntPtr hNameMappings;
        [MarshalAs(UnmanagedType.LPWStr)]
        public String lpszProgressTitle;
    }

    [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
    public static extern Int32 SHFileOperation(ref SHFILEOPSTRUCT
    lpFileOp);

    const int FO_DELETE = 3;
    const int FOF_ALLOWUNDO = 0x40;
    const int FOF_NOCONFIRMATION = 0x10;

    public static void DeleteFile(string fname)
    {
        SHFILEOPSTRUCT shf = new SHFILEOPSTRUCT();
        shf.hwnd = IntPtr.Zero;
        shf.wFunc = (uint)FO_DELETE;
        shf.fFlags = (ushort)FOF_ALLOWUNDO | FOF_NOCONFIRMATION;
        shf.pTo = fname;
        shf.fAnyOperationsAborted = 0;
        shf.hNameMappings = IntPtr.Zero;
        SHFileOperation(ref shf);
    }
}