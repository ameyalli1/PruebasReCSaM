﻿#pragma checksum "..\..\ERFrecuenciaServicios.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BFE49EE5AD659F9DB2473FD0425193FD9EFB38ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// ERFrecuenciaServicios
    /// </summary>
    public partial class ERFrecuenciaServicios : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\ERFrecuenciaServicios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreEmpleado;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\ERFrecuenciaServicios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreEmpresa;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ERFrecuenciaServicios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radPrimera;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ERFrecuenciaServicios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radSegunda;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ERFrecuenciaServicios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radTercera;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ERFrecuenciaServicios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radCuarta;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ERFrecuenciaServicios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSiguiente;
        
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
            System.Uri resourceLocater = new System.Uri("/Proyectos.Mesero.GUI;component/erfrecuenciaservicios.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ERFrecuenciaServicios.xaml"
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
            this.txtNombreEmpleado = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtNombreEmpresa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.radPrimera = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.radSegunda = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.radTercera = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.radCuarta = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.btnSiguiente = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\ERFrecuenciaServicios.xaml"
            this.btnSiguiente.Click += new System.Windows.RoutedEventHandler(this.btnSiguiente_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

