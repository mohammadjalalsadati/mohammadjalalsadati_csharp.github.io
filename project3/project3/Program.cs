using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
            string CityName = {"Tabriz","Tehran","shiraz"};

	string CityCode = {"041","021","0711"};

	 

	int index = Array.IndexOf(CityCode,"041");

	string Result;

	if(index > 0 )

	Result = CityName[index];

	else

 Result = "Not Found";
        }
   
}
