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
using Twilio.TwiML.Voice;

namespace Twilio.TwiML 
{

    /// <summary>
    /// Response TwiML for Voice
    /// </summary>
    public class VoiceResponse : TwiML 
    {
        /// <summary>
        /// Create a new VoiceResponse
        /// </summary>
        public VoiceResponse() : base("Response")
        {
        }

        /// <summary>
        /// Append a <Connect/> element as a child of this element
        /// </summary>
        /// <param name="connect"> A Connect instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Connect(Connect connect)
        {
            this.Append(connect);
            return this;
        }

        /// <summary>
        /// Create a new <Connect/> element and append it as a child of this element.
        /// </summary>
        /// <param name="action"> Action URL </param>
        /// <param name="method"> Action URL method </param>
        public VoiceResponse Connect(Uri action = null, Twilio.Http.HttpMethod method = null)
        {
            var newChild = new Connect(action, method);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Dial/> element as a child of this element
        /// </summary>
        /// <param name="dial"> A Dial instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Dial(Dial dial)
        {
            this.Append(dial);
            return this;
        }

        /// <summary>
        /// Create a new <Dial/> element and append it as a child of this element.
        /// </summary>
        /// <param name="number"> Phone number to dial, the body of the TwiML Element. </param>
        /// <param name="action"> Action URL </param>
        /// <param name="method"> Action URL method </param>
        /// <param name="timeout"> Time to wait for answer </param>
        /// <param name="hangupOnStar"> Hangup call on star press </param>
        /// <param name="timeLimit"> Max time length </param>
        /// <param name="callerId"> Caller ID to display </param>
        /// <param name="record"> Record the call </param>
        /// <param name="trim"> Trim the recording </param>
        /// <param name="recordingStatusCallback"> Recording status callback URL </param>
        /// <param name="recordingStatusCallbackMethod"> Recording status callback URL method </param>
        /// <param name="recordingStatusCallbackEvent"> Recording status callback events </param>
        /// <param name="answerOnBridge"> Preserve the ringing behavior of the inbound call until the Dialed call picks up
        ///                      </param>
        /// <param name="ringTone"> Ringtone allows you to override the ringback tone that Twilio will play back to the caller
        ///                while executing the Dial </param>
        public VoiceResponse Dial(string number = null, 
                                  Uri action = null, 
                                  Twilio.Http.HttpMethod method = null, 
                                  int? timeout = null, 
                                  bool? hangupOnStar = null, 
                                  int? timeLimit = null, 
                                  string callerId = null, 
                                  Dial.RecordEnum record = null, 
                                  Dial.TrimEnum trim = null, 
                                  Uri recordingStatusCallback = null, 
                                  Twilio.Http.HttpMethod recordingStatusCallbackMethod = null, 
                                  List<Dial.RecordingEventEnum> recordingStatusCallbackEvent = null, 
                                  bool? answerOnBridge = null, 
                                  Dial.RingToneEnum ringTone = null)
        {
            var newChild = new Dial(
                number,
                action,
                method,
                timeout,
                hangupOnStar,
                timeLimit,
                callerId,
                record,
                trim,
                recordingStatusCallback,
                recordingStatusCallbackMethod,
                recordingStatusCallbackEvent,
                answerOnBridge,
                ringTone
            );
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Echo/> element as a child of this element
        /// </summary>
        /// <param name="echo"> A Echo instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Echo(Echo echo)
        {
            this.Append(echo);
            return this;
        }

        /// <summary>
        /// Create a new <Echo/> element and append it as a child of this element.
        /// </summary>
        public VoiceResponse Echo()
        {
            var newChild = new Echo();
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Enqueue/> element as a child of this element
        /// </summary>
        /// <param name="enqueue"> A Enqueue instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Enqueue(Enqueue enqueue)
        {
            this.Append(enqueue);
            return this;
        }

        /// <summary>
        /// Create a new <Enqueue/> element and append it as a child of this element.
        /// </summary>
        /// <param name="name"> Friendly name, the body of the TwiML Element. </param>
        /// <param name="action"> Action URL </param>
        /// <param name="method"> Action URL method </param>
        /// <param name="waitUrl"> Wait URL </param>
        /// <param name="waitUrlMethod"> Wait URL method </param>
        /// <param name="workflowSid"> TaskRouter Workflow SID </param>
        public VoiceResponse Enqueue(string name = null, 
                                     Uri action = null, 
                                     Twilio.Http.HttpMethod method = null, 
                                     Uri waitUrl = null, 
                                     Twilio.Http.HttpMethod waitUrlMethod = null, 
                                     string workflowSid = null)
        {
            var newChild = new Enqueue(name, action, method, waitUrl, waitUrlMethod, workflowSid);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Gather/> element as a child of this element
        /// </summary>
        /// <param name="gather"> A Gather instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Gather(Gather gather)
        {
            this.Append(gather);
            return this;
        }

        /// <summary>
        /// Create a new <Gather/> element and append it as a child of this element.
        /// </summary>
        /// <param name="input"> Input type Twilio should accept </param>
        /// <param name="action"> Action URL </param>
        /// <param name="method"> Action URL method </param>
        /// <param name="timeout"> Time to wait to gather input </param>
        /// <param name="speechTimeout"> Time to wait to gather speech input and it should be either auto or a positive
        ///                     integer. </param>
        /// <param name="maxSpeechTime"> Max allowed time for speech input </param>
        /// <param name="profanityFilter"> Profanity Filter on speech </param>
        /// <param name="finishOnKey"> Finish gather on key </param>
        /// <param name="numDigits"> Number of digits to collect </param>
        /// <param name="partialResultCallback"> Partial result callback URL </param>
        /// <param name="partialResultCallbackMethod"> Partial result callback URL method </param>
        /// <param name="language"> Language to use </param>
        /// <param name="hints"> Speech recognition hints </param>
        /// <param name="bargeIn"> Stop playing media upon speech </param>
        /// <param name="debug"> Allow debug for gather </param>
        public VoiceResponse Gather(List<Gather.InputEnum> input = null, 
                                    Uri action = null, 
                                    Twilio.Http.HttpMethod method = null, 
                                    int? timeout = null, 
                                    string speechTimeout = null, 
                                    int? maxSpeechTime = null, 
                                    bool? profanityFilter = null, 
                                    string finishOnKey = null, 
                                    int? numDigits = null, 
                                    Uri partialResultCallback = null, 
                                    Twilio.Http.HttpMethod partialResultCallbackMethod = null, 
                                    Gather.LanguageEnum language = null, 
                                    string hints = null, 
                                    bool? bargeIn = null, 
                                    bool? debug = null)
        {
            var newChild = new Gather(
                input,
                action,
                method,
                timeout,
                speechTimeout,
                maxSpeechTime,
                profanityFilter,
                finishOnKey,
                numDigits,
                partialResultCallback,
                partialResultCallbackMethod,
                language,
                hints,
                bargeIn,
                debug
            );
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Hangup/> element as a child of this element
        /// </summary>
        /// <param name="hangup"> A Hangup instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Hangup(Hangup hangup)
        {
            this.Append(hangup);
            return this;
        }

        /// <summary>
        /// Create a new <Hangup/> element and append it as a child of this element.
        /// </summary>
        public VoiceResponse Hangup()
        {
            var newChild = new Hangup();
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Leave/> element as a child of this element
        /// </summary>
        /// <param name="leave"> A Leave instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Leave(Leave leave)
        {
            this.Append(leave);
            return this;
        }

        /// <summary>
        /// Create a new <Leave/> element and append it as a child of this element.
        /// </summary>
        public VoiceResponse Leave()
        {
            var newChild = new Leave();
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Pause/> element as a child of this element
        /// </summary>
        /// <param name="pause"> A Pause instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Pause(Pause pause)
        {
            this.Append(pause);
            return this;
        }

        /// <summary>
        /// Create a new <Pause/> element and append it as a child of this element.
        /// </summary>
        /// <param name="length"> Length in seconds to pause </param>
        public VoiceResponse Pause(int? length = null)
        {
            var newChild = new Pause(length);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Play/> element as a child of this element
        /// </summary>
        /// <param name="play"> A Play instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Play(Play play)
        {
            this.Append(play);
            return this;
        }

        /// <summary>
        /// Create a new <Play/> element and append it as a child of this element.
        /// </summary>
        /// <param name="url"> Media URL, the body of the TwiML Element. </param>
        /// <param name="loop"> Times to loop media </param>
        /// <param name="digits"> Play DTMF tones for digits </param>
        public VoiceResponse Play(Uri url = null, int? loop = null, string digits = null)
        {
            var newChild = new Play(url, loop, digits);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Queue/> element as a child of this element
        /// </summary>
        /// <param name="queue"> A Queue instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Queue(Queue queue)
        {
            this.Append(queue);
            return this;
        }

        /// <summary>
        /// Create a new <Queue/> element and append it as a child of this element.
        /// </summary>
        /// <param name="name"> Queue name, the body of the TwiML Element. </param>
        /// <param name="url"> Action URL </param>
        /// <param name="method"> Action URL method </param>
        /// <param name="reservationSid"> TaskRouter Reservation SID </param>
        /// <param name="postWorkActivitySid"> TaskRouter Activity SID </param>
        public VoiceResponse Queue(string name = null, 
                                   Uri url = null, 
                                   Twilio.Http.HttpMethod method = null, 
                                   string reservationSid = null, 
                                   string postWorkActivitySid = null)
        {
            var newChild = new Queue(name, url, method, reservationSid, postWorkActivitySid);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Record/> element as a child of this element
        /// </summary>
        /// <param name="record"> A Record instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Record(Record record)
        {
            this.Append(record);
            return this;
        }

        /// <summary>
        /// Create a new <Record/> element and append it as a child of this element.
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
        /// <param name="recordingStatusCallbackEvent"> Recording status callback events </param>
        /// <param name="transcribe"> Transcribe the recording </param>
        /// <param name="transcribeCallback"> Transcribe callback URL </param>
        public VoiceResponse Record(Uri action = null, 
                                    Twilio.Http.HttpMethod method = null, 
                                    int? timeout = null, 
                                    string finishOnKey = null, 
                                    int? maxLength = null, 
                                    bool? playBeep = null, 
                                    Record.TrimEnum trim = null, 
                                    Uri recordingStatusCallback = null, 
                                    Twilio.Http.HttpMethod recordingStatusCallbackMethod = null, 
                                    List<Record.RecordingEventEnum> recordingStatusCallbackEvent = null, 
                                    bool? transcribe = null, 
                                    Uri transcribeCallback = null)
        {
            var newChild = new Record(
                action,
                method,
                timeout,
                finishOnKey,
                maxLength,
                playBeep,
                trim,
                recordingStatusCallback,
                recordingStatusCallbackMethod,
                recordingStatusCallbackEvent,
                transcribe,
                transcribeCallback
            );
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Redirect/> element as a child of this element
        /// </summary>
        /// <param name="redirect"> A Redirect instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Redirect(Redirect redirect)
        {
            this.Append(redirect);
            return this;
        }

        /// <summary>
        /// Create a new <Redirect/> element and append it as a child of this element.
        /// </summary>
        /// <param name="url"> Redirect URL, the body of the TwiML Element. </param>
        /// <param name="method"> Redirect URL method </param>
        public VoiceResponse Redirect(Uri url = null, Twilio.Http.HttpMethod method = null)
        {
            var newChild = new Redirect(url, method);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Reject/> element as a child of this element
        /// </summary>
        /// <param name="reject"> A Reject instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Reject(Reject reject)
        {
            this.Append(reject);
            return this;
        }

        /// <summary>
        /// Create a new <Reject/> element and append it as a child of this element.
        /// </summary>
        /// <param name="reason"> Rejection reason </param>
        public VoiceResponse Reject(Reject.ReasonEnum reason = null)
        {
            var newChild = new Reject(reason);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Say/> element as a child of this element
        /// </summary>
        /// <param name="say"> A Say instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Say(Say say)
        {
            this.Append(say);
            return this;
        }

        /// <summary>
        /// Create a new <Say/> element and append it as a child of this element.
        /// </summary>
        /// <param name="message"> Message to say, the body of the TwiML Element. </param>
        /// <param name="voice"> Voice to use </param>
        /// <param name="loop"> Times to loop message </param>
        /// <param name="language"> Message langauge </param>
        public VoiceResponse Say(string message = null, 
                                 Say.VoiceEnum voice = null, 
                                 int? loop = null, 
                                 Say.LanguageEnum language = null)
        {
            var newChild = new Say(message, voice, loop, language);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Sms/> element as a child of this element
        /// </summary>
        /// <param name="sms"> A Sms instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Sms(Sms sms)
        {
            this.Append(sms);
            return this;
        }

        /// <summary>
        /// Create a new <Sms/> element and append it as a child of this element.
        /// </summary>
        /// <param name="message"> Message body, the body of the TwiML Element. </param>
        /// <param name="to"> Number to send message to </param>
        /// <param name="from"> Number to send message from </param>
        /// <param name="action"> Action URL </param>
        /// <param name="method"> Action URL method </param>
        /// <param name="statusCallback"> Status callback URL </param>
        public VoiceResponse Sms(string message = null, 
                                 Types.PhoneNumber to = null, 
                                 Types.PhoneNumber from = null, 
                                 Uri action = null, 
                                 Twilio.Http.HttpMethod method = null, 
                                 Uri statusCallback = null)
        {
            var newChild = new Sms(message, to, from, action, method, statusCallback);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Pay/> element as a child of this element
        /// </summary>
        /// <param name="pay"> A Pay instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Pay(Pay pay)
        {
            this.Append(pay);
            return this;
        }

        /// <summary>
        /// Create a new <Pay/> element and append it as a child of this element.
        /// </summary>
        /// <param name="input"> Input type Twilio should accept </param>
        /// <param name="action"> Action URL </param>
        /// <param name="statusCallback"> Status callback URL </param>
        /// <param name="statusCallbackMethod"> Status callback method </param>
        /// <param name="timeout"> Time to wait to gather input </param>
        /// <param name="maxAttempts"> Maximum number of allowed retries when gathering input </param>
        /// <param name="securityCode"> Prompt for security code </param>
        /// <param name="postalCode"> Prompt for postal code and it should be true/false or default postal code </param>
        /// <param name="paymentConnector"> Unique name for payment connector </param>
        /// <param name="tokenType"> Type of token </param>
        /// <param name="chargeAmount"> Amount to process. If value is greater than 0 then make the payment else create a
        ///                    payment token </param>
        /// <param name="currency"> Currency of the amount attribute </param>
        /// <param name="description"> Details regarding the payment </param>
        /// <param name="validCardTypes"> Comma separated accepted card types </param>
        /// <param name="language"> Language to use </param>
        public VoiceResponse Pay(Pay.InputEnum input = null, 
                                 Uri action = null, 
                                 Uri statusCallback = null, 
                                 Pay.StatusCallbackMethodEnum statusCallbackMethod = null, 
                                 int? timeout = null, 
                                 int? maxAttempts = null, 
                                 bool? securityCode = null, 
                                 string postalCode = null, 
                                 string paymentConnector = null, 
                                 Pay.TokenTypeEnum tokenType = null, 
                                 string chargeAmount = null, 
                                 string currency = null, 
                                 string description = null, 
                                 List<Pay.ValidCardTypesEnum> validCardTypes = null, 
                                 Pay.LanguageEnum language = null)
        {
            var newChild = new Pay(
                input,
                action,
                statusCallback,
                statusCallbackMethod,
                timeout,
                maxAttempts,
                securityCode,
                postalCode,
                paymentConnector,
                tokenType,
                chargeAmount,
                currency,
                description,
                validCardTypes,
                language
            );
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Prompt/> element as a child of this element
        /// </summary>
        /// <param name="prompt"> A Prompt instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public VoiceResponse Prompt(Prompt prompt)
        {
            this.Append(prompt);
            return this;
        }

        /// <summary>
        /// Create a new <Prompt/> element and append it as a child of this element.
        /// </summary>
        /// <param name="for_"> Name of the credit card data element </param>
        /// <param name="errorType"> Type of error </param>
        /// <param name="cardType"> Type of the credit card </param>
        /// <param name="attempt"> Current attempt count </param>
        public VoiceResponse Prompt(Prompt.ForEnum for_ = null, 
                                    List<Prompt.ErrorTypeEnum> errorType = null, 
                                    List<Prompt.CardTypeEnum> cardType = null, 
                                    List<int> attempt = null)
        {
            var newChild = new Prompt(for_, errorType, cardType, attempt);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new VoiceResponse Append(TwiML childElem)
        {
            return (VoiceResponse) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new VoiceResponse SetOption(string key, object value)
        {
            return (VoiceResponse) base.SetOption(key, value);
        }
    }

}