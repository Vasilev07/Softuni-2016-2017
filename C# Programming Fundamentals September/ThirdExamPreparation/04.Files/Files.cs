using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    public class Files
    {
        public static void Main(string[] args)
        {
            var filesByRoot = new Dictionary<string, Dictionary<string, long>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var routeParams = Console.ReadLine()
                    .Split('\\');

                var root = routeParams[0];
                var fileWithSize = routeParams[routeParams.Length - 1].Split(';');

                var fileNameWithExtention = fileWithSize[0];
                var fileSize = long.Parse(fileWithSize[1]);

                if (!filesByRoot.ContainsKey(root))
                {
                    filesByRoot.Add(root, new Dictionary<string, long>());
                }
                if (!filesByRoot[root].ContainsKey(fileNameWithExtention))
                {
                    filesByRoot[root].Add(fileNameWithExtention, fileSize);
                }
                filesByRoot[root][fileNameWithExtention] = fileSize;

                var querryParams = Console.ReadLine()
                    .Split(' ');

                var querryExtension = querryParams[0];
                var querryRoot = querryParams[2];
                if (filesByRoot.ContainsKey(querryRoot) )
                {


                    var foundFiles = filesByRoot[querryRoot];

                    foreach (var file in foundFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                    {
                        if (file.Key.EndsWith(querryExtension))
                        {
                            Console.WriteLine("{0} - {1} KB", file.Key, file.Value);
                        }

                    }
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
