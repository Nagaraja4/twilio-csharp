using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Address {

    public class DependentPhoneNumberResource : Resource {
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="addressSid"> The address_sid </param>
        /// <returns> DependentPhoneNumberReader capable of executing the read </returns> 
        public static DependentPhoneNumberReader Reader(string accountSid, string addressSid) {
            return new DependentPhoneNumberReader(accountSid, addressSid);
        }
    
        /// <summary>
        /// Create a DependentPhoneNumberReader to execute read.
        /// </summary>
        ///
        /// <param name="addressSid"> The address_sid </param>
        /// <returns> DependentPhoneNumberReader capable of executing the read </returns> 
        public static DependentPhoneNumberReader Reader(string addressSid) {
            return new DependentPhoneNumberReader(addressSid);
        }
    
        /// <summary>
        /// Converts a JSON string into a DependentPhoneNumberResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DependentPhoneNumberResource object represented by the provided JSON </returns> 
        public static DependentPhoneNumberResource FromJson(string json) {
            // Convert all checked exceptions to Runtime
            try {
                return JsonConvert.DeserializeObject<DependentPhoneNumberResource>(json);
            } catch (JsonException e) {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("friendly_name")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        private readonly Twilio.Types.PhoneNumber friendlyName;
        [JsonProperty("phone_number")]
        [JsonConverter(typeof(PhoneNumberConverter))]
        private readonly Twilio.Types.PhoneNumber phoneNumber;
        [JsonProperty("lata")]
        private readonly string lata;
        [JsonProperty("rate_center")]
        private readonly string rateCenter;
        [JsonProperty("latitude")]
        private readonly decimal? latitude;
        [JsonProperty("longitude")]
        private readonly decimal? longitude;
        [JsonProperty("region")]
        private readonly string region;
        [JsonProperty("postal_code")]
        private readonly string postalCode;
        [JsonProperty("iso_country")]
        private readonly string isoCountry;
        [JsonProperty("address_requirements")]
        private readonly string addressRequirements;
        [JsonProperty("capabilities")]
        private readonly Dictionary<string, string> capabilities;
    
        public DependentPhoneNumberResource() {
        
        }
    
        private DependentPhoneNumberResource([JsonProperty("friendly_name")]
                                             Twilio.Types.PhoneNumber friendlyName, 
                                             [JsonProperty("phone_number")]
                                             Twilio.Types.PhoneNumber phoneNumber, 
                                             [JsonProperty("lata")]
                                             string lata, 
                                             [JsonProperty("rate_center")]
                                             string rateCenter, 
                                             [JsonProperty("latitude")]
                                             decimal? latitude, 
                                             [JsonProperty("longitude")]
                                             decimal? longitude, 
                                             [JsonProperty("region")]
                                             string region, 
                                             [JsonProperty("postal_code")]
                                             string postalCode, 
                                             [JsonProperty("iso_country")]
                                             string isoCountry, 
                                             [JsonProperty("address_requirements")]
                                             string addressRequirements, 
                                             [JsonProperty("capabilities")]
                                             Dictionary<string, string> capabilities) {
            this.friendlyName = friendlyName;
            this.phoneNumber = phoneNumber;
            this.lata = lata;
            this.rateCenter = rateCenter;
            this.latitude = latitude;
            this.longitude = longitude;
            this.region = region;
            this.postalCode = postalCode;
            this.isoCountry = isoCountry;
            this.addressRequirements = addressRequirements;
            this.capabilities = capabilities;
        }
    
        /// <returns> The friendly_name </returns> 
        public Twilio.Types.PhoneNumber GetFriendlyName() {
            return this.friendlyName;
        }
    
        /// <returns> The phone_number </returns> 
        public Twilio.Types.PhoneNumber GetPhoneNumber() {
            return this.phoneNumber;
        }
    
        /// <returns> The lata </returns> 
        public string GetLata() {
            return this.lata;
        }
    
        /// <returns> The rate_center </returns> 
        public string GetRateCenter() {
            return this.rateCenter;
        }
    
        /// <returns> The latitude </returns> 
        public decimal? GetLatitude() {
            return this.latitude;
        }
    
        /// <returns> The longitude </returns> 
        public decimal? GetLongitude() {
            return this.longitude;
        }
    
        /// <returns> The region </returns> 
        public string GetRegion() {
            return this.region;
        }
    
        /// <returns> The postal_code </returns> 
        public string GetPostalCode() {
            return this.postalCode;
        }
    
        /// <returns> The iso_country </returns> 
        public string GetIsoCountry() {
            return this.isoCountry;
        }
    
        /// <returns> The address_requirements </returns> 
        public string GetAddressRequirements() {
            return this.addressRequirements;
        }
    
        /// <returns> The capabilities </returns> 
        public Dictionary<string, string> GetCapabilities() {
            return this.capabilities;
        }
    }
}