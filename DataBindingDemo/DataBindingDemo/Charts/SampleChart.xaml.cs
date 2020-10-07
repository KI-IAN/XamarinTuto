using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBindingDemo.ContentViewDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleChart : ContentPage
    {

        private ChartEntry[] entries;

        public SampleChart()
        {
            InitializeComponent();


        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            SetChartEntries();

            InitialzeChart();

        }


        private void InitialzeChart()
        {
            barChart.Chart = new BarChart()
            {
                Entries = entries,
                LabelOrientation = Orientation.Horizontal,
                ValueLabelOrientation = Orientation.Horizontal,
                PointMode = PointMode.None,
                AnimationDuration = new TimeSpan(0, 0, 5),
                AnimationProgress = 10,


            };


            donutChart.Chart = new DonutChart()
            {
                Entries = entries,
                AnimationDuration = new TimeSpan(0, 0, 5),

            };

            lineChart.Chart = new LineChart()
            {
                Entries = entries,
                AnimationDuration = new TimeSpan(0, 0, 5),
                LineMode = LineMode.Straight,
                PointMode = PointMode.Square,
                PointSize = 20

            };

            pieChart.Chart = new PieChart()
            {
                Entries = entries,
                AnimationDuration = new TimeSpan(0, 0, 5),

            };

            pointChart.Chart = new PointChart()
            {
                Entries = entries,
                AnimationDuration = new TimeSpan(0, 0, 5),

            };

            radarChart.Chart = new RadarChart()
            {
                Entries = entries,
                AnimationDuration = new TimeSpan(0, 0, 5),

            };

            radialGaugeChart.Chart = new RadialGaugeChart()
            {
                Entries = entries,
                AnimationDuration = new TimeSpan(0, 0, 5),

            };

        }

        private void SetChartEntries()
        {
            entries = new[] {

                new ChartEntry(212)
                {
                    Label = "UWP",
                    ValueLabel = "212",
                    Color = SKColor.Parse("#2c3e50"),
                },
                    new ChartEntry(248)
    {
        Label = "Android",
        ValueLabel = "658",
        Color = SKColor.Parse("#77d065")
    },
    new ChartEntry(128)
    {
        Label = "iOS",
        ValueLabel = "1128",
        Color = SKColor.Parse("#b455b6")
    },
    new ChartEntry(514)
    {
        Label = "Forms",
        ValueLabel = "2214",
        Color = SKColor.Parse("#3498db")
    }
            };
        }
    }
}