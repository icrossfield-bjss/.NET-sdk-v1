MobileConnectInterface.HandleUrlRedirect Method
===============================================
Synchronous wrapper for [HandleUrlRedirectAsync(Uri, String, String, String)][1]

**Namespace:** [GSMA.MobileConnect][2]  
**Assembly:** GSMA.MobileConnect (in GSMA.MobileConnect.dll)

Syntax
------

```csharp
public MobileConnectStatus HandleUrlRedirect(
	Uri redirectedUrl,
	string expectedState = null,
	string expectedNonce = null,
	string requestTokenUrl = null
)
```

#### Parameters

##### *redirectedUrl*
Type: [System.Uri][3]  
Url redirected to by the completion of the previous step

##### *expectedState* (Optional)
Type: [System.String][4]  
The state value returned from the StartAuthorization call should be passed here, it will be used to validate the authenticity of the authorization process

##### *expectedNonce* (Optional)
Type: [System.String][4]  
The nonce value returned from the StartAuthorization call should be passed here, it will be used to ensure the token was not requested using a replay attack

##### *requestTokenUrl* (Optional)
Type: [System.String][4]  
Url for token request, this is returned by the discovery process. An error status will be returned if the redirected url triggers a token request and this parameter has not been provided.

#### Return Value
Type: [MobileConnectStatus][5]  
MobileConnectStatus object with required information for continuing the mobileconnect process

See Also
--------

#### Reference
[MobileConnectInterface Class][6]  
[GSMA.MobileConnect Namespace][2]  

[1]: HandleUrlRedirectAsync.md
[2]: ../README.md
[3]: http://msdn.microsoft.com/en-us/library/txt7706a
[4]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[5]: ../MobileConnectStatus/README.md
[6]: README.md
[7]: ../../_icons/Help.png