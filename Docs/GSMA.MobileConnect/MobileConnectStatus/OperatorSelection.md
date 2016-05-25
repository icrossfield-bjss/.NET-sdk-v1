MobileConnectStatus.OperatorSelection Method
============================================
Creates a Status with ResponseType OperatorSelection and url for next process step. Indicates that the next step should be navigating to the operator selection URL.

**Namespace:** [GSMA.MobileConnect][1]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public static MobileConnectStatus OperatorSelection(
	string url
)
```

#### Parameters

##### *url*
Type: [System.String][2]  
Operator selection URL returned from [IDiscovery][3]

#### Return Value
Type: [MobileConnectStatus][4]  
MobileConnectStatus with ResponseType OperatorSelection

See Also
--------

#### Reference
[MobileConnectStatus Class][4]  
[GSMA.MobileConnect Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: ../../GSMA.MobileConnect.Discovery/IDiscovery/README.md
[4]: README.md
[5]: ../../_icons/Help.png