using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Compression
{
    public partial class MainForm : Form
    {
        FileCollection fList = new FileCollection();

        public MainForm()
        {
            InitializeComponent();
        }

        //Allows the user to select files on their computer to be added to the FileCollection
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            selectFileDialog.ShowDialog();
            string[] selFiles = selectFileDialog.FileNames;

            foreach (string s in selFiles)
                if (!s.Equals(""))
                    fList.addFile(s);

            populateListBox();
        }

        //Adds elements of the FileCollection to the listbox
        private void populateListBox()
        {
            lstFiles.Items.Clear();
            for(int i = 0; i < fList.getLength(); i++)
            {
                if (!(fList[i] == null))
                    lstFiles.Items.Add(fList[i]);
            }
        }

        //User selects a directory. A new directory is created where all the selected files are copied to
        //The new directory is then compressed into a .zip file of the same name and the directory is deleted
        private void btnCompress_Click(object sender, EventArgs e)
        {
            compressLocationDialog.SelectedPath = "";
            compressLocationDialog.ShowDialog();

            if(!(compressLocationDialog.Equals("")))
            {
                DirectoryInfo newDir = Directory.CreateDirectory(Path.Combine(compressLocationDialog.SelectedPath, txtDirName.Text));

                for (int x = 0; x < fList.getLength(); x++)
                {
                    if (!(fList[x] == null))
                        System.IO.File.Copy(fList[x], Path.Combine(newDir.FullName, getFileName(fList[x])), true);
                }

                try
                {
                    ZipFile.CreateFromDirectory(newDir.FullName, newDir.FullName + ".zip");
                }
                catch (Exception)
                {
                    MessageBox.Show("The file " + newDir.FullName + ".zip already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                newDir.Delete(true);

                Process.Start(newDir.FullName + ".zip");

                fList.clear();
                populateListBox();
            }
            
        }

        //When given a full path, will return just the file name and the extension
        private string getFileName(string s)
        {
            return s.Substring(s.LastIndexOf(@"\") + 1);
        }

        //User browses their computer to find a .zip file, which will then be extracted into a directory of the same name
        private void btnExtract_Click(object sender, EventArgs e)
        {
            selectZipDialog.FileName = "";
            selectZipDialog.ShowDialog();
            string zName = selectZipDialog.FileName;

            if (!(zName.Equals("")))
            {
                DirectoryInfo exDir = Directory.CreateDirectory(zName.Substring(0, zName.LastIndexOf(@".")));

                try
                {
                    ZipFile.ExtractToDirectory(zName, exDir.FullName);
                }
                catch (Exception)
                {
                    MessageBox.Show("The directory " + exDir.FullName + " already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Process.Start(exDir.FullName);
            }
        }
    }

    //Used to keep track of selected files
    public class FileCollection
    {
        string[] fileList = new string[10];

        public string this[int i]
        {
            get
            {
                return fileList[i];
            }

            set
            {
                fileList[i] = value;
            }
        }

        //Adds a file to the first empty slot in the array
        public void addFile(string tFile)
        {
            for(int x = 0; x < fileList.Length; x++)
            {
                if(fileList[x] == null)
                {
                    fileList[x] = tFile;
                    break;
                }
            }
        }

        public int getLength()
        {
            return fileList.Length;
        }

        //Clears the entire array
        public void clear()
        {
            for (int x = 0; x < fileList.Length; x++)
                fileList[x] = null;
        }
    }
}
