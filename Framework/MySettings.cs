using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Framework
{
    public class MySettings
    {
        [XmlElement("num")]
        public int MyNumber { get; set; }
        public string MyString { get; set; }

        public void Save()
        {
            using (Stream stream = File.Create(SettingsFile))
            //using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
            //{
            //    writer.WriteLine(MyNumber);
            //    writer.WriteLine(MyString);
            //}
            {
                XmlSerializer ser = new XmlSerializer(this.GetType());
                ser.Serialize(stream, this);
            }

            //writer.Close();
            //stream.Close();
        }

        public static MySettings Load()
        {
            if (!File.Exists(SettingsFile))
                return DefaultSettings;

            //using (Stream stream = File.OpenRead(SettingsFile))
            //using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            //{
            //    try
            //    {
            //        string firstLine = reader.ReadLine();
            //        string secondLine = reader.ReadLine();

            //        reader.Close();
            //        return new MySettings { MyNumber = int.Parse(firstLine), MyString = secondLine };
            //    }
            //    catch (FormatException)
            //    {
            //        stream.Close();
            //        File.Delete(SettingsFile);
            //        return DefaultSettings;
            //    }
            //}
            using (Stream stream = File.OpenRead(SettingsFile))
            {
                try
                {
                    XmlSerializer ser = new XmlSerializer(typeof(MySettings));
                    return (MySettings)ser.Deserialize(stream);
                }
                catch (InvalidOperationException)
                {
                    stream.Close();
                    File.Delete(SettingsFile);
                    return DefaultSettings;
                }

            }

        }

        private static string SettingsFolder
        {
            get
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                folder = Path.Combine(folder, "MyProject");
                folder = Path.Combine(folder, "MyApp");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                return folder;
            }
        }


        private static string SettingsFile
        {
            get
            {
                //return Path.Combine(SettingsFolder, "settings.txt");
                return Path.Combine(SettingsFolder, "settings.xml");
            }
        }

        private static MySettings DefaultSettings
        {
            get
            {
                return new MySettings { MyNumber = 0, MyString = "" };
            }
        }
    }
}
