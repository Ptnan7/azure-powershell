In this directory, run AutoRest:
```
autorest --reset
autorest --use:@autorest/powershell@4.x
```

### AutoRest Configuration
> see https://aka.ms/autorest
``` yaml

commit: f11631f1c1057d8363f9e3f9597c73b90f8924c8
input-file:
  - "C:/Users/jingnanxu/source/repos/waf-05-16-p/specification/frontdoor/resource-manager/Microsoft.Network/stable/2021-06-01/frontdoor.json"
  - "C:/Users/jingnanxu/source/repos/waf-05-16-p/specification/frontdoor/resource-manager/Microsoft.Network/preview/2025-05-16-preview/webapplicationfirewall.json"
  - "C:/Users/jingnanxu/source/repos/waf-05-16-p/specification/frontdoor/resource-manager/Microsoft.Network/preview/2025-05-16-preview/network.json"
  - "C:/Users/jingnanxu/source/repos/waf-05-16-p/specification/frontdoor/resource-manager/Microsoft.Network/stable/2019-11-01/networkexperiment.json"


# csharp: true
isSdkGenerator: true
powershell: true
clear-output-folder: true
openapi-type: arm
azure-arm: true
output-folder: Generated
namespace: Microsoft.Azure.Management.FrontDoor
title: FrontDoor

directive:
  - from: swagger-document
    where: $.definitions.RouteUpdatePropertiesParameters.properties.supportedProtocols
    transform: delete $.default
  - from: swagger-document
    where: $.definitions.PolicySettings.properties.logScrubbing
    transform: $['x-ms-client-flatten'] = false;
  - where:
      model-name: FrontDoor
    set:
      model-name: FrontDoorModel
