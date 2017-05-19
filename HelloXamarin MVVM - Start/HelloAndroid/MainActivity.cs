using Android.App;
using Android.Widget;
using Android.OS;
using System.Net.Http;

namespace HelloAndroid
{
    [Activity(Label = "HelloAndroid1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private int _counter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += async (s, e) =>
            {
                var text = FindViewById<TextView>(Resource.Id.MyText);
                var client = new HttpClient();

                var html = await client.GetStringAsync("https://www.youtube.com/watch?v=_ntWKJoqsLQ");

                var div = "<div class=\"watch-view-count\">";

                var index = html.IndexOf(div) + div.Length;
                html = html.Substring(index);
                var index2 = html.IndexOf("<");
                html = html.Substring(0, index2);
                text.Text = html;
            };
        }
    }
}

