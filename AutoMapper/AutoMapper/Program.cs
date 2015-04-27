using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nib.Sales.HttpServer;
using Nib.Sales.HttpServer.Dtos;
using Nib.Sales.Interface.Dtos.Responses;
using NUnit.Framework;

namespace AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMapperConfiguration.ConfigureMappings();
        }
    }

    [TestFixture]
    public class MappingTests
    {
        [Test]
        public void Check()
        {
            AutoMapperConfiguration.ConfigureMappings();

            Mapper.AssertConfigurationIsValid();
        }
    }


}
