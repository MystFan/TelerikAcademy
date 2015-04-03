using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class WeaponrySkill : Supplement
    {
        private const int WeaponrySkillPower = 0;
        private const int WeaponrySkillAggression = 0;
        private const int WeaponrySkillHealth = 0;
        public WeaponrySkill()
            : base(WeaponrySkill.WeaponrySkillHealth, WeaponrySkill.WeaponrySkillPower, WeaponrySkill.WeaponrySkillAggression)
        {

        }
    }
}
