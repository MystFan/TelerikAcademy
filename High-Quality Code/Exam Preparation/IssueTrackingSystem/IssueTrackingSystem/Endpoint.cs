namespace IssueTrackingSystem
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using IssueTrackingSystem.Contracts;

    public class Endpoint : IEndpoint
    {
        public Endpoint(string name)
        {
            this.Name = name;
            this.Parameters = new Dictionary<string, string>();
        }

        public string Name { get; set; }

        public IDictionary<string, string> Parameters { get; set; }

        public static Endpoint Parse(string endpointText)
        {
            int questionMark = endpointText.IndexOf('?');
            Endpoint endpoint = null;

            if (questionMark > 0)
            {
                string endpointName = endpointText.Substring(0, questionMark);

                var pairs = endpointText.Substring(questionMark + 1)
                    .Split('&')
                    .Select(x => x.Split('=')
                        .Select(xx => WebUtility.UrlDecode(xx))
                        .ToArray());

                var parameters = new Dictionary<string, string>();
                foreach (var pair in pairs)
                {
                    parameters.Add(pair[0], pair[1]);
                }

                endpoint = new Endpoint(endpointName);
                endpoint.Parameters = parameters;
            }
            else
            {
                endpoint = new Endpoint(endpointText);
            }

            return endpoint;
        }
    }
}
