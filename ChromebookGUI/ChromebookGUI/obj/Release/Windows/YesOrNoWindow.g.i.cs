﻿#pragma checksum "..\..\..\Windows\YesOrNoWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A406DF9725A54BB93B57AF4A88C31641F3C9F57D12E68412CD8AE1FEA97FE01D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ChromebookGUI;
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


namespace ChromebookGUI.Windows {
    
    
    /// <summary>
    /// YesOrNoWindow
    /// </summary>
    public partial class YesOrNoWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Windows\YesOrNoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock instructionTextBlock;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Windows\YesOrNoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InfoBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Windows\YesOrNoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button yesButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Windows\YesOrNoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button noButton;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Windows\YesOrNoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExtraButton;
        
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
            System.Uri resourceLocater = new System.Uri("/ChromebookGUI;component/windows/yesornowindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\YesOrNoWindow.xaml"
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
            
            #line 9 "..\..\..\Windows\YesOrNoWindow.xaml"
            ((ChromebookGUI.Windows.YesOrNoWindow)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.instructionTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.InfoBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.yesButton = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Windows\YesOrNoWindow.xaml"
            this.yesButton.Click += new System.Windows.RoutedEventHandler(this.YesButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.noButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Windows\YesOrNoWindow.xaml"
            this.noButton.Click += new System.Windows.RoutedEventHandler(this.NoButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ExtraButton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Windows\YesOrNoWindow.xaml"
            this.ExtraButton.Click += new System.Windows.RoutedEventHandler(this.ExtraButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
