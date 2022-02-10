using Lab_4.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    /// <summary>
    /// AlgorithmsMethods class.
    /// </summary>
    public static class AlgorithmsMethods
    {
        /// <summary>
        /// The input path.
        /// </summary>
        private const string InputPath = "Input path to input file: ";

        /// <summary>
        /// Joaats the hash.
        /// </summary>
        /// <returns></returns>
        public static async Task<uint> JOAATHash()
        {
            Console.Write(InputPath);
            var path = Console.ReadLine();

            return await FileWorker.HashFile(path);
        }
    }
}
