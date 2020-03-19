using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.Diagnostics;
using System.Web.UI;
using System.Web.Script.Serialization;

namespace Youtify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void webbrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (webbrowser.Url.ToString().Contains("code="))
            {
                Console.WriteLine(webbrowser.Url.ToString());
                string access_code = webbrowser.Url.ToString().Substring(35, 224);
                Console.WriteLine(access_code);
                webbrowser.Hide();
                Spotify_Authenticate(access_code);
            }
        }


        private void Spotify_Authenticate(string access_token) 
        {
            RestRequest request = new RestRequest("", Method.POST);
            RestClient client = new RestClient("https://accounts.spotify.com/api/token");

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "authorization_code");
            request.AddParameter("code", access_token);
            request.AddParameter("redirect_uri", "https://github.com/Jean-fabre");
            request.AddParameter("client_id", "5b10a95186374649ad215135159e9abc");
            request.AddParameter("client_secret", "c8d69a6285814811bc2d5a5e67431e41");

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content.ToString()); 

            JavaScriptSerializer ser = new JavaScriptSerializer();
            Spotify_Token token = ser.Deserialize<Spotify_Token>(response.Content);
            Spotify_Playlists(token);
        }

        //private void Spotify_API(Spotify_Token token)
        //{
        //    //get current user 
        //    RestRequest request = new RestRequest("", Method.GET);
        //    RestClient client = new RestClient("https://api.spotify.com/v1/me");
                        
        //    request.AddHeader("Authorization", "Bearer " + token.access_token);
            
        //    IRestResponse response = client.Execute(request);
        //    Console.WriteLine(response.Content.ToString());

        //    JavaScriptSerializer ser = new JavaScriptSerializer();
        //    Spotify_User user = ser.Deserialize<Spotify_User>(response.Content);
            
        //    Console.WriteLine(user.id);
        //    Spotify_Playlists(token, user);
        //}

        private void Spotify_Playlists(Spotify_Token token)
        {
            //get list of playlists
            RestRequest request = new RestRequest("", Method.GET);
            RestClient client = new RestClient("https://api.spotify.com/v1/me/playlists?offset=0&limit=50");

            request.AddHeader("Authorization", "Bearer " + token.access_token);

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content.ToString());

            JavaScriptSerializer ser = new JavaScriptSerializer();
            Spotify_All_Playlists All = ser.Deserialize<Spotify_All_Playlists>(response.Content);
            Spotify_Playlist_tracks(token, All.Items[0]);
        }

        private void Spotify_Playlist_tracks(Spotify_Token token, Spotify_Playlist playlist)
        {
            //get list of playlists
            RestRequest request = new RestRequest("", Method.GET);
            RestClient client = new RestClient("https://api.spotify.com/v1/playlists/" + playlist.Id + "/tracks");

            request.AddHeader("Authorization", "Bearer " + token.access_token);

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content.ToString());

        }

    }
}
