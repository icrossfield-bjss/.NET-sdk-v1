IDiscovery.GetOperatorSelectionURL Method (IPreferences, String)
================================================================
Synchronous wrapper for [GetOperatorSelectionURLAsync(IPreferences, String)][1]

**Namespace:** [GSMA.MobileConnect.Discovery][2]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
DiscoveryResponse GetOperatorSelectionURL(
	IPreferences preferences,
	string redirectUrl
)
```

#### Parameters

##### *preferences*
Type: [GSMA.MobileConnect.Discovery.IPreferences][3]  
Instance of IPreferences that provides clientId, clientSecret and discoveryUrl (Required)

##### *redirectUrl*
Type: [System.String][4]  
The URL the operator selection functionality redirects to. (Required)

#### Return Value
Type: [DiscoveryResponse][5]  

[Missing &lt;returns> documentation for "M:GSMA.MobileConnect.Discovery.IDiscovery.GetOperatorSelectionURL(GSMA.MobileConnect.Discovery.IPreferences,System.String)"]


See Also
--------

#### Reference
[IDiscovery Interface][6]  
[GSMA.MobileConnect.Discovery Namespace][2]  

[1]: GetOperatorSelectionURLAsync.md
[2]: ../README.md
[3]: ../IPreferences/README.md
[4]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[5]: ../DiscoveryResponse/README.md
[6]: README.md
[7]: ../../_icons/Help.png