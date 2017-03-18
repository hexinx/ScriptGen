using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ScriptGen.Classes;

namespace ScriptGen
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        static private List<string> SQL_Entries = new List<string>();
        static private string currentSQL = "";
        static string tColumns = "";
        static string tTargetTable = "";
        static cMisc tLookup = new cMisc();
        
        private void cmd_Generate_Click(object sender, EventArgs e)
        {
            fctb.Text = "";
            SQL_Entries.Clear();

            int tCount = 0;

            foreach (var currentType in lb_Type.SelectedItems)
            {
                foreach (var currentYearPair in tLookup.yearPairs)
                {
                    foreach (var currentLocation in lb_Location.SelectedItems)
                    {
                        foreach (var currentYear in lb_Year.SelectedItems)
                        {
                            string tShortCcurrentYear = currentYear.ToString().Substring(2, 2);

                            ////Check if current year is out of range pair
                            //if (!((tShortCcurrentYear.ToString() == currentYearPair.ToString().Substring(0, 2))
                            //    || (tShortCcurrentYear.ToString() == currentYearPair.ToString().Substring(2, 2))
                            //        || ((tShortCcurrentYear.ToString() == currentYearPair.ToString().Substring(4, 2)))))
                            //    continue;

                            //Work around to focus on years that we want
                            if (((tShortCcurrentYear.ToString() == "12") && (currentYearPair.ToString()!= "121314")))
                                continue;

                            if (((tShortCcurrentYear.ToString() == "13") && (currentYearPair.ToString() != "131415")))
                                continue;

                            if (((tShortCcurrentYear.ToString() == "14") && (currentYearPair.ToString() != "131415")))
                                continue;

                            if (((tShortCcurrentYear.ToString() == "15") && (currentYearPair.ToString() != "131415")))
                                continue;


                            //Check if Current year is less than 2014 for VAWA
                            if (currentType.ToString() == "Vawa")
                                if (Convert.ToInt32(currentYear) < 2014) continue;

                            tCount++;

                            //Make Insert query for target table 
                            currentSQL = "INSERT INTO " + currentType.ToString().Replace(" ","_") + System.Environment.NewLine;

                            //Specify Columns
                            currentSQL += "(id," + System.Environment.NewLine;

                            tColumns = "";
                            foreach (var column in tLookup.ColumnsInType[currentType.ToString()])
                            { tColumns += column + "," + System.Environment.NewLine; }
                            tColumns = tColumns.Substring(0, tColumns.Length - 3) + ")" + System.Environment.NewLine;
                            currentSQL += tColumns;

                            //Narrow down
                            currentSQL += "(SELECT locationyear.id,"+System.Environment.NewLine;

                            tTargetTable =
                                tLookup.shortType[currentType.ToString()] + "_" +
                                tLookup.shortLocation[currentLocation.ToString()] + "_" +
                                currentYearPair;

                            string narrowColumns = "";
                            tColumns = "";
                            foreach (var column in tLookup.ColumnsInType[currentType.ToString()])
                            {
                                tColumns = column + tShortCcurrentYear.ToString();
                                tColumns = tTargetTable + "." + tColumns;
                                narrowColumns += tColumns + "," + System.Environment.NewLine;
                            }
                            narrowColumns = narrowColumns.Substring(0, narrowColumns.Length - 3);
                            currentSQL += narrowColumns + System.Environment.NewLine;

                            //Assemble Join
                            currentSQL += "FROM " + tTargetTable + System.Environment.NewLine;
                            currentSQL += "INNER JOIN locationyear" + System.Environment.NewLine;
                            currentSQL += "ON" + System.Environment.NewLine;
                            currentSQL += tTargetTable + ".instnm = locationyear.NAME" + System.Environment.NewLine;
                            currentSQL += "AND " + tTargetTable + ".branch = locationyear.branch" + System.Environment.NewLine;
                            currentSQL += "AND " + tTargetTable + ".address = locationyear.address" + System.Environment.NewLine;
                            currentSQL += "AND " + tTargetTable + ".city = locationyear.city" + System.Environment.NewLine;
                            currentSQL += "AND " + tTargetTable + ".state = locationyear.state" + System.Environment.NewLine;

                            //Assemble Year
                            currentSQL += "WHERE  year = " + currentYear.ToString() + System.Environment.NewLine;
                            currentSQL += "AND location = " + "'" + tLookup.actualLocation[currentLocation.ToString()] + "');";

                            //Store generated SQL statement
                            SQL_Entries.Add(currentSQL);
                        }
                        currentSQL = "";
                    }
                }
            }

            if (tCount == 0)
            {
                fctb.Text = "--Insufficient (or invalid) parameters selected" + System.Environment.NewLine;
                fctb.Text += "--Choose atleast one from each column" + System.Environment.NewLine;
                fctb.Text += "--(VAWA data: Only years 2014 and 2015)";
                return;
            }

            fctb.Text = "--Generated using ScriptGen 0.1" + System.Environment.NewLine;
            fctb.Text += "--Total number of SQL statements generated: " + tCount + System.Environment.NewLine + System.Environment.NewLine;

            string tDel = System.Environment.NewLine + System.Environment.NewLine;
            fctb.Text += string.Join(tDel, SQL_Entries.ToArray());

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void cmd_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void cmd_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simply utility to generate (application specific)" +
                " SQL statements. Programmed as an aide during data pre-processing. \n\nProject work - "+
                "Database Managements Systems, CISE, UF, 2017.\nAaditya,Dev,Divya, Raji.\nSyntax Highlighting Control: Pavel Torgashov, 2014", "About");
        }
    }
}
