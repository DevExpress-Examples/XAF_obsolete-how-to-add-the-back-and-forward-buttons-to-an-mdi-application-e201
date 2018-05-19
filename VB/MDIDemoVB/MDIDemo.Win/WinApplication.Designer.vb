Imports Microsoft.VisualBasic
Imports System

Partial Public Class MDIDemoWindowsFormsApplication
	''' <summary> 
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (Not components Is Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
      Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule
      Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
      Me.module3 = New MDIDemo.[Module].MDIDemoModule
      Me.module4 = New MDIDemo.[Module].Win.MDIDemoWindowsFormsModule
      Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule
      Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
      Me.module7 = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
      Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule
      Me.securitySimple1 = New DevExpress.ExpressApp.Security.SecuritySimple
      Me.authenticationActiveDirectory1 = New DevExpress.ExpressApp.Security.AuthenticationActiveDirectory
      Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection
      Me.SchedulerWindowsFormsModule1 = New DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule
      Me.SchedulerModuleBase1 = New DevExpress.ExpressApp.Scheduler.SchedulerModuleBase
      CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
      '
      'module5
      '
      Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResult))
      Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResultItem))
      Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RulePropertyValueProperties))
      Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleRequiredFieldProperties))
      Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties))
      Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleRangeProperties))
      Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleValueComparisonProperties))
      Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleStringComparisonProperties))
      Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleRegularExpressionProperties))
      Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleCriteriaProperties))
      Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleSearchObjectProperties))
      Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleObjectExistsProperties))
      Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleUniqueValueProperties))
      Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleIsReferencedProperties))
      '
      'securitySimple1
      '
      Me.securitySimple1.Authentication = Me.authenticationActiveDirectory1
      Me.securitySimple1.IsGrantedForNonExistentPermission = False
      Me.securitySimple1.UserType = GetType(DevExpress.Persistent.BaseImpl.SimpleUser)
      '
      'authenticationActiveDirectory1
      '
      Me.authenticationActiveDirectory1.CreateUserAutomatically = True
      Me.authenticationActiveDirectory1.UserType = GetType(DevExpress.Persistent.BaseImpl.SimpleUser)
      '
      'sqlConnection1
      '
      Me.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=MDIDemo;Integrated Security=SSPI;Pooling=fals" & _
          "e"
      Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
      '
      'MDIDemoWindowsFormsApplication
      '
      Me.ApplicationName = "MDIDemo"
      Me.Connection = Me.sqlConnection1
      Me.Modules.Add(Me.module1)
      Me.Modules.Add(Me.module2)
      Me.Modules.Add(Me.module6)
      Me.Modules.Add(Me.module3)
      Me.Modules.Add(Me.module4)
      Me.Modules.Add(Me.module5)
      Me.Modules.Add(Me.module7)
      Me.Modules.Add(Me.securityModule1)
      Me.Modules.Add(Me.SchedulerModuleBase1)
      Me.Modules.Add(Me.SchedulerWindowsFormsModule1)
      Me.Security = Me.securitySimple1
      CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

   End Sub

#End Region

	Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
    Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
	Private module3 As Global.MDIDemo.Module.MDIDemoModule
	Private module4 As Global.MDIDemo.Module.Win.MDIDemoWindowsFormsModule
	Private module5 As DevExpress.ExpressApp.Validation.ValidationModule
    Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
    Private module7 As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
    Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule

	Private securitySimple1 As DevExpress.ExpressApp.Security.SecuritySimple
	Private authenticationActiveDirectory1 As DevExpress.ExpressApp.Security.AuthenticationActiveDirectory
   Private sqlConnection1 As System.Data.SqlClient.SqlConnection
   Friend WithEvents SchedulerWindowsFormsModule1 As DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule
   Friend WithEvents SchedulerModuleBase1 As DevExpress.ExpressApp.Scheduler.SchedulerModuleBase
End Class
