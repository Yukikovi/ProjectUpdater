using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarkovUpdate.MVC.Model;

namespace TarkovUpdate.MVC.View
{
    public class FolderInformationView
    {
        private FolderModel _folderModel;
        public FolderInformationView(FolderModel folderModel) { 
            _folderModel = folderModel;
        } 

        public void FolderViewInfo()
        {
            Console.WriteLine(_folderModel._folder.FullName);
        }
    }
}
