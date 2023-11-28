using Newtonsoft.Json;
using System.Text.Json;
using System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace SerializationDz9
{ 
    public class Ability
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("mana_cost")]
        public int? ManaCost { get; set; }

        [JsonPropertyName("cooldown")]
        public int? Cooldown { get; set; }

        public override string ToString()
        {
            return $" \n NameAbility = {Name} => Description = {Description} \n Mana Cost = {ManaCost} {indentation.IndentationText} Cooldown = {Cooldown} ";
        }
        Indentation indentation = new Indentation();
    }
    //string jsonString = "\"abilities\":[{\"name\":\"Swashbuckle\",\"description\":\"Pangolier dashes to a new position, assaulting enemies in the target direction with multiple quick thrusts.\",\"mana_cost\":70,\"cooldown\":20},{\"name\":\"Shield Crash\",\"description\":\"Pangolier jumps in the air and slams back to the ground, damaging and disarming nearby enemies.\",\"mana_cost\":80,\"cooldown\":13},{\"name\":\"Heartpiercer\",\"description\":\"Each attack reduces the target's armor and slows them for a duration.\",\"mana_cost\":0,\"cooldown\":0},{\"name\":\"Rolling Thunder\",\"description\":\"Pangolier curls into a magic-immune ball and rolls out. Enemies hit by the rolling ball are damaged and stunned.\",\"mana_cost\":100,\"cooldown\":60}]}}";

}
