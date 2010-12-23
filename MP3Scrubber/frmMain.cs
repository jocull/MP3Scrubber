using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
//We extend our recycle bin functionality from Visual Basic. It's easier.
using Microsoft.VisualBasic.FileIO;

public partial class frmMain : Form
{
    private string mRootFolder;
    private DateTime mFileMaxDate;
    private bool mRecycle;
    private bool mSimulate;
    private int mFileScrubCount;
    private int mFolderScrubCount;

    public frmMain()
    {
        InitializeComponent();
        this.Text = Program.APP_TITLE + " - v" + Program.APP_VERSION;
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        if (txtFolderPath.Text != "")
            fbd.SelectedPath = txtFolderPath.Text;
        fbd.ShowDialog();
        string path = fbd.SelectedPath;
        txtFolderPath.Text = path;

        if (path == "" || path == null)
        {
            return;
        }
    }

    private void btnCurrentDateTime_Click(object sender, EventArgs e)
    {
        txtFileDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        if (!validate(false))
            return;

        txtActionLog.Text = "";
        logText("***SCRUBBING OPERATION STARTING...");
        mFileScrubCount = 0;
        mFolderScrubCount = 0;
        scrubFiles(mRootFolder);
        scrubFolders(mRootFolder);
        logText("***SCRUBBING OPERATION COMPLETED! " + mFileScrubCount + " file(s) and " + mFolderScrubCount + " folder(s) scrubbed!");
    }

    private void scrubFiles(string path)
    {
        string[] paths = Directory.GetFiles(path, "*", System.IO.SearchOption.AllDirectories);

        foreach (string file in paths)
        {
            //Leave ignored directories alone
            if (file.ToLower().Contains(Path.DirectorySeparatorChar + "_ignore" + Path.DirectorySeparatorChar))
                continue;

            //Check the file's creation date
            if (File.GetCreationTime(file) >= mFileMaxDate)
                continue;

            //Check to make sure this isn't the folder image
            if (Path.GetFileName(file) == "folder.jpg")
                continue;

            //This file gets trashed!
            try
            {
                if (mRecycle)
                {
                    if(!mSimulate)
                        FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                    logText("File " + file + " recycled.");
                }
                else
                {
                    if(!mSimulate)
                        File.Delete(file);
                    logText("File " + file + " deleted.");
                }
                mFileScrubCount++;
            }
            catch (Exception ex)
            {
                //File in use? Missing? etc?
                logText("***ERROR WHILE DELETING FILE: " + ex.Message);
            }
        }
    }

    private void scrubFolders(string path)
    {
        List<string> paths = new List<string>(Directory.GetDirectories(path, "*", System.IO.SearchOption.AllDirectories));

        //Reduce the folders until gone.
        while (paths.Count > 0)
        {
            string directory = paths[0];
            if (directory.ToLower().Contains(Path.DirectorySeparatorChar + "_ignore"))
            {
                paths.Remove(directory);
                continue;
            }

            //Pop off empty directories... if subdirectories of this directory are empty
            if (Directory.GetFiles(directory, "*", System.IO.SearchOption.AllDirectories).Length == 0)
            {
                //This directory gets trashed!
                try
                {
                    if (mRecycle)
                    {
                        if (!mSimulate)
                            FileSystem.DeleteDirectory(directory, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                        logText("Directory " + directory + " recycled.");
                    }
                    else
                    {
                        if (!mSimulate)
                            Directory.Delete(directory);
                        logText("Directory " + directory + " deleted.");
                    }

                    //Remove this dir and all children from the path list
                    List<string> removePaths = new List<string>();
                    foreach (string p in paths)
                    {
                        if (p.Contains(directory))
                            removePaths.Add(p);
                    }
                    foreach (string p in removePaths)
                    {
                        paths.Remove(p);
                    }

                    //Increment and move on...
                    mFolderScrubCount++;
                }
                catch (Exception ex)
                {
                    //Directory in use? Missing? etc?
                    logText("***ERROR WHILE DELETING DIRECTORY: " + ex.Message);
                }
            }

            //Remove this directory from the list (forced reduce)
            paths.Remove(directory);
        }
    }

    private void tiltMP3Names(string path)
    {
        Random rnd = new Random();
        string[] paths = Directory.GetFiles(path, "*" + Program.APP_SCRUB_EXTENTION, System.IO.SearchOption.AllDirectories);

        foreach (string file in paths)
        {
            //Leave ignored directories alone
            if (file.ToLower().Contains(Path.DirectorySeparatorChar + "_ignore" + Path.DirectorySeparatorChar))
                continue;

            //This file gets tilted!
            try
            {
                File.Move(file, Path.Combine(Path.GetDirectoryName(file),
                    Path.GetFileNameWithoutExtension(file) + 
                    "-" + rnd.Next(int.MaxValue) + 
                    Path.GetExtension(file)));
                logText("File " + file + " tilted.");
                mFileScrubCount++;
            }
            catch (Exception ex)
            {
                //File in use? Missing? etc?
                logText("***ERROR WHILE TILTING FILE: " + ex.Message);
            }
        }
    }

    private void btnTileNames_Click(object sender, EventArgs e)
    {
        if (!Program.showQuestionBox(this, "This will alter MP3 filenames so that you may write to the same directory without writing on top of the same file (prevents write access errors).\n\nThis change is PERMANENT! Do you want to Continue?"))
            return;

        if (!validate(true))
            return;

        txtActionLog.Text = "";
        logText("***TILTING OPERATION STARTING...");
        mFileScrubCount = 0;
        mFolderScrubCount = 0;
        tiltMP3Names(mRootFolder);
        logText("***TILTING OPERATION COMPLETED! " + mFileScrubCount + " file(s) tilted!");
    }

    private void logText(string text)
    {
        txtActionLog.Text = text + "\r\n" + txtActionLog.Text;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        if (Program.showQuestionBox(this, "Are you sure you want to exit?"))
            this.Close();
    }

    private bool validate(bool tilting)
    {
        string errors = "";
        mRootFolder = txtFolderPath.Text;
        if (!Directory.Exists(mRootFolder))
        {
            errors += "- Folder to Scrub needs to be a valid path.\n";
        }
        if (!tilting)
        {
            if (!DateTime.TryParse(txtFileDateTime.Text, out mFileMaxDate))
            {
                errors += "- File Created Date needs to be in a valid date format.\n";
            }
        }
        mRecycle = chkRecycle.Checked;
        mSimulate = chkSimulateDelete.Checked;

        if (errors.Length > 0)
        {
            Program.showErrorBox(this, "There were one or more errors with your form:\n\n" + errors);
            return false;
        }

        return true;
    }
}