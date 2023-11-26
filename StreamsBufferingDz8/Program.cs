namespace StreamsBufferingDz8
{
    using System.Text;

    internal class Program
    {
        //Объедините две предыдущих работы(практические работы 2 и 3):
        //поиск файла и поиск текста в файле написав утилиту
        //которая ищет файлы определенного расширения с указанным текстом.
        //Рекурсивно.Пример вызова утилиты: utility.exe txt текст.
        static void Main(string[] args)
        {
            WriteFile writeFile = new WriteFile();
            ReaderFile readerFile = new ReaderFile();
            SearchFileToCatalog searchFileAndText = new SearchFileToCatalog();

            string searchFileName = "1.txt";
            string searchText = "Hello world!";

            string pathFile = searchFileAndText.SearchFile(searchFileName);
            //writeFile.WriteMyFile(pathFile);
            readerFile.ReaderMyFile(pathFile, searchText);
            

 

        }
    }
}
