# data_streaming.Model.PostCustomDataStreamingResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] 
**Name** | **string** |  | [optional] 
**DataSource** | **string** | Options:  * &#x60;http&#x60; - Edge Applications  * &#x60;waf&#x60; - WAF Events  * &#x60;cells_console&#x60; - Edge Functions  * &#x60;rtm_activity&#x60; - Activity History    | [optional] 
**TemplateModel** | **string** | Note:  * Add all variables and values that will be used to stream according to the data source you choose to use.    | [optional] 
**Active** | **bool** |  | [optional] 
**Endpoint** | **string** |  | [optional] 
**AllDomains** | **bool?** | Note:  * Field not used with the rtm_activity data source.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

