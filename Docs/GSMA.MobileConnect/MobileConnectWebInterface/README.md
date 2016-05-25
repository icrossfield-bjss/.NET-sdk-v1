MobileConnectWebInterface Class
===============================
Convenience wrapper for [IDiscovery][1] and [IAuthentication][2] methods for use with ASP.NET


Inheritance Hierarchy
---------------------
[System.Object][3]  
  **GSMA.MobileConnect.MobileConnectWebInterface**  

**Namespace:** [GSMA.MobileConnect][4]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public class MobileConnectWebInterface
```

The **MobileConnectWebInterface** type exposes the following members.


Constructors
------------

                 | Name                           | Description                                                       
---------------- | ------------------------------ | ----------------------------------------------------------------- 
![Public method] | [MobileConnectWebInterface][5] | Initializes a new instance of the MobileConnectWebInterface class 


Methods
-------

                 | Name                                             | Description                                                                                                                                                                                                                                                                                                                                    
---------------- | ------------------------------------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [AttemptDiscoveryAfterOperatorSelectionAsync][6] | Attempt discovery using the values returned from the operator selection redirect                                                                                                                                                                                                                                                               
![Public method] | [AttemptDiscoveryAsync][7]                       | Attempt discovery using the supplied parameters. If msisdn, mcc and mnc are null the result will be operator selection, otherwise valid parameters will result in a StartAuthorization status                                                                                                                                                  
![Public method] | [HandleUrlRedirectAsync][8]                      | Handles continuation of the process following a completed redirect, the request token url must be provided if it has been returned by the discovery process. Only the request and redirectedUrl are required, however if the redirect being handled is the result of calling the Authorization URL then the remaining parameters are required. 
![Public method] | [RequestTokenAsync][9]                           | Request token using the values returned from the authorization redirect                                                                                                                                                                                                                                                                        
![Public method] | [StartAuthorization][10]                         | Creates an authorization url with parameters to begin the authorization process                                                                                                                                                                                                                                                                


See Also
--------

#### Reference
[GSMA.MobileConnect Namespace][4]  
[GSMA.MobileConnect.MobileConnectInterface][11]  
[GSMA.MobileConnect.MobileConnectStatus][12]  
[GSMA.MobileConnect.MobileConnectConfig][13]  
[GSMA.MobileConnect.Web.ResponseConverter][14]  

[1]: ../../GSMA.MobileConnect.Discovery/IDiscovery/README.md
[2]: ../../GSMA.MobileConnect.Authentication/IAuthentication/README.md
[3]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[4]: ../README.md
[5]: _ctor.md
[6]: AttemptDiscoveryAfterOperatorSelectionAsync.md
[7]: AttemptDiscoveryAsync.md
[8]: HandleUrlRedirectAsync.md
[9]: RequestTokenAsync.md
[10]: StartAuthorization.md
[11]: ../MobileConnectInterface/README.md
[12]: ../MobileConnectStatus/README.md
[13]: ../MobileConnectConfig/README.md
[14]: ../../GSMA.MobileConnect.Web/ResponseConverter/README.md
[15]: ../../_icons/Help.png
[Public method]: ../../_icons/pubmethod.gif "Public method"