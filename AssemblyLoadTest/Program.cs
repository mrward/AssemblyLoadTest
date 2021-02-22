using System;
using System.IO;
using System.Reflection;

namespace AssemblyLoadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
#if NET472
                Console.WriteLine(".NET 4.7.2");
#else
                Console.WriteLine(".NET 5");
#endif
                Load();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void Load()
        {
            string fileName = Path.Combine("..", "..", "..", "..", "LibBin", "Lib2.dll");
            fileName = Path.GetFullPath(fileName);
            Assembly.LoadFrom(fileName);

            Assembly assembly = Assembly.LoadFile(fileName);

            foreach (var type in assembly.GetTypes())
            {
                Console.WriteLine(type.Name);
            }
        }
    }
}
