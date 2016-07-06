using System;
using InfluxData.Net.Common.Enums;
using InfluxData.Net.Common.Helpers;
using InfluxData.Net.Common.Infrastructure;
using System.Net.Http;

namespace InfluxData.Net.InfluxDb.Infrastructure
{
    public class InfluxDbClientConfiguration : IInfluxDbClientConfiguration
    {
        public Uri EndpointUri { get; internal set; }

        public string Username { get; private set; }

        public string Password { get; private set; }

        public InfluxDbVersion InfluxVersion { get; private set; }

        public HttpClient HttpClient { get; private set; }

        public InfluxDbClientConfiguration(Uri endpointUri, string username, string password, InfluxDbVersion influxVersion, HttpClient httpClient = null)
        {
            Validate.IsNotNull(endpointUri, "Endpoint may not be null or empty.");
            Validate.IsNotNullOrEmpty(password, "Password may not be null or empty.");
            Validate.IsNotNullOrEmpty(username, "Username may not be null or empty.");

            EndpointUri = SanitizeEndpoint(endpointUri, false);
            Username = username;
            Password = password;
            InfluxVersion = influxVersion;
            HttpClient = httpClient;
        }

        private static Uri SanitizeEndpoint(Uri endpointUri, bool isTls)
        {
            var builder = new UriBuilder(endpointUri);

            if (isTls)
            {
                builder.Scheme = "https";
            }
            else if (builder.Scheme.Equals("tcp", StringComparison.CurrentCultureIgnoreCase)) //InvariantCultureIgnoreCase, not supported in PCL
            {
                builder.Scheme = "http";
            }

            return builder.Uri;
        }
    }
}