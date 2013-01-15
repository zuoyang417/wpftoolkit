﻿/************************************************************************

   Extended WPF Toolkit

   Copyright (C) 2010-2012 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   This program can be provided to you by Xceed Software Inc. under a
   proprietary commercial license agreement for use in non-Open Source
   projects. The commercial version of Extended WPF Toolkit also includes
   priority technical support, commercial updates, and many additional 
   useful WPF controls if you license Xceed Business Suite for WPF.

   Visit http://xceed.com and follow @datagrid on Twitter.

  **********************************************************************/

#region Using directives

using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;
using System.Windows.Markup;

#endregion

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle( "Xceed Extended WPF Toolkit - DataGrid" )]
[assembly: AssemblyDescription( "This assembly implements the Xceed.Wpf.DataGrid namespace, a data grid control for the Windows Presentation Framework." )]

[assembly: AssemblyCompany( "Xceed Software Inc." )]
[assembly: AssemblyProduct( "Xceed Extended WPF Toolkit - DataGrid" )]
[assembly: AssemblyCopyright( "Copyright � Xceed Software Inc. 2010-2012" )]


[assembly: CLSCompliant( true )]
[assembly: ComVisible( false )]

[assembly: XmlnsPrefix( "http://schemas.xceed.com/wpf/xaml/datagrid", "xcdg" )]
[assembly: XmlnsDefinition( "http://schemas.xceed.com/wpf/xaml/datagrid", "Xceed.Wpf.DataGrid")]
[assembly: XmlnsDefinition( "http://schemas.xceed.com/wpf/xaml/datagrid", "Xceed.Wpf.DataGrid.Converters")]
[assembly: XmlnsDefinition( "http://schemas.xceed.com/wpf/xaml/datagrid", "Xceed.Wpf.DataGrid.Markup")]
[assembly: XmlnsDefinition( "http://schemas.xceed.com/wpf/xaml/datagrid", "Xceed.Wpf.DataGrid.Views")]
[assembly: XmlnsDefinition( "http://schemas.xceed.com/wpf/xaml/datagrid", "Xceed.Wpf.DataGrid.Automation")]
[assembly: XmlnsDefinition( "http://schemas.xceed.com/wpf/xaml/datagrid", "Xceed.Wpf.DataGrid.ValidationRules")]
[assembly: XmlnsDefinition( "http://schemas.xceed.com/wpf/xaml/datagrid", "Xceed.Wpf.DataGrid.FilterCriteria")]


[assembly: SecurityRules( SecurityRuleSet.Level1 )]
[assembly: AllowPartiallyTrustedCallers]

//In order to begin building localizable applications, set 
//<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
//inside a <PropertyGroup>.  For example, if you are using US english
//in your source files, set the <UICulture> to en-US.  Then uncomment
//the NeutralResourceLanguage attribute below.  Update the "en-US" in
//the line below to match the UICulture setting in the project file.

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]

[assembly: ThemeInfo(
    ResourceDictionaryLocation.SourceAssembly, //where theme specific resource dictionaries are located
  //(used if a resource is not found in the page, 
  // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
  //(used if a resource is not found in the page, 
  // app, or any theme specific resource dictionaries)
)]

#pragma warning disable 1699
[assembly: AssemblyDelaySign( false )]
[assembly: AssemblyKeyFile( @"sn.snk" )]
[assembly: AssemblyKeyName( "" )]
#pragma warning restore 1699