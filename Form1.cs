using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ComputerForensicsHasher
{
    public partial class btnLogThis : Form
    {
        public string myHashedFolder;
        public string TheCHosenPath;
        public string TheCaseNumber;
        public btnLogThis()
        {
            InitializeComponent();
        }

        private void btnChoosefolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Please choose a folder to hash";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string path1 = @"\";
                path1 = fbd.SelectedPath ;
                TheCHosenPath = fbd.SelectedPath;
                // get all the files inside this directory
                var files = Directory.GetFiles(path1 , "*", SearchOption.AllDirectories)
                          .OrderBy(p => p).ToList();
                string myHash = "";
                foreach ( var path in files )
                {
                   myHash += HashThisFolder(path); 
                }
                txtHashDisplay.Text = myHash;
                myHashedFolder = myHash;
               

            }
        }

        public string HashThisFolder(string filePath)
        {
            // hash path
            byte[] pathBytes = Encoding.UTF8.GetBytes(filePath);
            string hashed = ShaThis(pathBytes);

            // hash contents
            byte[] contentBytes = File.ReadAllBytes(filePath);
            string hashedFile = ShaThis(contentBytes);

            return hashed + "!" + hashedFile;
        }
        static string ShaThis(byte[] rawData)
        {

            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(rawData);

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TheCaseNumber  = txtCaseNum.Text;
            string location = txtLocation.Text;
            string description = txtDescription.Text;
            string time = txtDateTime.Text;
            if(myHashedFolder.Length <1)
            {
                // this is empty 
                MessageBox.Show("Please choose a folder","Alert");
            }
            else
            {
                // folder has been chosen save it 
                string sourceLoc = TheCHosenPath;
                string DestLoc = @"C:\Users\SanTheMan\Desktop\CFSaves";
                MakeACopy(sourceLoc, DestLoc);
              
            }
        }
        private void MakeACopy(string Source, string destination )
        {
            if (System.IO.Directory.Exists(Source))
            {
                //string fileName = System.IO.Path.GetFileName(Source );
                //// variables
                //string sourceFile = Source;//System.IO.Path.Combine(Source, fileName);

                //// create a folder for this case 
                string SaveLocation = System.IO.Path.Combine(destination, TheCaseNumber);
                //System.IO.Directory.CreateDirectory(SaveLocation );
                //// folder copy

                //string destFile = System.IO.Path.Combine(SaveLocation, fileName);
                //System.IO.File.Copy(sourceFile, destFile, true);
                //string[] files = System.IO.Directory.GetFiles(Source);

                //// Copy the files and overwrite destination files if they already exist.
                //foreach (string s in files)
                //{
                //    // Use static Path methods to extract only the file name from the path.
                //    fileName = System.IO.Path.GetFileName(s);
                //    destFile = System.IO.Path.Combine(SaveLocation , fileName);
                //    System.IO.File.Copy(s, destFile, true);
                //}
                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(Source, "*",
                    SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(Source, SaveLocation));

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(Source, "*.*",
                    SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(Source, SaveLocation), true);
            }
            else
            {
                return;
            }

        }

    }

}
