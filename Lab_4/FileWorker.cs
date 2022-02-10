using Lab_4.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    /// <summary>
    /// FileWorker class.
    /// </summary>
    public static class FileWorker
    {
        /// <summary>
        /// Hashes the file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static async Task<uint> HashFile(string path)
        {
            try
            {
                using var streamReader = new StreamReader(new FileStream(path, FileMode.Open));

                if (streamReader.Peek() != -1)
                {
                    var fileContent = await streamReader.ReadToEndAsync();
                    return JOAAT.Hash(fileContent);
                }

                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
