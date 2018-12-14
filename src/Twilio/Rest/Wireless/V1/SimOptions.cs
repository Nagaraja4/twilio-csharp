/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Wireless.V1 
{

    /// <summary>
    /// Fetch a Sim instance from your account.
    /// </summary>
    public class FetchSimOptions : IOptions<SimResource> 
    {
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchSimOptions
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public FetchSimOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Retrieve a list of Sims from your account.
    /// </summary>
    public class ReadSimOptions : ReadOptions<SimResource> 
    {
        /// <summary>
        /// Only return Sims with this status.
        /// </summary>
        public SimResource.StatusEnum Status { get; set; }
        /// <summary>
        /// Return Sims with this Iccid.
        /// </summary>
        public string Iccid { get; set; }
        /// <summary>
        /// Only return Sims with this Rate Plan.
        /// </summary>
        public string RatePlan { get; set; }
        /// <summary>
        /// Only return Sims with this EID.
        /// </summary>
        public string EId { get; set; }
        /// <summary>
        /// Only return Sims with this registration code.
        /// </summary>
        public string SimRegistrationCode { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (Iccid != null)
            {
                p.Add(new KeyValuePair<string, string>("Iccid", Iccid));
            }

            if (RatePlan != null)
            {
                p.Add(new KeyValuePair<string, string>("RatePlan", RatePlan));
            }

            if (EId != null)
            {
                p.Add(new KeyValuePair<string, string>("EId", EId));
            }

            if (SimRegistrationCode != null)
            {
                p.Add(new KeyValuePair<string, string>("SimRegistrationCode", SimRegistrationCode));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Updates the given properties of a Sim instance from your account.
    /// </summary>
    public class UpdateSimOptions : IOptions<SimResource> 
    {
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A user-provided string that uniquely identifies this resource as an alternative to the Sid.
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// The HTTP method Twilio will use when making a request to the callback URL.
        /// </summary>
        public Twilio.Http.HttpMethod CallbackMethod { get; set; }
        /// <summary>
        /// Twilio will make a request to this URL when the Sim has finished updating.
        /// </summary>
        public Uri CallbackUrl { get; set; }
        /// <summary>
        /// A user-provided string that identifies this resource.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The Sid or UniqueName of the RatePlan that this Sim should use.
        /// </summary>
        public string RatePlan { get; set; }
        /// <summary>
        /// A string representing the status of the Sim.
        /// </summary>
        public SimResource.StatusEnum Status { get; set; }
        /// <summary>
        /// A string representing the HTTP method to use when making a request to CommandsCallbackUrl.
        /// </summary>
        public Twilio.Http.HttpMethod CommandsCallbackMethod { get; set; }
        /// <summary>
        /// The URL that will receive a webhook when this Sim originates a Command.
        /// </summary>
        public Uri CommandsCallbackUrl { get; set; }
        /// <summary>
        /// The HTTP method Twilio will use when requesting the sms_fallback_url.
        /// </summary>
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; set; }
        /// <summary>
        /// The URL that Twilio will request if an error occurs retrieving or executing the TwiML requested by sms_url.
        /// </summary>
        public Uri SmsFallbackUrl { get; set; }
        /// <summary>
        /// The HTTP method Twilio will use when requesting the above Url.
        /// </summary>
        public Twilio.Http.HttpMethod SmsMethod { get; set; }
        /// <summary>
        /// The URL Twilio will request when the SIM-connected device sends an SMS message that is not a Command.
        /// </summary>
        public Uri SmsUrl { get; set; }
        /// <summary>
        /// The HTTP method Twilio will use when requesting the voice_fallback_url.
        /// </summary>
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }
        /// <summary>
        /// The URL that Twilio will request if an error occurs retrieving or executing the TwiML requested by voice_url.
        /// </summary>
        public Uri VoiceFallbackUrl { get; set; }
        /// <summary>
        /// The HTTP method Twilio will use when requesting the above Url.
        /// </summary>
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }
        /// <summary>
        /// The URL Twilio will request when the SIM-connected device makes a call.
        /// </summary>
        public Uri VoiceUrl { get; set; }

        /// <summary>
        /// Construct a new UpdateSimOptions
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public UpdateSimOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (CallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackMethod", CallbackMethod.ToString()));
            }

            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", Serializers.Url(CallbackUrl)));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (RatePlan != null)
            {
                p.Add(new KeyValuePair<string, string>("RatePlan", RatePlan.ToString()));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (CommandsCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CommandsCallbackMethod", CommandsCallbackMethod.ToString()));
            }

            if (CommandsCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CommandsCallbackUrl", Serializers.Url(CommandsCallbackUrl)));
            }

            if (SmsFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackMethod", SmsFallbackMethod.ToString()));
            }

            if (SmsFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackUrl", Serializers.Url(SmsFallbackUrl)));
            }

            if (SmsMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsMethod", SmsMethod.ToString()));
            }

            if (SmsUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsUrl", Serializers.Url(SmsUrl)));
            }

            if (VoiceFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackMethod", VoiceFallbackMethod.ToString()));
            }

            if (VoiceFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackUrl", Serializers.Url(VoiceFallbackUrl)));
            }

            if (VoiceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceMethod", VoiceMethod.ToString()));
            }

            if (VoiceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceUrl", Serializers.Url(VoiceUrl)));
            }

            return p;
        }
    }

    /// <summary>
    /// Delete a Sim instance from your account.
    /// </summary>
    public class DeleteSimOptions : IOptions<SimResource> 
    {
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteSimOptions
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public DeleteSimOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}