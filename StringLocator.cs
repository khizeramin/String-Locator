// ###########################################################################################################################
// ############################################# String Locator ################################################################
// ############################################# ............ ################################################################
// This simple code find the location of a specific string in any text that is input to the program. 
// The program also show the frequency of occurance for that string. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
//  using LINQ_Problems.GenericHelper;

        namespace LINQ_Problems
        {
            public static class Generics
            {       

           static int countEXT= 0; 
            
            static void Main(string[] args)
            {   // Pull out vowels out of this query.
                HashSet<string> uniqueValues = new HashSet<string>();
                string Text = "Such stories, be they framed in terms of Atlantis, " +
                "Zep Tepi, or the Judeo-Christian Biblical deluge, " +
                "are disparaged and offhandedly dismissed by many modern academics. " +
                "But the hallmark of good science and scholarship is to always stick with the evidence, " +
                "following it wherever it may lead, whether or not it contradicts the popular paradigm of the day." +
                " In a sense, both the modern Hobbesian view (that humanity was in a primitive and brutish " +
                "state prior to the rise of civilization about 5000 to 6000 thousand years ago)" +
                " and the classical ancient opinion (that advanced civilizations existed thousands of years earlier)" +
                " may be correct";

            string[] splitTXT = Text.Split();
            var result = from c in splitTXT
            //where c != 'a' || c == 'e'|| c == 'i'|| c == 'o'|| c == 'u'
            where c.ToString() == "dismissed"
            select c;
            int captureInt = 0;
            int savedInt = 0;
            
            bool state = false;
            for(int i=0; i<splitTXT.Length; i++)
            { 
                if (splitTXT[i] == "science")
                {
                    Console.WriteLine(i);
                    captureInt = i;
                    if(captureInt != 0)
                    {
                        //state = true;
                        captureInt = DisplaySwitch(1);

                    }
                    
                }
                 
            }

            Console.WriteLine(captureInt);
            //uniqueValues = result.ToArray();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
             
           
           string HashToArray;
           //uniqueValues = GenericHelper.WordCount(result));
            
            //HashToArray = result.ToString();   
            //foreach (var newArray in result)
            //{    
            //    Console.WriteLine(newArray + " Total Count: " + newArray);
            //}
            //Console.WriteLine(uniqueValues);
        }
        // An extension method to convert an IEnumerable to a HashSet<>..

        public static int  DisplaySwitch( int count)
        {
            
            countEXT +=  count;

            //Console.WriteLine("The count is: " + count);

            return countEXT;
        }
        

    }
}


