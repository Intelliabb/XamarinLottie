using System;
using Lottie.Forms;
using Xamarin.Forms;

namespace XamLottie
{
    public class FancyCheckbox : AnimationView, IDisposable
    {
        public FancyCheckbox()
        {
            Animation = "check.json";
            OnClick += Checkbox_OnClick;
        }

        public static BindableProperty IsCheckedProperty = BindableProperty.Create(
            nameof(IsChecked), typeof(bool), typeof(FancyCheckbox), defaultBindingMode:BindingMode.TwoWay, 
            propertyChanged:IsCheckedChanged);

        public bool IsChecked
        {
            get { return (bool) GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        private static void IsCheckedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is FancyCheckbox cb)) 
                return;

            if ((bool)newValue)
                cb.Play();
            else
                cb.Reset();
        }

        void Reset()
        {
            Animation = null;
            Animation = "check.json";
        }

        void Checkbox_OnClick(object sender, EventArgs e)
        {
            IsChecked = !IsChecked;
        }

        public void Dispose()
        {
            OnClick -= Checkbox_OnClick;
        }
    }
}
