﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMA.MobileConnect
{
    /// <summary>
    /// Class to hold a Rest error response
    /// </summary>
    public class ErrorResponse
    {
        /// <summary>
        /// The error code
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }

        /// <summary>
        /// The error description
        /// </summary>
        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// The error URI
        /// </summary>
        [JsonProperty("error_uri")]
        public string ErrorUri { get; set; }
    }
}
