﻿#pragma checksum "..\..\VentanaAgregarIngesta.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2CBFF0F4944741EB710BA2F44F7684B62ACC6808BD1761002EC84BA4081DCE4D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Practica_final;
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


namespace Practica_final {
    
    
    /// <summary>
    /// VentanaAgregarIngesta
    /// </summary>
    public partial class VentanaAgregarIngesta : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\VentanaAgregarIngesta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker CajaFecha;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\VentanaAgregarIngesta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar Calendario;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\VentanaAgregarIngesta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CajaCaloriasDesayuno;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\VentanaAgregarIngesta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CajaCaloriasAperitivo;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\VentanaAgregarIngesta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CajaCaloriasComida;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\VentanaAgregarIngesta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CajaCaloriasMerienda;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\VentanaAgregarIngesta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CajaCaloriasCena;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\VentanaAgregarIngesta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CajaCaloriasOtros;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\VentanaAgregarIngesta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelarIngesta;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\VentanaAgregarIngesta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AceptarIngesta;
        
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
            System.Uri resourceLocater = new System.Uri("/Practica final;component/ventanaagregaringesta.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VentanaAgregarIngesta.xaml"
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
            this.CajaFecha = ((System.Windows.Controls.DatePicker)(target));
            
            #line 49 "..\..\VentanaAgregarIngesta.xaml"
            this.CajaFecha.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.CajaFecha_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Calendario = ((System.Windows.Controls.Calendar)(target));
            
            #line 50 "..\..\VentanaAgregarIngesta.xaml"
            this.Calendario.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Calendario_SelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CajaCaloriasDesayuno = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\VentanaAgregarIngesta.xaml"
            this.CajaCaloriasDesayuno.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.CajaCaloriasDesayuno_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 54 "..\..\VentanaAgregarIngesta.xaml"
            this.CajaCaloriasDesayuno.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.CajaCaloriasDesayuno_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CajaCaloriasAperitivo = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\VentanaAgregarIngesta.xaml"
            this.CajaCaloriasAperitivo.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.CajaCaloriasAperitivo_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 66 "..\..\VentanaAgregarIngesta.xaml"
            this.CajaCaloriasAperitivo.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.CajaCaloriasAperitivo_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CajaCaloriasComida = ((System.Windows.Controls.TextBox)(target));
            
            #line 78 "..\..\VentanaAgregarIngesta.xaml"
            this.CajaCaloriasComida.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.CajaCaloriasComida_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 78 "..\..\VentanaAgregarIngesta.xaml"
            this.CajaCaloriasComida.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.CajaCaloriasComida_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CajaCaloriasMerienda = ((System.Windows.Controls.TextBox)(target));
            
            #line 90 "..\..\VentanaAgregarIngesta.xaml"
            this.CajaCaloriasMerienda.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.CajaCaloriasMerienda_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 90 "..\..\VentanaAgregarIngesta.xaml"
            this.CajaCaloriasMerienda.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.CajaCaloriasMerienda_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.CajaCaloriasCena = ((System.Windows.Controls.TextBox)(target));
            
            #line 102 "..\..\VentanaAgregarIngesta.xaml"
            this.CajaCaloriasCena.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.CajaCaloriasCena_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 102 "..\..\VentanaAgregarIngesta.xaml"
            this.CajaCaloriasCena.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.CajaCaloriasCena_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CajaCaloriasOtros = ((System.Windows.Controls.TextBox)(target));
            
            #line 114 "..\..\VentanaAgregarIngesta.xaml"
            this.CajaCaloriasOtros.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.CajaCaloriasOtros_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 114 "..\..\VentanaAgregarIngesta.xaml"
            this.CajaCaloriasOtros.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.CajaCaloriasOtros_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CancelarIngesta = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\VentanaAgregarIngesta.xaml"
            this.CancelarIngesta.Click += new System.Windows.RoutedEventHandler(this.CancelarIngesta_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AceptarIngesta = ((System.Windows.Controls.Button)(target));
            
            #line 134 "..\..\VentanaAgregarIngesta.xaml"
            this.AceptarIngesta.Click += new System.Windows.RoutedEventHandler(this.AceptarIngesta_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

