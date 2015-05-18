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

        string listFileName; //Name of list file
        string saveFileName; //Name of roster save file

        string readRecord; //Holding variable for individual records (Names)

        string delim = " , "; //Delimiter for namelist and roster

        string[] nameList; //Array for incoming name list
        string[] rosterList; //Array for custom roster

        DialogResult result;//result of dialogs

        public StreamReader inputFileReader; //File reading stream for the Name List files
        public StreamReader saveFileReader; //File reading stream for the Roster File
        public StreamWriter saveFileWriter; //File writing stream

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Check if an input file was opened 
            if (inputFileReader != null)
            {
                //Close and dump file 
                inputFileReader.Close();
                inputFileReader.Dispose();
            }
            
            //Check if an output file was opened 
            if (saveFileWriter != null)
            {
                //Close and dump file 
                saveFileWriter.Close();
                saveFileWriter.Dispose();
            }

            //Close program 
            Application.Exit();
        }

        private void numRosterSize_ValueChanged(object sender, EventArgs e)
        {
            //Save the roster size value to the proper variable
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
        }//end Custom Name List radio button

        private void btnOpenXcomListFile_Click(object sender, EventArgs e)
        {
            //Check if an input file was already open
            if (inputFileReader != null)
            {
                //Close and dump file 
                inputFileReader.Close();
                inputFileReader.Dispose();
            }

            DialogResult result;//result of dialog

            //open the file chooser dialog
            using (OpenFileDialog chooseFile = new OpenFileDialog())
            {
                chooseFile.Title = "Choose your XCOM Name List File";
                result = chooseFile.ShowDialog();//Save the result

                listFileName = chooseFile.FileName;//Save the filename

            }//end open dialog

            //If user selected file
            if (result == DialogResult.OK)
            {
                try
                {

                    //Open the file with read access
                    FileStream inputFile = new FileStream(listFileName, FileMode.Open, FileAccess.Read);

                    inputFileReader = new StreamReader(inputFile); //Pass the input file to the reader
                    
                }
                catch (IOException)
                {
                    MessageBox.Show("An error occured while opening the XCOM Name List file");
                }//end try/catch

            }// end click ok
        }//end OpenXcomListFile button

        private void btnOpenCustomNameListFile_Click(object sender, EventArgs e)
        {
            //Check if an input file was already open
            if (inputFileReader != null)
            {
                //Close and dump file
                inputFileReader.Close();
                inputFileReader.Dispose();
            }

            
            //open the file chooser dialog
            using (OpenFileDialog chooseFile = new OpenFileDialog())
            {
                chooseFile.Title = "Choose your Custom Name List file";
                result = chooseFile.ShowDialog();//Save the result

                listFileName = chooseFile.FileName;//Save the filename

            }//end open dialog

            //If user selected file
            if (result == DialogResult.OK)
            {
                try
                {

                    //Open the file with read access
                    FileStream inputFile = new FileStream(listFileName, FileMode.Open, FileAccess.Read);

                    inputFileReader = new StreamReader(inputFile); //Pass the input file to the reader

                }
                catch (IOException)
                {
                    MessageBox.Show("An error occured while opening the Custom Name List file");
                }//end try/catch

            }// end click ok
        }//end OpenCustomNameList button

        private void xcomListConverter(Array listArray)
        {
            //Method for converting the raw data in the nameList array from the XCOM Name List file into only names.
        }

        private void btnSaveRosterFile_Click(object sender, EventArgs e)
        {
            //Check if an output file was already open
            if (saveFileWriter != null || saveFileReader != null)
            {
                //Close and dump files
                saveFileReader.Close();
                saveFileReader.Dispose();
                saveFileWriter.Close();
                saveFileWriter.Dispose();
            }

            

            using (SaveFileDialog fileChooser = new SaveFileDialog())
            {

                //select or create an output file to store the input data.

                fileChooser.Title = "Choose a file for your Roster";
                fileChooser.DefaultExt = "txt"; //Set the default extention
                fileChooser.AddExtension = true; //add the default extention if omitted
                fileChooser.CheckFileExists = false;
                result = fileChooser.ShowDialog();
                saveFileName = fileChooser.FileName;

                if (result == DialogResult.OK)
                {
                    if (saveFileName == string.Empty)
                        MessageBox.Show("Invalid Roster Save File Name", "Error", MessageBoxButtons.OK);
                    else
                    {
                        try
                        {
                            FileStream rosterFile = new FileStream(saveFileName, FileMode.OpenOrCreate , FileAccess.ReadWrite);

                            //Pass the file to the writers
                            saveFileReader = new StreamReader(rosterFile);
                            saveFileWriter = new StreamWriter(rosterFile);
                        }
                        catch (IOException)
                        {
                            MessageBox.Show("Error opening Roster file");
                        }//end try/catch
                    }                   
                     
                    //Pull the information in the file into the rosterList array for comparison purposes
                    try
                    {
                        //Read each line as individual records
                        readRecord = saveFileReader.ReadLine();

                        //while there are still new records
                         while (readRecord != null)
                        {
                            rosterList = readRecord.Split();
                        }

                    }
                    catch
                    {
                        MessageBox.Show("No Roster File Opened");
                    }

                }//end if OK
            }//end filechooser
        }//end save roster file button
    }
}
