using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ThirdParty.Json.LitJson;

namespace SQS.Fornecedor.models
{
    public class MessageBodyJSON
    {

        public string? Body { get; set; }

        public int? Status { get; set; }
    }
}