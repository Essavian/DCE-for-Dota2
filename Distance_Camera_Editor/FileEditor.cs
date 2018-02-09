using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Camera_Editor
{
    public class FileEditor
    {
        private static string line;
        public static string sourceFileName;
        public static string copyFileName;

        public static void ModifyClient(string initPath, string oldValue, string newValue)
        {
            sourceFileName = initPath + "client.dll";
            copyFileName = initPath + "client_backup.dll";
            BackupFile(sourceFileName, copyFileName);
            using (StreamReader streamReader = new StreamReader(sourceFileName, Encoding.GetEncoding("windows-1252")))
            {
                line = streamReader.ReadToEnd();
                streamReader.Close();
            }
            line = line.Replace(oldValue, newValue);
            using (StreamWriter streamWriter = new StreamWriter(sourceFileName, false, Encoding.GetEncoding("windows-1252")))
            {
                streamWriter.Write(line);
                streamWriter.Close();
            }
        }

        private static void BackupFile(string sourceFileName, string copyFileName)
        {
            File.Copy(sourceFileName, copyFileName, true);
        }
    }
}
