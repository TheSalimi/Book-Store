﻿#pragma checksum "..\..\AdminPannel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75DFF69099645A57A0EE44A0B29FFA5D0F928690"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\AdminPannel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchUserBtn;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\AdminPannel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BookNameSearch;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\AdminPannel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox authornamee;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\AdminPannel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameofbook;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\AdminPannel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FundBtn;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\AdminPannel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GetMoneyBtn;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\AdminPannel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid VIPSET;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\AdminPannel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MonthlyFee;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\AdminPannel.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SumbitmonthlyFee;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/adminpannel.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminPannel.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 20 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddBook);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 23 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteBook);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 26 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 29 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Status);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 31 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 32 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToLoginPage);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 42 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowListOfNormalMembers);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 52 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowListOfVIPmembers);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SearchUserBtn = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\AdminPannel.xaml"
            this.SearchUserBtn.Click += new System.Windows.RoutedEventHandler(this.EmailSearchedButton);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 59 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowBooksList);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 61 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchBookByAuthorName);
            
            #line default
            #line hidden
            return;
            case 12:
            this.BookNameSearch = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\AdminPannel.xaml"
            this.BookNameSearch.Click += new System.Windows.RoutedEventHandler(this.SearchBookByBookName);
            
            #line default
            #line hidden
            return;
            case 13:
            this.authornamee = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.nameofbook = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            
            #line 66 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 67 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToLoginPage);
            
            #line default
            #line hidden
            return;
            case 17:
            this.FundBtn = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\AdminPannel.xaml"
            this.FundBtn.Click += new System.Windows.RoutedEventHandler(this.FundBtn_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.GetMoneyBtn = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\AdminPannel.xaml"
            this.GetMoneyBtn.Click += new System.Windows.RoutedEventHandler(this.GetMoneyBtn_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 83 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SetVIPprice);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 87 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 88 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToLoginPage);
            
            #line default
            #line hidden
            return;
            case 22:
            this.VIPSET = ((System.Windows.Controls.Grid)(target));
            return;
            case 23:
            this.MonthlyFee = ((System.Windows.Controls.TextBox)(target));
            return;
            case 24:
            this.SumbitmonthlyFee = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\AdminPannel.xaml"
            this.SumbitmonthlyFee.Click += new System.Windows.RoutedEventHandler(this.SumbitmonthlyFee_Click);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 100 "..\..\AdminPannel.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackToAdminPannel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

