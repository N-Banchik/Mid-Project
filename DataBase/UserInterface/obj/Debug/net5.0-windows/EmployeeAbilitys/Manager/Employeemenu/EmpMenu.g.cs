﻿#pragma checksum "..\..\..\..\..\..\EmployeeAbilitys\Manager\Employeemenu\EmpMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CF79774F88E2AFA848D9E17FA4E37094A601A707"
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
using UserInterface.EmployeeAbilitys.Manager.Employeemenu;


namespace UserInterface.EmployeeAbilitys.Manager.Employeemenu {
    
    
    /// <summary>
    /// EmpMenu
    /// </summary>
    public partial class EmpMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 10 "..\..\..\..\..\..\EmployeeAbilitys\Manager\Employeemenu\EmpMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid UserShow;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\..\EmployeeAbilitys\Manager\Employeemenu\EmpMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowUers;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\..\..\EmployeeAbilitys\Manager\Employeemenu\EmpMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IDBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\..\EmployeeAbilitys\Manager\Employeemenu\EmpMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\..\EmployeeAbilitys\Manager\Employeemenu\EmpMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Phonebox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\..\..\EmployeeAbilitys\Manager\Employeemenu\EmpMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\..\EmployeeAbilitys\Manager\Employeemenu\EmpMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewEmp;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/UserInterface;component/employeeabilitys/manager/employeemenu/empmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\EmployeeAbilitys\Manager\Employeemenu\EmpMenu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserShow = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.ShowUers = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\..\..\EmployeeAbilitys\Manager\Employeemenu\EmpMenu.xaml"
            this.ShowUers.Click += new System.Windows.RoutedEventHandler(this.ShowUers_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.IDBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.NameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Phonebox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.EmailBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.NewEmp = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\..\..\EmployeeAbilitys\Manager\Employeemenu\EmpMenu.xaml"
            this.NewEmp.Click += new System.Windows.RoutedEventHandler(this.NewEmp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 30 "..\..\..\..\..\..\EmployeeAbilitys\Manager\Employeemenu\EmpMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EmpOrders_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

