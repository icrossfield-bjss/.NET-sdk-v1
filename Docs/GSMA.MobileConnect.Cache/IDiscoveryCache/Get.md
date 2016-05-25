IDiscoveryCache.Get Method
==========================
Return a cached value based on the mcc and mnc

**Namespace:** [GSMA.MobileConnect.Cache][1]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
DiscoveryResponse Get(
	string mcc,
	string mnc
)
```

#### Parameters

##### *mcc*
Type: [System.String][2]  
Mobile Country Code (Required)

##### *mnc*
Type: [System.String][2]  
Mobile Network Code (Required)

#### Return Value
Type: [DiscoveryResponse][3]  
The cached value if present, null otherwise

See Also
--------

#### Reference
[IDiscoveryCache Interface][4]  
[GSMA.MobileConnect.Cache Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: ../../GSMA.MobileConnect.Discovery/DiscoveryResponse/README.md
[4]: README.md
[5]: ../../_icons/Help.png