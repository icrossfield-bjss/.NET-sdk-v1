IDiscoveryCache Interface
=========================
Interface for the discovery response cache

**Namespace:** [GSMA.MobileConnect.Cache][1]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public interface IDiscoveryCache
```

The **IDiscoveryCache** type exposes the following members.


Properties
----------

                   | Name         | Description         
------------------ | ------------ | ------------------- 
![Public property] | [IsEmpty][2] | Is the cache empty? 


Methods
-------

                 | Name        | Description                                                 
---------------- | ----------- | ----------------------------------------------------------- 
![Public method] | [Add][3]    | Add a value to the cache with the specified mcc and mnc     
![Public method] | [Clear][4]  | Remove all key value pairs from the cache                   
![Public method] | [Get][5]    | Return a cached value based on the mcc and mnc              
![Public method] | [Remove][6] | Remove an entry from the cache that matches the mcc and mnc 


See Also
--------

#### Reference
[GSMA.MobileConnect.Cache Namespace][1]  

[1]: ../README.md
[2]: IsEmpty.md
[3]: Add.md
[4]: Clear.md
[5]: Get.md
[6]: Remove.md
[7]: ../../_icons/Help.png
[Public property]: ../../_icons/pubproperty.gif "Public property"
[Public method]: ../../_icons/pubmethod.gif "Public method"