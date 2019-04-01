﻿using Prism.Mvvm;
using System;
using System.Threading;
using System.Windows;

namespace Boysenberry.Models
{
    class Record : BindableBase
    {
        private string _userId;
        private string _nickname;
        private int _count;
        private DateTime _updateTime;

        private bool _isFuncEnable = true;
        private bool _isOpenEnable = true;
        private Visibility _isProgressVisiable = Visibility.Hidden;
        private CancellationTokenSource _cancellationTokenSource;



        public string UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }
        public string Nickname
        {
            get { return _nickname; }
            set { SetProperty(ref _nickname, value); }
        }
        public int Count
        {
            get { return _count; }
            set { SetProperty(ref _count, value); }
        }
        public DateTime UpdateTime
        {
            get { return _updateTime; }
            set { SetProperty(ref _updateTime, value); }
        }

        public bool IsFuncEnable
        {
            get { return _isFuncEnable; }
            set { SetProperty(ref _isFuncEnable, value); }
        }
       public bool IsOpenEnable
        {
            get { return _isOpenEnable; }
            set { SetProperty(ref _isOpenEnable, value); }
        }
       
         public Visibility IsProgressVisiable
        {
            get { return _isProgressVisiable; }
            set { SetProperty(ref _isProgressVisiable, value); }
        }

        public CancellationTokenSource CancellationTokenSource
        {
            get { return _cancellationTokenSource; }
            set { SetProperty(ref _cancellationTokenSource, value); }
        }

        public Record()
        {
        }

        public Record(string userId, string nickname, int count, DateTime updateTime)
        {
            _userId = userId;
            _nickname = nickname;
            _count = count;
            _updateTime = updateTime;
        }
    }
}
