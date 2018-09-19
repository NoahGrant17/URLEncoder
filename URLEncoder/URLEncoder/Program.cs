using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of the project?");
            var project_name = Console.ReadLine();

            Console.WriteLine("What is your name?");
            var activity_name = Console.ReadLine();

            project_name = MakeURLencoder(project_name);
            activity_name = MakeURLencoder(activity_name);

            var URL = $"https://companyserver.com/content/{project_name}/files/{activity_name}/{activity_name}Report.pdf";
            Console.WriteLine($"{URL}");
            Console.WriteLine("End");
            Console.ReadKey();
        }

        public static string MakeURLencoder(string url)
        {
            string url2 = "";
            
            for (int x = 0; x < url.Length; ++x)
            {               
                if (url[x] == ';')
                {
                    url2 = url2 + "%3B";                                     
                }
                 else if (url[x] == '/')
                 {
                     url2 = url2 + "%2F";
                 }
                 else if (url[x] == '?')
                 {
                    url2 = url2 + "%3F";
                 }
                 else if (url[x] == ':')
                 {
                    url2 = url2 + "%3A";
                 }
                 else if (url[x] == '@')
                 {
                     url2 = url2 + "%40";
                 }
                 else if (url[x] == '&')
                 {
                    url2 = url2 + "%26";
                 }
                 else if (url[x] == '=')
                 {
                    url2 = url2 + "%3D";
                 }
                 else if (url[x] == '+')
                 {
                    url2 = url2 + "%2B";
                 }
                 else if (url[x] == '$')
                 {
                    url2 = url2 + "%24";
                 }
                 else if (url[x] == '{')
                 {
                    url2 = url2 + "%7B";
                 }
                 else if (url[x] == '}')
                 {
                    url2 = url2 + "%7D";
                 }
                 else if (url[x] == '|')
                 {
                    url2 = url2 + "%7C";
                 }
                  else if (url[x] == '\\')
                 {
                    url2 = url2 + "%5C";
                 }
                 else if (url[x] == '^')
                 {
                    url2 = url2 + "%5E";
                 }
                 else if (url[x] == '[')
                 {
                    url2 = url2 + "%5B";
                 }
                 else if (url[x] == ']')
                 {
                    url2 = url2 + "%5D";
                 }              
                 else if (url[x] == ' ')
                 {
                    url2 = url2 + "%%20";
                 }
                else
                {
                    url2 = url2 + url[x];                    
                }                
            }           
            return url2;
        }
    }
}