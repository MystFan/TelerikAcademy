

namespace _11.CallPrice
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using _08.Calls;
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private List<Call> callHistory;

        public GSM(string model, string manufacturer, decimal price = 0, string owner = "None")
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.callHistory = new List<Call>();
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Owner name can not be null");
                }
                if (value == "")
                {
                    throw new ArgumentException("Owner name can not be empty string");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Owner name should be more than 2 symbols");
                }
                this.owner = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        public void AddCall(Call call)
        {
            if (call != null)
            {
                this.callHistory.Add(call);
            }
            else
            {
                throw new NullReferenceException("Phone Call can not be null");
            }
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CalcCallsTotalPrice(decimal pricePerMinute)
        {
            decimal result = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                result += (decimal)this.callHistory[i].Duration;
            }
            result = result / 60;
            result *= pricePerMinute;
            return result;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("Mobile phone info");
            info.AppendLine(" *Model: " + this.Model);
            info.AppendLine(" *Manufacturer: " + this.Manufacturer);
            info.AppendLine(" *Price: " + this.Price);
            if (this.Owner == "")
            {
                info.AppendLine(" *Owner: " + this.Owner);
            }
            else
            {
                info.AppendLine(" *Owner: None");
            }
            return info.ToString();
        }
    }
}
