MobileConnectInterface.RequestTokenAsync Method
===============================================
Request token using the values returned from the authorization redirect

**Namespace:** [GSMA.MobileConnect][1]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public Task<MobileConnectStatus> RequestTokenAsync(
	string requestTokenUrl,
	Uri redirectedUrl,
	string expectedState,
	string expectedNonce
)
```

#### Parameters

##### *requestTokenUrl*
Type: [System.String][2]  
Network specific url for token request service returned from the Discovery process

##### *redirectedUrl*
Type: [System.Uri][3]  
Uri redirected to by the completion of the authorization UI

##### *expectedState*
Type: [System.String][2]  
The state value returned from the StartAuthorization call should be passed here, it will be used to validate the authenticity of the authorization process

##### *expectedNonce*
Type: [System.String][2]  
The nonce value returned from the StartAuthorization call should be passed here, it will be used to ensure the token was not requested using a replay attack

#### Return Value
Type: [Task][4]&lt;[MobileConnectStatus][5]>  
MobileConnectStatus object with required information for continuing the mobileconnect process

See Also
--------

#### Reference
[MobileConnectInterface Class][6]  
[GSMA.MobileConnect Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[3]: http://msdn.microsoft.com/en-us/library/txt7706a
[4]: http://msdn.microsoft.com/en-us/library/dd321424
[5]: ../MobileConnectStatus/README.md
[6]: README.md
[7]: ../../_icons/Help.png