using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace SideBySideBar2D {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create an empty chart.
            ChartControl sideBySideBarChart = new ChartControl();

            // Create the first side-by-side bar series and add points to it.
            Series series1 = new Series("Side-by-Side Bar Series 1", ViewType.Bar);
            series1.Points.Add(new SeriesPoint("A",  10));
            series1.Points.Add(new SeriesPoint("B", 12));
            series1.Points.Add(new SeriesPoint("C", 14));
            series1.Points.Add(new SeriesPoint("D", 17));

            // Create the second side-by-side bar series and add points to it.
            Series series2 = new Series("Side-by-Side Bar Series 2", ViewType.Bar);
            series2.Points.Add(new SeriesPoint("A", 15));
            series2.Points.Add(new SeriesPoint("B", 18));
            series2.Points.Add(new SeriesPoint("C", 25));
            series2.Points.Add(new SeriesPoint("D", 33));

            // Add the series to the chart.
            sideBySideBarChart.Series.Add(series1);
            sideBySideBarChart.Series.Add(series2);

            // Hide the legend (if necessary).
            sideBySideBarChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Rotate the diagram (if necessary).
            ((XYDiagram)sideBySideBarChart.Diagram).Rotated = true;

            // Add a title to the chart (if necessary).
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "Side-by-Side Bar Chart";
            sideBySideBarChart.Titles.Add(chartTitle1);

            // Add the chart to the form.
            sideBySideBarChart.Dock = DockStyle.Fill;
            this.Controls.Add(sideBySideBarChart);
        }

    }
}