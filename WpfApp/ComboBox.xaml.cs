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
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// ComboBox.xaml 的交互逻辑
    /// </summary>
    public partial class ComboBox : Window
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        #region  通过字典形式赋值，取值(设置SelectedValuePath和DisplayMemberPath)
        /// <summary>
        /// 通过字典形式赋值，取值(设置SelectedValuePath和DisplayMemberPath)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            Dictionary<int, string> mydic = new Dictionary<int, string>()
            {
                {1,"a"},{2,"b"},{3,"c"}
            };
            //设置数据源
            combobox.ItemsSource = mydic;
            //设置实际的值
            combobox.SelectedValuePath = "Key";
            //设置显示的值
            combobox.DisplayMemberPath = "Value";
        }

        /// <summary>
        /// 获取选定的值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            KeyValuePair<int, string> dict = (KeyValuePair<int, string>)combobox.SelectedItem;

            MessageBox.Show(dict.Key.ToString());
            MessageBox.Show(dict.Value.ToString());
        }

        #endregion

        #region 通过List<string>赋值，取值(默认不设置SelectedValuePath和DisplayMemberPath)
        private void Combobox2_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("中国");
            list.Add("俄罗斯");
            list.Add("英国");
            list.Add("法国");
            combobox2.ItemsSource = list;

        }
        private void Combobox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ss = combobox2.SelectedItem.ToString();
            MessageBox.Show(ss);
        }
        #endregion

        #region 通过List<string>赋值，取值(默认设置SelectedValuePath属性)
        private void Combobox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ss = combobox3.SelectedItem.ToString();
            MessageBox.Show(ss);
        }

        private void Combobox3_Loaded(object sender, RoutedEventArgs e)
        {
            
            List<string> list = new List<string>();
            list.Add("美国");
            list.Add("日本");
            list.Add("德国");
            list.Add("加拿大");
            combobox3.ItemsSource = list;
            combobox3.SelectedValuePath = "Key";
        }
        #endregion
    }
}
