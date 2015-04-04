using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTunesShop
{
    public class Band : Performer, IBand
    {
        private IList<string> members;
        private PerformerType type;
        public Band(string name)
            : base(name)
        {
            this.type = PerformerType.Band;
            this.Members = new List<string>();
        }
        public IList<string> Members
        {
            get 
            {
                return this.members;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Performer members list is null");
                }
                this.members = value;
            }
        }

        public override PerformerType Type
        {
            get 
            {
                return this.type;
            }
        }

        public void AddMember(string memberName)
        {
            if (!string.IsNullOrEmpty(memberName))
            {
                this.Members.Add(memberName);
            }
            else
            {
                throw new ArgumentException("Member name you try to add is null or empty");
            }
        }
    }
}
