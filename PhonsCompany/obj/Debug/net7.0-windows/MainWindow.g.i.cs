﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ECEA42D21263FA85DFF7FDEBEEB9D47944935379"
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
using System.Windows.Controls.Ribbon;
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


namespace PhonsCompany {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FullNameFilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StreetFilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HomeFilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HomePhoneFilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WorkPhoneFilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MobilePhoneFilterTextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AbonentsDataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PhonsCompany;V1.0.0.0;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ExportCSVButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 13 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StreetsButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FullNameFilterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\MainWindow.xaml"
            this.FullNameFilterTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FilterTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.StreetFilterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\MainWindow.xaml"
            this.StreetFilterTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FilterTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.HomeFilterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.HomeFilterTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FilterTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.HomePhoneFilterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\MainWindow.xaml"
            this.HomePhoneFilterTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FilterTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.WorkPhoneFilterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\MainWindow.xaml"
            this.WorkPhoneFilterTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FilterTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.MobilePhoneFilterTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\MainWindow.xaml"
            this.MobilePhoneFilterTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FilterTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AbonentsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

