using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace CustomEvents
{
    [TemplatePart(Name = Button100Name, Type = typeof(Button))]
    [TemplatePart(Name = Button10Name, Type = typeof(Button))]
    [TemplatePart(Name = Button1Name, Type = typeof(Button))]
    public sealed class Counter : Control
    {
        private const int DefaultCountValue = 0;
        private const string CountStringFormat = "{0:0000}";
        private const string Button100Name = "PART_100Button";
        private const string Button10Name = "PART_10Button";
        private const string Button1Name = "PART_1Button";

        public Counter()
        {
            this.DefaultStyleKey = typeof(Counter);
        }

        public static readonly DependencyProperty CountProperty = DependencyProperty.Register(
            "Count",
            typeof(int),
            typeof(Counter),
            new PropertyMetadata(DefaultCountValue, CountChanged)
        );

        public static readonly DependencyProperty CountStringProperty = DependencyProperty.Register(
            "CountString",
            typeof(string),
            typeof(Counter),
            new PropertyMetadata(String.Format(CountStringFormat, DefaultCountValue))
        );

        public int Count
        {
            get { return (int)GetValue(CountProperty); }
            set { SetValue(CountProperty, value); }
        }

        public string CountString
        {
            get { return (string)GetValue(CountStringProperty); }
            set { SetValue(CountStringProperty, value); }
        }

        private static void CountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.SetValue(Counter.CountStringProperty, String.Format(CountStringFormat, e.NewValue));
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var button100 = this.GetTemplateChild(Button100Name) as Button;
            if (button100 != null)
            {
                button100.Click += (sender, args) => IncrementCount(100);
            }
            var button10 = this.GetTemplateChild(Button10Name) as Button;
            if (button10 != null)
            {
                button10.Click += (sender, args) => IncrementCount(10);
            }
            var button1 = this.GetTemplateChild(Button1Name) as Button;
            if (button1 != null)
            {
                button1.Click += (sender, args) => IncrementCount(1);
            }
        }

        private void IncrementCount(int append)
        {
            Count += append;
            if (Increment != null)
            {
                Increment(this, new IncrementEventArgs(append));
            }
        }

        public delegate void IncrementEventHandler(Counter sender, IncrementEventArgs e);

        public event IncrementEventHandler Increment;
    }
}
