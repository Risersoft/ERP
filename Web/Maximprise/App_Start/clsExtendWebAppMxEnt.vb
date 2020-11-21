Imports risersoft.app.mxengg
Imports risersoft.app.mxform
Imports risersoft.shared
Imports risersoft.shared.cloud
Imports risersoft.shared.portable.Models.Nav
Imports risersoft.shared.web
Imports risersoft.UnitCAD.provider.acadio
Imports risersoft.app.reports
Imports risersoft.shared.web.mvc
Imports risersoft.app.mxform.gst
Imports risersoft.shared.dotnetfx
Imports risersoft.app.mxform.hrm

Public Class clsExtendWebAppMxEnt
    Inherits clsExtendWebAppBase


    Public Overrides Function NewDBName() As String
        Return "mxentdb"
    End Function


    Public Overrides Function ProgramCode() As String
        Return "mxent"
    End Function

    Public Overrides Function ProgramName() As String
        Return "EtomPlan"

    End Function

    Public Overrides Function StartupAppCode() As String
        Return ""
    End Function
    Public Overrides Function dicFormModelTypes() As clsCollecString(Of Type)
        If dicFormModel Is Nothing Then
            dicFormModel = New clsCollecString(Of Type)
            Me.AddTypeAssembly(dicFormModel, GetType(frmGenPersonModel).Assembly, GetType(clsFormDataModel))
        End If
        Return dicFormModel
    End Function

    Public Overrides Function dicReportProviderTypes(myContext As clsAppController) As clsCollecString(Of Type)
        If dicReportModelProvider Is Nothing Then
            dicReportModelProvider = New clsCollecString(Of Type)
            Me.AddTypeAssembly(dicReportModelProvider, GetType(erp.accReportDataProvider).Assembly, GetType(clsReportDataProviderBase))
        End If
        Return dicReportModelProvider

    End Function

    Public Overrides Function dicTaskProviderTypes() As clsCollecString(Of Type)
        If dicTaskProvider Is Nothing Then
            dicTaskProvider = New clsCollecString(Of Type)
            Me.AddTypeAssembly(dicTaskProvider, GetType(EVTaskProvider).Assembly, GetType(clsTaskProviderBase))
            Me.AddTypeAssembly(dicTaskProvider, GetType(GSTR1TaskProvider).Assembly, GetType(clsTaskProviderBase))
            Me.AddTypeAssembly(dicTaskProvider, GetType(BFTaskProvider).Assembly, GetType(clsTaskProviderBase))
            Me.AddTypeAssembly(dicTaskProvider, GetType(BMTaskProvider).Assembly, GetType(clsTaskProviderBase))
        End If
        Return dicTaskProvider
    End Function


    Public Overrides Function GenerateDataTable(pView As clsViewModel, conf As clsBandConf, pdclientview As String, strFilter As String) As DataTable
        Dim oGen As New clsPDCViewGenerator(pView.myContext)
        Dim dt1 As DataTable = oGen.GenerateDataTable(pView, conf, pdclientview, strFilter)
        Return dt1
    End Function

    Public Overrides Function HelpSite() As String
        Throw New NotImplementedException()
    End Function
End Class
