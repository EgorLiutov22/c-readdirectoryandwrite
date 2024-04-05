using System.IO;
using static System.Console;
using System.Text;

namespace SimpleProject
{class Program
 {
 static void Main(string[] args)
 {
 // текущий каталог
 DirectoryInfo dir = new DirectoryInfo(".");
 WriteLine($"Full path to the
 directory:\n{dir.FullName}");
 WriteLine($"Time of creation:
 {dir.CreationTime}");
 WriteLine("\n\tAll directory files:");
 FileInfo[] files = dir.GetFiles(); // все файлы
 
 
 string filePath = "files.txt";
 using (FileStream fs = new FileStream(filePath,
 FileMode.Create))
 {
 using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
 {
 // получаем данные для записи в файл
 
 string writeText = "";
 
 foreach (FileInfo f in files)
 {
 writeText += f.Name;
 }
 
 // записываем данные в файл
 sw.WriteLine(writeText);
 foreach (var item in writeText)
 {
 sw.Write($"{item} ");
 }
 WriteLine("\nData recorded!");
 }
 }
 
 
 
 
 
 
 // в каталоге
 foreach (FileInfo f in files)
 {
 WriteLine(f.Name);
 }
 WriteLine();
 }
 }
}
