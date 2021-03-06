/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Voice.V1.ConnectionPolicy
{

    /// <summary>
    /// CreateConnectionPolicyTargetOptions
    /// </summary>
    public class CreateConnectionPolicyTargetOptions : IOptions<ConnectionPolicyTargetResource>
    {
        /// <summary>
        /// The SID of the Connection Policy that owns the Target
        /// </summary>
        public string PathConnectionPolicySid { get; }
        /// <summary>
        /// The SIP address you want Twilio to route your calls to
        /// </summary>
        public Uri Target { get; }
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The relative importance of the target
        /// </summary>
        public int? Priority { get; set; }
        /// <summary>
        /// The value that determines the relative load the Target should receive compared to others with the same priority
        /// </summary>
        public int? Weight { get; set; }
        /// <summary>
        /// Whether the Target is enabled
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Construct a new CreateConnectionPolicyTargetOptions
        /// </summary>
        /// <param name="pathConnectionPolicySid"> The SID of the Connection Policy that owns the Target </param>
        /// <param name="target"> The SIP address you want Twilio to route your calls to </param>
        public CreateConnectionPolicyTargetOptions(string pathConnectionPolicySid, Uri target)
        {
            PathConnectionPolicySid = pathConnectionPolicySid;
            Target = target;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Target != null)
            {
                p.Add(new KeyValuePair<string, string>("Target", Serializers.Url(Target)));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }

            if (Weight != null)
            {
                p.Add(new KeyValuePair<string, string>("Weight", Weight.ToString()));
            }

            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }

            return p;
        }
    }

    /// <summary>
    /// FetchConnectionPolicyTargetOptions
    /// </summary>
    public class FetchConnectionPolicyTargetOptions : IOptions<ConnectionPolicyTargetResource>
    {
        /// <summary>
        /// The SID of the Connection Policy that owns the Target
        /// </summary>
        public string PathConnectionPolicySid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchConnectionPolicyTargetOptions
        /// </summary>
        /// <param name="pathConnectionPolicySid"> The SID of the Connection Policy that owns the Target </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchConnectionPolicyTargetOptions(string pathConnectionPolicySid, string pathSid)
        {
            PathConnectionPolicySid = pathConnectionPolicySid;
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
    /// ReadConnectionPolicyTargetOptions
    /// </summary>
    public class ReadConnectionPolicyTargetOptions : ReadOptions<ConnectionPolicyTargetResource>
    {
        /// <summary>
        /// The SID of the Connection Policy from which to read the Targets
        /// </summary>
        public string PathConnectionPolicySid { get; }

        /// <summary>
        /// Construct a new ReadConnectionPolicyTargetOptions
        /// </summary>
        /// <param name="pathConnectionPolicySid"> The SID of the Connection Policy from which to read the Targets </param>
        public ReadConnectionPolicyTargetOptions(string pathConnectionPolicySid)
        {
            PathConnectionPolicySid = pathConnectionPolicySid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// UpdateConnectionPolicyTargetOptions
    /// </summary>
    public class UpdateConnectionPolicyTargetOptions : IOptions<ConnectionPolicyTargetResource>
    {
        /// <summary>
        /// The SID of the Connection Policy that owns the Target
        /// </summary>
        public string PathConnectionPolicySid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A string to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The SIP address you want Twilio to route your calls to
        /// </summary>
        public Uri Target { get; set; }
        /// <summary>
        /// The relative importance of the target
        /// </summary>
        public int? Priority { get; set; }
        /// <summary>
        /// The value that determines the relative load the Target should receive compared to others with the same priority
        /// </summary>
        public int? Weight { get; set; }
        /// <summary>
        /// Whether the Target is enabled
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Construct a new UpdateConnectionPolicyTargetOptions
        /// </summary>
        /// <param name="pathConnectionPolicySid"> The SID of the Connection Policy that owns the Target </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public UpdateConnectionPolicyTargetOptions(string pathConnectionPolicySid, string pathSid)
        {
            PathConnectionPolicySid = pathConnectionPolicySid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Target != null)
            {
                p.Add(new KeyValuePair<string, string>("Target", Serializers.Url(Target)));
            }

            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }

            if (Weight != null)
            {
                p.Add(new KeyValuePair<string, string>("Weight", Weight.ToString()));
            }

            if (Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Enabled", Enabled.Value.ToString().ToLower()));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteConnectionPolicyTargetOptions
    /// </summary>
    public class DeleteConnectionPolicyTargetOptions : IOptions<ConnectionPolicyTargetResource>
    {
        /// <summary>
        /// The SID of the Connection Policy that owns the Target
        /// </summary>
        public string PathConnectionPolicySid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteConnectionPolicyTargetOptions
        /// </summary>
        /// <param name="pathConnectionPolicySid"> The SID of the Connection Policy that owns the Target </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public DeleteConnectionPolicyTargetOptions(string pathConnectionPolicySid, string pathSid)
        {
            PathConnectionPolicySid = pathConnectionPolicySid;
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