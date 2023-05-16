namespace RetailApp.Utility
{
    public static class FileUtility
    {
        public static string GetStringFromXml()
        {
            string xmlString = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*\";";
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
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
