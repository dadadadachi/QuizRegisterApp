using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using XmlManager.Mapping;
using XmlManager.XmlSetting;

namespace QuizSaveApp
{
    public static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeSetting();
            Application.Run(new InputForm());
        }
        
        public static QuizSetting.Root quizSetting = null;

        static void InitializeSetting()
        {
            XmlSetting.InitializeXmlSetting();
        }
    }
}
