using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarkovUpdate.MVC.Controller;
using TarkovUpdate.MVC.Model;
using TarkovUpdate.MVC.View;

namespace TarkovUpdate
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReadFolder readFolder = new ReadFolder();
            GitHubApiController gitHubApiController = new GitHubApiController();
            FolderModel folderModel = new FolderModel(readFolder.FolderInfo());
            FolderInformationView folderView = new FolderInformationView(folderModel);

        }
    }
}
