/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Twilio.Converters;
using Twilio.Types;

namespace Twilio.TwiML.Voice 
{

    /// <summary>
    /// Conference TwiML Noun
    /// </summary>
    public class Conference : TwiML 
    {
        public sealed class BeepEnum : StringEnum 
        {
            private BeepEnum(string value) : base(value) {}
            public BeepEnum() {}
            public static implicit operator BeepEnum(string value)
            {
                return new BeepEnum(value);
            }

            public static readonly BeepEnum True = new BeepEnum("true");
            public static readonly BeepEnum False = new BeepEnum("false");
            public static readonly BeepEnum Onenter = new BeepEnum("onEnter");
            public static readonly BeepEnum Onexit = new BeepEnum("onExit");
        }

        public sealed class RecordEnum : StringEnum 
        {
            private RecordEnum(string value) : base(value) {}
            public RecordEnum() {}
            public static implicit operator RecordEnum(string value)
            {
                return new RecordEnum(value);
            }

            public static readonly RecordEnum DoNotRecord = new RecordEnum("do-not-record");
            public static readonly RecordEnum RecordFromStart = new RecordEnum("record-from-start");
        }

        public sealed class RegionEnum : StringEnum 
        {
            private RegionEnum(string value) : base(value) {}
            public RegionEnum() {}
            public static implicit operator RegionEnum(string value)
            {
                return new RegionEnum(value);
            }

            public static readonly RegionEnum Us1 = new RegionEnum("us1");
            public static readonly RegionEnum Ie1 = new RegionEnum("ie1");
            public static readonly RegionEnum Sg1 = new RegionEnum("sg1");
            public static readonly RegionEnum Br1 = new RegionEnum("br1");
            public static readonly RegionEnum Au1 = new RegionEnum("au1");
            public static readonly RegionEnum Jp1 = new RegionEnum("jp1");
        }

        public sealed class EventEnum : StringEnum 
        {
            private EventEnum(string value) : base(value) {}
            public EventEnum() {}
            public static implicit operator EventEnum(string value)
            {
                return new EventEnum(value);
            }

            public static readonly EventEnum Start = new EventEnum("start");
            public static readonly EventEnum End = new EventEnum("end");
            public static readonly EventEnum Join = new EventEnum("join");
            public static readonly EventEnum Leave = new EventEnum("leave");
            public static readonly EventEnum Mute = new EventEnum("mute");
            public static readonly EventEnum Hold = new EventEnum("hold");
            public static readonly EventEnum Speaker = new EventEnum("speaker");
        }

        public sealed class TrimEnum : StringEnum 
        {
            private TrimEnum(string value) : base(value) {}
            public TrimEnum() {}
            public static implicit operator TrimEnum(string value)
            {
                return new TrimEnum(value);
            }

            public static readonly TrimEnum TrimSilence = new TrimEnum("trim-silence");
            public static readonly TrimEnum DoNotTrim = new TrimEnum("do-not-trim");
        }

        public sealed class RecordingEventEnum : StringEnum 
        {
            private RecordingEventEnum(string value) : base(value) {}
            public RecordingEventEnum() {}
            public static implicit operator RecordingEventEnum(string value)
            {
                return new RecordingEventEnum(value);
            }

            public static readonly RecordingEventEnum Started = new RecordingEventEnum("started");
            public static readonly RecordingEventEnum Stopped = new RecordingEventEnum("stopped");
            public static readonly RecordingEventEnum Paused = new RecordingEventEnum("paused");
            public static readonly RecordingEventEnum Resumed = new RecordingEventEnum("resumed");
            public static readonly RecordingEventEnum Completed = new RecordingEventEnum("completed");
            public static readonly RecordingEventEnum Absent = new RecordingEventEnum("absent");
        }

