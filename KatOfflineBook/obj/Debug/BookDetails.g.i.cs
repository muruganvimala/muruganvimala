﻿#pragma checksum "..\..\BookDetails.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AEF0A840B9DEBD8FAE38A9A54D515A0100DC5129"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Pro1;
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


namespace Pro1 {
    
    
    /// <summary>
    /// BookDetails
    /// </summary>
    public partial class BookDetails : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\BookDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid topgrid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\BookDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimizebtn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\BookDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closebtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\BookDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid usergrid;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\BookDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label namelbl;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\BookDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid userDetail;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\BookDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label welcomelbl;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\BookDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label userlbl;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\BookDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel bookdetailspanel;
        
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
            System.Uri resourceLocater = new System.Uri("/Pro1;component/bookdetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BookDetails.xaml"
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
            
            #line 8 "..\..\BookDetails.xaml"
            ((Pro1.BookDetails)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            
            #line 8 "..\..\BookDetails.xaml"
            ((Pro1.BookDetails)(target)).Initialized += new System.EventHandler(this.Window_Initialized);
            
            #line default
            #line hidden
            
            #line 8 "..\..\BookDetails.xaml"
            ((Pro1.BookDetails)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 9 "..\..\BookDetails.xaml"
            ((System.Windows.Controls.Grid)(target)).Initialized += new System.EventHandler(this.Grid_Initialized);
            
            #line default
            #line hidden
            return;
            case 3:
            this.topgrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.minimizebtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\BookDetails.xaml"
            this.minimizebtn.Click += new System.Windows.RoutedEventHandler(this.minimizebtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.closebtn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\BookDetails.xaml"
            this.closebtn.Click += new System.Windows.RoutedEventHandler(this.closebtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.usergrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.namelbl = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.userDetail = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.welcomelbl = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.userlbl = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.bookdetailspanel = ((System.Windows.Controls.WrapPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

