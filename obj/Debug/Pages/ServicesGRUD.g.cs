﻿#pragma checksum "..\..\..\Pages\ServicesGRUD.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A0FF5C80FA93D765663C23C10DB047523C15CF8CA0CBD86672CB464D5DCB2373"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfBeauty.Pages;


namespace WpfBeauty.Pages {
    
    
    /// <summary>
    /// ServicesGRUD
    /// </summary>
    public partial class ServicesGRUD : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 82 "..\..\..\Pages\ServicesGRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBSortBy;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Pages\ServicesGRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBFilter;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Pages\ServicesGRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSearch;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Pages\ServicesGRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ServicesGrid;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Pages\ServicesGRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBCountServices;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\Pages\ServicesGRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid AdminPanel;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\Pages\ServicesGRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddService;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\Pages\ServicesGRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSignUpClient;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\Pages\ServicesGRUD.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUpcoming;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfBeauty;component/pages/servicesgrud.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ServicesGRUD.xaml"
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
            case 3:
            this.CBSortBy = ((System.Windows.Controls.ComboBox)(target));
            
            #line 82 "..\..\..\Pages\ServicesGRUD.xaml"
            this.CBSortBy.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBSortBy_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CBFilter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 88 "..\..\..\Pages\ServicesGRUD.xaml"
            this.CBFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBFilter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TBSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 98 "..\..\..\Pages\ServicesGRUD.xaml"
            this.TBSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ServicesGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.TBCountServices = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.AdminPanel = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.BtnAddService = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\..\Pages\ServicesGRUD.xaml"
            this.BtnAddService.Click += new System.Windows.RoutedEventHandler(this.BtnAddService_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnSignUpClient = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\..\Pages\ServicesGRUD.xaml"
            this.BtnSignUpClient.Click += new System.Windows.RoutedEventHandler(this.BtnSignUpClient_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BtnUpcoming = ((System.Windows.Controls.Button)(target));
            
            #line 119 "..\..\..\Pages\ServicesGRUD.xaml"
            this.BtnUpcoming.Click += new System.Windows.RoutedEventHandler(this.BtnUpcoming_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 60 "..\..\..\Pages\ServicesGRUD.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEdit_Click);
            
            #line default
            #line hidden
            break;
            case 2:
            
            #line 61 "..\..\..\Pages\ServicesGRUD.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