        /// <summary>
        /// Conference name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Join the conference muted
        /// </summary>
        public bool? Muted { get; set; }
        /// <summary>
        /// Play beep when joining
        /// </summary>
        public Conference.BeepEnum Beep { get; set; }
        /// <summary>
        /// Start the conference on enter
        /// </summary>
        public bool? StartConferenceOnEnter { get; set; }
        /// <summary>
        /// End the conferenceon exit
        /// </summary>
        public bool? EndConferenceOnExit { get; set; }
        /// <summary>
        /// Wait URL
        /// </summary>
        public Uri WaitUrl { get; set; }
        /// <summary>
        /// Wait URL method
        /// </summary>
        public Twilio.Http.HttpMethod WaitMethod { get; set; }
        /// <summary>
        /// Maximum number of participants
        /// </summary>
        public int? MaxParticipants { get; set; }
        /// <summary>
        /// Record the conference
        /// </summary>
        public Conference.RecordEnum Record { get; set; }
        /// <summary>
        /// Conference region
        /// </summary>
        public Conference.RegionEnum Region { get; set; }
        /// <summary>
        /// Call whisper
        /// </summary>
        public string Whisper { get; set; }
        /// <summary>
        /// Trim the conference recording
        /// </summary>
        public Conference.TrimEnum Trim { get; set; }
        /// <summary>
        /// Events to call status callback URL
        /// </summary>
        public List<Conference.EventEnum> StatusCallbackEvent { get; set; }
        /// <summary>
        /// Status callback URL
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// Status callback URL method
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// Recording status callback URL
        /// </summary>
        public Uri RecordingStatusCallback { get; set; }
        /// <summary>
        /// Recording status callback URL method
        /// </summary>
        public Twilio.Http.HttpMethod RecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// Recording status callback events
        /// </summary>
        public List<Conference.RecordingEventEnum> RecordingStatusCallbackEvent { get; set; }
        /// <summary>
        /// Event callback URL
        /// </summary>
        public Uri EventCallbackUrl { get; set; }

