namespace Converter
{
    public class Action
    {

        public string Name { get; set; }
        public string desc { get; set; }

        public string attack_bonus { get; set; }

        public string damage_dice { get; set; }

        public string damage_bonus { get; set; }

        public TargetAction Convert()
        {
            return new TargetAction(){
                Name = this.Name,
                Desc = this.desc,
                AttackBonus = this.attack_bonus,
                DamageDice = this.damage_dice,
                DamageBonus = this.damage_bonus
            };
        }
    }

}