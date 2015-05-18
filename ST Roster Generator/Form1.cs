using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Kelly Stoops
//ST Roster Generator
//5-14-15

namespace ST_Roster_Generator
{
    public partial class Form1 : Form
    {

        //Declare Variables

        int rosterSize; //Size of the desired random roster

        int rndRNG; //Random number from the RNG to be used for randomizing

        string filename; //Name of file

        string readRecord; //Holding variable for individual records (Names)

        string delim = " , "; //Delimiter for namelist and roster

        string[] nameList; //Array for incoming name list
        string[] rosterList; //Array for custom roster

        public StreamReader fileReader; //File reading stream
        public StreamWriter fileWriter; //File writing stream

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Check if an input file was opened 
            if (fileReader != null)
            {
                //Close and dump file 
                fileReader.Close();
                fileReader.Dispose();
            }

            //Check if an output file was opened 
            if (fileWriter != null)
            {
                //Close and dump file 
                fileWriter.Close();
                fileWriter.Dispose();
            }

            //Close program 
            Application.Exit();
        }

        private void numRosterSize_ValueChanged(object sender, EventArgs e)
        {
            rosterSize = Convert.ToInt32(numRosterSize.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdbXcomListRadio_CheckedChanged(object sender, EventArgs e)
        {
            //Check if the radio box has been checked or unchecked
            if (rdbXcomListRadio.Checked == true)
            {
                //Enable the combobox
                cmbXcomListFile.Enabled = true;

                //Enable the File Browser
                btnOpenXcomListFile.Enabled = true;

                //Disable the Custom combobox and browser if not already done
                if (cmbCustomNameListFile.Enabled == true || btnOpenCustomNameListFile.Enabled == true)
                {
                    cmbCustomNameListFile.Enabled = false;
                    btnOpenCustomNameListFile.Enabled = false;
                }
            }//end checked if
        }

        private void rdbCustomNameListRadio_CheckedChanged(object sender, EventArgs e)
        {
            //Check if the radio box has been checked or unchecked
            if (rdbCustomNameListRadio.Checked == true)
            {
                //Enable the combobox
                cmbCustomNameListFile.Enabled = true;

                //Enable the File Browser
                btnOpenCustomNameListFile.Enabled = true;

                //Disable the XCOM combobox and browser if not already done
                if (cmbXcomListFile.Enabled == true || btnOpenXcomListFile.Enabled == true)
                {
                    cmbXcomListFile.Enabled = false;
                    btnOpenXcomListFile.Enabled = false;
                }
            }//end checked if
        }
    }
}
