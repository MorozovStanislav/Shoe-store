using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ShoeStore.Domains
{

    public class Provider
    {
        public int ProviderId { get; set; }

        public int MaterialOrderNumber { get; set; }

        public int ShoesOrderNumber { get; set; }

        public int NumberPackage { get; set; }

        public Provider() { }

        public Provider(int materiaordernumber, int shoesordernumber, int numberpackage)
        {
            MaterialOrderNumber = materiaordernumber;
            ShoesOrderNumber = shoesordernumber;
            NumberPackage = numberpackage;
        }
    }
}