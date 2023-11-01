﻿using System;
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
using wpfData_Step_4.Model;
using wpfData_Step_4.ViewModel;

namespace wpfData
{
    /// <summary>
    /// Interaction logic for UserUserControl1.xaml
    /// </summary>
    public partial class UserUserControl1 : UserControl
    {
        public UserUserControl1()
        {
            InitializeComponent();
            UserDB userDB = new UserDB();
            UserList userList = userDB.SelectAll();
            usersListView.ItemsSource = userList;
        }
    }
}
