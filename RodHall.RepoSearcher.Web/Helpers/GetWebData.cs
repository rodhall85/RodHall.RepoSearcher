namespace RodHall.RepoSearcher.Web.Helpers {
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net;

    public static class GetWebData {
        public static T DownloadJsonAsObject<T>(string url) where T : new() {
            using (WebClient client = new WebClient()) {
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

                try {
                    string json = client.DownloadString(url);
                    return !string.IsNullOrEmpty(json) ? JsonConvert.DeserializeObject<T>(json) : new T();
                }
                catch (WebException ex) {
                    throw new WebException($"Could not download the web service content. Ensure that this is a valid url: '{ url }'", ex);
                }
            }
        }
    }
}