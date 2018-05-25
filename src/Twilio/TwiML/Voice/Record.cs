/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Twilio.Converters;
using Twilio.Types;

namespace Twilio.TwiML.Voice 
{

    /// <summary>
    /// Record TwiML Verb
    /// </summary>
    public class Record : TwiML 
    {
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

        /// <summary>
        /// Action URL
        /// </summary>
        public Uri Action { get; set; }
        /// <summary>
        /// Action URL method
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Timeout to begin recording
        /// </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// Finish recording on key
        /// </summary>
        public string FinishOnKey { get; set; }
        /// <summary>
        /// Max time to record in seconds
        /// </summary>
        public int? MaxLength { get; set; }
        /// <summary>
        /// Play beep
        /// </summary>
        public bool? PlayBeep { get; set; }
        /// <summary>
        /// Trim the recording
        /// </summary>
        public Record.TrimEnum Trim { get; set; }
        /// <summary>
        /// Status callback URL
        /// </summary>
        public Uri RecordingStatusCallback { get; set; }
        /// <summary>
        /// Status callback URL method
        /// </summary>
        public Twilio.Http.HttpMethod RecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// Transcribe the recording
        /// </summary>
        public bool? Transcribe { get; set; }
        /// <summary>
        /// Transcribe callback URL
        /// </summary>
        public Uri TranscribeCallback { get; set; }

        /// <summary>
        /// Create a new Record
        /// </summary>
        /// <param name="action"> Action URL </param>
        /// <param name="method"> Action URL method </param>
        /// <param name="timeout"> Timeout to begin recording </param>
        /// <param name="finishOnKey"> Finish recording on key </param>
        /// <param name="maxLength"> Max time to record in seconds </param>
        /// <param name="playBeep"> Play beep </param>
        /// <param name="trim"> Trim the recording </param>
        /// <param name="recordingStatusCallback"> Status callback URL </param>
        /// <param name="recordingStatusCallbackMethod"> Status callback URL method </param>
        /// <param name="transcribe"> Transcribe the recording </param>
        /// <param name="transcribeCallback"> Transcribe callback URL </param>
        public Record(Uri action = null, 
                      Twilio.Http.HttpMethod method = null, 
                      int? timeout = null, 
                      string finishOnKey = null, 
                      int? maxLength = null, 
                      bool? playBeep = null, 
                      Record.TrimEnum trim = null, 
                      Uri recordingStatusCallback = null, 
                      Twilio.Http.HttpMethod recordingStatusCallbackMethod = null, 
                      bool? transcribe = null, 
                      Uri transcribeCallback = null) : base("Record")
        {
            this.Action = action;
            this.Method = method;
            this.Timeout = timeout;
            this.FinishOnKey = finishOnKey;
            this.MaxLength = maxLength;
            this.PlayBeep = playBeep;
            this.Trim = trim;
            this.RecordingStatusCallback = recordingStatusCallback;
            this.RecordingStatusCallbackMethod = recordingStatusCallbackMethod;
            this.Transcribe = transcribe;
            this.TranscribeCallback = transcribeCallback;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Action != null)
            {
                attributes.Add(new XAttribute("action", Serializers.Url(this.Action)));
            }
            if (this.Method != null)
            {
                attributes.Add(new XAttribute("method", this.Method.ToString()));
            }
            if (this.Timeout != null)
            {
                attributes.Add(new XAttribute("timeout", this.Timeout.Value.ToString()));
            }
            if (this.FinishOnKey != null)
            {
                attributes.Add(new XAttribute("finishOnKey", this.FinishOnKey));
            }
            if (this.MaxLength != null)
            {
                attributes.Add(new XAttribute("maxLength", this.MaxLength.Value.ToString()));
            }
            if (this.PlayBeep != null)
            {
                attributes.Add(new XAttribute("playBeep", this.PlayBeep.Value.ToString().ToLower()));
            }
            if (this.Trim != null)
            {
                attributes.Add(new XAttribute("trim", this.Trim.ToString()));
            }
            if (this.RecordingStatusCallback != null)
            {
                attributes.Add(new XAttribute("recordingStatusCallback", Serializers.Url(this.RecordingStatusCallback)));
            }
            if (this.RecordingStatusCallbackMethod != null)
            {
                attributes.Add(new XAttribute("recordingStatusCallbackMethod", this.RecordingStatusCallbackMethod.ToString()));
            }
            if (this.Transcribe != null)
            {
                attributes.Add(new XAttribute("transcribe", this.Transcribe.Value.ToString().ToLower()));
            }
            if (this.TranscribeCallback != null)
            {
                attributes.Add(new XAttribute("transcribeCallback", Serializers.Url(this.TranscribeCallback)));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Record Append(TwiML childElem)
        {
            return (Record) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Record SetOption(string key, object value)
        {
            return (Record) base.SetOption(key, value);
        }
    }

}