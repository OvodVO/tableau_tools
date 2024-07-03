using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace WashU.BatemanLab.MassSpec.TableauTweaker
{
    class TableauWorkbook
    {
        XDocument _twbXdoc;
        XElement _workBook;
        XElement _dataSources;
        XElement _workSheets;
        XElement _dsParameters;
        XElement _dsMS_DataUnion;
        string _inputTableauFileName;

        public void OpenFile(string uri)
        {
            try
              {
                _twbXdoc = XDocument.Load(uri);
                _inputTableauFileName = uri;
              }
            catch (Exception _XDocExeption)
              {
                MessageBox.Show(_XDocExeption.Message);
                return;
              }

            _workBook = _twbXdoc.Root;

            _dataSources = _workBook.Element("datasources");

            _workSheets = _workBook.Element("worksheets");

            _dsParameters = _dataSources.Elements("datasource").Where(ds => ds.Attribute("name").Value == "Parameters").Single();

            _dsMS_DataUnion = _dataSources.Elements("datasource").Where(ds => ds.Attribute("caption")?.Value.ToString() == "Aggregated").Single();

        }

        public void CleanWorkbook()
        {
            List<string> _columnNames = new List<string>();

            int i = 0;

            //string _strWithreplacments = _twbXdoc.ToString(SaveOptions.DisableFormatting);

            string _strWithreplacments = File.ReadAllText(_inputTableauFileName);


            string _outputfilename1 = Path.ChangeExtension(_inputTableauFileName, "twb1");

            //File.WriteAllText(_outputfilename1, _strWithreplacments, Encoding.UTF8);


            foreach (XElement columnElement in _dsMS_DataUnion.Elements("column").Where(x => x.Element("calculation") != null))
            {
                i++;

                string _colname = columnElement.Attribute("name").Value;

                _columnNames.Add(_colname);

                //_twbXdoc.ToString().Replace(_colname, string.Format("Calc_{0:D3}", i));

               // _strWithreplacments = File.ReadAllText(_outputfilename1);

                _strWithreplacments = _strWithreplacments.Replace(_colname, string.Format("[Calc_{0:D3}]", i));

                //File.WriteAllText(_outputfilename1, _strWithreplacments, Encoding.UTF8);

            }


            string _outputfilename = Path.ChangeExtension(_inputTableauFileName, "txt");

           // string _outputfilename1 = Path.ChangeExtension(_inputTableauFileName, "twb1");

            //   SaveFileDialog _saveDlg = new SaveFileDialog();
            //  if (_saveDlg.ShowDialog() == DialogResult.OK)
            //  {
            MessageBox.Show(_outputfilename);


            

            File.WriteAllLines(_outputfilename, _columnNames, Encoding.GetEncoding(1250));


            //XDocument.Load()

            File.WriteAllText(_outputfilename1, _strWithreplacments, Encoding.UTF8);

            //  }

          //  XmlDocument xdoc = new XmlDocument();

          //  xdoc.LoadXml(_strWithreplacments);

           // xdoc.

          //  xdoc.Save(_outputfilename1);

        }
    }
}
