using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp2
{
    [Serializable]
    class task11employee
    {
        public string id = "k38";
        public string name = "Krishna";
        public string gender = "Male";
        public int age = 21;


    }
    class emp1
    {
        
        public void Seritofile()
        {
            task11employee emobj = new task11employee();
            FileStream fs = new FileStream("employee.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter f = new BinaryFormatter();
            f.Serialize(fs, emobj);
            fs.Close();
        }

        public void deserialdata()
        {
            FileStream fs = new FileStream("employee.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter f = new BinaryFormatter();
            task11employee emp = (task11employee)f.Deserialize(fs);
            Console.WriteLine(emp.id);
            Console.WriteLine(emp.name);
            Console.WriteLine(emp.gender);
            Console.WriteLine(emp.age);
        }
        public static void Main()
        {
            emp1 obj = new emp1();
            obj.Seritofile();
            obj.deserialdata();
        }

    }
}

