Discovery Class
===============
Concrete implementation of [IDiscovery][1]


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **GSMA.MobileConnect.Discovery.Discovery**  

**Namespace:** [GSMA.MobileConnect.Discovery][3]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public class Discovery : IDiscovery
```

The **Discovery** type exposes the following members.


Constructors
------------

                 | Name           | Description                                           
---------------- | -------------- | ----------------------------------------------------- 
![Public method] | [Discovery][4] | Initializes a new instance of the **Discovery** class 


Methods
-------

                 | Name                                                                                                                            | Description                                                                                                                                                                                                                                                                                                                                                     
---------------- | ------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [ClearDiscoveryCache][5]                                                                                                        | Helper function which clears any result from the discovery cache which corresponds with the provided parameters                                                                                                                                                                                                                                                 
![Public method] | [CompleteSelectedOperatorDiscovery(IPreferences, String, String, String)][6]                                                    | Synchronous wrapper for [CompleteSelectedOperatorDiscoveryAsync(IPreferences, String, String, String)][7]                                                                                                                                                                                                                                                       
![Public method] | [CompleteSelectedOperatorDiscovery(String, String, String, String, String, String)][8]                                          | Synchronous wrapper for [CompleteSelectedOperatorDiscoveryAsync(String, String, String, String, String, String)][9]                                                                                                                                                                                                                                             
![Public method] | [CompleteSelectedOperatorDiscoveryAsync(IPreferences, String, String, String)][10]                                              | Convenience version of [CompleteSelectedOperatorDiscoveryAsync(String, String, String, String, String, String)][9] where the clientId, clientSecret and discoveryUrl are provided by the IPreferences implementation                                                                                                                                            
![Public method] | [CompleteSelectedOperatorDiscoveryAsync(String, String, String, String, String, String)][11]                                    | Allows an application to use the selected operator MCC and MNC to obtain the discovery response. In the case there is already a discovery result in the cache and the Selected-MCC/Selected-MNC in the new request are the same as relates to the discovery result for the cached result, the cached result will be returned.                                   
![Public method] | [ExtractOperatorSelectionURL][12]                                                                                               | Helper function to extract operator selection URL from the discovery reponse                                                                                                                                                                                                                                                                                    
![Public method] | [GetCachedDiscoveryResult][13]                                                                                                  | Helper function which retrieves a discovery response (if available) from the discovery cache which corresponds with the operator details                                                                                                                                                                                                                        
![Public method] | [GetOperatorSelectionURL(IPreferences, String)][14]                                                                             | Synchronous wrapper for [GetOperatorSelectionURLAsync(IPreferences, String)][15]                                                                                                                                                                                                                                                                                
![Public method] | [GetOperatorSelectionURL(String, String, String, String)][16]                                                                   | Synchronous wrapper for [GetOperatorSelectionURLAsync(String, String, String, String)][17]                                                                                                                                                                                                                                                                      
![Public method] | [GetOperatorSelectionURLAsync(IPreferences, String)][18]                                                                        | Convenience wrapper for [GetOperatorSelectionURLAsync(String, String, String, String)][17] where the clientId, clientSecret and discoveryUrl are provided by the IPreferences implementation                                                                                                                                                                    
![Public method] | [GetOperatorSelectionURLAsync(String, String, String, String)][19]                                                              | Allows an application to get the URL for the operator selection UI of the discovery service. This will not reference the discovery result cache. The returned URL will contain a session id created by the discovery server. The URL must be used as-is.                                                                                                        
![Public method] | [ParseDiscoveryRedirect][20]                                                                                                    | Allows an application to obtain parameters which have been passed within a discovery redirect URL                                                                                                                                                                                                                                                               
![Public method] | [StartAutomatedOperatorDiscovery(IPreferences, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][21]                | Synchronous wrapper for [StartAutomatedOperatorDiscoveryAsync(IPreferences, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][22]                                                                                                                                                                                                                   
![Public method] | [StartAutomatedOperatorDiscovery(String, String, String, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][23]      | Synchronous wrapper for [StartAutomatedOperatorDiscoveryAsync(String, String, String, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][24]                                                                                                                                                                                                         
![Public method] | [StartAutomatedOperatorDiscoveryAsync(IPreferences, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][25]           | Convenience version of [StartAutomatedOperatorDiscoveryAsync(String, String, String, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][24] where the clientId, clientSecret and discoveryUrl are provided by the IPreferences implementation                                                                                                        
![Public method] | [StartAutomatedOperatorDiscoveryAsync(String, String, String, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][26] | Allows an application to conduct discovery based on the predetermined operator/network identified operator semantics. If the operator cannot be identified the function will return the 'operator selection' form of the response. The application can then determine how to proceed i.e. open the operator selection page separately or otherwise handle this. 


See Also
--------

#### Reference
[GSMA.MobileConnect.Discovery Namespace][3]  

[1]: ../IDiscovery/README.md
[2]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[3]: ../README.md
[4]: _ctor.md
[5]: ClearDiscoveryCache.md
[6]: CompleteSelectedOperatorDiscovery.md
[7]: ../IDiscovery/CompleteSelectedOperatorDiscoveryAsync.md
[8]: CompleteSelectedOperatorDiscovery_1.md
[9]: ../IDiscovery/CompleteSelectedOperatorDiscoveryAsync_1.md
[10]: CompleteSelectedOperatorDiscoveryAsync.md
[11]: CompleteSelectedOperatorDiscoveryAsync_1.md
[12]: ExtractOperatorSelectionURL.md
[13]: GetCachedDiscoveryResult.md
[14]: GetOperatorSelectionURL.md
[15]: ../IDiscovery/GetOperatorSelectionURLAsync.md
[16]: GetOperatorSelectionURL_1.md
[17]: ../IDiscovery/GetOperatorSelectionURLAsync_1.md
[18]: GetOperatorSelectionURLAsync.md
[19]: GetOperatorSelectionURLAsync_1.md
[20]: ParseDiscoveryRedirect.md
[21]: StartAutomatedOperatorDiscovery.md
[22]: ../IDiscovery/StartAutomatedOperatorDiscoveryAsync.md
[23]: StartAutomatedOperatorDiscovery_1.md
[24]: ../IDiscovery/StartAutomatedOperatorDiscoveryAsync_1.md
[25]: StartAutomatedOperatorDiscoveryAsync.md
[26]: StartAutomatedOperatorDiscoveryAsync_1.md
[27]: ../../_icons/Help.png
[Public method]: ../../_icons/pubmethod.gif "Public method"