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

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Xceed.Wpf.DataGrid
{
  internal class MaxGroupLevelsChangedEventManager : WeakEventManager
  {
    private MaxGroupLevelsChangedEventManager()
    {
    }

    public static void AddListener( object source, IWeakEventListener listener )
    {
      CurrentManager.ProtectedAddListener( source, listener );
    }

    public static void RemoveListener( object source, IWeakEventListener listener )
    {
      CurrentManager.ProtectedRemoveListener( source, listener );
    }

    protected override void StartListening( object source )
    {
      DataGridControl dataGridControl = source as DataGridControl;
      if( dataGridControl != null )
      {
        dataGridControl.MaxGroupLevelsChanged += new EventHandler( this.OnMaxGroupLevelsChanged );
        return;
      }

      DetailConfiguration detailConfiguration = source as DetailConfiguration;
      if( detailConfiguration != null )
      {
        detailConfiguration.MaxGroupLevelsChanged += new EventHandler( this.OnMaxGroupLevelsChanged );
        return;
      }

      throw new ArgumentException( "The specified source must be a DataGridControl or a DetailConfiguration.", "source" );
    }

    protected override void StopListening( object source )
    {
      DataGridControl dataGridControl = source as DataGridControl;
      if( dataGridControl != null )
      {
        dataGridControl.MaxGroupLevelsChanged -= new EventHandler( this.OnMaxGroupLevelsChanged );
        return;
      }

      DetailConfiguration detailConfiguration = source as DetailConfiguration;
      if( detailConfiguration != null )
      {
        detailConfiguration.MaxGroupLevelsChanged -= new EventHandler( this.OnMaxGroupLevelsChanged );
        return;
      }

      throw new ArgumentException( "The specified source must be a DataGridControl or a DetailConfiguration.", "source" );
    }

    private static MaxGroupLevelsChangedEventManager CurrentManager
    {
      get
      {
        Type managerType = typeof( MaxGroupLevelsChangedEventManager );
        MaxGroupLevelsChangedEventManager currentManager = ( MaxGroupLevelsChangedEventManager )WeakEventManager.GetCurrentManager( managerType );

        if( currentManager == null )
        {
          currentManager = new MaxGroupLevelsChangedEventManager();
          WeakEventManager.SetCurrentManager( managerType, currentManager );
        }

        return currentManager;
      }
    }

    private void OnMaxGroupLevelsChanged( object sender, EventArgs args )
    {
      this.DeliverEvent( sender, args );
    }
  }
}