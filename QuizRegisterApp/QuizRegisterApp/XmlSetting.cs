using System;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using QuizSaveApp;
using XmlManager.Mapping;

namespace XmlManager.XmlSetting
{
    class XmlSetting
    {
        public static void InitializeXmlSetting()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(QuizSetting.Root));
            XmlReader xml = XmlReader.Create(@"D:\Projects\github\QuizRegisterApp\QuizRegisterApp\QuizSetting.xml");
            Program.quizSetting = (QuizSetting.Root)serializer.Deserialize(xml);
        }
    }
}
