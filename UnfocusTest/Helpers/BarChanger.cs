#if ANDROID
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#endif
#if IOS
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;
#endif
namespace UnfocusTest.Helpers
{
    class BarChanger
    {
        private static BarChanger _instance = new BarChanger();
        #region Constructor

        private BarChanger() { }

        #endregion

        #region Properties

        public static BarChanger Instance
        {
            get
            {
                return _instance;
            }
        }
        #endregion
        #region Methods
        public void SetBackgroundColor(Color color)
        {
            try
            {
                Application.Current.MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, color);
                if (Shell.Current != null)
                {

                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        try
                        {


                            Shell.Current.SetValue(Shell.BackgroundColorProperty, color);
#if ANDROID
                            var androidcolor = color.AddLuminosity(-0.1f).ToAndroid();
                            Microsoft.Maui.ApplicationModel.Platform.CurrentActivity.Window.SetStatusBarColor(androidcolor);
#endif

                        }
                        catch
                        {

                        }
                    });
                }


            }
            catch
            {

            }
        }

        #endregion
    }
}
