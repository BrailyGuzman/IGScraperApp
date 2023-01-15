using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Scraper
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        static JObject jobject = new JObject();

        public Form1()
        {
            InitializeComponent();
            Select();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (DataContainer != null)
            {
                DataContainer.Text = string.Empty;
            }
            client.DefaultRequestHeaders.Add("User-Agent", "Instagram 85.0.0.21.100 Android (28/9; 380dpi; 1080x2147; OnePlus; HWEVA; OnePlus6T; qcom; en_US; 146536611)");
            client.DefaultRequestHeaders.Add("x-csrftoken", "fbMty08hNS2evXP6EB4IsnFqoIUjGPB7");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");

            using (var response = client.GetAsync($"https://i.instagram.com/api/v1/users/web_profile_info/?username={TargetTxt.Text}").Result)
            {
                string textResponse = response.Content.ReadAsStringAsync().Result;

                try
                {
                    jobject = JObject.Parse(textResponse);
                }
                catch (Exception)
                {
                    MessageBox.Show("An error has occurred..");
                    return;
                }
                jobject = JObject.Parse(textResponse);

                var checkValues = !jobject["data"]?["user"]?.HasValues;

                if (checkValues.Value)
                {
                    MessageBox.Show("[ERROR] User not found..");
                    return;
                }

                else
                {
                    Int64? userId = jobject["data"]?["user"]?["id"]?.ToObject<Int64>();
                    string? user = jobject["data"]?["user"]?["username"]?.ToObject<string>();
                    string? full_name = jobject["data"]?["user"]?["full_name"]?.ToObject<string>();
                    string? pfp_url = jobject["data"]?["user"]?["profile_pic_url_hd"]?.ToObject<string>();
                    long? followerCount = jobject["data"]?["user"]?["edge_followed_by"]?["count"]?.ToObject<long>();
                    long? followingsCount = jobject["data"]?["user"]?["edge_follow"]?["count"]?.ToObject<long>();
                    long? postCount = jobject["data"]?["user"]?["edge_owner_to_timeline_media"]?["count"]?.ToObject<long>();
                    bool? is_verified = jobject["data"]?["user"]?["is_verified"]?.ToObject<bool>();
                    bool? is_private = jobject["data"]?["user"]?["is_private"]?.ToObject<bool>();

                    var dateResponse = client.GetAsync($"https://o7aa.pythonanywhere.com/?id={userId}").Result;
                    string dateTextResponse = dateResponse.Content.ReadAsStringAsync().Result;
                    jobject = JObject.Parse(dateTextResponse);
                    string? year = jobject["date"]?.ToObject<string>();

                    DataContainer.AppendText($"UserID: {userId} \nUsername: {user} \nCreation Year: {year} \nFull Name: {full_name} \nPfp URL: {pfp_url} \nFollowers Count: {followerCount} \nFollowings Count: {followingsCount} \nPost Count: {postCount} \nIs Verified: {is_verified} \nIs Private: {is_private}");
                }

            }
        }

        private void ClearDataTxt_Click(object sender, EventArgs e)
        {
            DataContainer.Clear();
        }

        

        private void TargetTxt_Click(object sender, EventArgs e)
        {
            TargetTxt.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DataContainer.Text);
            MessageBox.Show("[+] Text Has Been Copied To The Clipboard!");

        }
    }
}