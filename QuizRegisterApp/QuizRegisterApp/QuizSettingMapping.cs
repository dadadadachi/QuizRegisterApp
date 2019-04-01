using System;
using System.Collections.Generic;
using Serialization = System.Xml.Serialization;

namespace XmlManager.Mapping
{
    /// <summary>
    /// QuizSettingのスキーマ定義
    /// </summary>
    public class QuizSetting
    {
        [Serialization::XmlRoot("Setting")]
        public class Root
        {
            /// <summary>入力データ定義</summary>
            [Serialization::XmlElement("Define")]
            public Define Define { get; set; }
            /// <summary>クイズテンプレート</summary>
            [Serialization::XmlElement("Template")]
            public Template Template { get; set; }
        }

        #region <Define>
        public class Define
        {
            /// <summary>項目定義</summary>
            [Serialization::XmlElement("Column")]
            public List<Column> Columns { get; set; }
        }

        public class Column
        {
            /// <summary>項目キー</summary>
            [Serialization::XmlAttribute("key")]
            public String Key { get; set; }
            /// <summary>項目名</summary>
            [Serialization::XmlElement("Title")]
            public String Title { get; set; }
            /// <summary>入力タイプ</summary>
            [Serialization::XmlElement("InputType")]
            public String InputType { get; set; }
            /// <summary>選択項目</summary>
            [Serialization::XmlElement("Options")]
            public String Options { get; set; }
        }
        #endregion

        #region <Template>
        public class Template
        {
            /// <summary>ジャンル</summary>
            [Serialization::XmlElement("Genre")]
            public List<Genre> Genres { get; set; }
        }

        public class Genre
        {
            /// <summary>ジャンル名</summary>
            [Serialization::XmlAttribute("name")]
            public String Name { get; set; }
            /// <summary>出題形式</summary>
            [Serialization::XmlElement("Format")]
            public List<Format> Formats { get; set; }
        }

        public class Format
        {
            /// <summary>出題形式名</summary>
            [Serialization::XmlAttribute("name")]
            public String Name { get; set; }
            /// <summary>難易度</summary>
            [Serialization::XmlElement("Difficulty")]
            public String Difficulty { get; set; }
            /// <summary>問題文</summary>
            [Serialization::XmlElement("ProblemSentence")]
            public String ProblemSentence { get; set; }
            /// <summary>選択肢</summary>
            [Serialization::XmlElement("Options")]
            public String Options { get; set; }
            /// <summary>エフェクト画像</summary>
            [Serialization::XmlElement("EffectImage")]
            public String EffectImage { get; set; }
            /// <summary>文字パネル</summary>
            [Serialization::XmlElement("CharPanel")]
            public String CharPanel { get; set; }
            /// <summary>ヒント</summary>
            [Serialization::XmlElement("Hint")]
            public String Hint { get; set; }
            /// <summary>正答率</summary>
            [Serialization::XmlElement("Rate")]
            public String Rate { get; set; }
            /// <summary>答え</summary>
            [Serialization::XmlElement("CorrectAnswer")]
            public String CorrectAnswer { get; set; }
            /// <summary>備考</summary>
            [Serialization::XmlElement("Remarks")]
            public String Remarks { get; set; }
        }
        #endregion
    }
}
