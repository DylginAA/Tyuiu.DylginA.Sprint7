using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Tyuiu.DylginA.Sprint7.Project.V5.Lib
{
    public static class DataService
    {
        public static List<string[]> LoadDataFromCsv(string filePath)
        {
            var lines = File.ReadAllLines(filePath, Encoding.UTF8);

            if (lines.Length == 0)
            {
                throw new Exception("Файл пустой!");
            }

            var data = new List<string[]>();
            foreach (var line in lines)
            {
                var cells = line.Split(';');
                data.Add(cells);
            }

            return data;
        }
        public static void SaveDataToCsv(string filePath, List<string[]> data)
        {
            var lines = data.Select(row => string.Join(";", row));
            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }

        public static List<string[]> SearchData(List<string[]> data, string searchText, int columnIndex = -1)
        {
            return data.Where(row =>
                columnIndex == -1 
                ? row.Any(cell => cell != null && cell.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                : row[columnIndex] != null && row[columnIndex].IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0
            ).ToList();
        }

        public static List<string[]> DeleteRows(List<string[]> data, List<int> rowIndicesToDelete)
        {
            return data.Where((row, index) => !rowIndicesToDelete.Contains(index)).ToList();
        }
       
    }
}
