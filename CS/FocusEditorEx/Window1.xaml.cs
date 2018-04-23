using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Wpf.Bars;

namespace FocusEditorEx {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        #region #2
        private void btn_ItemClick(object sender, DevExpress.Wpf.Bars.ItemClickEventArgs e) {
            (beiEditor.Links[0] as BarEditItemLink).Editor.Focus();
        }
        #endregion #2
    }
}
