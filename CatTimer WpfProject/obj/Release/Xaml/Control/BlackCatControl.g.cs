﻿#pragma checksum "..\..\..\..\Xaml\Control\BlackCatControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B720753E7AA7FB2D6EE88C098A917BBFBC9C0447"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CatTimer_WpfProject;
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


namespace CatTimer_WpfProject {
    
    
    /// <summary>
    /// BlackCatControl
    /// </summary>
    public partial class BlackCatControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 82 "..\..\..\..\Xaml\Control\BlackCatControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard BeginRopeGridStoryboard;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\..\Xaml\Control\BlackCatControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid CatGrid;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\Xaml\Control\BlackCatControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal CatTimer_WpfProject.ButtonControl CatButtonControl;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\Xaml\Control\BlackCatControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid RopeGrid;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\Xaml\Control\BlackCatControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PressCatButtonGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/CatTimer WpfProject;component/xaml/control/blackcatcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Xaml\Control\BlackCatControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.BeginRopeGridStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 2:
            this.CatGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 108 "..\..\..\..\Xaml\Control\BlackCatControl.xaml"
            this.CatGrid.MouseEnter += new System.Windows.Input.MouseEventHandler(this.CatGrid_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 109 "..\..\..\..\Xaml\Control\BlackCatControl.xaml"
            this.CatGrid.MouseLeave += new System.Windows.Input.MouseEventHandler(this.CatGrid_OnMouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CatButtonControl = ((CatTimer_WpfProject.ButtonControl)(target));
            return;
            case 4:
            this.RopeGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.PressCatButtonGrid = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

