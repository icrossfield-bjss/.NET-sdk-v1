ConcurrentDiscoveryCache.Add Method
===================================
Adds the DiscoveryResponse to the cache with the supplied MCC and MNC values

**Namespace:** [GSMA.MobileConnect.Cache][1]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public void Add(
	string mcc,
	string mnc,
	DiscoveryResponse value
)
```

#### Parameters

##### *mcc*
Type: [System.String][2]  
Mobile Country Code

##### *mnc*
Type: [System.String][2]  
Mobile Network Code

##### *value*
Type: [GSMA.MobileConnect.Discovery.DiscoveryResponse][3]  
Value to be cached

#### Implements
[IDiscoveryCache.Add(String, String, DiscoveryResponse)][4]  


Remarks
-------
Value will not be cached if MCC or MNC are null or empty

See Also
--------

#### Reference
[ConcurrentDiscoveryCache Class][5]  
[GSMA.MobileConnect.Cache Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: ../../GSMA.MobileConnect.Discovery/DiscoveryResponse/README.md
[4]: ../IDiscoveryCache/Add.md
[5]: README.md
[6]: ../../_icons/Help.png