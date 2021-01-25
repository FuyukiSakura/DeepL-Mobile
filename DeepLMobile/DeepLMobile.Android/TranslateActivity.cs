using Android.App;
using Android.Content;
using Android.OS;

namespace Utosoft.DeepLMobile.Droid
{
    [Activity(Label = "DeepL", NoHistory = true)]
    [IntentFilter(new [] { Intent.ActionProcessText },
        Categories = new []
        {
            Intent.CategoryDefault
        },
        DataMimeType = "text/plain")]
    public class TranslateActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            var selectedText = Intent.GetCharSequenceExtra(Intent.ExtraProcessText);
            var intent = new Intent(this, typeof(MainActivity));
            intent.PutExtra("selectedText", selectedText);
            StartActivity(intent);
        }
    }
}