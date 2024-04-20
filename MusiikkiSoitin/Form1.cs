using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusiikkiSoitin
{
    public partial class MusiikkiSoitinApp : Form
    {
        public MusiikkiSoitinApp()
        {
            InitializeComponent();
        }


        //Creating Global Variables of String Type Array that will hold the songs titles and paths to the songs location
        string[] paths, files;

        private void btnValitseMusiikki_Click(object sender, EventArgs e)
        {
            //this will be used to select the song we want to play
            OpenFileDialog ofd = new OpenFileDialog();
            //code for multible song selection
            ofd.Multiselect = true;
            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //saving the names of the tracks in the file array
                paths = ofd.FileNames; //saving the paths of the tracks in the path array
                //this will display the song titles in the listbox
                for(int i = 0; i <files.Length; i++)
                {
                    ListMusicList.Items.Add(files[i]); //this will dispaly the song in the music list
                }
            }
        }

        private void ListMusicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this will be used for playing the files selected in the list
            axWindowsMediaPlayerMusiikinSoitin.URL = paths[ListMusicList.SelectedIndex];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this will close the application
            this.Close();
        }
    }
}