        /// <summary>
        /// Create a new Conference
        /// </summary>
        /// <param name="name"> Conference name, the body of the TwiML Element. </param>
        /// <param name="muted"> Join the conference muted </param>
        /// <param name="beep"> Play beep when joining </param>
        /// <param name="startConferenceOnEnter"> Start the conference on enter </param>
        /// <param name="endConferenceOnExit"> End the conferenceon exit </param>
        /// <param name="waitUrl"> Wait URL </param>
        /// <param name="waitMethod"> Wait URL method </param>
        /// <param name="maxParticipants"> Maximum number of participants </param>
        /// <param name="record"> Record the conference </param>
        /// <param name="region"> Conference region </param>
        /// <param name="whisper"> Call whisper </param>
        /// <param name="trim"> Trim the conference recording </param>
        /// <param name="statusCallbackEvent"> Events to call status callback URL </param>
        /// <param name="statusCallback"> Status callback URL </param>
        /// <param name="statusCallbackMethod"> Status callback URL method </param>
        /// <param name="recordingStatusCallback"> Recording status callback URL </param>
        /// <param name="recordingStatusCallbackMethod"> Recording status callback URL method </param>
        /// <param name="recordingStatusCallbackEvent"> Recording status callback events </param>
        /// <param name="eventCallbackUrl"> Event callback URL </param>
        public Conference(string name = null, 
                          bool? muted = null, 
                          Conference.BeepEnum beep = null, 
                          bool? startConferenceOnEnter = null, 
                          bool? endConferenceOnExit = null, 
                          Uri waitUrl = null, 
                          Twilio.Http.HttpMethod waitMethod = null, 
                          int? maxParticipants = null, 
                          Conference.RecordEnum record = null, 
                          Conference.RegionEnum region = null, 
                          string whisper = null, 
                          Conference.TrimEnum trim = null, 
                          List<Conference.EventEnum> statusCallbackEvent = null, 
                          Uri statusCallback = null, 
                          Twilio.Http.HttpMethod statusCallbackMethod = null, 
                          Uri recordingStatusCallback = null, 
                          Twilio.Http.HttpMethod recordingStatusCallbackMethod = null, 
                          List<Conference.RecordingEventEnum> recordingStatusCallbackEvent = null, 
                          Uri eventCallbackUrl = null) : base("Conference")
        {
            this.Name = name;
            this.Muted = muted;
            this.Beep = beep;
            this.StartConferenceOnEnter = startConferenceOnEnter;
            this.EndConferenceOnExit = endConferenceOnExit;
            this.WaitUrl = waitUrl;
            this.WaitMethod = waitMethod;
            this.MaxParticipants = maxParticipants;
            this.Record = record;
            this.Region = region;
            this.Whisper = whisper;
            this.Trim = trim;
            this.StatusCallbackEvent = statusCallbackEvent;
            this.StatusCallback = statusCallback;
            this.StatusCallbackMethod = statusCallbackMethod;
            this.RecordingStatusCallback = recordingStatusCallback;
            this.RecordingStatusCallbackMethod = recordingStatusCallbackMethod;
            this.RecordingStatusCallbackEvent = recordingStatusCallbackEvent;
            this.EventCallbackUrl = eventCallbackUrl;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.Name != null ? this.Name : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Muted != null)
            {
                attributes.Add(new XAttribute("muted", this.Muted.Value.ToString().ToLower()));
            }
            if (this.Beep != null)
            {
                attributes.Add(new XAttribute("beep", this.Beep.ToString()));
            }
            if (this.StartConferenceOnEnter != null)
            {
                attributes.Add(new XAttribute("startConferenceOnEnter", this.StartConferenceOnEnter.Value.ToString().ToLower()));
            }
            if (this.EndConferenceOnExit != null)
            {
                attributes.Add(new XAttribute("endConferenceOnExit", this.EndConferenceOnExit.Value.ToString().ToLower()));
            }
            if (this.WaitUrl != null)
            {
                attributes.Add(new XAttribute("waitUrl", Serializers.Url(this.WaitUrl)));
            }
            if (this.WaitMethod != null)
            {
                attributes.Add(new XAttribute("waitMethod", this.WaitMethod.ToString()));
            }
            if (this.MaxParticipants != null)
            {
                attributes.Add(new XAttribute("maxParticipants", this.MaxParticipants.ToString()));
            }
            if (this.Record != null)
            {
                attributes.Add(new XAttribute("record", this.Record.ToString()));
            }
            if (this.Region != null)
            {
                attributes.Add(new XAttribute("region", this.Region.ToString()));
            }
            if (this.Whisper != null)
            {
                attributes.Add(new XAttribute("whisper", this.Whisper.ToString()));
            }
            if (this.Trim != null)
            {
                attributes.Add(new XAttribute("trim", this.Trim.ToString()));
            }
            if (this.StatusCallbackEvent != null)
            {
                attributes.Add(new XAttribute("statusCallbackEvent", String.Join(" ", this.StatusCallbackEvent.Select(e => e.ToString()).ToArray())));
            }
            if (this.StatusCallback != null)
            {
                attributes.Add(new XAttribute("statusCallback", Serializers.Url(this.StatusCallback)));
            }
            if (this.StatusCallbackMethod != null)
            {
                attributes.Add(new XAttribute("statusCallbackMethod", this.StatusCallbackMethod.ToString()));
            }
            if (this.RecordingStatusCallback != null)
            {
                attributes.Add(new XAttribute("recordingStatusCallback", Serializers.Url(this.RecordingStatusCallback)));
            }
            if (this.RecordingStatusCallbackMethod != null)
            {
                attributes.Add(new XAttribute("recordingStatusCallbackMethod", this.RecordingStatusCallbackMethod.ToString()));
            }
            if (this.RecordingStatusCallbackEvent != null)
            {
                attributes.Add(new XAttribute("recordingStatusCallbackEvent", String.Join(" ", this.RecordingStatusCallbackEvent.Select(e => e.ToString()).ToArray())));
            }
            if (this.EventCallbackUrl != null)
            {
                attributes.Add(new XAttribute("eventCallbackUrl", Serializers.Url(this.EventCallbackUrl)));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Conference Append(TwiML childElem)
        {
            return (Conference) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Conference SetOption(string key, object value)
        {
            return (Conference) base.SetOption(key, value);
        }
    }

}