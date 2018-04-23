using System.Windows;
using DXPivotGrid_OverrideElementStyles.DataSet1TableAdapters;

namespace DXPivotGrid_OverrideElementStyles {
    public partial class MainWindow : Window {
        SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();
        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = salesPersonDataAdapter.GetData();
        }
    }
}
