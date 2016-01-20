namespace StudentsRegistrationForm
{
    using System;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;

    public partial class RegistrationForm : System.Web.UI.Page
    {
        private static string[] courses;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (courses != null)
            {
                GenerateDropDownList(courses);
            }
            else
            {
                courses = new string[]
                {
                    "JavaScript developer",
                    "Angular Developer",
                    "Node JS Developer",
                    "iOS Developer",
                    "C# Developer"
                };

                GenerateDropDownList(courses);
            }
        }


        protected void DropDownListUni_TextChanged(object sender, EventArgs e)
        {

            if (this.DropDownListUni.SelectedItem.Text == "University of Oxford")
            {
                courses = new string[]
                {
                    "JavaScript developer",
                    "iOS Developer",
                    "C# Developer"
                };

                if (this.FormContent.FindControl("DropDownListSpec") != null)
                {
                    var dropdown = (DropDownList)this.FormContent.FindControl("DropDownListSpec");
                    this.FormContent.Controls.Remove(dropdown);
                }

                GenerateDropDownList(courses);
            }

            if (this.DropDownListUni.SelectedItem.Text == "Harvard University")
            {
                courses = new string[]
                {
                    "Administrative Law",
                    "Children's Rights",
                    "Citizenship Guide: Information on Hiring for Non-Citizens",
                    "Civil Rights/Civil Liberties",
                    "Conservative Public Interest Law"
                };

                if (this.FormContent.FindControl("DropDownListSpec") != null)
                {
                    var dropdown = (DropDownList)this.FormContent.FindControl("DropDownListSpec");
                    this.FormContent.Controls.Remove(dropdown);
                }

                GenerateDropDownList(courses);
            }

            if (this.DropDownListUni.SelectedItem.Text == "Stanford University")
            {
                courses = new string[]
                {
                    "Photonics, Solid State and Electromagnetics",
                    "Signal Processing, Communications and Controls",
                    "Energy and Environment",
                    "Computer Software",
                    "Computer Hardware"
                };

                if (this.FormContent.FindControl("DropDownListSpec") != null)
                {
                    var dropdown = (DropDownList)this.FormContent.FindControl("DropDownListSpec");
                    this.FormContent.Controls.Remove(dropdown);
                }

                GenerateDropDownList(courses);
            }
        }

        private void GenerateDropDownList(string[] items)
        {
            DropDownList dropdownList = new DropDownList();
            dropdownList.ID = "DropDownListSpec";
            dropdownList.Attributes.Add("runat", "server");
            dropdownList.AutoPostBack = true;

            for (int i = 0; i < items.Length; i++)
            {
                ListItem listItem = new ListItem();
                listItem.Value = items[i];
                listItem.Text = items[i];
                dropdownList.Items.Add(listItem);
            }

            if (this.FormContent.FindControl("LabelSpecialties") != null)
            {
                var labelSpecialties = this.FormContent.FindControl("LabelSpecialties");
                this.FormContent.Controls.Remove(labelSpecialties);
            }

            Label label = new Label();
            label.Text = "Specialties: ";
            label.Attributes.Add("runat", "server");
            label.ID = "LabelSpecialties";
            this.FormContent.Controls.Add(label);
            this.FormContent.Controls.Add(dropdownList);
        }

        private void GenerateMultiSelectList(string[] items)
        {
            ListBox listBox = new ListBox();
            listBox.ID = "ListBoxCourses";
            listBox.Attributes.Add("runat", "server");
            listBox.SelectionMode = ListSelectionMode.Multiple;

            for (int i = 0; i < items.Length; i++)
            {
                ListItem listItem = new ListItem();
                listItem.Value = items[i];
                listItem.Text = items[i];
                listBox.Items.Add(listItem);
            }

            this.FormContent.Controls.Add(listBox);
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            var studentInfo = new HtmlGenericControl("div");
            var h1 = new HtmlGenericControl("h1");
            h1.InnerText = "Student Profile";
            studentInfo.Controls.Add(h1);

            var labelFN = new HtmlGenericControl("label");
            labelFN.InnerText = "First name: ";
            studentInfo.Controls.Add(labelFN);

            var strongFN = new HtmlGenericControl("strong");
            strongFN.InnerText = this.TextBoxFirstName.Text;
            studentInfo.Controls.Add(strongFN);
            studentInfo.Controls.Add(new HtmlGenericControl("br"));

            var labelSN = new HtmlGenericControl("label");
            labelSN.InnerText = "Second name: ";
            studentInfo.Controls.Add(labelSN);

            var strongSN = new HtmlGenericControl("strong");
            strongSN.InnerText = this.TextBoxSecondName.Text;
            studentInfo.Controls.Add(strongSN);
            studentInfo.Controls.Add(new HtmlGenericControl("br"));

            var labelUni = new HtmlGenericControl("label");
            labelUni.InnerText = "University: ";
            studentInfo.Controls.Add(labelUni);

            var strongUni = new HtmlGenericControl("strong");
            strongUni.InnerText = this.DropDownListUni.SelectedItem.Text;
            studentInfo.Controls.Add(strongUni);
            studentInfo.Controls.Add(new HtmlGenericControl("br"));

            var labelSpec = new HtmlGenericControl("label");
            labelSpec.InnerText = "Specialty: ";
            studentInfo.Controls.Add(labelSpec);

            var strongSpec = new HtmlGenericControl("strong");
            DropDownList dropdownList = (DropDownList)this.FormContent.FindControl("DropDownListSpec");
            strongSpec.InnerText = dropdownList.SelectedItem.Value;
            studentInfo.Controls.Add(strongSpec);
            studentInfo.Controls.Add(new HtmlGenericControl("br"));

            this.Page.Controls.Add(studentInfo);
        }
    }
}