using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3_1
{
  
    internal class Program
        {
            static void Main(string[] args)
        {
                string location = @"C:\Users\User\OneDrive\Documents\M.text";

                FileInfo file = new FileInfo(location);

                using (StreamReader sr = new StreamReader(location))
                {
                    string line = sr.ReadLine();

                    while (line != null)
                    {
                        Console.WriteLine("Number of words: " + CountWords(line));

                      
                        line = sr.ReadLine();
                    }
                }
            }

            static int CountWords(string line)
            {
                int count = 0;

                foreach (char c in line)
                {
                    if (c == ' ')
                    {
                        count++;
                    }
                }

               
                return count + 1;
            }
        }


    }

