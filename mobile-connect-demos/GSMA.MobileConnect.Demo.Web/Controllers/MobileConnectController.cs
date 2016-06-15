﻿using GSMA.MobileConnect.Discovery;
using GSMA.MobileConnect.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace GSMA.MobileConnect.Demo.Web.Controllers
{
    [RoutePrefix("api/mobileconnect")]
    public class MobileConnectController : ApiController
    {
        private MobileConnectWebInterface _mobileConnect;

        public MobileConnectController(MobileConnectWebInterface mobileConnect)
        {
            this._mobileConnect = mobileConnect;
        }

        [HttpGet]
        [Route("start_discovery")]
        public async Task<IHttpActionResult> StartDiscovery(string msisdn="", string mcc="", string mnc="")
        {
            var response = await _mobileConnect.AttemptDiscoveryAsync(Request, msisdn, mcc, mnc, true, new MobileConnectRequestOptions());
            return CreateResponse(response);
        }

        [HttpGet]
        [Route("start_authorization")]
        public async Task<IHttpActionResult> StartAuthorization(string sdksession = null, string subscriberId = null)
        {
            var response = await _mobileConnect.StartAuthorization(Request, sdksession, subscriberId, null, null, new MobileConnectRequestOptions() { Prompt = "login" });
            return CreateResponse(response);
        }

        [HttpGet]
        [Route("")]
        public async Task<IHttpActionResult> HandleRedirect(string sdksession=null, string mcc_mnc=null, string code=null, string expectedState=null, string expectedNonce=null)
        {
            var response = await _mobileConnect.HandleUrlRedirectAsync(Request, Request.RequestUri, sdksession, expectedState, expectedNonce);
            
            return CreateResponse(response);
        }

        private IHttpActionResult CreateResponse(MobileConnectStatus status)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK, ResponseConverter.Convert(status));

            if (status.SetCookie != null)
            {
                foreach (var cookie in status.SetCookie)
                {
                    response.Headers.Add("Set-Cookie", cookie);
                }
            }

            return new ResponseMessageResult(response);
        }
    }
}
