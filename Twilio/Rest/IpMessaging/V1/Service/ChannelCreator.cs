using Twilio.Base;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Rest.IpMessaging.V1.Service {

    public class ChannelCreator : Creator<ChannelResource> {
        private string serviceSid;
        private string friendlyName;
        private string uniqueName;
        private string attributes;
        private ChannelResource.ChannelType type;
    
        /// <summary>
        /// Construct a new ChannelCreator
        /// </summary>
        ///
        /// <param name="serviceSid"> The service_sid </param>
        public ChannelCreator(string serviceSid) {
            this.serviceSid = serviceSid;
        }
    
        /// <summary>
        /// The friendly_name
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <returns> this </returns> 
        public ChannelCreator setFriendlyName(string friendlyName) {
            this.friendlyName = friendlyName;
            return this;
        }
    
        /// <summary>
        /// The unique_name
        /// </summary>
        ///
        /// <param name="uniqueName"> The unique_name </param>
        /// <returns> this </returns> 
        public ChannelCreator setUniqueName(string uniqueName) {
            this.uniqueName = uniqueName;
            return this;
        }
    
        /// <summary>
        /// The attributes
        /// </summary>
        ///
        /// <param name="attributes"> The attributes </param>
        /// <returns> this </returns> 
        public ChannelCreator setAttributes(string attributes) {
            this.attributes = attributes;
            return this;
        }
    
        /// <summary>
        /// The type
        /// </summary>
        ///
        /// <param name="type"> The type </param>
        /// <returns> this </returns> 
        public ChannelCreator setType(ChannelResource.ChannelType type) {
            this.type = type;
            return this;
        }
    
        #if NET40
        /// <summary>
        /// Make the request to the Twilio API to perform the create
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Created ChannelResource </returns> 
        public override async Task<ChannelResource> CreateAsync(ITwilioRestClient client) {
            var request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.IP_MESSAGING,
                "/v1/Services/" + this.serviceSid + "/Channels"
            );
            
            addPostParams(request);
            var response = await client.RequestAsync(request);
            if (response == null)
            {
                throw new ApiConnectionException("ChannelResource creation failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to create record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return ChannelResource.FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Make the request to the Twilio API to perform the create
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Created ChannelResource </returns> 
        public override ChannelResource Create(ITwilioRestClient client) {
            var request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.IP_MESSAGING,
                "/v1/Services/" + this.serviceSid + "/Channels"
            );
            
            addPostParams(request);
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("ChannelResource creation failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to create record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return ChannelResource.FromJson(response.Content);
        }
    
        /// <summary>
        /// Add the requested post parameters to the Request
        /// </summary>
        ///
        /// <param name="request"> Request to add post params to </param>
        private void addPostParams(Request request) {
            if (friendlyName != null) {
                request.AddPostParam("FriendlyName", friendlyName);
            }
            
            if (uniqueName != null) {
                request.AddPostParam("UniqueName", uniqueName);
            }
            
            if (attributes != null) {
                request.AddPostParam("Attributes", attributes);
            }
            
            if (type != null) {
                request.AddPostParam("Type", type.ToString());
            }
        }
    }
}