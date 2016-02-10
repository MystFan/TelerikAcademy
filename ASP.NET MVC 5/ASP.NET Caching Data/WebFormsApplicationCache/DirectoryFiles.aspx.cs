using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApplicationCache
{
    public partial class DirectoryFiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public List<string> GetFilePaths()
        {
            List<string> cacheResult = this.Cache["files"] as List<string>;

            if (cacheResult == null)
            {
                var filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                List<string> files = new List<string>();
                if (!File.Exists(filePath))
                {
                    files = Directory.GetFiles(filePath).ToList();
                }

                cacheResult = files;
                var dependency = new CacheDependency(filePath);
                var content = files;
                Cache.Insert("files", content, dependency);
            }

            return cacheResult as List<string>;
        }
    }
}