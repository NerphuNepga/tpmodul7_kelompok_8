using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace tpmodul7_kelompok_8
{
    internal class DataMahasiswa103022300041
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public Nama nama { get; set; }
        public string fakultas { get; set; }
        public long nim { get; set; }


        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\Dokumen Kuliah\\Semester 4\\Konstruksi Perangkat Lunak Praktikum\\TP MODUL 7\\tpmodul7_kelompok_8\\tp7_1_103022300041.json");
            var options = new JsonSerializerOptions
            {
                IncludeFields = true
            };
            DataMahasiswa103022300041 dataMhs = JsonSerializer.Deserialize<DataMahasiswa103022300041>(jsonString, options);

            Console.WriteLine("Nama " + dataMhs.nama.depan + " " + dataMhs.nama.belakang + " dengan nim " + dataMhs.nim + " dari fakultas " + dataMhs.fakultas);
        }
    }
}
