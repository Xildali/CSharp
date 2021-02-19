using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TrueFalseGame
{
    public class TrueFalse
    {
        #region Private Fields

        private List<Question> list;
        private string fileName;

        #endregion

        #region Public Properties

        public string FileName
        {
            set { fileName = value; }
        }

        public int Count
        {
            get { return list.Count; }
        }

        public Question this[int index]
        {
            get { return list[index]; }
        }

        #endregion

        #region Constructors

        public TrueFalse(string fileName)
        {
            this.fileName = fileName;

            list = new List<Question>();
        }

        #endregion

        #region Public Methods

        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                list = (List<Question>)xmlSerializer.Deserialize(stream);
            }
        }

        #endregion
    }
}
