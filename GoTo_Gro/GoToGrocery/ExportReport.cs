using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    class ExportReport
    {
        //before your loop
        StringBuilder csv = new StringBuilder();

        foreach (record in things)
            {
            //in your loop
            string id = reader[0].ToString();
            string first = image.ToString();
            string last = thing from database;
            string dob = databse stuff
            string phone = databse stuf
            string email = databse stuf
            string status = databse stuf
            string start = databse stuf
            string newLine = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", id, first, last, dob, phone, email, status, start);
            csv.AppendLine(newLine);  
            }

        //after your loop
        File.WriteAllText(filePath, csv.ToString());
    }
}
