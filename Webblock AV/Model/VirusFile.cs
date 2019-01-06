using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webblock_AV.Model
{
    class VirusFile
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
