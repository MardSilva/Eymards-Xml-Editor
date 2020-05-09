using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eymard_s_XML_Editor
{
    public class LogEditorXML
    {
        public void LogDeProcessodoUsuario(string strLog)
        {
            StreamWriter swEscritorLog;
            FileStream fsEscritorArquivolog = null;
            DirectoryInfo DirLog = null;
            FileInfo ArquivoLog;

            //inicializando o arquivo de log
            string strCaminhoLog = "C:\\Logs do Eymard's XML Editor\\Logs\\Logs de Processos\\";
            strCaminhoLog = strCaminhoLog + "Log-Processos-Usuario-" + System.DateTime.Today.ToString("MM-dd-yyyy_hh-mm-ss-tt") + "." + "txt";

            //criando o log
            ArquivoLog = new FileInfo(strCaminhoLog);

            //diretório do do log
            DirLog = new DirectoryInfo(ArquivoLog.DirectoryName);

            if(!DirLog.Exists)
            {
                DirLog.Create();

                if (!ArquivoLog.Exists)
                {
                    fsEscritorArquivolog = ArquivoLog.Create();
                }
                else
                {
                    fsEscritorArquivolog = new FileStream(strCaminhoLog, FileMode.Append);
                }

                swEscritorLog = new StreamWriter(fsEscritorArquivolog);
                swEscritorLog.WriteLine("---------------------------------------------------------------------------");
                swEscritorLog.Write("Entrada de Log - Log de Processo do Usuário");
                swEscritorLog.WriteLine("{1} {0}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                swEscritorLog.WriteLine(strLog);
                swEscritorLog.WriteLine("---------------------------------------------------------------------------");
                swEscritorLog.Close();
            }
            else
            {
                if(!ArquivoLog.Exists)
                {
                    fsEscritorArquivolog = ArquivoLog.Create();
                }
                else
                {
                    fsEscritorArquivolog = new FileStream(strCaminhoLog, FileMode.Append);
                }

                swEscritorLog = new StreamWriter(fsEscritorArquivolog);
                swEscritorLog.WriteLine("---------------------------------------------------------------------------");
                swEscritorLog.Write("Entrada de Log - Log de Processo do Usuário\r\n");
                swEscritorLog.WriteLine("{1} {0}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                swEscritorLog.WriteLine(strLog);
                swEscritorLog.WriteLine("---------------------------------------------------------------------------");
                swEscritorLog.Close();
            }
        }
        public void LogDeErroXML(string strLog)
        {
            StreamWriter swEscritorLog;
            FileStream fsEscritorArquivolog = null;
            DirectoryInfo DirLog = null;
            FileInfo ArquivoLog;

            //inicializando o arquivo de log
            string strCaminhoLog = "C:\\Logs do Eymard's XML Editor\\Logs\\Logs de Erros XMLs\\";
            strCaminhoLog = strCaminhoLog + "Log-Erros-XML-" + System.DateTime.Today.ToString("MM-dd-yyyy_hh-mm-ss-tt") + "." + "txt";

            //criando o log
            ArquivoLog = new FileInfo(strCaminhoLog);

            //diretório do do log
            DirLog = new DirectoryInfo(ArquivoLog.DirectoryName);

            if (!DirLog.Exists)
            {
                DirLog.Create();

                if (!ArquivoLog.Exists)
                {
                    fsEscritorArquivolog = ArquivoLog.Create();
                }
                else
                {
                    fsEscritorArquivolog = new FileStream(strCaminhoLog, FileMode.Append);
                }

                swEscritorLog = new StreamWriter(fsEscritorArquivolog);
                swEscritorLog.WriteLine("---------------------------------------------------------------------------");
                swEscritorLog.Write("Entrada de Log - Log de Erro de XML");
                swEscritorLog.WriteLine("{1} {0}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                swEscritorLog.WriteLine("   :{0}", strLog);
                swEscritorLog.WriteLine("---------------------------------------------------------------------------");
                swEscritorLog.Close();
            }
            else
            {
                if (!ArquivoLog.Exists)
                {
                    fsEscritorArquivolog = ArquivoLog.Create();
                }
                else
                {
                    fsEscritorArquivolog = new FileStream(strCaminhoLog, FileMode.Append);
                }

                swEscritorLog = new StreamWriter(fsEscritorArquivolog);
                swEscritorLog.WriteLine("---------------------------------------------------------------------------");
                swEscritorLog.Write("Entrada de Log - Log de Erro de XML\r\n");
                swEscritorLog.WriteLine("{1} {0}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                swEscritorLog.WriteLine("   :{0}", strLog);
                swEscritorLog.WriteLine("---------------------------------------------------------------------------");
                swEscritorLog.Close();
            }
        }
    }
}
