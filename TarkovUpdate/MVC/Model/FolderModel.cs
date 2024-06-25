using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarkovUpdate.MVC.Model
{
    public class FolderModel
    {
        public FolderModel(DirectoryInfo directoryInfo) { 
            _folder = directoryInfo;
        }

        public DirectoryInfo _folder;

    }
}
