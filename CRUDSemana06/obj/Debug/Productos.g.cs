﻿#pragma checksum "..\..\Productos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "502529F0222F1A2C9072285205078860BDAAEB1FEBE2DCFFDDF65ED3A0882B8F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using CRUDSemana06;
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


namespace CRUDSemana06 {
    
    
    /// <summary>
    /// Productos
    /// </summary>
    public partial class Productos : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConsultar;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNuevo;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCategorias;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Productos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvProducto;
        
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
            System.Uri resourceLocater = new System.Uri("/CRUDSemana06;component/productos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Productos.xaml"
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
            this.btnConsultar = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Productos.xaml"
            this.btnConsultar.Click += new System.Windows.RoutedEventHandler(this.BtnConsultar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnNuevo = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Productos.xaml"
            this.btnNuevo.Click += new System.Windows.RoutedEventHandler(this.BtnNuevo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCategorias = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Productos.xaml"
            this.btnCategorias.Click += new System.Windows.RoutedEventHandler(this.BtnCategorias_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgvProducto = ((System.Windows.Controls.DataGrid)(target));
            
            #line 30 "..\..\Productos.xaml"
            this.dgvProducto.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DgvProducto_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

