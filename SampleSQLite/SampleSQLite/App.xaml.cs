﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SampleSQLite
{
    public partial class App : Application
    {
        private static PersonRepository _personRepo;
        public static PersonRepository PersonRepo
        {
            get
            {
                if (_personRepo == null)
                {
                    _personRepo = new PersonRepository();
                }

                return _personRepo;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new SampleSQLite.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
