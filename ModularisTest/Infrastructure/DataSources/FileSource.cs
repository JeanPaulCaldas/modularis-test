using ModularisTest.Domain.Repositories;
using System;
using System.Configuration;
using System.IO;

namespace ModularisTest.Infrastructure.DataSources
{
    internal class FileSource : ILogSource
    {
        public void Log(Message message)
        {
            string logFolder = GetDirectory();
            var logFileName = GetFileName();
            var logFullFilePath = Path.Combine(logFolder, logFileName);
            string stringFileContent = ReadFileContent(logFullFilePath);

            stringFileContent += message.ToString() + Environment.NewLine;
            File.WriteAllText(logFullFilePath, stringFileContent);
        }

        private static string ReadFileContent(string logFullFilePath)
        {
            string stringFileContent = string.Empty;
            if (File.Exists(logFullFilePath))
            {
                stringFileContent = File.ReadAllText(logFullFilePath);
            }

            return stringFileContent;
        }

        private static string GetFileName() => $"LogFile{DateTime.Now.ToShortDateString().Replace("/", ".")}.txt";

        private static string GetDirectory()
        {
            var logFolder = ConfigurationManager.AppSettings["LogFileDirectory"];
            if (string.IsNullOrEmpty(logFolder)) logFolder = Environment.CurrentDirectory;
            if (!Directory.Exists(logFolder)) Directory.CreateDirectory(logFolder);
            return logFolder;
        }
    }
}
