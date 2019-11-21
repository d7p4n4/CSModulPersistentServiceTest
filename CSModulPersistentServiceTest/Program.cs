using CSAc4yObjectService.Class;
using d7p4n4Namespace.Final.Class;
using d7p4n4Namespace.PersistentService.Class;
using System;
using System.Configuration;

namespace CSModulPersistentServiceTest
{
    class Program
    {
        private static string _serverName = ".\\SQLEXPRESS";
        private static string _baseName = "ModulDb";
        private static string _userName = "manager";
        private static string _pwd = "Manager99";
        static void Main(string[] args)
        {
            ModulPersistentService modulPersistentService = new ModulPersistentService(_serverName, _baseName, _userName, _pwd);
            Modul modul = new Modul() { Leiras = "Teszt Leirás" };
            
            GetObjectResponse getObjectResponse = modulPersistentService.SaveWithXml(modul);
            Console.WriteLine(getObjectResponse.id);
        }
    }
}
