namespace CarsSystem
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using CarsSystem.Models;
    using CarsSystem.Data;

    public partial class CarSeler : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.DropDownListProducers.DataSource = DataSource.GetProducers();
                this.DropDownListModels.DataSource = DataSource.GetProducers().ToList()[0].Models;
                this.CheckBoxListExtres.DataSource = DataSource.GetExtresNames();
                this.Page.DataBind();
            }
        }

        protected void DropDownListProducers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectProducerName = this.DropDownListProducers.SelectedItem.Text;
            this.DropDownListModels.DataSource = DataSource.GetProducers()
                        .Where(p => p.Name == selectProducerName)
                        .FirstOrDefault()
                        .Models;

            this.DropDownListModels.DataBind();
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            ICar car = new Car();
            car.Extres = new Extra();
            car.Producer = Server.HtmlEncode(this.DropDownListProducers.Text);
            car.Model = Server.HtmlEncode(this.DropDownListModels.Text);
            var extras = this.CheckBoxListExtres.Items;
            var engineTypes = this.RadioButtonListEnginType.Items;
            for (int i = 0; i < engineTypes.Count; i++)
            {
                if (engineTypes[i].Selected)
                {
                    car.EngineType = (EngineType)Enum.Parse(typeof(EngineType), engineTypes[i].Value);
                    break;
                }
            }

            for (int i = 0; i < extras.Count; i++)
            {
                if (extras[i].Selected)
                {
                    switch (extras[i].Value)
                    {
                        case "Alarm": car.Extres.HasAlarm = true; break;
                        case "Air Condition": car.Extres.HasAirCondition = true; break;
                        case "Electrical Glasses": car.Extres.HasElectricalGlasses = true; break;
                    }
                }
            }

            DisplayResult(car);
        }

        private void DisplayResult(ICar newCar)
        {
            StringBuilder sb = new StringBuilder();

            var foundedCars = DataSource.GetCars()
                .Where(c => c.Producer == newCar.Producer)
                .Where(c => c.Model == newCar.Model)
                .Where(c => c.EngineType == newCar.EngineType)
                .Where(c => c.Extres.HasAirCondition == newCar.Extres.HasAirCondition)
                .Where(c => c.Extres.HasAlarm == newCar.Extres.HasAlarm)
                .Where(c => c.Extres.HasElectricalGlasses == newCar.Extres.HasElectricalGlasses)
                .ToList();


            for (int i = 0; i < foundedCars.Count; i++)
            {
                sb.AppendLine("<ul><li>Producer: " + foundedCars[i].Producer + "</li>");
                sb.AppendLine("<li>Model: " + foundedCars[i].Model + "</li>");
                sb.AppendLine("<li>Engin Type: " + foundedCars[i].EngineType + "</li>");
                sb.AppendLine("<h6>Extras</h6><ul>");
                sb.AppendLine("<li> HasAirCondition: " + (foundedCars[i].Extres.HasAirCondition ? "Yes" : "No").ToString() + "</li>");
                sb.AppendLine("<li> HasAlarm: " + (foundedCars[i].Extres.HasAlarm ? "Yes" : "No").ToString() + "</li>");
                sb.AppendLine("<li> HasElectricalGlasses: " + (foundedCars[i].Extres.HasElectricalGlasses ? "Yes" : "No").ToString() + "</li></ul></ul>");
                sb.AppendLine("<br/>");
            }

            if (foundedCars.Count == 0)
            {
                this.LiteralContainer.Text = "No results";
            }
            else
            {
                this.LiteralContainer.Text = sb.ToString();
            }
        }
    }
}