﻿using System;
using Windows.UI.Xaml;

namespace MyToolkit.Controls
{
    public class HamburgerItem : DependencyObject
    {
        public static readonly DependencyProperty AutoClosePaneProperty = DependencyProperty.Register(
            "AutoClosePane", typeof (bool), typeof (HamburgerItem), new PropertyMetadata(default(bool)));

        public bool AutoClosePane
        {
            get { return (bool) GetValue(AutoClosePaneProperty); }
            set { SetValue(AutoClosePaneProperty, value); }
        }

        public static readonly DependencyProperty ShowIconWhenPaneIsOpenProperty = DependencyProperty.Register(
            "ShowIconWhenPaneIsOpen", typeof (bool), typeof (HamburgerItem), new PropertyMetadata(true));

        public bool ShowIconWhenPaneIsOpen
        {
            get { return (bool) GetValue(ShowIconWhenPaneIsOpenProperty); }
            set { SetValue(ShowIconWhenPaneIsOpenProperty, value); }
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            "Icon", typeof (string), typeof (HamburgerItem), new PropertyMetadata(default(string)));

        public string Icon
        {
            get { return (string) GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }   
        
        public static readonly DependencyProperty ContentProperty = DependencyProperty.Register(
            "Content", typeof(object), typeof(HamburgerItem), new PropertyMetadata(default(object)));

        public object Content
        {
            get { return (object)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        public static readonly DependencyProperty IsSelectedProperty = DependencyProperty.Register(
            "IsSelected", typeof (bool), typeof (HamburgerItem), new PropertyMetadata(default(bool)));

        public bool IsSelected
        {
            get { return (bool) GetValue(IsSelectedProperty); }
            set { SetValue(IsSelectedProperty, value); }
        }

        public event EventHandler<HamburgerItemSelectedEventArgs> Selected;

        internal void RaiseSelected(Hamburger hamburger)
        {
            var copy = Selected;
            if (copy != null)
                copy(this, new HamburgerItemSelectedEventArgs(hamburger));
        }
    }
}