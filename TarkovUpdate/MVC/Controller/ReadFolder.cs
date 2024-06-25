using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TarkovUpdate.MVC.Model;

namespace TarkovUpdate.MVC.Controller
{
    public class ReadFolder
    {
        private DirectoryInfo _folder;
        private FolderModel FolderModel;
        public ReadFolder() { 
            _folder = new DirectoryInfo(GetCurrectPathDirectory());
            FolderModel = new FolderModel(_folder);
        }
        private string GetCurrectPathDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

        public DirectoryInfo FolderInfo()
        {
        return _folder; 
        }

        public FolderModel folderUpdate(FolderModel folderModel) { 
            return FolderModel = folderModel;
        }
    }
}
