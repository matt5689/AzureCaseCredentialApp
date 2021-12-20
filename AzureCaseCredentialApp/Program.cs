using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;

namespace AzureCaseCredentialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string myResponse = string.Empty;


                var cookieContainer = new CookieContainer();

                using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
                {
                    //using (var client = new HttpClient(handler) { BaseAddress = new Uri($"https://wawsobserver.azurewebsites.windows.net/api/sites/{siteName}") })
                    using (var client = new HttpClient(handler) { BaseAddress = new Uri($"https://onesupport.crm.dynamics.com/main.aspx?appid=101acb62-8d00-eb11-a813-000d3a8b3117&forceUCI=1&pagetype=AdvancedFind#347993078") })
                    {
                        cookieContainer.Add(new Uri("https://onesupport.crm.dynamics.com/AppWebServices/AppGridWebService.ashx?operation=Refresh"), new Cookie("CrmOwinAuth", "MAAAANJfbARPIBHsnwbi_L0ZGMJpvWhQ3CCi3sCJXRQX5Uw4BQWnpdhbgcsyOUdKVQX4Uh-LCAAAAAAABAC1WFmv27gZvbf3IpnJdNoBCuQtwH24b61s7UvQoJVlSV5ly5tsv6iSSC22JcqiNvsH9ndVzk0yk6Ao2tglbErmcnjI7-PHQz_c3d39YVJFiYLQPoJykYf3d_d3T03xg1OAZ_IlCcQlf8m8z2-f0_3dhzDPU_y-3cY5bjVgAFW4lcC87bIex_IOSwjA8YjmjSccAQACApGmHYqCPmDa93cPEcbXYlzPwcnfUDwjSTzPstLjYD4xrsZMXP_mmLBOXzAFkrkR5vtL_0t3L4Sxg1tx5GUIIz9veShuewcninHbaXwjiWEeIoAz6MMMJh7ED2kFrl_8awjEvnM9gfF_JFDhNk2SYpvk2xGASR7lp9-SupR4Th6hJEpw7iRf_Ehg6JvY55Vnhw4O3-4Wp7k3L4xTPHd3B2qkWPa4lK-f_e887x9KoMpqOMsdyzi5jFFuk9kZrDuVywzIUWyU7gzNlVDeafP-0ZULNOeFQ6-D28JuA_thf6gq5kbVt5PRAvSPSjfdMaE3quSTvOc6E1n-cD3LD9_YqI4PGDlpC2XBJwtx7ebzrYVwkSVODF8rTukcDuh6Hn_7Ph5BVMLkI5OxkzdOU13P5FWUOgBkP7FCixFbNEW2hOtBHy8c__iJ49PNVu1b6329w75dLOTuoJe_lPoRzJ4dnhOBwwiEQLEUwZKOT4iAYwjScx2aIZu5A-kGc0-LCPxCkSTTWJFUuxrD8gJ7gw2WhTzZkueVnKqulg9rKd07CQNpZRj2SrLy5M-p-vImY1k2W9eP_XscBU1gspvIlMPHfYyj6zG737cFLp71q03_jCU9HW-TaackFZs9pP78WG7yUhn4KRdze90AoxmHhFBBm-spc_-T_-UwaeJ4BJ7_G_Tryd3fvRvLirySR6O_fyGGizRF2Ud-148gfZ_FijT5fzN7KPLo7aATmNs9mxtkhPqTeAq1qpRvcLI9lDB7oFo30KiPVQTwsytIvuuzgGCgLzWNRYkQKZYhBN6lJBaKHEfeIAz9UMfYjlMvekVzUmOam4iI1xfQBvOR4W-E-JFmhaP8kRJvBPkWNZ1aXha3LsIqR_vGHU8p_HmSwqQPFJQkzbFw2S_3dz82o4NTYmf5P998X2yVA7nz8rNLEN2RzKwmgpkBEAwCwYJlJgfdZn6mLE1tZuaejxmwhFrMjiQlMugcJjPGExLbgnrHZyqWpPYEuz71IY3ieEWV5GCvJt4SnhhuoWvJYiV62wLX0sAP_MEUlR1Sj3ukUgiW7ZxnQMh9Pa5XClFpIAvBojNxNNPzyljBW5_ChJiswOq44czxqUvGMpkuhovRbqTqJ2pfyhFvWp1YOgsTYyxgwg13xRhOkDxEjhvwoIeMYaKYEbZKrxrmR8M7-B0xXnaJOT7UzKR7EI-OBA81KJZD3VJSda0e4NLvaPnehqdamNdmMSA4a1CyZ6TieMpapehFQCQzPzLYclOG247gyuVSDif7TE0T62gOk8oczKletoHmQlMIhhWDasQLvsmNTSef2qseQQvUeT5D3pqqh8e1CrkjZ3CjWBwF5mrVW5_l8ZCbLTmtOKhwcRYd0jM7edH3CT1XeKyOZDaqz4w_XeoDi04kI1SyxIpEnT2dlsZqZ3PMIJ9mJVEbtQ43UeNw0ag68nAdHCJHtG15FRedEUcSwtyaM6VFVOelstWG0OvkIjHxlJEf6vzc7_dW7knDRVjmKkzUPuQCc0Prnh0NTvuVzO-qXdbUams-Z0ooCLkgB6bpc9JUtY9cJjrheV4r_T573unbaamduWjjF13XWOe-GrhKY-zpXgrAfiFN82zY7zICAsKEHINil4neuR7ay-M59Q25Isih58DZYL4eipughJSEpd4ael6Y12ydEEZX5ngvG8OBxjpul-kskLbsnhJ4YJWkIKOhpsfnbX8r9wSrNzvatrmRx6hsrKosEBMUS3NYD6z9oWJNdpr2y8U29ji-kJf6eRZAa4vJnjtTYsoKYRDWxnjPponTx3ihQ3rvhjq3IyeM4FIbud8fo80Igp1lLU3CWe_3YlWWrCHqctZbIjEKe97SkmfOGJKgt1mR6YlRtOVxIVur08wP8XRWJ3Vl2IjtkqhLaUa0qP0NxSC6KwRsj2a2Ky9d-eediU9jG3QnHeieaBNCdTZIDGVMdPFRwjTuHQsECTKeSivnZI3IpUDvNmlHrYK9tpkmB0s6WJU1zXeLsHAoO9vXCidsexOzW9GTIN72bFXtjq3hdrmeKTs3JkjHjCiQasUMjNzzdB3hg08JrAlG9WbQ8VRWOzIbocB9L6TGQ2pPmn6YHTd4pyj8kELWeasAUxEqYkXBESDVkeJPYz2THf4kI986cLNTQW63W1Vxk5J3J9MknffTdWebTQeGNDFMiUFGWs_iOR9EII_qo95YgyV0VtgSOzrq9RE2a1kjtFm4lTbSrDB1M6Mnk5GtlxIgBmEl2Gl5LmOPEI4HuTgWufASV998iqtB9us9liO_rjv8m7pLuuSvmu-PrQyCKGti9fPnAwEl8ItsaMJ7g-I0egJ_VF8_tzDEuLk_zy8a9dltLjUMFB1CEpuMdRhAiDxsVD9Hi25zhjCsI_6p1QgZbz9_6dfXskZa_vXzWAcUNKfIF7mCkkOUwJe_EprYjJI2upwudPsjxKehf2qlMMMRbpRffvdDC9Zpwx-_mzv5X55o8qkLvebBUE8k_Z6S3lPkkz5evG5FGBcQvBuj5Det6K9b_QvdKBmFZBMAAA"));

                        HttpRequestMessage request = new HttpRequestMessage()
                        {
                            Method = HttpMethod.Post,
                            RequestUri = new Uri($"https://onesupport.crm.dynamics.com/AppWebServices/AppGridWebService.ashx?operation=Refresh")

                        };

                        request.Headers.Add("Referer", "https://onesupport.crm.dynamics.com/AdvancedFind/fetchData.aspx?sitemappath=SFA%7cMyWork%7cnav_dashboards&pagemode=iframe");

                        string[] query = System.IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\query.txt");
                        string query2 = String.Empty;

                        foreach (string line in query)
                        {
                            query2 += line;
                        }

                        request.Content = new StringContent(query2, Encoding.UTF8, "text/plain");

                        var result = Task.Run(async () =>
                        {
                            var preResponse = await client.SendAsync(request);
                            myResponse = await preResponse.Content.ReadAsStringAsync();
                        });

                        result.Wait();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
