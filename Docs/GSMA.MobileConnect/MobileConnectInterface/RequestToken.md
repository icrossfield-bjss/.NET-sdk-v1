MobileConnectInterface.RequestToken Method
==========================================
Synchronous wrapper for [RequestTokenAsync(String, Uri, String, String)][1]

**Namespace:** [GSMA.MobileConnect][2]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public MobileConnectStatus RequestToken(
	string requestTokenUrl,
	Uri redirectedUrl,
	string expectedState,
	string expectedNonce
)
```

#### Parameters

##### *requestTokenUrl*
Type: [System.String][3]  
Network specific url for token request service returned from the Discovery process

##### *redirectedUrl*
Type: [System.Uri][4]  
Uri redirected to by the completion of the authorization UI

##### *expectedState*
Type: [System.String][3]  
The state value returned from the StartAuthorization call should be passed here, it will be used to validate the authenticity of the authorization process

##### *expectedNonce*
Type: [System.String][3]  
The nonce value returned from the StartAuthorization call should be passed here, it will be used to ensure the token was not requested using a replay attack

#### Return Value
Type: [MobileConnectStatus][5]  
MobileConnectStatus object with required information for continuing the mobileconnect process

See Also
--------

#### Reference
[MobileConnectInterface Class][6]  
[GSMA.MobileConnect Namespace][2]  

[1]: RequestTokenAsync.md
[2]: ../README.md
[3]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[4]: http://msdn.microsoft.com/en-us/library/txt7706a
[5]: ../MobileConnectStatus/README.md
[6]: README.md
[7]: ../../_icons/Help.png