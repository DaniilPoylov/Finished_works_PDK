﻿#pragma checksum "..\..\ClientProductWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2582703078825CB24ED6F8395EBCF707CC02799BF78C1004154C446A76C11510"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FabricsApplication;
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


namespace FabricsApplication {
    
    
    /// <summary>
    /// ClientProductWindow
    /// </summary>
    public partial class ClientProductWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\ClientProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Hello_textBlock;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ClientProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Find_textBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\ClientProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Sort_comboBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ClientProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Filtr_comboBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\ClientProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ElementsCount_textBlock;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\ClientProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProductList;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\ClientProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Out_button;
        
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
            System.Uri resourceLocater = new System.Uri("/FabricsApplication;component/clientproductwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ClientProductWindow.xaml"
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
            this.Hello_textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Find_textBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\ClientProductWindow.xaml"
            this.Find_textBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Find_textBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Sort_comboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\ClientProductWindow.xaml"
            this.Sort_comboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Sort_comboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Filtr_comboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 53 "..\..\ClientProductWindow.xaml"
            this.Filtr_comboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Filtr_comboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ElementsCount_textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ProductList = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.Out_button = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\ClientProductWindow.xaml"
            this.Out_button.Click += new System.Windows.RoutedEventHandler(this.Out_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

