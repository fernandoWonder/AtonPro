using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Domain.Domain.Saft
{
    public class MetodosSaft
    {
        public class UTF8StringWriter : StringWriter
        {
            public override Encoding Encoding
            {
                get
                {
                    return new UTF8Encoding(false);
                }
            }
        }

        public static bool salvar(AuditFile auditFile, string pasta, string filename)
        {
            bool sucesso = true;
            try
            {
                auditFile.ToString();
                string fileName = @"\" + filename + ".xml";

                if(!Directory.Exists(pasta))
                    Directory.CreateDirectory(pasta);

                pasta = pasta + fileName;

                XmlSerializer xmlSer = new XmlSerializer(typeof(AuditFile));

                using (StringWriter arquivo = new UTF8StringWriter())
                {
                    xmlSer.Serialize(arquivo, auditFile);

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(arquivo.ToString());

                    xmlDoc.Save(@pasta);
                }
            }
            catch (Exception ex)
            {
                sucesso = false;
                Console.WriteLine(ex.Message);
            }

            return sucesso;
        }

    }
}
