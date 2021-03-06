﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrossCutting.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Exceptions {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Exceptions() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CrossCutting.Resources.Exceptions", typeof(Exceptions).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El libro {0} no está displonible ahora mismo.
        /// </summary>
        public static string BookNotAvailable {
            get {
                return ResourceManager.GetString("BookNotAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No se ha encontrado el libro, introdúzcalo de nuevo.
        /// </summary>
        public static string BookNotFoundException {
            get {
                return ResourceManager.GetString("BookNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fecha no válida, introdúzcala de nuevo.
        /// </summary>
        public static string DateException {
            get {
                return ResourceManager.GetString("DateException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El título está vacio, por introduzcalo de nuevo.
        /// </summary>
        public static string EmptyTitleException {
            get {
                return ResourceManager.GetString("EmptyTitleException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to El nombre del usuario está vacio, por introdúzcalo de nuevo.
        /// </summary>
        public static string EmptyUsernameException {
            get {
                return ResourceManager.GetString("EmptyUsernameException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Idioma no valido, por introduzcalo de nuevo.
        /// </summary>
        public static string LanguageException {
            get {
                return ResourceManager.GetString("LanguageException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Letra no reconocida, por favor escriba R, P, D o S.
        /// </summary>
        public static string LetterAskException {
            get {
                return ResourceManager.GetString("LetterAskException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Letra no reconocida, por favor escriba S o N.
        /// </summary>
        public static string LetterAskYesNoException {
            get {
                return ResourceManager.GetString("LetterAskYesNoException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tiene tres o más libros alquilados, para realizar un préstamo devuelva antes algún libro.
        /// </summary>
        public static string MaxBookLentException {
            get {
                return ResourceManager.GetString("MaxBookLentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No hay ningún libro registrado, introdúzcalos primero.
        /// </summary>
        public static string NotBookRegistered {
            get {
                return ResourceManager.GetString("NotBookRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No tienes ese libro prestado, por favor introdúzcalo de nuevo.
        /// </summary>
        public static string NotLentBookException {
            get {
                return ResourceManager.GetString("NotLentBookException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No puede alquilar libros ya que tienes multas pendientes por pagar. ¿Desea pagar ahora? (S)i o (N)o.
        /// </summary>
        public static string PaidFineException {
            get {
                return ResourceManager.GetString("PaidFineException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to La fecha de devolución es anterior a la del préstamo, introdúzcala de nuevo.
        /// </summary>
        public static string ReturnLoanDateException {
            get {
                return ResourceManager.GetString("ReturnLoanDateException", resourceCulture);
            }
        }
    }
}
