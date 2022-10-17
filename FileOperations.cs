using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Maya
{
    public class FileOperations
    {
        public string ReadFilePath { get; set; }
        public string WriteFilePath { get; set; }
        public FileOperations(string readFilePath, string writeFilePath)
        {
            ReadFilePath = readFilePath;
            WriteFilePath = writeFilePath;
        }

        #region Output to file
        #region Write to file
        public void Write(string content, bool isAppend = false)
        {
            try
            {
                using (var streamWriter = new StreamWriter(WriteFilePath, isAppend))
                {
                    streamWriter.Write(content);
                }
            }
            catch (Exception)
            {

            }
        }
        public void Write(char content, bool isAppend = false)
        {
            try
            {
                using (var streamWriter = new StreamWriter(WriteFilePath, isAppend))
                {
                    streamWriter.Write(content);
                }
            }
            catch (Exception)
            {

            }
        }
        public void Write(float content, bool isAppend = false)
        {
            try
            {
                using (var streamWriter = new StreamWriter(WriteFilePath, isAppend))
                {
                    streamWriter.Write(content);
                }
            }
            catch (Exception)
            {

            }
        }
        public void Write(int content, bool isAppend = false)
        {
            try
            {
                using (var streamWriter = new StreamWriter(WriteFilePath, isAppend))
                {
                    streamWriter.Write(content);
                }
            }
            catch (Exception)
            {

            }
        }
        #endregion
        #region Write on new line

        /// <summary>
        /// Writes to a new line
        /// </summary>
        /// <param name="content"></param>
        /// <param name="isAppend"></param>
        public void WriteLine(string content, bool isAppend = false)
        {
            try
            {
                using (var streamWriter = new StreamWriter(WriteFilePath, isAppend))
                {
                    streamWriter.Write($"\n{content}");
                }
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Writes to a new line
        /// </summary>
        /// <param name="content"></param>
        /// <param name="isAppend"></param>
        public void WriteLine(float content, bool isAppend = false)
        {
            try
            {
                using (var streamWriter = new StreamWriter(WriteFilePath, isAppend))
                {
                    streamWriter.Write($"\n{content}");
                }
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Writes to a new line
        /// </summary>
        /// <param name="content"></param>
        /// <param name="isAppend"></param>
        public void WriteLine(int content, bool isAppend = false)
        {
            try
            {
                using (var streamWriter = new StreamWriter(WriteFilePath, isAppend))
                {
                    streamWriter.Write($"\n{content}");
                }
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Writes to a new line
        /// </summary>
        /// <param name="content"></param>
        /// <param name="isAppend"></param>
        public void WriteLine(char content, bool isAppend = false)
        {
            try
            {
                using (var streamWriter = new StreamWriter(WriteFilePath, isAppend))
                {
                    streamWriter.Write($"\n{content}");
                }
            }
            catch (Exception)
            {

            }
        }
        #endregion
        #endregion
        #region Input from file
        public Tick[] GetTicks()
        {
            try
            {
                using(var streamReader = new StreamReader(ReadFilePath))
                {
                    List<Tick> tickList = new List<Tick>();

                    while (!streamReader.EndOfStream)
                    {
                        tickList.Add(new Tick(streamReader.ReadLine().Split('|')));
                    }

                    return tickList.ToArray();
                }
            }
            catch (Exception)
            {
                return Array.Empty<Tick>();
            }
        }
        #endregion
    }
}
