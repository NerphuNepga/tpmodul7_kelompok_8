using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_8
{
    internal class KuliahMahasiswa103022300148
    {
        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public List<Course> courses { get; set; }


        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\Kuliah\\KPL\\tp7_2_103022300148.json");
            var options = new JsonSerializerOptions
            {
                IncludeFields = true
            };
            
            KuliahMahasiswa103022300148 json = JsonSerializer.Deserialize<KuliahMahasiswa103022300148>(jsonString, options);
            for (int i = 0; i < json.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i+1) + " " + json.courses[i].code + " - " + json.courses[i].name);
            }
        }
    }
}
