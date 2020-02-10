using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Massar
{
    internal class Import
    {
        private DataSet workBook;

        public DataSet WorkBook { get => workBook; set => workBook = value; }

        public Import()
        {

        }
        private DataSet Reader(Stream stream)
        {
            try
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });
                    return result;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            return null;
        }
        public void OpenFile(string fileName)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string safeName = null;
                        if (Path.GetExtension(openFileDialog.FileName) == ".xls")
                        {
                            try
                            {
                                safeName = openFileDialog.SafeFileName.Substring(0, openFileDialog.SafeFileName.IndexOf("_"));
                            }
                            catch (Exception x)
                            {
                                MessageBox.Show(x.Message);
                            }
                            if (safeName == fileName)
                            {
                                using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                                {
                                    workBook = Reader(stream);
                                    workBook.DataSetName = fileName;
                                }
                            }
                            else
                            {
                                MessageBox.Show("this is ( " + safeName + " ) not " + fileName);
                            }
                        }
                        else if (Path.GetExtension(openFileDialog.FileName) == ".xlsx")
                        {
                            try
                            {
                                safeName = openFileDialog.SafeFileName.Substring(0, openFileDialog.SafeFileName.IndexOf("_"));
                            }
                            catch (Exception x)
                            {
                                MessageBox.Show(x.Message);
                            }

                            if (safeName == "export")
                            {
                                safeName += openFileDialog.SafeFileName.Substring(safeName.Length, openFileDialog.SafeFileName.IndexOf("_"));
                            }
                        }
                        else
                        {
                            MessageBox.Show("This Files is not an Excel File , How you do that !!!");
                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Class > Import");
            }
        }
        public void OpenFolder(string fileName)
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string r = folderBrowserDialog.SelectedPath;
                        int f=0, s=0;
                        foreach (string path in Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.xls"))
                        {
                            f++;
                            string safeName = null;
                            //MessageBox.Show(r);
                            try
                            {
                                safeName = path.Substring(path.IndexOf("_")+1,path.Length-path.IndexOf("_")-1);
                                safeName = safeName.Substring(0,safeName.IndexOf("_"));
                            }
                            catch (Exception x)
                            {
                                MessageBox.Show(x.Message);
                            }
                            //MessageBox.Show("SafeName = ( " + safeName + " )\nFileName = " + fileName);
                            if (safeName == "export")
                            {
                                safeName += path.Substring(safeName.Length, path.IndexOf("_"));
                            }
                            if (safeName == fileName)
                            {
                                using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
                                {
                                    s = 0;
                                    DataSet set = Reader(stream);
                                    /*
                                    foreach (DataTable table in set.Tables)
                                    {
                                        s++;
                                        if (table is null)
                                        {

                                        }
                                        if (workBook is null)
                                        {
                                            workBook = new DataSet(fileName);
                                        }
                                        table.TableName = safeName + s + "-" + f;
                                        MessageBox.Show(table.TableName);
                                        workBook.Tables.Add(table);
                                    }
                                    */
                                    for (int i = 0; i < set.Tables.Count; i++)
                                    {
                                        DataTable data = set.Tables[i];
                                        s++;
                                        if (data.Rows.Count == 0)
                                        {
                                            break;
                                        }
                                        set.Tables.Remove(data);
                                        if (workBook is null)
                                        {
                                            workBook = new DataSet(fileName);
                                        }
                                        data.TableName = safeName + s + "-" + f;
                                        //MessageBox.Show(data.TableName);
                                        workBook.Tables.Add(data);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("this is ( " + safeName + " ) not " + fileName);
                            }
                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Class > Import");
            }
        }
    }
}
