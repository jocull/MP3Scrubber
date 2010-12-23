using System;
using System.Collections.Generic;
using System.Windows.Forms;

static class Program
{
    public const string APP_TITLE = "MP3Scrubber";
    public const string APP_VERSION = "1.1";
    public const string APP_SCRUB_EXTENTION = ".MP3";

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new frmMain());
    }

    public static void showMessageBox(IWin32Window form, string msg)
    {
        MessageBox.Show(form, msg, APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
    }

    public static void showErrorBox(IWin32Window form, string msg)
    {
        MessageBox.Show(form, msg, APP_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    public static bool showQuestionBox(IWin32Window form, string msg)
    {
        DialogResult dr = new DialogResult();
        dr = MessageBox.Show(form, msg, APP_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}