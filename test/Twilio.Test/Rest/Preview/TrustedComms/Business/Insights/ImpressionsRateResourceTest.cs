/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Preview.TrustedComms.Business.Insights;

namespace Twilio.Tests.Rest.Preview.TrustedComms.Business.Insights
{

    [TestFixture]
    public class ImpressionsRateTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Preview,
                "/TrustedComms/Businesses/BXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Insights/ImpressionsRate",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ImpressionsRateResource.Fetch("BXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"business_sid\": \"BXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"start\": \"2015-07-30T20:00:00Z\",\"end\": \"2015-07-30T21:00:00Z\",\"interval\": \"minute\",\"reports\": {\"impressions_rate\": {\"timestamp\": \"2015-07-30T20:00:00\",\"calls\": 1200,\"impressions\": 800}},\"url\": \"https://preview.twilio.com/TrustedComms/Businesses/BXaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Insights/ImpressionsRate\"}"
                                     ));

            var response = ImpressionsRateResource.Fetch("BXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}