using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


class Program
{
    static void Main()
    {
         int f; //rail feet
            int i; //rail inches
            double rl; //rail length total in inches
            double pc; //amount of panels in rail
            double pcr; //pc rounded up to even panels
            double pl; //equal length of each panel
            double iPL; // interior panel length b/w end grips
            double iPG; //interior panel grips
            double iPGR; // interior panel grips rounded up to whole
            double pPG; //panel grips per panel
            double trPG; //total grips per rail
            
            
            Console.Write("Enter feet : ");
            string userInput1 = Console.ReadLine();
            Console.Write("Enter inches : ");
            string userInput2 = Console.ReadLine();
            f = Convert.ToInt32(userInput1);
            i = Convert.ToInt32(userInput2);
            rl = f * 12 + i;
            
            pc = rl / 48; //finds panel count
            pcr = Math.Ceiling(pc); //rounds to whole panel
            pl = (rl / pcr) - (pcr *1.5); //finds length of each panel
            iPL = pl - 8; //finds length b/w end grips
            iPG = iPL / 12; // finds amount of grips needed for interior of panel
            iPGR = Math.Ceiling(iPG); //Rounds panel grips up to whole
            pPG = iPGR + 2; //grips per panel
            trPG = pPG * pcr;
            
            
            Console.WriteLine("Rail consists of " + pcr + " panels of " + pl + " inches each.");
            Console.WriteLine("Total panel grips needed for rail is: " + trPG);
    }
}