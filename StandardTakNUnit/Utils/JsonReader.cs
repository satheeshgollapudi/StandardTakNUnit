
using System;
using System.IO;
using Newtonsoft.Json;
namespace test.Utils
{
	public class JsonReader
	{

        public string email { get; set; }
        public string password { get; set; }
        public String country { get; set; }
        public String university { get; set; }
        public String title { get; set; }
        public String degree { get; set; }
        public String graduationYear { get; set; }
        public String Language { get; set; }
        public String Level { get; set; }
        public String certificate { get; set; }
        public String from { get; set; }
        public String year { get; set; }


        /* public static Object loadData(String path)
         {
             using StreamReader reader = new StreamReader(path);
             var jsonContent = reader.ReadToEnd();
             return JsonConvert.DeserializeObject<Object>(jsonContent);
         } */



        public static JsonReader read(string path)
        {
         

            string json = File.ReadAllText(path);
            JsonReader jr = JsonConvert.DeserializeObject<JsonReader>(json);
            return jr;
        }

        /*public static JsonReader educationReader()
        {


            string json = File.ReadAllText(@"C:\Users\gskum\OneDrive\Documents\SatheeshProject\StandardTaskNunitFramework\MarNunitPOMExmaple\TestData\Education.json");
            JsonReader er = JsonConvert.DeserializeObject<JsonReader>(json);
            return er;
        }*/


    }
}

