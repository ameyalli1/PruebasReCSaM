﻿#pragma checksum "..\..\MenuAmbu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B0DD63856CBC5C8C1ACF65705CAC52097A05E811"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using Proyectos.Mesero.GUI;
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


namespace Proyectos.Mesero.GUI {
    
    
    /// <summary>
    /// MenuAmbu
    /// </summary>
    public partial class MenuAmbu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\MenuAmbu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonPopup;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\MenuAmbu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Menu;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\MenuAmbu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CerrarMenu;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MenuAmbu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AbrirMenu;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\MenuAmbu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUsuario;
        
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
            System.Uri resourceLocater = new System.Uri("/Proyectos.Mesero.GUI;component/menuambu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MenuAmbu.xaml"
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
            this.ButtonPopup = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\MenuAmbu.xaml"
            this.ButtonPopup.Click += new System.Windows.RoutedEventHandler(this.ButtonPopup_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Menu = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.CerrarMenu = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\MenuAmbu.xaml"
            this.CerrarMenu.Click += new System.Windows.RoutedEventHandler(this.CerrarMenu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AbrirMenu = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\MenuAmbu.xaml"
            this.AbrirMenu.Click += new System.Windows.RoutedEventHandler(this.AbrirMenu_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnUsuario = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\MenuAmbu.xaml"
            this.btnUsuario.Click += new System.Windows.RoutedEventHandler(this.btnUsuario_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
