using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace power_saving_crash
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private int counter = 0;

        public MainPage()
        {
            InitializeComponent();
            this.RotateElement(this.icon);
        }

        private async Task RotateElement(VisualElement element)
        {
            while (true)
            {
                await element.RotateTo(360, 1200);
				element.Rotation = 0;

                // workaround: await Task.Delay(1);

                // also happens for other animations:
                //await element.FadeTo(0, 1200, Easing.Linear);
                //await element.FadeTo(1, 10, Easing.Linear);
            }
        }

        public void ButtonClicked(object sender, EventArgs e)
        {
            this.testLabel.Text = (counter++).ToString();
        }
    }
}
