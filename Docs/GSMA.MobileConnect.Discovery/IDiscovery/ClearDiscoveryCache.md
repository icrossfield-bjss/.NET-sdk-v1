IDiscovery.ClearDiscoveryCache Method
=====================================
Helper function which clears any result from the discovery cache which corresponds with the provided parameters

**Namespace:** [GSMA.MobileConnect.Discovery][1]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
void ClearDiscoveryCache(
	string mcc,
	string mnc
)
```

#### Parameters

##### *mcc*
Type: [System.String][2]  
The mobile country code of the cached object (optional)

##### *mnc*
Type: [System.String][2]  
The mobile network code of the cached object (optional)


Remarks
-------
If either mcc or mnc are null or empty the cache will be cleared

See Also
--------

#### Reference
[IDiscovery Interface][3]  
[GSMA.MobileConnect.Discovery Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: README.md
[4]: ../../_icons/Help.png