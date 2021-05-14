using Appplication.Controller;
using Domain.Domain.Entities.Documents;
using Domain.Domain.Saft;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;

namespace Appplication.Statics
{
    public static class Methods
    {

        public static int atualSerieId = 1;
        public static string atualDocumentTypeId = "2";
        public static string PRINTER; 
        public static string getCurrentAccountCustomer()
        {
            int lastId = 1;
            CustomerController _customertController = new CustomerController();
            if(_customertController.ListALL().Count > 0)
                lastId = _customertController.ListALLAsNoTracking()[_customertController.ListALLAsNoTracking().Count - 1].Id + 1;
            return "2343" + lastId;
        }

        public static string getCurrentAccountProvider()
        {
            int lastId = 1;
            ProviderController _providetController = new ProviderController();
            if(_providetController.ListALL().Count > 0)
                lastId = _providetController.ListALLAsNoTracking()[_providetController.ListALLAsNoTracking().Count - 1].Id + 1;
            return "2387" + lastId;
        }

        public static string gerarHash(string dados)
        {

            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\sellerPro_hash";

            // Criar a pasta prot_sv_hash no documentos
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }


            string hashNameFile = "hash";
            string file = caminho + "\\" + hashNameFile + ".txt";
            string fileResulHash = caminho + "\\" + hashNameFile + ".b64"; // Será o ficheiro resultante de todo processo e é onde vai conter o hash


            // ======================= Criar o ficheiro ==========================================
            File.Delete(file);
            StreamWriter writeH;
            writeH = File.CreateText(file);
            writeH.Write(dados);
            writeH.Close();

            /*Execute no openSSL os comandos abaixo para criar a chave priva e achave pública
                openssl genrsa -out ChavePrivada.pem 1024
                openssl rsa -in ChavePrivada.pem -out ChavePublica.pem - outform PEM –pubout
         */
            Process cmd = new Process();
            string executavelSSL = "\"C:\\Program Files\\OpenSSL-Win64\\bin\\openssl.exe\"";
            if (!File.Exists(caminho + "\\ChavePrivadaf.pem"))
            {
                File.Copy(Directory.GetCurrentDirectory() + "\\ChavePrivadaf.pem", caminho + "\\ChavePrivadaf.pem");
                File.Copy(Directory.GetCurrentDirectory() + "\\ChavePublicaf.pem", caminho + "\\ChavePublicaf.pem");
            }
            // ======================= End Criar o ficheiro ==========================================



            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true; // Não preciso
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("cd " + caminho); // Recebe o caminho da pasta criada em documentos para que toda operação seja feita lá

            // ======================= Criar as chave privada e a chave pública ===================================================
            //cmd.StandardInput.WriteLine(executavelSSL + " genrsa -out ChavePrivada.pem 1024");
            //cmd.StandardInput.WriteLine(executavelSSL + " rsa -in ChavePrivada.pem -out ChavePublica.pem -outform PEM –pubout");
            // ====================================================================================================================

            cmd.StandardInput.WriteLine(executavelSSL + " dgst -sha1 -sign ChavePrivadaf.pem -out " + hashNameFile + ".sha1 " + hashNameFile + ".txt");
            cmd.StandardInput.WriteLine(executavelSSL + " enc -base64 -in " + hashNameFile + ".sha1 -out " + hashNameFile + ".b64 -A");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            // ---------------------------------- END CMD Proccess --------------------------------------------------------------------

            StreamReader readH = File.OpenText(fileResulHash);

            string hashGerada = readH.ReadToEnd();
            readH.Close();

            //File.Delete(file);
            //File.Delete(file.Replace(".txt", ".sha1"));
            //File.Delete(file.Replace(".txt", ".b64"));

            return hashGerada;
        }

