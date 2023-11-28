


using Newtonsoft.Json;
using SerializationDz9;
using System.Data;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace SerializationDz9
{

    
    public class Hero
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("primary_attribute")]
        public string? PrimaryAttribute { get; set; }

        [JsonPropertyName("roles")]
        public List<string>? Roles { get; set; }

        [JsonPropertyName("base_health")]
        public int? BaseHealth { get; set; }

        [JsonPropertyName("base_mana")]
        public int? BaseMana { get; set; }

        [JsonPropertyName("attack_damage")]
        public int? AttackDamage { get; set; }

        [JsonPropertyName("armor")]
        public int? Armor { get; set; }

        [JsonPropertyName("abilities")]
        public List<Ability>? Abilities { get; set; }

        public override string ToString()
        {
            return $" Name = {Name} {indentation.IndentationText} Attribute = {PrimaryAttribute} {indentation.IndentationText} Role = {string.Join(", ", Roles)} \n Health = {BaseHealth} {indentation.IndentationText} Mana = {BaseMana} {indentation.IndentationText} Attack damage = {AttackDamage} {indentation.IndentationText} Armor = {Armor} \n Capabilities {string.Join(", ", Abilities)} \n";
        }

        Indentation indentation = new Indentation();
    }



    public class Root
    {
        public Hero hero { get; set; }
    }

}


//string jsonString = "{\"hero\":{\"name\":\"Pangolier\",\"primary_attribute\":\"Agility\",\"roles\":[\"Carry\",\"Nuker\",\"Disabler\",\"Durable\"],\"base_health\":200,\"base_mana\":75,\"attack_damage\":49,\"armor\":1,\"abilities\":[{\"name\":\"Swashbuckle\",\"description\":\"Pangolier dashes to a new position, assaulting enemies in the target direction with multiple quick thrusts.\",\"mana_cost\":70,\"cooldown\":20},{\"name\":\"Shield Crash\",\"description\":\"Pangolier jumps in the air and slams back to the ground, damaging and disarming nearby enemies.\",\"mana_cost\":80,\"cooldown\":13},{\"name\":\"Heartpiercer\",\"description\":\"Each attack reduces the target's armor and slows them for a duration.\",\"mana_cost\":0,\"cooldown\":0},{\"name\":\"Rolling Thunder\",\"description\":\"Pangolier curls into a magic-immune ball and rolls out. Enemies hit by the rolling ball are damaged and stunned.\",\"mana_cost\":100,\"cooldown\":60}]}}";
