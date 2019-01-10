// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.37.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   PageSpeed Insights API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/speed/docs/insights/v1/getting_started'>PageSpeed Insights API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20190103 (1463)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/speed/docs/insights/v1/getting_started'>
 *              https://developers.google.com/speed/docs/insights/v1/getting_started</a>
 *      <tr><th>Discovery Name<td>pagespeedonline
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using PageSpeed Insights API can be found at
 * <a href='https://developers.google.com/speed/docs/insights/v1/getting_started'>https://developers.google.com/speed/docs/insights/v1/getting_started</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.Pagespeedonline.v1
{
    /// <summary>The Pagespeedonline Service.</summary>
    public class PagespeedonlineService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PagespeedonlineService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PagespeedonlineService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            pagespeedapi = new PagespeedapiResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "pagespeedonline"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://www.googleapis.com/pagespeedonline/v1/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return "pagespeedonline/v1/"; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://www.googleapis.com/batch/pagespeedonline/v1"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch/pagespeedonline/v1"; }
        }
        #endif





        private readonly PagespeedapiResource pagespeedapi;

        /// <summary>Gets the Pagespeedapi resource.</summary>
        public virtual PagespeedapiResource Pagespeedapi
        {
            get { return pagespeedapi; }
        }
    }

    ///<summary>A base abstract class for Pagespeedonline requests.</summary>
    public abstract class PagespeedonlineBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new PagespeedonlineBaseServiceRequest instance.</summary>
        protected PagespeedonlineBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>An opaque string that represents a user for quota purposes. Must not exceed 40
        /// characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Pagespeedonline parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "pagespeedapi" collection of methods.</summary>
    public class PagespeedapiResource
    {
        private const string Resource = "pagespeedapi";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PagespeedapiResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Runs PageSpeed analysis on the page at the specified URL, and returns a PageSpeed score, a list of
        /// suggestions to make that page faster, and other information.</summary>
        /// <param name="url">The URL to fetch and analyze</param>
        public virtual RunpagespeedRequest Runpagespeed(string url)
        {
            return new RunpagespeedRequest(service, url);
        }

        /// <summary>Runs PageSpeed analysis on the page at the specified URL, and returns a PageSpeed score, a list of
        /// suggestions to make that page faster, and other information.</summary>
        public class RunpagespeedRequest : PagespeedonlineBaseServiceRequest<Google.Apis.Pagespeedonline.v1.Data.Result>
        {
            /// <summary>Constructs a new Runpagespeed request.</summary>
            public RunpagespeedRequest(Google.Apis.Services.IClientService service, string url)
                : base(service)
            {
                Url = url;
                InitParameters();
            }


            /// <summary>The URL to fetch and analyze</summary>
            [Google.Apis.Util.RequestParameterAttribute("url", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Url { get; private set; }

            /// <summary>Indicates if third party resources should be filtered out before PageSpeed analysis.</summary>
            /// [default: false]
            [Google.Apis.Util.RequestParameterAttribute("filter_third_party_resources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> FilterThirdPartyResources { get; set; }

            /// <summary>The locale used to localize formatted results</summary>
            [Google.Apis.Util.RequestParameterAttribute("locale", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Locale { get; set; }

            /// <summary>A PageSpeed rule to run; if none are given, all rules are run</summary>
            [Google.Apis.Util.RequestParameterAttribute("rule", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> Rule { get; set; }

            /// <summary>Indicates if binary data containing a screenshot should be included</summary>
            /// [default: false]
            [Google.Apis.Util.RequestParameterAttribute("screenshot", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> Screenshot { get; set; }

            /// <summary>The analysis strategy to use</summary>
            [Google.Apis.Util.RequestParameterAttribute("strategy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StrategyEnum> Strategy { get; set; }

            /// <summary>The analysis strategy to use</summary>
            public enum StrategyEnum
            {
                /// <summary>Fetch and analyze the URL for desktop browsers</summary>
                [Google.Apis.Util.StringValueAttribute("desktop")]
                Desktop,
                /// <summary>Fetch and analyze the URL for mobile devices</summary>
                [Google.Apis.Util.StringValueAttribute("mobile")]
                Mobile,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "runpagespeed"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "runPagespeed"; }
            }

            /// <summary>Initializes Runpagespeed parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "url", new Google.Apis.Discovery.Parameter
                    {
                        Name = "url",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"(?i)http(s)?://.*",
                    });
                RequestParameters.Add(
                    "filter_third_party_resources", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter_third_party_resources",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "locale", new Google.Apis.Discovery.Parameter
                    {
                        Name = "locale",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"[a-zA-Z]+(_[a-zA-Z]+)?",
                    });
                RequestParameters.Add(
                    "rule", new Google.Apis.Discovery.Parameter
                    {
                        Name = "rule",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = @"[a-zA-Z]+",
                    });
                RequestParameters.Add(
                    "screenshot", new Google.Apis.Discovery.Parameter
                    {
                        Name = "screenshot",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "strategy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "strategy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.Pagespeedonline.v1.Data
{    

    public class Result : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The captcha verify result</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("captchaResult")]
        public virtual string CaptchaResult { get; set; } 

        /// <summary>Localized PageSpeed results. Contains a ruleResults entry for each PageSpeed rule instantiated and
        /// run by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedResults")]
        public virtual Result.FormattedResultsData FormattedResults { get; set; } 

        /// <summary>Canonicalized and final URL for the document, after following page redirects (if any).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>List of rules that were specified in the request, but which the server did not know how to
        /// instantiate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("invalidRules")]
        public virtual System.Collections.Generic.IList<string> InvalidRules { get; set; } 

        /// <summary>Kind of result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Summary statistics for the page, such as number of JavaScript bytes, number of HTML bytes,
        /// etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageStats")]
        public virtual Result.PageStatsData PageStats { get; set; } 

        /// <summary>Response code for the document. 200 indicates a normal page load. 4xx/5xx indicates an
        /// error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseCode")]
        public virtual System.Nullable<int> ResponseCode { get; set; } 

        /// <summary>The PageSpeed Score (0-100), which indicates how much faster a page could be. A high score
        /// indicates little room for improvement, while a lower score indicates more room for improvement.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<int> Score { get; set; } 

        /// <summary>Base64-encoded screenshot of the page that was analyzed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("screenshot")]
        public virtual Result.ScreenshotData Screenshot { get; set; } 

        /// <summary>Title of the page, as displayed in the browser's title bar.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The version of PageSpeed used to generate these results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual Result.VersionData Version { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        /// <summary>Localized PageSpeed results. Contains a ruleResults entry for each PageSpeed rule instantiated and
        /// run by the server.</summary>
        public class FormattedResultsData
        {
            /// <summary>The locale of the formattedResults, e.g. "en_US".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("locale")]
            public virtual string Locale { get; set; } 

            /// <summary>Dictionary of formatted rule results, with one entry for each PageSpeed rule instantiated and
            /// run by the server.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("ruleResults")]
            public virtual System.Collections.Generic.IDictionary<string,FormattedResultsData.RuleResultsDataElement> RuleResults { get; set; } 

            

            /// <summary>The enum-like identifier for this rule. For instance "EnableKeepAlive" or "AvoidCssImport". Not
            /// localized.</summary>
            public class RuleResultsDataElement
            {
                /// <summary>Localized name of the rule, intended for presentation to a user.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("localizedRuleName")]
                public virtual string LocalizedRuleName { get; set; } 

                /// <summary>The impact (unbounded floating point value) that implementing the suggestions for this rule
                /// would have on making the page faster. Impact is comparable between rules to determine which rule's
                /// suggestions would have a higher or lower impact on making a page faster. For instance, if enabling
                /// compression would save 1MB, while optimizing images would save 500kB, the enable compression rule
                /// would have 2x the impact of the image optimization rule, all other things being equal.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("ruleImpact")]
                public virtual System.Nullable<double> RuleImpact { get; set; } 

                /// <summary>List of blocks of URLs. Each block may contain a heading and a list of URLs. Each URL may
                /// optionally include additional details.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("urlBlocks")]
                public virtual System.Collections.Generic.IList<RuleResultsDataElement.UrlBlocksData> UrlBlocks { get; set; } 

                

                public class UrlBlocksData
                {
                    /// <summary>Heading to be displayed with the list of URLs.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("header")]
                    public virtual UrlBlocksData.HeaderData Header { get; set; } 

                    /// <summary>List of entries that provide information about URLs in the url block.
                    /// Optional.</summary>
                    [Newtonsoft.Json.JsonPropertyAttribute("urls")]
                    public virtual System.Collections.Generic.IList<UrlBlocksData.UrlsData> Urls { get; set; } 

                    

                    /// <summary>Heading to be displayed with the list of URLs.</summary>
                    public class HeaderData
                    {
                        /// <summary>List of arguments for the format string.</summary>
                        [Newtonsoft.Json.JsonPropertyAttribute("args")]
                        public virtual System.Collections.Generic.IList<HeaderData.ArgsData> Args { get; set; } 

                        /// <summary>A localized format string with $N placeholders, where N is the 1-indexed argument
                        /// number, e.g. 'Minifying the following $1 resources would save a total of $2
                        /// bytes'.</summary>
                        [Newtonsoft.Json.JsonPropertyAttribute("format")]
                        public virtual string Format { get; set; } 

                        

                        public class ArgsData
                        {
                            /// <summary>Type of argument. One of URL, STRING_LITERAL, INT_LITERAL, BYTES, or
                            /// DURATION.</summary>
                            [Newtonsoft.Json.JsonPropertyAttribute("type")]
                            public virtual string Type { get; set; } 

                            /// <summary>Argument value, as a localized string.</summary>
                            [Newtonsoft.Json.JsonPropertyAttribute("value")]
                            public virtual string Value { get; set; } 

                        }
                    }    

                    public class UrlsData
                    {
                        /// <summary>List of entries that provide additional details about a single URL.
                        /// Optional.</summary>
                        [Newtonsoft.Json.JsonPropertyAttribute("details")]
                        public virtual System.Collections.Generic.IList<UrlsData.DetailsData> Details { get; set; } 

                        /// <summary>A format string that gives information about the URL, and a list of arguments for
                        /// that format string.</summary>
                        [Newtonsoft.Json.JsonPropertyAttribute("result")]
                        public virtual UrlsData.ResultData Result { get; set; } 

                        

                        public class DetailsData
                        {
                            /// <summary>List of arguments for the format string.</summary>
                            [Newtonsoft.Json.JsonPropertyAttribute("args")]
                            public virtual System.Collections.Generic.IList<DetailsData.ArgsData> Args { get; set; } 

                            /// <summary>A localized format string with $N placeholders, where N is the 1-indexed
                            /// argument number, e.g. 'Unnecessary metadata for this resource adds an additional $1
                            /// bytes to its download size'.</summary>
                            [Newtonsoft.Json.JsonPropertyAttribute("format")]
                            public virtual string Format { get; set; } 

                            

                            public class ArgsData
                            {
                                /// <summary>Type of argument. One of URL, STRING_LITERAL, INT_LITERAL, BYTES, or
                                /// DURATION.</summary>
                                [Newtonsoft.Json.JsonPropertyAttribute("type")]
                                public virtual string Type { get; set; } 

                                /// <summary>Argument value, as a localized string.</summary>
                                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                                public virtual string Value { get; set; } 

                            }
                        }    

                        /// <summary>A format string that gives information about the URL, and a list of arguments for
                        /// that format string.</summary>
                        public class ResultData
                        {
                            /// <summary>List of arguments for the format string.</summary>
                            [Newtonsoft.Json.JsonPropertyAttribute("args")]
                            public virtual System.Collections.Generic.IList<ResultData.ArgsData> Args { get; set; } 

                            /// <summary>A localized format string with $N placeholders, where N is the 1-indexed
                            /// argument number, e.g. 'Minifying the resource at URL $1 can save $2 bytes'.</summary>
                            [Newtonsoft.Json.JsonPropertyAttribute("format")]
                            public virtual string Format { get; set; } 

                            

                            public class ArgsData
                            {
                                /// <summary>Type of argument. One of URL, STRING_LITERAL, INT_LITERAL, BYTES, or
                                /// DURATION.</summary>
                                [Newtonsoft.Json.JsonPropertyAttribute("type")]
                                public virtual string Type { get; set; } 

                                /// <summary>Argument value, as a localized string.</summary>
                                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                                public virtual string Value { get; set; } 

                            }
                        }
                    }
                }
            }
        }    

        /// <summary>Summary statistics for the page, such as number of JavaScript bytes, number of HTML bytes,
        /// etc.</summary>
        public class PageStatsData
        {
            /// <summary>Number of uncompressed response bytes for CSS resources on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("cssResponseBytes")]
            public virtual System.Nullable<long> CssResponseBytes { get; set; } 

            /// <summary>Number of response bytes for flash resources on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("flashResponseBytes")]
            public virtual System.Nullable<long> FlashResponseBytes { get; set; } 

            /// <summary>Number of uncompressed response bytes for the main HTML document and all iframes on the
            /// page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("htmlResponseBytes")]
            public virtual System.Nullable<long> HtmlResponseBytes { get; set; } 

            /// <summary>Number of response bytes for image resources on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("imageResponseBytes")]
            public virtual System.Nullable<long> ImageResponseBytes { get; set; } 

            /// <summary>Number of uncompressed response bytes for JS resources on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("javascriptResponseBytes")]
            public virtual System.Nullable<long> JavascriptResponseBytes { get; set; } 

            /// <summary>Number of CSS resources referenced by the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("numberCssResources")]
            public virtual System.Nullable<int> NumberCssResources { get; set; } 

            /// <summary>Number of unique hosts referenced by the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("numberHosts")]
            public virtual System.Nullable<int> NumberHosts { get; set; } 

            /// <summary>Number of JavaScript resources referenced by the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("numberJsResources")]
            public virtual System.Nullable<int> NumberJsResources { get; set; } 

            /// <summary>Number of HTTP resources loaded by the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("numberResources")]
            public virtual System.Nullable<int> NumberResources { get; set; } 

            /// <summary>Number of static (i.e. cacheable) resources on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("numberStaticResources")]
            public virtual System.Nullable<int> NumberStaticResources { get; set; } 

            /// <summary>Number of response bytes for other resources on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("otherResponseBytes")]
            public virtual System.Nullable<long> OtherResponseBytes { get; set; } 

            /// <summary>Number of uncompressed response bytes for text resources not covered by other statistics (i.e
            /// non-HTML, non-script, non-CSS resources) on the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("textResponseBytes")]
            public virtual System.Nullable<long> TextResponseBytes { get; set; } 

            /// <summary>Total size of all request bytes sent by the page.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("totalRequestBytes")]
            public virtual System.Nullable<long> TotalRequestBytes { get; set; } 

        }    

        /// <summary>Base64-encoded screenshot of the page that was analyzed.</summary>
        public class ScreenshotData
        {
            /// <summary>Image data base64 encoded.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("data")]
            public virtual string Data { get; set; } 

            /// <summary>Height of screenshot in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("height")]
            public virtual System.Nullable<int> Height { get; set; } 

            /// <summary>Mime type of image data. E.g. "image/jpeg".</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("mime_type")]
            public virtual string MimeType { get; set; } 

            /// <summary>Width of screenshot in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("width")]
            public virtual System.Nullable<int> Width { get; set; } 

        }    

        /// <summary>The version of PageSpeed used to generate these results.</summary>
        public class VersionData
        {
            /// <summary>The major version number of PageSpeed used to generate these results.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("major")]
            public virtual System.Nullable<int> Major { get; set; } 

            /// <summary>The minor version number of PageSpeed used to generate these results.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("minor")]
            public virtual System.Nullable<int> Minor { get; set; } 

        }
    }
}
