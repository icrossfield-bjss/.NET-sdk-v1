MobileConnectInterface.StartAuthorization Method
================================================
Creates an authorization url with parameters to begin the authorization process

**Namespace:** [GSMA.MobileConnect][1]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public MobileConnectStatus StartAuthorization(
	string authorizationUrl,
	string encryptedMSISDN,
	string state,
	string nonce,
	MobileConnectRequestOptions options
)
```

#### Parameters

##### *authorizationUrl*
Type: [System.String][2]  
Network specific url for authorization service returned from the Discovery process

##### *encryptedMSISDN*
Type: [System.String][2]  
Encrypted MSISDN/Subscriber Id returned from the Discovery process

##### *state*
Type: [System.String][2]  
Unique state value, this will be returned by the authorization process and should be checked for equality as a security measure

##### *nonce*
Type: [System.String][2]  
Unique value to associate a client session with an id token

##### *options*
Type: [GSMA.MobileConnect.MobileConnectRequestOptions][3]  
Optional parameters

#### Return Value
Type: [MobileConnectStatus][4]  
MobileConnectStatus object with required information for continuing the mobileconnect process

See Also
--------

#### Reference
[MobileConnectInterface Class][5]  
[GSMA.MobileConnect Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: ../MobileConnectRequestOptions/README.md
[4]: ../MobileConnectStatus/README.md
[5]: README.md
[6]: ../../_icons/Help.png