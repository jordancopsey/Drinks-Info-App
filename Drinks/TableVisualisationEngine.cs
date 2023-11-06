using ConsoleTableExt;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks
{
    internal class TableVisualisationEngine
    {
        //Generic list of T type can pass a list of any type, as well as a Null check 
        public static void ShowTable<T>(List<T> tableData, [AllowNull] string tableName) where T :
        class
        {
            Console.Clear();

            if (tableName == null)
                tableName = "";
            Console.WriteLine("\n\n");

            ConsoleTableBuilder
                .From(tableData)
                .WithColumn(tableName)
                .WithFormat(ConsoleTableBuilderFormat.Alternative)
                .ExportAndWriteLine(TableAligntment.Center);
            Console.WriteLine("\n\n");
        }
    }
}
