﻿#pragma checksum "..\..\AddDeleteConcert.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6A9F4DFA3F7A43FE98F4DB462A7D0012F98073CCCBEF0019B788C3D09BBB3041"
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
using Vangeneugden_Robin_DMP_Project_WPF;


namespace Vangeneugden_Robin_DMP_Project_WPF {
    
    
    /// <summary>
    /// AddDeleteConcert
    /// </summary>
    public partial class AddDeleteConcert : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\AddDeleteConcert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblBandlid;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AddDeleteConcert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblConcert;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AddDeleteConcert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddDeleteConcert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddDeleteConcert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbBandlid;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AddDeleteConcert.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbConcert;
        
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
            System.Uri resourceLocater = new System.Uri("/Vangeneugden_Robin_DMP_Project_WPF;component/adddeleteconcert.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddDeleteConcert.xaml"
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
            
            #line 9 "..\..\AddDeleteConcert.xaml"
            ((Vangeneugden_Robin_DMP_Project_WPF.AddDeleteConcert)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblBandlid = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblConcert = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\AddDeleteConcert.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\AddDeleteConcert.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbBandlid = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.lbConcert = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

