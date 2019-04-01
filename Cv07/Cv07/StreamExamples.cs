using System;
using System.IO;

namespace Cv07
{
    public class StreamExamples
    {
        public static void FileExamples()
        {
            const string testPath01 = "test.txt";

            if (!File.Exists(testPath01))
            {
                //FileStream test1 = File.Create(testPath01, sizeof(int) * 100);
                //test1.Flush();

                using (StreamWriter sw = File.CreateText(testPath01))
                {
                    sw.Write("test text");
                }

                FileInfo fileInfoTets1 = new FileInfo(testPath01);

                if (fileInfoTets1.Exists)
                {
                    var sw = fileInfoTets1.Create();
                    sw.Close();
                }

                DriveInfo di = new DriveInfo("C");
               var freeSpace = di.TotalFreeSpace;
            }

        }
    }
}
