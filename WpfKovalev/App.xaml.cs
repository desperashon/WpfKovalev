﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfKovalev.Model;

namespace WpfKovalev
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static RestartKovalevEntities context = new RestartKovalevEntities();

        public static User enteredUser;
    }
}
