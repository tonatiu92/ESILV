﻿#pragma checksum "..\..\GestionCommis.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B839EC6165E189E1DB030B5D575F457FB56A8F83BBD592428E51831209529884"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Probleme_TDJ_Osorio_Thomas;
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


namespace Probleme_TDJ_Osorio_Thomas {
    
    
    /// <summary>
    /// GestionCommis
    /// </summary>
    public partial class GestionCommis : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\GestionCommis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListCommis;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\GestionCommis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nom;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\GestionCommis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Prenom;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\GestionCommis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Num;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\GestionCommis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Telephone;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\GestionCommis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Rue;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\GestionCommis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CodePostale;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\GestionCommis.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Ville;
        
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
            System.Uri resourceLocater = new System.Uri("/Probleme_TDJ_Osorio_Thomas;component/gestioncommis.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GestionCommis.xaml"
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
            this.ListCommis = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.Nom = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\GestionCommis.xaml"
            this.Nom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Nom_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Prenom = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\GestionCommis.xaml"
            this.Prenom.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Prenom_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Num = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\GestionCommis.xaml"
            this.Num.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NumRue_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Telephone = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\GestionCommis.xaml"
            this.Telephone.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Numero_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 34 "..\..\GestionCommis.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Ajouter);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 35 "..\..\GestionCommis.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Rechercher);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 36 "..\..\GestionCommis.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Supprimer);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 38 "..\..\GestionCommis.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Tri_Nom);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 39 "..\..\GestionCommis.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Tri_Ville);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Rue = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\GestionCommis.xaml"
            this.Rue.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Rue_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.CodePostale = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\GestionCommis.xaml"
            this.CodePostale.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.CodePostale_TextChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Ville = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\GestionCommis.xaml"
            this.Ville.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Ville_TextChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 43 "..\..\GestionCommis.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Tri_NbCommandes);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 44 "..\..\GestionCommis.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Modifier_Commis);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 45 "..\..\GestionCommis.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Conge);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

