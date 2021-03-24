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
    /// DataGrid.xaml 的交互逻辑
    /// </summary>
    public partial class DataGrid : Window
    {
        List<people> peopleList = new List<people>();

        #region 实体对象定义
        public enum sexual_enum
        {
            BOY,
            GIRL
        }
        public class people
        {
            public int id { get; set; }
            public string name{ get; set; }
            public string age { get; set; }
            public sexual_enum sexual { get; set; }
        }
        #endregion
        public DataGrid()
        {
            InitializeComponent();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            DataInit();
            dataGrid.ItemsSource = peopleList;
        }

        #region 获取当前选中项的ID值
        private List<int> GetSelectedIds()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < this.dataGrid.Items.Count; i++)
            {
                var cntr = dataGrid.ItemContainerGenerator.ContainerFromIndex(i);
                DataGridRow ObjROw = (DataGridRow)cntr;
                if (ObjROw != null)
                {
                    FrameworkElement objElement = dataGrid.Columns[0].GetCellContent(ObjROw);
                    if (objElement != null)
                    {
                        System.Windows.Controls.CheckBox objChk = (System.Windows.Controls.CheckBox)objElement;
                        if (objChk.IsChecked == true)
                        {
                            list.Add(i);   //选中的加到集合中
                        }
                    }
                }
            }
            return list;
        }
        #endregion

        #region 初始化数据
        private void DataInit()
        {
            peopleList.Add(new people()
            {
                id = 458,
                name = "小明",
                age = "18",
                sexual = sexual_enum.BOY,
            });
            peopleList.Add(new people()
            {
                id = 489,
                name = "小红",
                age = "20",
                sexual = sexual_enum.GIRL
            });
        }
        #endregion

        #region  全选
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbSelectedAll_Checked(object sender, RoutedEventArgs e)
        {
            //this.dataGrid.SelectAll();
            for (int i = 0; i < this.dataGrid.Items.Count; i++)
            {
                var cntr = dataGrid.ItemContainerGenerator.ContainerFromIndex(i);
                DataGridRow ObjROw = (DataGridRow)cntr;
                if (ObjROw != null)
                {
                    FrameworkElement objElement = dataGrid.Columns[0].GetCellContent(ObjROw);
                    if (objElement != null)
                    {
                        System.Windows.Controls.CheckBox objChk = (System.Windows.Controls.CheckBox)objElement;
                        if (objChk.IsChecked == false)
                        {
                            objChk.IsChecked = true;
                        }
                    }
                }
            }
        }
        #endregion

        #region  全不选
        /// <summary>
        /// 全不选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbSelectedAll_Unchecked(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < this.dataGrid.Items.Count; i++)
            {
                var cntr = dataGrid.ItemContainerGenerator.ContainerFromIndex(i);
                DataGridRow ObjROw = (DataGridRow)cntr;
                if (ObjROw != null)
                {
                    FrameworkElement objElement = dataGrid.Columns[0].GetCellContent(ObjROw);
                    if (objElement != null)
                    {

                        System.Windows.Controls.CheckBox objChk = (System.Windows.Controls.CheckBox)objElement;
                        if (objChk.IsChecked == false)
                        {
                            objChk.IsChecked = true;
                        }
                        else
                        {
                            objChk.IsChecked = false;
                        }
                    }
                }
            }
        }
        #endregion

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<int> list = GetSelectedIds();
            foreach (var item in list)
            {
                MessageBox.Show("选中行当Index是：" + item);
            }
            
        }
    }
}
