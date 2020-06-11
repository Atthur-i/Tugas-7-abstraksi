using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tugas_abstraction.Abstrak;
using Tugas_abstraction.inter;

namespace Tugas_abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertebrata vertebrata;

            vertebrata = new Mamalia();
            vertebrata.Bernapas();

            Console.WriteLine();
            vertebrata = new Pisces();
            vertebrata.Bernapas();

            Console.WriteLine();
            vertebrata = new Amphibia();
            vertebrata.Bernapas();

            Console.WriteLine();
            IVertebrata ivertebrata;

            ivertebrata = new Reptilia();
            ivertebrata.Bernapas();

            Console.WriteLine();
            ivertebrata = new Aves();
            ivertebrata.Bernapas();

            Console.ReadKey();
        }
    }
}
