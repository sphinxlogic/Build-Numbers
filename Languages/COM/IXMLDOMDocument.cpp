#include "wmsserver.h"
#include <atlbase.h> // Includes CComVariant and CComBSTR.

// Declare variables.
IWMSServer*         pServer;
IXMLDOMDocument*    pPlaylist;

HRESULT             hr;
VARIANT_BOOL        bIsSuccessful;
CComBSTR            bstrXML;

// Initialize the COM library and retrieve a pointer
// to an IWMSServer interface.
hr = CoInitialize(NULL);
hr = CoCreateInstance(CLSID_WMSServer, NULL, CLSCTX_ALL, 
       IID_IWMSServer, (void**)&pServer);
if (FAILED(hr)) goto EXIT;

// Create the playlist object.
hr = pServer->CreatePlaylist(&pPlaylist);

// Load a sample playlist file.
bstrXML = "<?wsx version \"1.0\" ?><smil> \
           <media src = \"welcome1.asf\"/></smil>";
hr = pPlaylist->loadXML(bstrXML, &bIsSuccessful);

EXIT:
    // TODO: Release temporary COM objects and uninitialize COM.
if (FAILED(hr)) goto EXIT;