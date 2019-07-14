using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileParserNetStandard {
    public class FileHandler {
       
        public FileHandler() { }

        /// <summary>
        /// Reads a file returning each line in a list.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
            public List<string> ReadFile(string filePath) {
                List<string> lines = new List<string>();

                return File.ReadAllLines(filePath).ToList();
            }

        
        /// <summary>
        /// Takes a list of a list of data.  Writes to file, using delimeter to seperate data.  Always overwrites.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="delimeter"></param>
        /// <param name="rows"></param>
        public void WriteFile(string filePath, char delimeter, List<List<string>> rows) {

            File.WriteAllLines(filePath, rows.Select(b => String.Join(delimeter.ToString(), b)));

        }
        
        /// <summary>
        /// Takes a list of strings and seperates based on delimeter.  Returns list of list of strings seperated by delimeter.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="delimeter"></param>
        /// <returns></returns>
        public List<List<string>> ParseData(List<string> data, char delimeter) {
            //return new List<List<string>>();  //-- return result here
            return data.Select(a => a.Split(delimeter).ToList()).ToList();
        }
        
        /// <summary>
        /// Takes a list of strings and seperates on comma.  Returns list of list of strings seperated by comma.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> ParseCsv(List<string> data) {
            // return new List<List<string>>();  //-- return result here
            return ParseData(data, ',');
        }
    }
}