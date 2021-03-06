// Copyright 2012 ESRI
// 
// All rights reserved under the copyright laws of the United States
// and applicable international laws, treaties, and conventions.
// 
// You may freely redistribute and use this sample code, with or
// without modification, provided you include the original copyright
// notice and use restrictions.
// 
// See the use restrictions at <your ArcGIS install location>/DeveloperKit10.1/userestrictions.txt.
// 

using System;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using System.Runtime.InteropServices;

namespace GIS.MapPrint
{
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("5175B831-F18E-4cff-A016-146A7923681D")]
    [ProgId("GIS.MapPrint.CreateNorthArrow")]
	public sealed class CreateNorthArrow : BaseTool
	{
		private IHookHelper m_HookHelper; 
		private INewEnvelopeFeedback m_Feedback;
		private IPoint m_Point; 
		private bool m_InUse;

		//Windows API functions to capture mouse and keyboard
		//input to a window when the mouse is outside the window
		[DllImport("User32", CharSet=CharSet.Auto)]
		private static extern int SetCapture(int hWnd);
		[DllImport("User32", CharSet=CharSet.Auto)]
		private static extern int GetCapture();
		[DllImport("User32", CharSet=CharSet.Auto)]
		private static extern int ReleaseCapture();

		#region Component Category Registration
		[ComRegisterFunction()]
		[ComVisible(false)]
		static void RegisterFunction(String sKey)
		{
			ControlsCommands.Register(sKey);
		}
		[ComUnregisterFunction()]
		[ComVisible(false)]
		static void UnregisterFunction(String sKey)
		{
	 		ControlsCommands.Unregister(sKey);
		}
		#endregion

		public CreateNorthArrow()
		{
			//Create an IHookHelper object
			m_HookHelper = new HookHelperClass();

			//Set the tool properties
            base.m_bitmap = GIS.Properties.Resources.NorthArrow16;
			base.m_caption = "添加指北针";
            base.m_category = "MapPrint";
			base.m_message = "通过地图上画框，添加指标针";
            base.m_name = "MapPrint_CreateNorthArrow";
			base.m_toolTip = "添加指北针";
			base.m_deactivate = true;
		}
	
		public override void OnCreate(object hook)
		{
			m_HookHelper.Hook = hook;
            
		}
	
		public override void OnMouseDown(int Button, int Shift, int X, int Y)
		{
			//Create a point in map coordinates

			m_Point = m_HookHelper.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(X, Y);

			//Start capturing mouse events
			SetCapture(m_HookHelper.ActiveView.ScreenDisplay.hWnd);

			m_InUse = true;		
		}
	
		public override void OnMouseMove(int Button, int Shift, int X, int Y)
		{
			if (m_InUse == false) return;

			//Start an envelope feedback
			if (m_Feedback == null )
			{
				m_Feedback = new NewEnvelopeFeedbackClass();
				m_Feedback.Display = m_HookHelper.ActiveView.ScreenDisplay;
				m_Feedback.Start(m_Point);
			}

			//Move the envelope feedback
			m_Feedback.MoveTo(m_HookHelper.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(X, Y));
		}
	
		public override void OnMouseUp(int Button, int Shift, int X, int Y)
		{
			if (m_InUse == false) return;

			//Stop capturing mouse events
			if (GetCapture() == m_HookHelper.ActiveView.ScreenDisplay.hWnd)
				ReleaseCapture();

			//If an envelope has not been tracked or its height/width is 0
			if (m_Feedback == null)
			{
				m_Feedback = null;
				m_InUse = false;
				return;
			}
			IEnvelope envelope = m_Feedback.Stop();
			if ((envelope.IsEmpty) || (envelope.Width == 0) || (envelope.Height == 0))
			{
				m_Feedback = null;
				m_InUse = false;
				return;
			}

			//Create the form with the SymbologyControl
			SymbolForm symbolForm = new SymbolForm();
			//Get the IStyleGalleryItem
			IStyleGalleryItem styleGalleryItem = symbolForm.GetItem(esriSymbologyStyleClass.esriStyleClassNorthArrows);
			//Release the form
			symbolForm.Dispose();
			if (styleGalleryItem == null) return;

            Common.MapPrintCommon.GraphicsContainClearSelection();
			//Get the map frame of the focus map
			IMapFrame mapFrame = (IMapFrame) m_HookHelper.ActiveView.GraphicsContainer.FindFrame(m_HookHelper.ActiveView.FocusMap);

			//Create a map surround frame
			IMapSurroundFrame mapSurroundFrame = new MapSurroundFrameClass(); 
			//Set its map frame and map surround
			mapSurroundFrame.MapFrame = mapFrame;
			mapSurroundFrame.MapSurround = (IMapSurround) styleGalleryItem.Item;

			//QI to IElement and set its geometry
			IElement element = (IElement) mapSurroundFrame;
			element.Geometry = envelope;

			//Add the element to the graphics container
			m_HookHelper.ActiveView.GraphicsContainer.AddElement((IElement)mapSurroundFrame, 0);
			//Refresh
			m_HookHelper.ActiveView.PartialRefresh(esriViewDrawPhase.esriViewGraphics, mapSurroundFrame, null);

			m_Feedback = null;
			m_InUse = false;
            Common.MapPrintCommon.g_axPageLayoutControl.CurrentTool = Common.MapPrintCommon.SetControlsSelectCommand();

		}
	}
}
