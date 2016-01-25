using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Countries
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Message.Visible = false;          
        }

        protected void ListViewTowns_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {
            foreach (DictionaryEntry entry in e.NewValues)
            {
                var value = entry.Value as string;
                switch (entry.Key as string)
                {
                    case "Name":
                        if (value == null || value.Length < 2 || value.Length > 50)
                        {
                            Cancel(e, "Town name must be between 2 and 50 characters long");
                            return;
                        }
                        break;
                    case "Population":
                        int population;
                        int.TryParse(value, out population);
                        if (population == 0)
                        {
                            Cancel(e, "Town name must be between 2 and 50 characters long");
                            return;
                        }
                        break;
                }
            }
        }

        protected void ListViewTowns_ItemInserting(object sender, ListViewInsertEventArgs e)
        {
            foreach (DictionaryEntry entry in e.Values)
            {
                var value = entry.Value as string;
                switch (entry.Key as string)
                {
                    case "Name":
                        if (value == null || value.Length < 2 || value.Length > 50)
                        {
                            Cancel(e, "Town name must be between 2 and 50 characters long");
                            return;
                        }
                        break;
                    case "Population":
                        int population;
                        int.TryParse(value, out population);
                        if (population == 0)
                        {
                            Cancel(e, "Town population is too large or value is not a number");
                            return;
                        }
                        break;
                }
            }
        }

        protected void ListViewCountries_ItemUpdating(object sender, ListViewUpdateEventArgs ev)
        {
            FileUpload FlagFileUpload = (FileUpload)this.ListViewCountries.EditItem.FindControl("FlagUpdateFileUpload");
            if (FlagFileUpload.PostedFile != null)
            {
                HttpPostedFile currentFile = FlagFileUpload.PostedFile;
                int currentFileContentLength = currentFile.ContentLength;
                if (currentFileContentLength == 0)
                {
                    return;
                }

                if (currentFileContentLength > 100000)
                {
                    Cancel(ev, "Country flag image size its to large");
                    return;
                }

                if (Path.GetExtension(currentFile.FileName).ToLower() != ".png")
                {
                    Cancel(ev, "Country flag image must be .png file");
                    return;
                }

                byte[] currentFileData = new Byte[currentFileContentLength];
                currentFile.InputStream.Read(currentFileData, 0, currentFileContentLength);

                string currentFileFilename = Path.GetFileName(currentFile.FileName);
                ev.NewValues.Add("Flag", currentFileData);
            }

            foreach (DictionaryEntry entry in ev.NewValues)
            {
                var value = entry.Value as string;
                switch (entry.Key as string)
                {
                    case "Name":
                        if (value == null || value.Length < 2 || value.Length > 50)
                        {
                            Cancel(ev, "Country name must be between 2 and 50 characters long");
                            return;
                        }
                        break;
                    case "Population":
                        int population;
                        int.TryParse(value, out population);
                        if (population == 0)
                        {
                            Cancel(ev, "Country population is too large or value is not a number");
                            return;
                        }
                        break;
                    case "Language":
                        if (value == null || value.Length < 2 || value.Length > 50)
                        {
                            Cancel(ev, "Country language must be between 2 and 50 characters long");
                            return;
                        }
                        break;
                }
            }
        }

        protected void ListViewCountries_ItemInserting(object sender, ListViewInsertEventArgs ev)
        {
            FileUpload FlagFileUpload = (FileUpload) this.ListViewCountries.InsertItem.FindControl("FlagFileUpload");
            if (FlagFileUpload.PostedFile != null)
            {
                HttpPostedFile currentFile = FlagFileUpload.PostedFile;
                int currentFileContentLength = currentFile.ContentLength;
                if (currentFileContentLength == 0)
                {
                    return;
                }

                if (currentFileContentLength > 100000)
                {
                    Cancel(ev, "Country flag image size its to large");
                    return;
                }

                if (Path.GetExtension(currentFile.FileName).ToLower() != ".png")
                {
                    Cancel(ev, "Country flag image must be .png file");
                    return;
                }

                byte[] currentFileData = new Byte[currentFileContentLength];
                currentFile.InputStream.Read(currentFileData, 0, currentFileContentLength);

                string currentFileFilename = Path.GetFileName(currentFile.FileName);
                ev.Values.Add("Flag", currentFileData);
            }

            foreach (DictionaryEntry entry in ev.Values)
            {
                var value = entry.Value as string;

                switch (entry.Key as string)
                {
                    case "Name":
                        if (value == null || value.Length < 2 || value.Length > 50)
                        {
                            Cancel(ev, "Country name must be between 2 and 50 characters long");
                            return;
                        }
                        break;
                    case "Population":
                        int population;
                        int.TryParse(value, out population);
                        if (population == 0)
                        {
                            Cancel(ev, "Country population is too large or value is not a number");
                            return;
                        }
                        break;
                    case "Language":
                        if (value == string.Empty || value.Length > 50)
                        {
                            Cancel(ev, "Country language must be between 2 and 50 characters long");
                            return;
                        }
                        break;
                }
            }
        }

        protected void ListViewUpdateContinents_ItemUpdating(object sender, ListViewUpdateEventArgs ev)
        {
            foreach (DictionaryEntry entry in ev.NewValues)
            {
                var value = entry.Value as string;
                var key = entry.Key as string;

                if(key == "Name")
                {
                    if (value == null || value.Length < 2 || value.Length > 50)
                    {
                        Cancel(ev, "Continent name must be between 2 and 50 characters long");
                        return;
                    }
                }
            }
        }

        protected void ListViewUpdateContinents_ItemInserting(object sender, ListViewInsertEventArgs ev)
        {
            foreach (DictionaryEntry entry in ev.Values)
            {
                var value = entry.Value as string;
                var key = entry.Key as string;

                if (key == "Name")
                {
                    if (value == null || value.Length < 2 || value.Length > 50)
                    {
                        Cancel(ev, "Continent name must be between 2 and 50 characters long");
                        return;
                    }
                }
            }
        }

        private void Cancel(ListViewInsertEventArgs e, string message)
        {
            e.Cancel = true;
            this.Message.InnerText = message;
            this.Message.Visible = true;
        }

        private void Cancel(ListViewUpdateEventArgs e, string message)
        {
            e.Cancel = true;
            this.Message.InnerText = message;
            this.Message.Visible = true;
        }

        public string ProcessMyDataItem(object value)
        {
            if (value == null)
            {
                return "~/images/flag.png";
            }

            string flagUrl = "data:image/jpeg;base64," + Convert.ToBase64String((byte[])value);
            return flagUrl;
        }
    }
}