﻿#pragma checksum "..\..\MENU_EMPLOYEE.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CF6EC6D5CDBFF2A39B0B9EAD593A9FBF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using PL_UI2;
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


namespace PL_UI2 {
    
    
    /// <summary>
    /// MENU_EMPLOYEE
    /// </summary>
    public partial class MENU_EMPLOYEE : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\MENU_EMPLOYEE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Employee_b;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MENU_EMPLOYEE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Copy;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MENU_EMPLOYEE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button1_Copy5;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MENU_EMPLOYEE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butto_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/PL_UI2-5;component/menu_employee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MENU_EMPLOYEE.xaml"
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
            this.Employee_b = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\MENU_EMPLOYEE.xaml"
            this.Employee_b.Click += new System.Windows.RoutedEventHandler(this.Employee_b_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.button_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\MENU_EMPLOYEE.xaml"
            this.button_Copy.Click += new System.Windows.RoutedEventHandler(this.button_Copy_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.button1_Copy5 = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\MENU_EMPLOYEE.xaml"
            this.button1_Copy5.Click += new System.Windows.RoutedEventHandler(this.button1_Copy5_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.butto_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\MENU_EMPLOYEE.xaml"
            this.butto_Copy.Click += new System.Windows.RoutedEventHandler(this.butto_Copy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
