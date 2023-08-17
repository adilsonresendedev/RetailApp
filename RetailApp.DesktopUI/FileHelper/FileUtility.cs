using Microsoft.Win32;
using System.IO;

namespace RetailApp.DesktopUI.FileHelper
{
    public static class FileUtility
    {
        public static string GetStringFromXml()
        {
            string xmlString = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*\";";

            if (openFileDialog.ShowDialog() == true)
            {
                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                {
                    xmlString = streamReader.ReadToEnd();
                }
            }

            return xmlString;
        }
    }
}
