using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MassFileModifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void RenameFilesInFolder(string folderPath, string newFileName)
        {
            // Get all the files in the specified folder
            string[] files = Directory.GetFiles(folderPath);

            // Loop through each file
            for (int i = 0; i < files.Length; i++)
            {
                string extension = Path.GetExtension(files[i]);
                string newFilePath = Path.Combine(folderPath, newFileName + "_" + (i + 1) + extension);

                // Rename the file
                File.Move(files[i], newFilePath);
            }
        }

        public void ReplaceTextInFiles(string folderPath, string oldText, string newText, bool recursive)
        {
            // Get all the files with .cs or .txt extensions in the folder (optionally recursive)
            SearchOption searchOption = recursive ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            string[] files = Directory.GetFiles(folderPath, "*.cs", searchOption).Concat(Directory.GetFiles(folderPath, "*.txt", searchOption)).ToArray();

            // Loop through each file
            foreach (var file in files)
            {
                try
                {
                    // Read the file content
                    string content = File.ReadAllText(file);

                    // Replace occurrences of oldText with newText (case-sensitive)
                    string updatedContent = content.Replace(oldText, newText);

                    // Write the updated content back to the file
                    File.WriteAllText(file, updatedContent);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error modifying file '{file}': {ex.Message}");
                }
            }
        }

        private void changeContentsBtn_Click(object sender, EventArgs e)
        {
            string folderPath = filePathTxtBox.Text;
            string oldText = oldFileContentsBox.Text;
            string newText = newFileContentsBox.Text;
            bool recursive = recursiveCheckBox1.Checked;

            if (Directory.Exists(folderPath))
            {
                ReplaceTextInFiles(folderPath, oldText, newText, recursive);
                MessageBox.Show("Text replaced successfully.");
            }
            else
            {
                MessageBox.Show("The specified folder path does not exist.");
            }
        }

        private void oldFileContentsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void filePathTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newFileContentsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void folderPathLabel_Click(object sender, EventArgs e)
        {

        }

        private void oldFileContents_Click(object sender, EventArgs e)
        {

        }

        private void newFileContents_Click(object sender, EventArgs e)
        {

        }

        private void recursiveCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
