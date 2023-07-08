using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank___Soul
{
    internal static class IdGeneration
    {
        //this method generates ID
        public static string idGenerator()
        {

            Random rnd = new Random();

            while (true)
            {
                string pictureId = "";
                Data.ID = "";
                for (int i = 0; i < 5; i++)
                {
                    int digit = rnd.Next(1, 10);
                    Data.ID += digit;
                    pictureId += digit;
                }
                Data.picture_name += pictureId + ".JPG";
                bool matchFound = false;
                foreach (List<string> list in Data.local_db)
                {
                    if (Data.ID == list[0])
                    {
                        matchFound = true;
                        break;
                    }
                }

                if (matchFound)
                    continue;

                return Data.ID;
            }
        }
    }
}
