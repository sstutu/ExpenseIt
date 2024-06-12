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

namespace ExpenseIt
{
    /// <summary>
    /// ExpenseReportPage.xaml 的交互逻辑
    /// </summary>
    public partial class ExpenseReportPage : Page
    {
        public ExpenseReportPage()
        {
            InitializeComponent();
        }
        
        // 自定义构造函数以传递费用报告数据  
        public ExpenseReportPage(object data)  
            : this() // 调用无参数的构造函数  
        {  
            // 绑定到费用报告数据。  
            this.DataContext = data;  
        }  
    }
    
    
}
