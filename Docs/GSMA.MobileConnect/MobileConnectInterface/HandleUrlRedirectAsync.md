MobileConnectInterface.HandleUrlRedirectAsync Method
====================================================
Handles continuation of the process following a completed redirect. Only the redirectedUrl is required, however if the redirect being handled is the result of calling the Authorization URL then the remaining parameters are required.

**Namespace:** [GSMA.MobileConnect][1]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public Task<MobileConnectStatus> HandleUrlRedirectAsync(
	Uri redirectedUrl,
	string expectedState = null,
	string expectedNonce = null,
	string requestTokenUrl = null
)
```

#### Parameters

##### *redirectedUrl*
Type: [System.Uri][2]  
Url redirected to by the completion of the previous step

##### *expectedState* (Optional)
Type: [System.String][3]  
The state value returned from the StartAuthorization call should be passed here, it will be used to validate the authenticity of the authorization process

##### *expectedNonce* (Optional)
Type: [System.String][3]  
The nonce value returned from the StartAuthorization call should be passed here, it will be used to ensure the token was not requested using a replay attack

##### *requestTokenUrl* (Optional)
Type: [System.String][3]  
Url for token request, this is returned by the discovery process. An error status will be returned if the redirected url triggers a token request and this parameter has not been provided.

#### Return Value
Type: [Task][4]&lt;[MobileConnectStatus][5]>  
MobileConnectStatus object with required information for continuing the mobileconnect process

See Also
--------

#### Reference
[MobileConnectInterface Class][6]  
[GSMA.MobileConnect Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/txt7706a
[3]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[4]: http://msdn.microsoft.com/en-us/library/dd321424
[5]: ../MobileConnectStatus/README.md
[6]: README.md
[7]: ../../_icons/Help.png