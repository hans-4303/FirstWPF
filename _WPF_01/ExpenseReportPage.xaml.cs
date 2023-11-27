using System.Windows.Controls;

/// <summary>
/// 코드 비하인드 파일:
/// XAML 파일에서 정의된 UI와 관련된 로직이 포함되어 있음
/// 코드 비하인드 파일에서 ExpenseReportPage라는 클래스가 정의, XAML 파일의 Page 요소를 확장
/// </summary>
namespace _WPF_01
{
    /// <summary>
    /// ExpenseReportPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ExpenseReportPage : Page
    {
        public ExpenseReportPage()
        {
            InitializeComponent();
        }

        // Custom constructor to pass expense report data
        /// <summary>
        /// 현재 생성자가 두 개 있으며 기본 생성자는 인스턴스가 생성될 때 호출됨
        /// 두 번째 생성자는 파라미터로 개체를 받아들이고 this()를 사용하여 기본 생성자 호출
        /// 생성자 호출해서 report data를 전역 DataContext에 반환 받기
        /// </summary>
        public ExpenseReportPage(object data) : this()
        {
            /// <summary>
            /// 사용자가 제공한 데이터 개체를 파라미터로 취하는 사용자 지정 생성자에서
            /// ExpenseReportPage 인스턴스의 DataContext 속성이 제공된 데이터 개체로 설정됨
            /// 외부에서 전달되며 목적은 XAML에서 UI 요소를 이 데이터 개체의 속성에 바인딩하는 것
            /// DataContext를 설정하면 XAML에서 데이터 바인딩 표현식이 제공된 데이터 개체의 속성을 직접 참조할 수 있게 됨
            /// 
            /// DataContext의 설정 목적은 XAML에서 정의된 UI와 해당 데이터(이 경우 ExpenseReport 또는 유사한 클래스의 객체)
            /// 간 데이터 바인딩 활성화하고 UI 업데이트 쉽게 만드는 것
            /// 
            /// 어느 정도 이해한 대로, XAML 파일에서 ExpenseReportPage 클래스의 인스턴스를 생성하면
            /// (x:Class)에 대입될 ExpenseReportPage 생성자가 호출됨
            /// 사용자 정의 생성자는 외부에서 제공된 데이터 개체, DataContext 설정하여 UI 데이터 바인딩이 용이함
            /// </summary>
            this.DataContext = data;
        }
    }
}
