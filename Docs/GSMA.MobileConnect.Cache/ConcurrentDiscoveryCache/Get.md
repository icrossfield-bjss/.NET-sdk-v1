ConcurrentDiscoveryCache.Get Method
===================================
Retrieves a copy of the cached response if found and has not expired

**Namespace:** [GSMA.MobileConnect.Cache][1]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public DiscoveryResponse Get(
	string mcc,
	string mnc
)
```

#### Parameters

##### *mcc*
Type: [System.String][2]  
Mobile Country Code

##### *mnc*
Type: [System.String][2]  
Mobile Network Code

#### Return Value
Type: [DiscoveryResponse][3]  
A copy of the cached value or null if no cached value or cached value has expired
#### Implements
[IDiscoveryCache.Get(String, String)][4]  


See Also
--------

#### Reference
[ConcurrentDiscoveryCache Class][5]  
[GSMA.MobileConnect.Cache Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: ../../GSMA.MobileConnect.Discovery/DiscoveryResponse/README.md
[4]: ../IDiscoveryCache/Get.md
[5]: README.md
[6]: ../../_icons/Help.png