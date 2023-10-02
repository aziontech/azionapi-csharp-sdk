# waf.Model.CreateNewWAFRulesetRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** |  | [optional] 
**Name** | **string** | Identification name for WAF Rule Set. | 
**Mode** | **string** |  | 
**Active** | **bool** |  | 
**SqlInjection** | **bool** |  | 
**SqlInjectionSensitivity** | **WAFSensitivityChoices** |  | 
**RemoteFileInclusion** | **bool** |  | 
**RemoteFileInclusionSensitivity** | **WAFSensitivityChoices** |  | 
**DirectoryTraversal** | **bool** |  | 
**DirectoryTraversalSensitivity** | **WAFSensitivityChoices** |  | 
**CrossSiteScripting** | **bool** |  | 
**CrossSiteScriptingSensitivity** | **WAFSensitivityChoices** |  | 
**EvadingTricks** | **bool** |  | 
**EvadingTricksSensitivity** | **WAFSensitivityChoices** |  | 
**FileUpload** | **bool** |  | 
**FileUploadSensitivity** | **WAFSensitivityChoices** |  | 
**UnwantedAccess** | **bool** |  | 
**UnwantedAccessSensitivity** | **WAFSensitivityChoices** |  | 
**IdentifiedAttack** | **bool** |  | 
**IdentifiedAttackSensitivity** | **WAFSensitivityChoices** |  | 
**BypassAddresses** | **List&lt;string&gt;** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

