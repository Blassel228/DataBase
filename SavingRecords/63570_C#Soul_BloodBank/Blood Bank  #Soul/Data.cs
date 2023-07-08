using System.Drawing;
using System.Collections.Generic;

namespace Blood_Bank___Soul
{
    internal static class Data
    {
        public static string image_file_path = "Images";
        public static string extension = ""; //contains extension of an image
        public static Image image = null;    //contains Image itself
        public static string picture_name = "";
        public static int index = 0;         //magical thing that will be used in the future I dunno how really
        public static string ID = "";
        public static string file = "Database.txt";//name of our txt database

        public static Dictionary<string, List<string>> user_data = new Dictionary<string, List<string>>();

        public static List<List<string>> local_db = new List<List<string>>();

    }
}