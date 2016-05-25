IDiscovery Interface
====================
Interface for Mobile Connect Discovery requests

**Namespace:** [GSMA.MobileConnect.Discovery][1]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public interface IDiscovery
```

The **IDiscovery** type exposes the following members.


Methods
-------

                 | Name                                                                                                                            | Description                                                                                                                                                                                                                                                                                                                                                     
---------------- | ------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method] | [ClearDiscoveryCache][2]                                                                                                        | Helper function which clears any result from the discovery cache which corresponds with the provided parameters                                                                                                                                                                                                                                                 
![Public method] | [CompleteSelectedOperatorDiscovery(IPreferences, String, String, String)][3]                                                    | Synchronous wrapper for [CompleteSelectedOperatorDiscoveryAsync(IPreferences, String, String, String)][4]                                                                                                                                                                                                                                                       
![Public method] | [CompleteSelectedOperatorDiscovery(String, String, String, String, String, String)][5]                                          | Synchronous wrapper for [CompleteSelectedOperatorDiscoveryAsync(String, String, String, String, String, String)][6]                                                                                                                                                                                                                                             
![Public method] | [CompleteSelectedOperatorDiscoveryAsync(IPreferences, String, String, String)][4]                                               | Convenience version of [CompleteSelectedOperatorDiscoveryAsync(String, String, String, String, String, String)][6] where the clientId, clientSecret and discoveryUrl are provided by the IPreferences implementation                                                                                                                                            
![Public method] | [CompleteSelectedOperatorDiscoveryAsync(String, String, String, String, String, String)][6]                                     | Allows an application to use the selected operator MCC and MNC to obtain the discovery response. In the case there is already a discovery result in the cache and the Selected-MCC/Selected-MNC in the new request are the same as relates to the discovery result for the cached result, the cached result will be returned.                                   
![Public method] | [ExtractOperatorSelectionURL][7]                                                                                                | Helper function to extract operator selection URL from the discovery reponse                                                                                                                                                                                                                                                                                    
![Public method] | [GetCachedDiscoveryResult][8]                                                                                                   | Helper function which retrieves a discovery response (if available) from the discovery cache which corresponds with the operator details                                                                                                                                                                                                                        
![Public method] | [GetOperatorSelectionURL(IPreferences, String)][9]                                                                              | Synchronous wrapper for [GetOperatorSelectionURLAsync(IPreferences, String)][10]                                                                                                                                                                                                                                                                                
![Public method] | [GetOperatorSelectionURL(String, String, String, String)][11]                                                                   | Synchronous wrapper for [GetOperatorSelectionURLAsync(String, String, String, String)][12]                                                                                                                                                                                                                                                                      
![Public method] | [GetOperatorSelectionURLAsync(IPreferences, String)][10]                                                                        | Convenience wrapper for [GetOperatorSelectionURLAsync(String, String, String, String)][12] where the clientId, clientSecret and discoveryUrl are provided by the IPreferences implementation                                                                                                                                                                    
![Public method] | [GetOperatorSelectionURLAsync(String, String, String, String)][12]                                                              | Allows an application to get the URL for the operator selection UI of the discovery service. This will not reference the discovery result cache. The returned URL will contain a session id created by the discovery server. The URL must be used as-is.                                                                                                        
![Public method] | [ParseDiscoveryRedirect][13]                                                                                                    | Allows an application to obtain parameters which have been passed within a discovery redirect URL                                                                                                                                                                                                                                                               
![Public method] | [StartAutomatedOperatorDiscovery(IPreferences, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][14]                | Synchronous wrapper for [StartAutomatedOperatorDiscoveryAsync(IPreferences, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][15]                                                                                                                                                                                                                   
![Public method] | [StartAutomatedOperatorDiscovery(String, String, String, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][16]      | Synchronous wrapper for [StartAutomatedOperatorDiscoveryAsync(String, String, String, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][17]                                                                                                                                                                                                         
![Public method] | [StartAutomatedOperatorDiscoveryAsync(IPreferences, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][15]           | Convenience version of [StartAutomatedOperatorDiscoveryAsync(String, String, String, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][17] where the clientId, clientSecret and discoveryUrl are provided by the IPreferences implementation                                                                                                        
![Public method] | [StartAutomatedOperatorDiscoveryAsync(String, String, String, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][17] | Allows an application to conduct discovery based on the predetermined operator/network identified operator semantics. If the operator cannot be identified the function will return the 'operator selection' form of the response. The application can then determine how to proceed i.e. open the operator selection page separately or otherwise handle this. 


See Also
--------

#### Reference
[GSMA.MobileConnect.Discovery Namespace][1]  
[GSMA.MobileConnect.Discovery.Discovery][18]  
[GSMA.MobileConnect.Discovery.DiscoveryOptions][19]  
[GSMA.MobileConnect.Discovery.DiscoveryResponse][20]  

[1]: ../README.md
[2]: ClearDiscoveryCache.md
[3]: CompleteSelectedOperatorDiscovery.md
[4]: CompleteSelectedOperatorDiscoveryAsync.md
[5]: CompleteSelectedOperatorDiscovery_1.md
[6]: CompleteSelectedOperatorDiscoveryAsync_1.md
[7]: ExtractOperatorSelectionURL.md
[8]: GetCachedDiscoveryResult.md
[9]: GetOperatorSelectionURL.md
[10]: GetOperatorSelectionURLAsync.md
[11]: GetOperatorSelectionURL_1.md
[12]: GetOperatorSelectionURLAsync_1.md
[13]: ParseDiscoveryRedirect.md
[14]: StartAutomatedOperatorDiscovery.md
[15]: StartAutomatedOperatorDiscoveryAsync.md
[16]: StartAutomatedOperatorDiscovery_1.md
[17]: StartAutomatedOperatorDiscoveryAsync_1.md
[18]: ../Discovery/README.md
[19]: ../DiscoveryOptions/README.md
[20]: ../DiscoveryResponse/README.md
[21]: ../../_icons/Help.png
[Public method]: ../../_icons/pubmethod.gif "Public method"