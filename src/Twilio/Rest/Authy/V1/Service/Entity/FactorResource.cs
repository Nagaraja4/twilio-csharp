/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// FactorResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Authy.V1.Service.Entity 
{

    public class FactorResource : Resource 
    {
        public sealed class FactorStatusesEnum : StringEnum 
        {
            private FactorStatusesEnum(string value) : base(value) {}
            public FactorStatusesEnum() {}
            public static implicit operator FactorStatusesEnum(string value)
            {
                return new FactorStatusesEnum(value);
            }

            public static readonly FactorStatusesEnum Unverified = new FactorStatusesEnum("unverified");
            public static readonly FactorStatusesEnum Verified = new FactorStatusesEnum("verified");
        }

        public sealed class FactorTypesEnum : StringEnum 
        {
            private FactorTypesEnum(string value) : base(value) {}
            public FactorTypesEnum() {}
            public static implicit operator FactorTypesEnum(string value)
            {
                return new FactorTypesEnum(value);
            }

            public static readonly FactorTypesEnum AppPush = new FactorTypesEnum("app-push");
            public static readonly FactorTypesEnum Sms = new FactorTypesEnum("sms");
            public static readonly FactorTypesEnum Totp = new FactorTypesEnum("totp");
        }

        private static Request BuildCreateRequest(CreateFactorOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Authy,
                "/v1/Services/" + options.PathServiceSid + "/Entities/" + options.PathIdentity + "/Factors",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a new Factor for the Entity
        /// </summary>
        /// <param name="options"> Create Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns> 
        public static FactorResource Create(CreateFactorOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Factor for the Entity
        /// </summary>
        /// <param name="options"> Create Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns> 
        public static async System.Threading.Tasks.Task<FactorResource> CreateAsync(CreateFactorOptions options, 
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Factor for the Entity
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="binding"> A unique binding for this Factor </param>
        /// <param name="friendlyName"> The friendly name of this Factor </param>
        /// <param name="factorType"> The Type of this Factor </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns> 
        public static FactorResource Create(string pathServiceSid, 
                                            string pathIdentity, 
                                            string binding, 
                                            string friendlyName, 
                                            FactorResource.FactorTypesEnum factorType, 
                                            ITwilioRestClient client = null)
        {
            var options = new CreateFactorOptions(pathServiceSid, pathIdentity, binding, friendlyName, factorType);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Factor for the Entity
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="binding"> A unique binding for this Factor </param>
        /// <param name="friendlyName"> The friendly name of this Factor </param>
        /// <param name="factorType"> The Type of this Factor </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns> 
        public static async System.Threading.Tasks.Task<FactorResource> CreateAsync(string pathServiceSid, 
                                                                                    string pathIdentity, 
                                                                                    string binding, 
                                                                                    string friendlyName, 
                                                                                    FactorResource.FactorTypesEnum factorType, 
                                                                                    ITwilioRestClient client = null)
        {
            var options = new CreateFactorOptions(pathServiceSid, pathIdentity, binding, friendlyName, factorType);
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteFactorOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Authy,
                "/v1/Services/" + options.PathServiceSid + "/Entities/" + options.PathIdentity + "/Factors/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Delete a specific Factor.
        /// </summary>
        /// <param name="options"> Delete Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns> 
        public static bool Delete(DeleteFactorOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Factor.
        /// </summary>
        /// <param name="options"> Delete Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteFactorOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a specific Factor.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="pathSid"> A string that uniquely identifies this Factor. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns> 
        public static bool Delete(string pathServiceSid, 
                                  string pathIdentity, 
                                  string pathSid, 
                                  ITwilioRestClient client = null)
        {
            var options = new DeleteFactorOptions(pathServiceSid, pathIdentity, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Factor.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="pathSid"> A string that uniquely identifies this Factor. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, 
                                                                          string pathIdentity, 
                                                                          string pathSid, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteFactorOptions(pathServiceSid, pathIdentity, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchFactorOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Authy,
                "/v1/Services/" + options.PathServiceSid + "/Entities/" + options.PathIdentity + "/Factors/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch a specific Factor.
        /// </summary>
        /// <param name="options"> Fetch Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns> 
        public static FactorResource Fetch(FetchFactorOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Factor.
        /// </summary>
        /// <param name="options"> Fetch Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns> 
        public static async System.Threading.Tasks.Task<FactorResource> FetchAsync(FetchFactorOptions options, 
                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific Factor.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="pathSid"> A string that uniquely identifies this Factor. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns> 
        public static FactorResource Fetch(string pathServiceSid, 
                                           string pathIdentity, 
                                           string pathSid, 
                                           ITwilioRestClient client = null)
        {
            var options = new FetchFactorOptions(pathServiceSid, pathIdentity, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Factor.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="pathSid"> A string that uniquely identifies this Factor. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns> 
        public static async System.Threading.Tasks.Task<FactorResource> FetchAsync(string pathServiceSid, 
                                                                                   string pathIdentity, 
                                                                                   string pathSid, 
                                                                                   ITwilioRestClient client = null)
        {
            var options = new FetchFactorOptions(pathServiceSid, pathIdentity, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadFactorOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Authy,
                "/v1/Services/" + options.PathServiceSid + "/Entities/" + options.PathIdentity + "/Factors",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Factors for an Entity.
        /// </summary>
        /// <param name="options"> Read Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns> 
        public static ResourceSet<FactorResource> Read(ReadFactorOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<FactorResource>.FromJson("factors", response.Content);
            return new ResourceSet<FactorResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Factors for an Entity.
        /// </summary>
        /// <param name="options"> Read Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<FactorResource>> ReadAsync(ReadFactorOptions options, 
                                                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<FactorResource>.FromJson("factors", response.Content);
            return new ResourceSet<FactorResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Factors for an Entity.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns> 
        public static ResourceSet<FactorResource> Read(string pathServiceSid, 
                                                       string pathIdentity, 
                                                       int? pageSize = null, 
                                                       long? limit = null, 
                                                       ITwilioRestClient client = null)
        {
            var options = new ReadFactorOptions(pathServiceSid, pathIdentity){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Factors for an Entity.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<FactorResource>> ReadAsync(string pathServiceSid, 
                                                                                               string pathIdentity, 
                                                                                               int? pageSize = null, 
                                                                                               long? limit = null, 
                                                                                               ITwilioRestClient client = null)
        {
            var options = new ReadFactorOptions(pathServiceSid, pathIdentity){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<FactorResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<FactorResource>.FromJson("factors", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<FactorResource> NextPage(Page<FactorResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Authy,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<FactorResource>.FromJson("factors", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<FactorResource> PreviousPage(Page<FactorResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Authy,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<FactorResource>.FromJson("factors", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateFactorOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Authy,
                "/v1/Services/" + options.PathServiceSid + "/Entities/" + options.PathIdentity + "/Factors/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Update a specific Factor. This endpoint can be used to Verify a Factor if passed an `AuthPayload` param.
        /// </summary>
        /// <param name="options"> Update Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns> 
        public static FactorResource Update(UpdateFactorOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update a specific Factor. This endpoint can be used to Verify a Factor if passed an `AuthPayload` param.
        /// </summary>
        /// <param name="options"> Update Factor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns> 
        public static async System.Threading.Tasks.Task<FactorResource> UpdateAsync(UpdateFactorOptions options, 
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update a specific Factor. This endpoint can be used to Verify a Factor if passed an `AuthPayload` param.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="pathSid"> A string that uniquely identifies this Factor. </param>
        /// <param name="authPayload"> Optional payload to verify the Factor for the first time </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Factor </returns> 
        public static FactorResource Update(string pathServiceSid, 
                                            string pathIdentity, 
                                            string pathSid, 
                                            string authPayload = null, 
                                            ITwilioRestClient client = null)
        {
            var options = new UpdateFactorOptions(pathServiceSid, pathIdentity, pathSid){AuthPayload = authPayload};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update a specific Factor. This endpoint can be used to Verify a Factor if passed an `AuthPayload` param.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        /// <param name="pathSid"> A string that uniquely identifies this Factor. </param>
        /// <param name="authPayload"> Optional payload to verify the Factor for the first time </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Factor </returns> 
        public static async System.Threading.Tasks.Task<FactorResource> UpdateAsync(string pathServiceSid, 
                                                                                    string pathIdentity, 
                                                                                    string pathSid, 
                                                                                    string authPayload = null, 
                                                                                    ITwilioRestClient client = null)
        {
            var options = new UpdateFactorOptions(pathServiceSid, pathIdentity, pathSid){AuthPayload = authPayload};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a FactorResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FactorResource object represented by the provided JSON </returns> 
        public static FactorResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<FactorResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Factor.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Service Sid.
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// Entity Sid.
        /// </summary>
        [JsonProperty("entity_sid")]
        public string EntitySid { get; private set; }
        /// <summary>
        /// Unique identity of the Entity
        /// </summary>
        [JsonProperty("identity")]
        public string Identity { get; private set; }
        /// <summary>
        /// The date this Factor was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Factor was updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// A human readable description of this resource.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The Status of this Factor
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FactorResource.FactorStatusesEnum Status { get; private set; }
        /// <summary>
        /// The Type of this Factor
        /// </summary>
        [JsonProperty("factor_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public FactorResource.FactorTypesEnum FactorType { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Nested resource URLs.
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private FactorResource()
        {

        }
    }

}