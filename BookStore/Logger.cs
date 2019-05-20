using System;
using System.Dynamic;
using System.IO;

namespace BookStore {
    public class Logger {
        
        private static readonly Lazy<Logger> lazy = new Lazy<Logger>(() => new Logger());
        private string _LogPath;
        public StreamWriter Writer { get; set; }
        public string LogFileName { get; set; }
        public string LogFileExtension { get; set; }
        public string LogPath {
            get { return _LogPath ?? (_LogPath = AppDomain.CurrentDomain.BaseDirectory); }
            set { _LogPath = value; }
        }

        public static Logger Instance {
            get { return lazy.Value; }
        }

        internal Logger() {
            LogFileName = "LibraryHistory";
            LogFileExtension = ".txt";
        }

        public string LogAbsolutePath {
            get { return Path.Combine(LogPath, LogFileName + LogFileExtension); }
        }
        
        

        public bool isExistent() {
            return File.Exists(LogAbsolutePath);
        }

        public void WriteToLog(string message) {
            if (!Directory.Exists(LogPath)) {
                Directory.CreateDirectory(LogPath);
            }

            if (Writer == null) {
                Writer = new StreamWriter(LogAbsolutePath, true);
            }
            
            Writer.WriteLine("[{0}][{1}] {2} ", String.Format("{0:yyyy/MM/dd HH:mm:ss}", DateTime.Now), "History", message);
            Writer.Flush();
        }

        public static void WriteLine(string message) {
            Instance.WriteToLog(message);
        }
    }
}