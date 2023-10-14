namespace ApplicationDevelopment
{
    //Доработайте приложение генеалогического дерева таким образом чтобы программа выводила
    //на экран близких родственников (жену/мужа). Продумайте способ более красивого вывода с
    //использованием горизонтальных и вертикальных черточек.
    internal class Program
    {

        static void Main(string[] args)
        {
            FamilyMember husband0 = new FamilyMember("Генадий", Gender.Male, null);
            FamilyMember wife0 = new FamilyMember("Афросья", Gender.Female, null);
            FamilyMember child0 = new FamilyMember("Светлана", Gender.Female, null);
            husband0.spouse = wife0;
            wife0.spouse = husband0;
            wife0.children.Add(child0);
            husband0.children.Add(child0);

            Indentation indentation = new Indentation();

            Console.WriteLine("Семья 0:");
            Console.WriteLine($"{indentation.indentation10}Муж - {husband0.Name} пол: {husband0.gender}");
            if (husband0.spouse != null)
            {

                Console.WriteLine($"{indentation.indentation10}Жена - {husband0.spouse.Name} пол: {husband0.spouse.gender}");
            }

            foreach (FamilyMember c in wife0.children)
            {
                Console.WriteLine($"{indentation.indentation20}{indentation.indentation10}Ребенок - {c.Name} пол: {c.gender}\n " +
                    $"{indentation.indentation40}{indentation.indentation10}Родитель: {wife0.Name} ");
            }

            foreach (FamilyMember c in husband0.children)
            {
                Console.WriteLine($"{indentation.indentation20}{indentation.indentation10}Ребенок - {c.Name} пол: {c.gender}\n " +
                    $"{indentation.indentation40}{indentation.indentation10}Родитель: {husband0.Name}");
            }




            FamilyMember husband = new FamilyMember("Валера", Gender.Male, null);
            FamilyMember wife = new FamilyMember("Светлана", Gender.Female, null);
            FamilyMember child = new FamilyMember("Егор", Gender.Male, null);
            FamilyMember child1 = new FamilyMember("Оля", Gender.Female, null);
            husband.spouse= wife;
            wife.spouse = husband;
            wife.children.Add(child1);

            
            Console.WriteLine();
            Console.WriteLine($"{indentation.indentation40}Семья 1:");
            Console.WriteLine($"{indentation.indentation40}{indentation.indentation10}Жена - {wife.Name} пол: {wife.gender}");
            
            if (wife.spouse != null && husband.spouse != null)
            {
                Console.WriteLine($"{indentation.indentation40}{indentation.indentation10}Муж - {wife.spouse.Name} пол: {wife.spouse.Name}");
                wife.children.Add(child);
                husband.children.Add(child);

                foreach (FamilyMember c in husband.children)
                {
                    Console.WriteLine($"{indentation.indentation60}{indentation.indentation10}Ребенок - {c.Name} пол: {c.gender}\n " +
                        $"{indentation.indentation80}{indentation.indentation10}Родитель: {husband.Name}");
                }
            }
            else
            {
                Console.WriteLine($"{indentation.indentation40}{indentation.indentation10}Сейчас мужа у {wife.Name} нет.");
            }

            FamilyMember anotherMarriage = null;
            foreach (FamilyMember c in wife.children) 
            {
                if (c.Name == "Оля")
                {
                     anotherMarriage = c;
                }
                else
                {
                    Console.WriteLine($"{indentation.indentation60}{indentation.indentation10}Ребенок - {c.Name} пол: {c.gender}\n " +
                        $"{indentation.indentation80}{indentation.indentation10}Родитель: {wife.Name} ");

                }

               

            }
            if (anotherMarriage != null)
            {
                Console.WriteLine($"{indentation.indentation60}{indentation.indentation20}Ребенок от другого брака: {wife.Name}");
                Console.WriteLine($"{indentation.indentation60}{indentation.indentation10}Ребенок - {anotherMarriage.Name} пол: {anotherMarriage.gender}\n" +
                    $" {indentation.indentation80}{indentation.indentation10}Родитель: {wife.Name} ");

            }





        }
    }
}