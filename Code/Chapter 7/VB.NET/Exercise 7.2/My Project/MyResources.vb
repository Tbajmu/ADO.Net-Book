﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.IO
Imports System.Resources

Namespace My.Resources
    
    '<summary>
    '   A strongly-typed resource class, for looking up localized strings, etc.
    '</summary>
    'This class was auto-generated by the Strongly Typed Resource Builder
    'class via a tool like ResGen or Visual Studio.NET.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    <Microsoft.VisualBasic.HideModuleName()>  _
    Module MyResources
        
        Private _resMgr As System.Resources.ResourceManager
        
        Private _resCulture As System.Globalization.CultureInfo
        
        '<summary>
        '   Returns the cached ResourceManager instance used by this class.
        '</summary>
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public ReadOnly Property ResourceManager() As System.Resources.ResourceManager
            Get
                If (_resMgr Is Nothing) Then
                    Dim temp As System.Resources.ResourceManager = New System.Resources.ResourceManager("Exercise_7_2.MyResources", GetType(MyResources).Assembly)
                    System.Threading.Thread.MemoryBarrier
                    _resMgr = temp
                End If
                Return _resMgr
            End Get
        End Property
        
        '<summary>
        '   Overrides the current thread's CurrentUICulture property for all
        '   resource lookups using this strongly typed resource class.
        '</summary>
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Property Culture() As System.Globalization.CultureInfo
            Get
                Return _resCulture
            End Get
            Set
                _resCulture = value
            End Set
        End Property
    End Module
End Namespace
