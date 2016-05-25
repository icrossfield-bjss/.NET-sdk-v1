MobileConnectStatus Class
=========================
Object to hold the details of a response returned from [MobileConnectInterface][1] and [MobileConnectWebInterface][2] all information required to continue the process is included


Inheritance Hierarchy
---------------------
[System.Object][3]  
  **GSMA.MobileConnect.MobileConnectStatus**  

**Namespace:** [GSMA.MobileConnect][4]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public class MobileConnectStatus
```

The **MobileConnectStatus** type exposes the following members.


Properties
----------

                   | Name                   | Description                                                                                                             
------------------ | ---------------------- | ----------------------------------------------------------------------------------------------------------------------- 
![Public property] | [DiscoveryResponse][5] | Complete discovery response if included                                                                                 
![Public property] | [ErrorCode][6]         | Error code if included                                                                                                  
![Public property] | [ErrorMessage][7]      | User friendly error description if included                                                                             
![Public property] | [Exception][8]         | Exception encountered during request if included                                                                        
![Public property] | [Nonce][9]             | Nonce value used for Authorization                                                                                      
![Public property] | [ResponseType][10]     | Type of response, indicates the step in the process that should be triggered next                                       
![Public property] | [SetCookie][11]        | Content of the Set-Cookie header returned in the response, should be used to proxy cookies back to the user if required 
![Public property] | [State][12]            | State value used for Authorization                                                                                      
![Public property] | [TokenResponse][13]    | Complete discovery response if included                                                                                 
![Public property] | [Url][14]              | Url to navigate to in the next step if required                                                                         


Methods
-------

                                 | Name                                                         | Description                                                                                                                                                                  
-------------------------------- | ------------------------------------------------------------ | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [Authorization][15]                                          | Creates a Status with ResponseType Authorization and url for next process step. Indicates that the next step should be navigating to the Authorization URL.                  
![Public method]![Static member] | [Complete][16]                                               | Creates a Status with ResponseType Complete and the complete [RequestTokenResponse][17]. Indicates that the MobileConnect process is complete and the user is authenticated. 
![Public method]![Static member] | [Error(String, String, Exception)][18]                       | Creates a Status with ResponseType error and error related properties filled. Indicates that the MobileConnect process has been aborted due to an issue encountered.         
![Public method]![Static member] | [Error(String, String, Exception, RequestTokenResponse)][19] | Creates a Status with ResponseType error and error related properties filled. Indicates that the MobileConnect process has been aborted due to an issue encountered.         
![Public method]![Static member] | [Error(String, String, Exception, DiscoveryResponse)][20]    | Creates a Status with ResponseType error and error related properties filled. Indicates that the MobileConnect process has been aborted due to an issue encountered.         
![Public method]![Static member] | [OperatorSelection][21]                                      | Creates a Status with ResponseType OperatorSelection and url for next process step. Indicates that the next step should be navigating to the operator selection URL.         
![Public method]![Static member] | [StartAuthorization][22]                                     | Creates a Status with ResponseType StartAuthorization and the complete [DiscoveryResponse][5]. Indicates that the next step should be starting authorization.                
![Public method]![Static member] | [StartDiscovery][23]                                         | Creates a Status with ResponseType StartDiscovery. Indicates that some required data was missing and the discovery process needs to be restarted.                            


See Also
--------

#### Reference
[GSMA.MobileConnect Namespace][4]  

[1]: ../MobileConnectInterface/README.md
[2]: ../MobileConnectWebInterface/README.md
[3]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[4]: ../README.md
[5]: DiscoveryResponse.md
[6]: ErrorCode.md
[7]: ErrorMessage.md
[8]: Exception.md
[9]: Nonce.md
[10]: ResponseType.md
[11]: SetCookie.md
[12]: State.md
[13]: TokenResponse.md
[14]: Url.md
[15]: Authorization.md
[16]: Complete.md
[17]: ../../GSMA.MobileConnect.Authentication/RequestTokenResponse/README.md
[18]: Error.md
[19]: Error_1.md
[20]: Error_2.md
[21]: OperatorSelection.md
[22]: StartAuthorization.md
[23]: StartDiscovery.md
[24]: ../../_icons/Help.png
[Public property]: ../../_icons/pubproperty.gif "Public property"
[Public method]: ../../_icons/pubmethod.gif "Public method"
[Static member]: ../../_icons/static.gif "Static member"