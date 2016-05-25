IDiscovery.GetCachedDiscoveryResult Method
==========================================
Helper function which retrieves a discovery response (if available) from the discovery cache which corresponds with the operator details

**Namespace:** [GSMA.MobileConnect.Discovery][1]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
DiscoveryResponse GetCachedDiscoveryResult(
	string mcc,
	string mnc
)
```

#### Parameters

##### *mcc*
Type: [System.String][2]  
The Mobile Country Code (Required)

##### *mnc*
Type: [System.String][2]  
The Mobile Network Code (Required)

#### Return Value
Type: [DiscoveryResponse][3]  
A cached entry if found, otherwise null

See Also
--------

#### Reference
[IDiscovery Interface][4]  
[GSMA.MobileConnect.Discovery Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: ../DiscoveryResponse/README.md
[4]: README.md
[5]: ../../_icons/Help.png