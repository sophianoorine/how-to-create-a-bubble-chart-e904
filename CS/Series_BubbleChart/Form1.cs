using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_BubbleChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl bubbleChart = new ChartControl();

            // Create two bubble series.
            Series series1 = new Series("Series 1", ViewType.Bubble);
            Series series2 = new Series("Series 2", ViewType.Bubble);

            // Add points to them.
            series1.Points.Add(new SeriesPoint(1, 11, 2));
            series1.Points.Add(new SeriesPoint(2, 10, 1));
            series1.Points.Add(new SeriesPoint(3, 14, 3));
            series1.Points.Add(new SeriesPoint(4, 17, 2));

            series2.Points.Add(new SeriesPoint(1, 15, 3));
            series2.Points.Add(new SeriesPoint(2, 18, 4));
            series2.Points.Add(new SeriesPoint(3, 25, 2));
            series2.Points.Add(new SeriesPoint(4, 33, 1));

            // Add both series to the chart.
            bubbleChart.Series.AddRange(new Series[] { series1, series2 });

            // Set the numerical argument scale types for the series,
            // as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Numerical;
            series2.ArgumentScaleType = ScaleType.Numerical;

            // Access the view-type-specific options of the series.
            ((BubbleSeriesView)series1.View).MaxSize = 2;
            ((BubbleSeriesView)series1.View).MinSize = 1;
            ((BubbleSeriesView)series1.View).BubbleMarkerOptions.Kind = MarkerKind.Circle;

            // Access the type-specific options of the diagram.
            ((XYDiagram)bubbleChart.Diagram).Rotated = true;

            // Hide the legend (if necessary).
            bubbleChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Add a chart to the form.
            bubbleChart.Dock = DockStyle.Fill;
            this.Controls.Add(bubbleChart);
        }
    }
}