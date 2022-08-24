Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

' ...
Namespace SideBySideBar2D

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Create an empty chart.
            Dim sideBySideBarChart As ChartControl = New ChartControl()
            ' Create the first side-by-side bar series and add points to it.
            Dim series1 As Series = New Series("Side-by-Side Bar Series 1", ViewType.Bar)
            series1.Points.Add(New SeriesPoint("A", New Double() {10}))
            series1.Points.Add(New SeriesPoint("B", New Double() {12}))
            series1.Points.Add(New SeriesPoint("C", New Double() {14}))
            series1.Points.Add(New SeriesPoint("D", New Double() {17}))
            ' Create the second side-by-side bar series and add points to it.
            Dim series2 As Series = New Series("Side-by-Side Bar Series 2", ViewType.Bar)
            series2.Points.Add(New SeriesPoint("A", New Double() {15}))
            series2.Points.Add(New SeriesPoint("B", New Double() {18}))
            series2.Points.Add(New SeriesPoint("C", New Double() {25}))
            series2.Points.Add(New SeriesPoint("D", New Double() {33}))
            ' Add the series to the chart.
            sideBySideBarChart.Series.Add(series1)
            sideBySideBarChart.Series.Add(series2)
            ' Hide the legend (if necessary).
            sideBySideBarChart.Legend.Visible = False
            ' Rotate the diagram (if necessary).
            CType(sideBySideBarChart.Diagram, XYDiagram).Rotated = True
            ' Add a title to the chart (if necessary).
            Dim chartTitle1 As ChartTitle = New ChartTitle()
            chartTitle1.Text = "Side-by-Side Bar Chart"
            sideBySideBarChart.Titles.Add(chartTitle1)
            ' Add the chart to the form.
            sideBySideBarChart.Dock = DockStyle.Fill
            Me.Controls.Add(sideBySideBarChart)
        End Sub
    End Class
End Namespace