        public static string gerarHash(string dados, string invNo)
        {
            string[] invoicePath = invNo.Split('/');

            string caminho = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\sellerPro_hash\\" + invoicePath[0];

            // Criar a pasta prot_sv_hash no documentos
            if (!Directory.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }


            string hashNameFile = invoicePath[0].Replace(" ", "_") + "_" + invoicePath[1];
            string file = caminho + "\\" + hashNameFile + ".txt";
            string fileResulHash = caminho + "\\" + hashNameFile + ".b64"; // Será o ficheiro resultante de todo processo e é onde vai conter o hash


            // ======================= Criar o ficheiro ==========================================
            File.Delete(file);
            StreamWriter writeH;
            writeH = File.CreateText(file);
            writeH.Write(dados);
            writeH.Close();

            /*Execute no openSSL os comandos abaixo para criar a chave priva e achave pública
                openssl genrsa -out ChavePrivada.pem 1024
                openssl rsa -in ChavePrivada.pem -out ChavePublica.pem - outform PEM –pubout
         */
            Process cmd = new Process();
            string executavelSSL = "\"C:\\Program Files\\OpenSSL-Win64\\bin\\openssl.exe\"";
            if (!File.Exists(caminho + "\\ChavePrivadaf.pem"))
            {
                File.Copy(Directory.GetCurrentDirectory() + "\\ChavePrivadaf.pem", caminho + "\\ChavePrivadaf.pem");
                File.Copy(Directory.GetCurrentDirectory() + "\\ChavePublicaf.pem", caminho + "\\ChavePublicaf.pem");
            }
            // ======================= End Criar o ficheiro ==========================================



            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true; // Não preciso
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("cd " + caminho); // Recebe o caminho da pasta criada em documentos para que toda operação seja feita lá

            // ======================= Criar as chave privada e a chave pública ===================================================
            //cmd.StandardInput.WriteLine(executavelSSL + " genrsa -out ChavePrivada.pem 1024");
            //cmd.StandardInput.WriteLine(executavelSSL + " rsa -in ChavePrivada.pem -out ChavePublica.pem -outform PEM –pubout");
            // ====================================================================================================================

            cmd.StandardInput.WriteLine(executavelSSL + " dgst -sha1 -sign ChavePrivadaf.pem -out " + hashNameFile + ".sha1 " + hashNameFile + ".txt");
            cmd.StandardInput.WriteLine(executavelSSL + " enc -base64 -in " + hashNameFile + ".sha1 -out " + hashNameFile + ".b64 -A");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            // ---------------------------------- END CMD Proccess --------------------------------------------------------------------

            StreamReader readH = File.OpenText(fileResulHash);

            string hashGerada = readH.ReadToEnd();
            readH.Close();

            //File.Delete(file);
            //File.Delete(file.Replace(".txt", ".sha1"));
            //File.Delete(file.Replace(".txt", ".b64"));

            return hashGerada;
        }

        public static void allowPermissionFolder(string path)
        {
            System.Security.AccessControl.DirectorySecurity b = new System.Security.AccessControl.DirectorySecurity();
            b.SetAccessRuleProtection(false, true);
            if(Directory.Exists(path))
                Directory.SetAccessControl(path, b);
        }

        public static void denyPermissionFolder(string path)
        {
            System.Security.AccessControl.DirectorySecurity b = new System.Security.AccessControl.DirectorySecurity();
            b.SetAccessRuleProtection(true, true);
            if (Directory.Exists(path))
                Directory.SetAccessControl(path, b);
        }

        public static bool verificaData()
        {
            Invoice ivlast = new InvoiceController().ListALLAsNoTracking().LastOrDefault();
            if (ivlast != null)
            {
                if (ivlast.DataCadastro > DateTime.Now)
                {
                    return false;
                }
            }
            return true;
        }
       
        public static void playSuccess()
        {/*
            string audioName = "successGun.wav";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SellerProSources\\";
            allowPermissionFolder(path);
            if (File.Exists(path + audioName))
                using (SoundPlayer successSound = new SoundPlayer(path + audioName))
                {
                    successSound.Play();
                    denyPermissionFolder(path);
                }
        
            */
            }

        public static bool exportarSaft(string fileName, string pasta, DateTime dataInicio, DateTime dataFinal)
        {
            fileName += "_" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
            return MetodosSaft.salvar(getAduditFile(dataInicio, dataFinal), pasta, fileName);
        }


        private static AuditFile getAduditFile(DateTime dataInicio, DateTime dataFinal)
        {
            return new preencherDadosSaft(dataInicio, dataFinal).getAduditFile();
        }

    }
}
