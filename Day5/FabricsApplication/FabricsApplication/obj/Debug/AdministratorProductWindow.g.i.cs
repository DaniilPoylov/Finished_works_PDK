﻿#pragma checksum "..\..\AdministratorProductWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EB6413E92C0E27B7BD64D11D66E8A83052958E14B8AC4526DF3036E788427BA0"
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
    /// AdministratorProductWindow
    /// </summary>
    public partial class AdministratorProductWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\AdministratorProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Hello_textBlock;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AdministratorProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Find_textBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\AdministratorProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Sort_comboBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\AdministratorProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Filtr_comboBox;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\AdministratorProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ElementsCount_textBlock;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\AdministratorProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProductList;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\AdministratorProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddRecord_button;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\AdministratorProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditRecord_button;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\AdministratorProductWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelRecord_button;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\AdministratorProductWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/FabricsApplication;component/administratorproductwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdministratorProductWindow.xaml"
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
            
            #line 49 "..\..\AdministratorProductWindow.xaml"
            this.Find_textBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Find_textBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Sort_comboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 50 "..\..\AdministratorProductWindow.xaml"
            this.Sort_comboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Sort_comboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Filtr_comboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\AdministratorProductWindow.xaml"
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
            this.AddRecord_button = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\AdministratorProductWindow.xaml"
            this.AddRecord_button.Click += new System.Windows.RoutedEventHandler(this.AddRecord_button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.EditRecord_button = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\AdministratorProductWindow.xaml"
            this.EditRecord_button.Click += new System.Windows.RoutedEventHandler(this.EditRecord_button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DelRecord_button = ((System.Windows.Controls.Button)(target));
            
            #line 106 "..\..\AdministratorProductWindow.xaml"
            this.DelRecord_button.Click += new System.Windows.RoutedEventHandler(this.DelRecord_button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Out_button = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\AdministratorProductWindow.xaml"
            this.Out_button.Click += new System.Windows.RoutedEventHandler(this.Out_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

