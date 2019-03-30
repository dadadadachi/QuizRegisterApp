using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuizSaveApp
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeXmlSetting();
            Application.Run(new InputForm());
        }

        public static XDocument xml = null;
        public static IEnumerable<XElement> xmlTypes = null;
        public static IEnumerable<XElement> xmlColumns = null;

        static void InitializeXmlSetting()
        {
            xml = XDocument.Load(@"..\..\..\templateSetting.xml");
            xmlTypes = xml.Root.Elements("Template").Elements("Type");
            xmlColumns = xml.Root.Elements("Input").Elements("Column");
        }
    }
}
