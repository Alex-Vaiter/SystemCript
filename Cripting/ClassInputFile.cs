using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Cripting
{
    class ClassInputFile
    {
        private string Input;
        private OpenFileDialog openFile;
        public ClassInputFile()
        {
            openFile = new OpenFileDialog();
            openFile.CheckFileExists = true;
            openFile.Multiselect = false;
        }

        public String GetText()
        {
            
            try
            {
                openFile.ShowDialog();

                StreamReader reader = new StreamReader(openFile.FileName, Encoding.GetEncoding(1251));
                Input = reader.ReadToEnd();
                reader.Close();

                if (Input != null)
                {
                    return Input;
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                MessageBox.Show("Ошибка открытия файла");
                return "";
            }
        }
    }
}
