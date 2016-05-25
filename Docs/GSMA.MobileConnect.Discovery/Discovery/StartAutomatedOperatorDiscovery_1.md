Discovery.StartAutomatedOperatorDiscovery Method (String, String, String, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)
======================================================================================================================================
Synchronous wrapper for [StartAutomatedOperatorDiscoveryAsync(String, String, String, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][1]

**Namespace:** [GSMA.MobileConnect.Discovery][2]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public DiscoveryResponse StartAutomatedOperatorDiscovery(
	string clientId,
	string clientSecret,
	string discoveryUrl,
	string redirectUrl,
	DiscoveryOptions options,
	IEnumerable<BasicKeyValuePair> currentCookies
)
```

#### Parameters

##### *clientId*
Type: [System.String][3]  
The registered application clientId (Required)

##### *clientSecret*
Type: [System.String][3]  
the registered application client secret (Required)

##### *discoveryUrl*
Type: [System.String][3]  
The URL of the discovery endpoint (Required)

##### *redirectUrl*
Type: [System.String][3]  
The URL of the operator selection functionality redirects to. (Required)

##### *options*
Type: [GSMA.MobileConnect.Discovery.DiscoveryOptions][4]  
Optional parameters

##### *currentCookies*
Type: [System.Collections.Generic.IEnumerable][5]&lt;[BasicKeyValuePair][6]>  
List of the current cookies sent by the browser if applicable

#### Return Value
Type: [DiscoveryResponse][7]  

[Missing &lt;returns> documentation for "M:GSMA.MobileConnect.Discovery.Discovery.StartAutomatedOperatorDiscovery(System.String,System.String,System.String,System.String,GSMA.MobileConnect.Discovery.DiscoveryOptions,System.Collections.Generic.IEnumerable{GSMA.MobileConnect.Utils.BasicKeyValuePair})"]

#### Implements
[IDiscovery.StartAutomatedOperatorDiscovery(String, String, String, String, DiscoveryOptions, IEnumerable&lt;BasicKeyValuePair>)][8]  


See Also
--------

#### Reference
[Discovery Class][9]  
[GSMA.MobileConnect.Discovery Namespace][2]  

[1]: ../IDiscovery/StartAutomatedOperatorDiscoveryAsync_1.md
[2]: ../README.md
[3]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[4]: ../DiscoveryOptions/README.md
[5]: http://msdn.microsoft.com/en-us/library/9eekhta0
[6]: ../../GSMA.MobileConnect.Utils/BasicKeyValuePair/README.md
[7]: ../DiscoveryResponse/README.md
[8]: ../IDiscovery/StartAutomatedOperatorDiscovery_1.md
[9]: README.md
[10]: ../../_icons/Help.png