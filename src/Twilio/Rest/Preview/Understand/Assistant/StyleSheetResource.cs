/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// StyleSheetResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.Understand.Assistant
{

    public class StyleSheetResource : Resource
    {
        private static Request BuildFetchRequest(FetchStyleSheetOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/understand/Assistants/" + options.PathAssistantSid + "/StyleSheet",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Returns Style sheet JSON object for this Assistant
        /// </summary>
        /// <param name="options"> Fetch StyleSheet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of StyleSheet </returns>
        public static StyleSheetResource Fetch(FetchStyleSheetOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Returns Style sheet JSON object for this Assistant
        /// </summary>
        /// <param name="options"> Fetch StyleSheet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of StyleSheet </returns>
        public static async System.Threading.Tasks.Task<StyleSheetResource> FetchAsync(FetchStyleSheetOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Returns Style sheet JSON object for this Assistant
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the Assistant </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of StyleSheet </returns>
        public static StyleSheetResource Fetch(string pathAssistantSid, ITwilioRestClient client = null)
        {
            var options = new FetchStyleSheetOptions(pathAssistantSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns Style sheet JSON object for this Assistant
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the Assistant </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of StyleSheet </returns>
        public static async System.Threading.Tasks.Task<StyleSheetResource> FetchAsync(string pathAssistantSid,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new FetchStyleSheetOptions(pathAssistantSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateStyleSheetOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/understand/Assistants/" + options.PathAssistantSid + "/StyleSheet",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Updates the style sheet for an assistant identified by {AssistantSid} or {AssistantUniqueName}.
        /// </summary>
        /// <param name="options"> Update StyleSheet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of StyleSheet </returns>
        public static StyleSheetResource Update(UpdateStyleSheetOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Updates the style sheet for an assistant identified by {AssistantSid} or {AssistantUniqueName}.
        /// </summary>
        /// <param name="options"> Update StyleSheet parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of StyleSheet </returns>
        public static async System.Threading.Tasks.Task<StyleSheetResource> UpdateAsync(UpdateStyleSheetOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Updates the style sheet for an assistant identified by {AssistantSid} or {AssistantUniqueName}.
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the Assistant </param>
        /// <param name="styleSheet"> The JSON Style sheet string </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of StyleSheet </returns>
        public static StyleSheetResource Update(string pathAssistantSid,
                                                object styleSheet = null,
                                                ITwilioRestClient client = null)
        {
            var options = new UpdateStyleSheetOptions(pathAssistantSid){StyleSheet = styleSheet};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Updates the style sheet for an assistant identified by {AssistantSid} or {AssistantUniqueName}.
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the Assistant </param>
        /// <param name="styleSheet"> The JSON Style sheet string </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of StyleSheet </returns>
        public static async System.Threading.Tasks.Task<StyleSheetResource> UpdateAsync(string pathAssistantSid,
                                                                                        object styleSheet = null,
                                                                                        ITwilioRestClient client = null)
        {
            var options = new UpdateStyleSheetOptions(pathAssistantSid){StyleSheet = styleSheet};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a StyleSheetResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> StyleSheetResource object represented by the provided JSON </returns>
        public static StyleSheetResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<StyleSheetResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique ID of the Account that created this Assistant
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The unique ID of the Assistant
        /// </summary>
        [JsonProperty("assistant_sid")]
        public string AssistantSid { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The JSON style sheet object
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; private set; }

        private StyleSheetResource()
        {

        }
    }

}