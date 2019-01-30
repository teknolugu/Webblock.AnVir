namespace Webblock_AV.Model
{
    internal class VirusFile
    {
        private string FileName;
        private string FilePath;
        private string VirusType;

        public string fileName
        {
            get
            {
                return FileName;
            }
            set
            {
                FileName = value;
            }
        }

        public string filePath
        {
            get
            {
                return FilePath;
            }
            set
            {
                FilePath = value;
            }
        }

        public string virusType
        {
            get
            {
                return VirusType;
            }
            set
            {
                VirusType = value;
            }
        }
    }
}