using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week_09b_FileIO
{
    public static class MyFiles
    {

        public static String OpenFile(String fileName)
        {
            String content = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    content = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error reading file: " + ex.Message);
            }
            return content;
        }

        public static bool SaveFile(String fileName, String content)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.Write(content);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error writing file: " + ex.Message);
            }
            
            return true;
        }


    }
}
