using System;

namespace Microsoft_Learn
{
    internal class SecoundClass
    {
        // Listas e Coleções
        public void DecimoSegundo()
        {
            List<string> names = ["<name>", "Ana", "Felipe"];

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
