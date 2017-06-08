///////////////////////////////////////////////////////
//
// Weston Buck  Colby Dial
// Program 2
// Get user input and return response from server
//
///////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Assignment2
{
    class Program
    {

        static void Main(string[] args)
        {
            string input="" , WebString = "";
            
            //wrUrl is a webrequest(gets response from server), webStream is the connections to that server we will
            //use to get the response.
            WebRequest URL;
            Stream WebStream;
            int i = 0;
             
            // Get user's URI
            Console.WriteLine("Please enter a URI to connect to:");
            input = Console.ReadLine();
            Console.WriteLine("Connecting...");
        
            //  make new request from user input. no code to check if url is correct
            URL = WebRequest.Create(input);
        
            //open up stream to get a response from server
            WebStream = URL.GetResponse().GetResponseStream();

            //make a reader variable that will read the server's response
            StreamReader Reader = new StreamReader(WebStream);
        
            //read response from website
            while (WebString != null)
            {
                i++;
                WebString = Reader.ReadLine();
                if (WebString != null)
                {
                    //line #
                    //Console.WriteLine("{0} {1}", "Line " + i+ ":", WebString);
                    
                    //no line #
                    Console.WriteLine(WebString);
                }
            }

            Console.WriteLine("\nEnd of HTML file\n");

            //close stream
            Reader.Close();
            WebStream.Close();
              
        }
    }
}
