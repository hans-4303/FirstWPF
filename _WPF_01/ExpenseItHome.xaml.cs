using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _WPF_01
{
    /// <summary>
    /// ExpenseItHome.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ExpenseItHome : Page
    {
        /// <summary>
        /// 파라미터 이름 중 허용 하는 게 있고 그렇지 않은 게 있음
        /// event를 그대로 쓸 수는 없고, _event로 작성해줄 수는 있음
        /// <param name="sender" || "아무 이름이나 괜찮지만 예약어는 안 됨"></param>
        /// <param name="e"></param>
        /// </summary>
        private void handleClick(object sender, RoutedEventArgs _event)
        {
            // 인스턴스 생성
            // View Expense Report
            ExpenseReportPage expenseReportPage = new ExpenseReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(expenseReportPage);
        }

        public ExpenseItHome()
        {
            InitializeComponent();
        }
    }
}
