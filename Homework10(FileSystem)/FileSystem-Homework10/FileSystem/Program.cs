using System;
using System.IO;
using System.Collections.Generic;

string folderPath = @"..\..\..\Files";
string filePath = folderPath + @"\names.txt";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

Console.WriteLine("Enter names or type exit to finish: ");

using (StreamWriter sw = new StreamWriter(filePath, true))
{
    string inputName;
    while (true)
    {
        Console.Write("Name: ");
        inputName = Console.ReadLine();

        if (inputName.ToLower() == "exit")
        {
            break;
        }

        if (!string.IsNullOrWhiteSpace(inputName))
        {
            sw.WriteLine(inputName);
        }
    }
}

string[] lines = File.ReadAllLines(filePath);
List<string> names = new List<string>();

foreach (string line in lines)
{
    string trimmed = line.Trim();
    if (!string.IsNullOrEmpty(trimmed))
    {
        names.Add(trimmed);
    }
}

char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
foreach (char letter in alphabet)
{
    string newFileName = $"namesStartingWith_{letter}.txt";
    string newFilePath = folderPath + $@"\{newFileName}";

    List<string> filteredNames = names.FindAll(name => !string.IsNullOrEmpty(name) && char.ToUpper(name[0]) == letter);

    if (filteredNames.Count > 0)
    {
        List<string> existingNames = new List<string>();


        if (File.Exists(newFilePath))
        {
            string[] existingLines = File.ReadAllLines(newFilePath);
            foreach (string line in existingLines)
            {
                string trimmedLine = line.Trim();
                if (!string.IsNullOrEmpty(trimmedLine))
                {
                    existingNames.Add(trimmedLine);
                }
            }
        }

        using (StreamWriter sw = new StreamWriter(newFilePath, true))
        {
            foreach (string name in filteredNames)
            {
                if (!existingNames.Contains(name))
                {
                    sw.WriteLine(name);
                    existingNames.Add(name);
                }
            }
        }

        Console.WriteLine($"Updated file: {newFileName}");
    }
}