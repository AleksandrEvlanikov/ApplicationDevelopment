


using System.Text.Json;
using System.Xml.Serialization;

namespace SerializationDz9
{
    internal class Program
    {
        //Напишите приложение, конвертирующее произвольный JSON в XML.Используйте JsonDocument.
        static void Main(string[] args)
        {
            string jsonString = File.ReadAllText("C:\\Users\\aleks\\OneDrive\\Рабочий стол\\C#pog\\ApplicationDevelopment\\SerializationDz9\\json1.json");
            Hero? hero = JsonSerializer.Deserialize<Hero>(jsonString);

            Console.WriteLine("Json в обьект C#");
            Console.WriteLine(hero);

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Обьект C# в XML");

            var jsonToXML = new XmlSerializer(typeof(Hero));
            jsonToXML.Serialize(Console.Out, hero);
        }

    }
}
