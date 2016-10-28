using System;
using System.Collections.Generic;
using log4net;
using log4net.Config;
using DataTransfer;
using DataAcces;
using System.Xml.Linq;
using Domain;
using Domain.Services;

namespace DebugConsole
{

    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            FilmService service = new FilmService();

            service.LoadData();
        }
    }
}
