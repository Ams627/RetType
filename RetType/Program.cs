using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace RetType
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var n = GetL<int>();
            }
            catch (Exception ex)
            {
                var fullname = System.Reflection.Assembly.GetEntryAssembly().Location;
                var progname = Path.GetFileNameWithoutExtension(fullname);
                Console.Error.WriteLine($"{progname} Error: {ex.Message}");
            }

        }

        private static object GetL<T>()
        {
            var ret = Get();
            return ret is T t ? t : throw new Exception($"Wrong type - expected {typeof(T)} but received {ret.GetType()}");
        }

        private static object Get()
        {
            return 1L;
        }
    }
}
