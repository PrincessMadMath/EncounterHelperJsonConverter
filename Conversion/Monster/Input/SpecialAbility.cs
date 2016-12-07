
namespace Converter
{
    public class SpecialAbility
    {

        public string Name { get; set; }
        public string desc { get; set; }

        public string attack_bonus { get; set; }


        public TargetSpecialAbility Convert()
        {
            return new TargetSpecialAbility()
            {
                Name = this.Name,
                Desc = this.desc,
                AttackBonus = this.attack_bonus,
            };
        }
    }

}
