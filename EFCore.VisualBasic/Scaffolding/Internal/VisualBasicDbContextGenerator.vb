﻿Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Design
Imports Microsoft.EntityFrameworkCore.Scaffolding
Imports Microsoft.Extensions.DependencyInjection
Imports EntityFrameworkCore.VisualBasic.Design
Imports System

'------------------------------------------------------------------------------
'<auto-generated>
'    This code was generated by a tool.
'    Runtime Version: 17.0.0.0
' 
'    Changes to this file may cause incorrect behavior and will be lost if
'    the code is regenerated.
'</auto-generated>
'------------------------------------------------------------------------------
Namespace Scaffolding.Internal
    '''<summary>
    '''Class to produce the template output
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")>  _
    Partial Public Class VisualBasicDbContextGenerator
        Inherits VisualBasicDbContextGeneratorBase
        '''<summary>
        '''Create the template output
        '''</summary>
        Public Overridable Function TransformText() As String

    Dim services = DirectCast(Host, IServiceProvider)
    Dim providerCode = services.GetRequiredService(Of IProviderConfigurationCodeGenerator)()
    Dim annotationCodeGenerator = services.GetRequiredService(Of IAnnotationCodeGenerator)()
    Dim code = services.GetRequiredService(Of IVisualBasicHelper)()

    Dim importsList = New List(Of String) From {
        "System",
        "System.Collections.Generic",
        "Microsoft.EntityFrameworkCore"
    }

    Dim FullyQualifiedContextNamespace = code.FullyQualifiedNamespace(Options.RootNamespace, NamespaceHint)
    Dim FullyQualifiedModelNamespace = code.FullyQualifiedNamespace(Options.RootNamespace, Options.ModelNamespace)
    Dim ImportsClauseName = code.ImportsClause(FullyQualifiedContextNamespace, FullyQualifiedModelNamespace)

    If ImportsClauseName IsNot Nothing Then
        importsList.Add(FullyQualifiedModelNamespace)
    End If

    Dim FileNamespaceIdentifier = code.NamespaceIdentifier(Options.RootNamespace, NamespaceHint)

    If Not String.IsNullOrEmpty(FileNamespaceIdentifier) Then

            Me.Write("Namespace ")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(FileNamespaceIdentifier))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

    End If

            Me.Write("    Partial Public Class ")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(Options.ContextName))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"        Inherits DbContext"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

    If Not Options.SuppressOnConfiguring Then

            Me.Write("        Public Sub New()"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"        End Sub"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

    End If

            Me.Write("        Public Sub New(options As DbContextOptions(Of ")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(Options.ContextName))
            Me.Write("))"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"            MyBase.New(options)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"        End Sub"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

    For Each entityType in Model.GetEntityTypes().Where(Function(e) Not e.IsSimpleManyToManyJoinEntityType())

            Me.Write("        Public Overridable Property ")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Identifier(entityType.GetDbSetName())))
            Me.Write(" As DbSet(Of ")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(entityType.Name))
            Me.Write(")"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

    Next

    If Not Options.SuppressOnConfiguring Then

            Me.Write("        Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsB"& _ 
                    "uilder)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

        If Not Options.SuppressConnectionStringWarning Then

            Me.Write("            'TODO /!\ To protect potentially sensitive information in your connec"& _ 
                    "tion string, you should move it out of source code. You can avoid scaffolding th"& _ 
                    "e connection string by using the Name= syntax to read it from configuration - se"& _ 
                    "e https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing "& _ 
                    "connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

        End If

            Me.Write("            optionsBuilder")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Fragment(providerCode.GenerateUseProvider(Options.ConnectionString), indent:=4)))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"        End Sub"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

    End If

            Me.Write("        Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

    Dim anyConfiguration = False

    Dim modelFluentApiCalls = Model.GetFluentApiCalls(annotationCodeGenerator)
    If modelFluentApiCalls IsNot Nothing Then
        importsList.AddRange(modelFluentApiCalls.GetRequiredUsings())

            Me.Write("            modelBuilder")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Fragment(modelFluentApiCalls, indent:=4)))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

        anyConfiguration = True
    End If

    Dim mainEnvironment As StringBuilder
    For Each entityType in Model.GetEntityTypes().Where(Function(e) Not e.IsSimpleManyToManyJoinEntityType())
        ' Save all previously generated code, and start generating into a new temporary environment
        mainEnvironment = GenerationEnvironment
        GenerationEnvironment = New StringBuilder()

        If anyConfiguration Then
            WriteLine("")
        End If

        Dim anyEntityTypeConfiguration = False

            Me.Write("            modelBuilder.Entity(Of ")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(entityType.Name))
            Me.Write(")("&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"                Sub(entity)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

        Dim key = entityType.FindPrimaryKey()
        If key IsNot Nothing Then
            Dim keyFluentApiCalls = key.GetFluentApiCalls(annotationCodeGenerator)
            If keyFluentApiCalls IsNot Nothing OrElse
               (Not key.IsHandledByConvention() AndAlso Not Options.UseDataAnnotations)

                If keyFluentApiCalls IsNot Nothing Then
                    importsList.AddRange(keyFluentApiCalls.GetRequiredUsings())
                End If

            Me.Write("                    entity.HasKey(")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Lambda(key.Properties, "e")))
            Me.Write(")")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Fragment(keyFluentApiCalls, indent:=6)))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

                anyEntityTypeConfiguration = True
            End If
        End If

        Dim entityTypeFluentApiCalls = entityType.GetFluentApiCalls(annotationCodeGenerator)?.
                                           FilterChain(Function(c) Not (Options.UseDataAnnotations AndAlso c.IsHandledByDataAnnotations))

        If entityTypeFluentApiCalls IsNot Nothing Then
            importsList.AddRange(entityTypeFluentApiCalls.GetRequiredUsings())

            If anyEntityTypeConfiguration Then
                WriteLine("")
            End If

            Me.Write("                    entity")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Fragment(entityTypeFluentApiCalls, indent:=5)))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

            anyEntityTypeConfiguration = true
        End If

        For Each index in entityType.GetIndexes().
                                     Where(Function(i) Not (Options.UseDataAnnotations AndAlso i.IsHandledByDataAnnotations(annotationCodeGenerator)))

            If anyEntityTypeConfiguration Then
                WriteLine("")
            End If

            Dim indexFluentApiCalls = index.GetFluentApiCalls(annotationCodeGenerator)
            If indexFluentApiCalls IsNot Nothing Then
                importsList.AddRange(indexFluentApiCalls.GetRequiredUsings())
            End If

            Me.Write("                    entity.HasIndex(")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Lambda(index.Properties, "e")))
            Me.Write(", ")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Literal(index.GetDatabaseName())))
            Me.Write(")")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Fragment(indexFluentApiCalls, indent:=6)))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

            anyEntityTypeConfiguration = True
        Next

        Dim firstProperty = True
        For Each prop in entityType.GetProperties()
            Dim propertyFluentApiCalls = prop.GetFluentApiCalls(annotationCodeGenerator)?.
                                              FilterChain(Function(c) Not (Options.UseDataAnnotations AndAlso c.IsHandledByDataAnnotations))

            If propertyFluentApiCalls Is Nothing Then
                Continue For
            End If

            importsList.AddRange(propertyFluentApiCalls.GetRequiredUsings())

            If anyEntityTypeConfiguration AndAlso firstProperty Then
                WriteLine("")
            End If

            Me.Write("                    entity.Property(Function(e) e.")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Identifier(prop.Name)))
            Me.Write(")")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Fragment(propertyFluentApiCalls, indent:=6)))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

            anyEntityTypeConfiguration = True
            firstProperty = False
        Next

        For Each foreignKey in entityType.GetForeignKeys()
            Dim foreignKeyFluentApiCalls = foreignKey.GetFluentApiCalls(annotationCodeGenerator)?.
                                                      FilterChain(Function(c) Not (Options.UseDataAnnotations AndAlso c.IsHandledByDataAnnotations))

            If foreignKeyFluentApiCalls Is Nothing Then
                Continue For
            End If

            importsList.AddRange(foreignKeyFluentApiCalls.GetRequiredUsings())

            If anyEntityTypeConfiguration Then
                WriteLine("")
            End If

            Me.Write("                    entity.HasOne(Function(d) d.")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(foreignKey.DependentToPrincipal.Name))
            Me.Write(").")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(If(foreignKey.IsUnique, "WithOne", "WithMany")))
            Me.Write("(")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(If(foreignKey.PrincipalToDependent IsNot Nothing, $"Function(p) p.{foreignKey.PrincipalToDependent.Name}", "")))
            Me.Write(")")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Fragment(foreignKeyFluentApiCalls, indent:=6)))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

            anyEntityTypeConfiguration = True
        Next

        For Each skipNavigation in entityType.GetSkipNavigations().Where(Function(n) n.IsLeftNavigation())
            If anyEntityTypeConfiguration Then
                WriteLine("")
            End If

            Dim left = skipNavigation.ForeignKey
            Dim leftFluentApiCalls = left.GetFluentApiCalls(annotationCodeGenerator, useStrings:=True)
            Dim right = skipNavigation.Inverse.ForeignKey
            Dim rightFluentApiCalls = right.GetFluentApiCalls(annotationCodeGenerator, useStrings:=True)
            Dim joinEntityType = skipNavigation.JoinEntityType

            If leftFluentApiCalls IsNot Nothing Then
                importsList.AddRange(leftFluentApiCalls.GetRequiredUsings())
            End If

            If rightFluentApiCalls IsNot Nothing Then
                importsList.AddRange(rightFluentApiCalls.GetRequiredUsings())
            End If

            Me.Write("                    entity.HasMany(Function(d) d.")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(skipNavigation.Name))
            Me.Write(").WithMany(Function(p) p.")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(skipNavigation.Inverse.Name))
            Me.Write(")."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"                        UsingEntity(Of Dictionary(Of String, Object))("&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"     "& _ 
                    "                       ")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Literal(joinEntityType.Name)))
            Me.Write(","&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"                            Function(r) r.HasOne(Of ")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(right.PrincipalEntityType.Name))
            Me.Write(")().WithMany()")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Fragment(rightFluentApiCalls, indent:=8)))
            Me.Write(","&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"                            Function(l) l.HasOne(Of ")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(left.PrincipalEntityType.Name))
            Me.Write(")().WithMany()")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Fragment(leftFluentApiCalls, indent:=8)))
            Me.Write(","&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"                            Sub(j)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

            Dim joinKey = joinEntityType.FindPrimaryKey()
            Dim joinKeyFluentApiCalls = joinKey.GetFluentApiCalls(annotationCodeGenerator)

            If joinKeyFluentApiCalls IsNot Nothing Then
                importsList.AddRange(joinKeyFluentApiCalls.GetRequiredUsings())
            End If

            Me.Write("                                j.HasKey(")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Arguments(joinKey.Properties.Select(Function(e) e.Name))))
            Me.Write(")")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Fragment(joinKeyFluentApiCalls, indent:=8)))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

            Dim joinEntityTypeFluentApiCalls = joinEntityType.GetFluentApiCalls(annotationCodeGenerator)

            If joinEntityTypeFluentApiCalls IsNot Nothing Then
                importsList.AddRange(joinEntityTypeFluentApiCalls.GetRequiredUsings())

            Me.Write("                                j")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Fragment(joinEntityTypeFluentApiCalls, indent:=8)))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

            End If

            For Each index in joinEntityType.GetIndexes()
                Dim indexFluentApiCalls = index.GetFluentApiCalls(annotationCodeGenerator)
                If indexFluentApiCalls IsNot Nothing Then
                    importsList.AddRange(indexFluentApiCalls.GetRequiredUsings())
                End If

            Me.Write("                                j.HasIndex(")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Literal(index.Properties.Select(Function(e) e.Name).ToArray())))
            Me.Write(", ")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Literal(index.GetDatabaseName())))
            Me.Write(")")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Fragment(indexFluentApiCalls, indent:=8)))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

            Next

            For Each prop in joinEntityType.GetProperties()
                Dim propertyFluentApiCalls = prop.GetFluentApiCalls(annotationCodeGenerator)
                If propertyFluentApiCalls Is Nothing Then
                    Continue For
                End If

                importsList.AddRange(propertyFluentApiCalls.GetRequiredUsings())

            Me.Write("                                j.IndexerProperty(Of ")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Reference(prop.ClrType)))
            Me.Write(")(")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Literal(prop.Name)))
            Me.Write(")")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Fragment(propertyFluentApiCalls, indent:=8)))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

            Next

            Me.Write("                            End Sub)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

            anyEntityTypeConfiguration = True
        Next

            Me.Write("                End Sub)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

        ' If any signicant code was generated, append it to the main environment
        If anyEntityTypeConfiguration Then
            mainEnvironment.Append(GenerationEnvironment)
            anyConfiguration = True
        End If

        ' Resume generating code into the main environment
        GenerationEnvironment = mainEnvironment
    Next

    For Each sequence in Model.GetSequences()
        Dim needsType = sequence.Type <> GetType(long)
        Dim needsSchema = Not String.IsNullOrEmpty(sequence.Schema) AndAlso sequence.Schema <> sequence.Model.GetDefaultSchema()
        Dim sequenceFluentApiCalls = sequence.GetFluentApiCalls(annotationCodeGenerator)

            Me.Write("            modelBuilder.HasSequence")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(If(needsType, $"(Of {code.Reference(sequence.Type)})", "")))
            Me.Write("(")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Literal(sequence.Name)))
            Me.Write(Me.ToStringHelper.ToStringWithCulture(If(needsSchema, $", {code.Literal(sequence.Schema)}", "")))
            Me.Write(")")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(code.Fragment(sequenceFluentApiCalls, indent:=4)))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

    Next

    If anyConfiguration Then
        WriteLine("")
    End If

            Me.Write("            OnModelCreatingPartial(modelBuilder)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"        End Sub"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"        Part"& _ 
                    "ial Private Sub OnModelCreatingPartial(modelBuilder As ModelBuilder)"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"        En"& _ 
                    "d Sub"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"    End Class"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

    If Not String.IsNullOrEmpty(FileNamespaceIdentifier) Then

            Me.Write("End Namespace"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

    End If


    mainEnvironment = GenerationEnvironment
    GenerationEnvironment = New StringBuilder()

    For Each ns in importsList.Where(Function(x) Not String.IsNullOrWhiteSpace(x)).
                               Distinct().
                               OrderBy(Function(x) x, New NamespaceComparer())

            Me.Write("Imports ")
            Me.Write(Me.ToStringHelper.ToStringWithCulture(ns))
            Me.Write(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

    Next

    WriteLine("")

    GenerationEnvironment.Append(mainEnvironment)

            Return Me.GenerationEnvironment.ToString
        End Function
        Private hostValue As Global.Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost
        '''<summary>
        '''The current host for the text templating engine
        '''</summary>
        Public Overridable Property Host() As Global.Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost
            Get
                Return Me.hostValue
            End Get
            Set
                Me.hostValue = value
            End Set
        End Property

Private _ModelField As Global.Microsoft.EntityFrameworkCore.Metadata.IModel

'''<summary>
'''Access the Model parameter of the template.
'''</summary>
Private ReadOnly Property Model() As Global.Microsoft.EntityFrameworkCore.Metadata.IModel
    Get
        Return Me._ModelField
    End Get
End Property

Private _OptionsField As Global.Microsoft.EntityFrameworkCore.Scaffolding.ModelCodeGenerationOptions

'''<summary>
'''Access the Options parameter of the template.
'''</summary>
Private ReadOnly Property Options() As Global.Microsoft.EntityFrameworkCore.Scaffolding.ModelCodeGenerationOptions
    Get
        Return Me._OptionsField
    End Get
End Property

Private _NamespaceHintField As String

'''<summary>
'''Access the NamespaceHint parameter of the template.
'''</summary>
Private ReadOnly Property NamespaceHint() As String
    Get
        Return Me._NamespaceHintField
    End Get
End Property


'''<summary>
'''Initialize the template
'''</summary>
Public Overridable Sub Initialize()
    If (Me.Errors.HasErrors = false) Then
Dim ModelValueAcquired As Boolean = false
If Me.Session.ContainsKey("Model") Then
    Me._ModelField = CType(Me.Session("Model"),Global.Microsoft.EntityFrameworkCore.Metadata.IModel)
    ModelValueAcquired = true
End If
If (ModelValueAcquired = false) Then
    Dim parameterValue As String = Me.Host.ResolveParameterValue("Property", "PropertyDirectiveProcessor", "Model")
    If (String.IsNullOrEmpty(parameterValue) = false) Then
        Dim tc As Global.System.ComponentModel.TypeConverter = Global.System.ComponentModel.TypeDescriptor.GetConverter(GetType(Global.Microsoft.EntityFrameworkCore.Metadata.IModel))
        If ((Not (tc) Is Nothing)  _
                    AndAlso tc.CanConvertFrom(GetType(String))) Then
            Me._ModelField = CType(tc.ConvertFrom(parameterValue),Global.Microsoft.EntityFrameworkCore.Metadata.IModel)
            ModelValueAcquired = true
        Else
            Me.Error("The type 'Microsoft.EntityFrameworkCore.Metadata.IModel' of the parameter 'Model'"& _ 
                    " did not match the type of the data passed to the template.")
        End If
    End If
End If
If (ModelValueAcquired = false) Then
    Dim data As Object = Global.System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Model")
    If (Not (data) Is Nothing) Then
        Me._ModelField = CType(data,Global.Microsoft.EntityFrameworkCore.Metadata.IModel)
    End If
End If
Dim OptionsValueAcquired As Boolean = false
If Me.Session.ContainsKey("Options") Then
    Me._OptionsField = CType(Me.Session("Options"),Global.Microsoft.EntityFrameworkCore.Scaffolding.ModelCodeGenerationOptions)
    OptionsValueAcquired = true
End If
If (OptionsValueAcquired = false) Then
    Dim parameterValue As String = Me.Host.ResolveParameterValue("Property", "PropertyDirectiveProcessor", "Options")
    If (String.IsNullOrEmpty(parameterValue) = false) Then
        Dim tc As Global.System.ComponentModel.TypeConverter = Global.System.ComponentModel.TypeDescriptor.GetConverter(GetType(Global.Microsoft.EntityFrameworkCore.Scaffolding.ModelCodeGenerationOptions))
        If ((Not (tc) Is Nothing)  _
                    AndAlso tc.CanConvertFrom(GetType(String))) Then
            Me._OptionsField = CType(tc.ConvertFrom(parameterValue),Global.Microsoft.EntityFrameworkCore.Scaffolding.ModelCodeGenerationOptions)
            OptionsValueAcquired = true
        Else
            Me.Error("The type 'Microsoft.EntityFrameworkCore.Scaffolding.ModelCodeGenerationOptions' o"& _ 
                    "f the parameter 'Options' did not match the type of the data passed to the templ"& _ 
                    "ate.")
        End If
    End If
End If
If (OptionsValueAcquired = false) Then
    Dim data As Object = Global.System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("Options")
    If (Not (data) Is Nothing) Then
        Me._OptionsField = CType(data,Global.Microsoft.EntityFrameworkCore.Scaffolding.ModelCodeGenerationOptions)
    End If
End If
Dim NamespaceHintValueAcquired As Boolean = false
If Me.Session.ContainsKey("NamespaceHint") Then
    Me._NamespaceHintField = CType(Me.Session("NamespaceHint"),String)
    NamespaceHintValueAcquired = true
End If
If (NamespaceHintValueAcquired = false) Then
    Dim parameterValue As String = Me.Host.ResolveParameterValue("Property", "PropertyDirectiveProcessor", "NamespaceHint")
    If (String.IsNullOrEmpty(parameterValue) = false) Then
        Dim tc As Global.System.ComponentModel.TypeConverter = Global.System.ComponentModel.TypeDescriptor.GetConverter(GetType(String))
        If ((Not (tc) Is Nothing)  _
                    AndAlso tc.CanConvertFrom(GetType(String))) Then
            Me._NamespaceHintField = CType(tc.ConvertFrom(parameterValue),String)
            NamespaceHintValueAcquired = true
        Else
            Me.Error("The type 'System.String' of the parameter 'NamespaceHint' did not match the type "& _ 
                    "of the data passed to the template.")
        End If
    End If
End If
If (NamespaceHintValueAcquired = false) Then
    Dim data As Object = Global.System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("NamespaceHint")
    If (Not (data) Is Nothing) Then
        Me._NamespaceHintField = CType(data,String)
    End If
End If


    End If
End Sub


    End Class
    #Region "Base class"
    '''<summary>
    '''Base class for this transformation
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")>  _
    Public Class VisualBasicDbContextGeneratorBase
        #Region "Fields"
        Private generationEnvironmentField As Global.System.Text.StringBuilder
        Private errorsField As Global.System.CodeDom.Compiler.CompilerErrorCollection
        Private indentLengthsField As Global.System.Collections.Generic.List(Of Integer)
        Private currentIndentField As String = ""
        Private endsWithNewline As Boolean
        Private sessionField As Global.System.Collections.Generic.IDictionary(Of String, Object)
        #End Region
        #Region "Properties"
        '''<summary>
        '''The string builder that generation-time code is using to assemble generated output
        '''</summary>
        Public Property GenerationEnvironment() As System.Text.StringBuilder
            Get
                If (Me.generationEnvironmentField Is Nothing) Then
                    Me.generationEnvironmentField = New Global.System.Text.StringBuilder()
                End If
                Return Me.generationEnvironmentField
            End Get
            Set
                Me.generationEnvironmentField = value
            End Set
        End Property
        '''<summary>
        '''The error collection for the generation process
        '''</summary>
        Public ReadOnly Property Errors() As System.CodeDom.Compiler.CompilerErrorCollection
            Get
                If (Me.errorsField Is Nothing) Then
                    Me.errorsField = New Global.System.CodeDom.Compiler.CompilerErrorCollection()
                End If
                Return Me.errorsField
            End Get
        End Property
        '''<summary>
        '''A list of the lengths of each indent that was added with PushIndent
        '''</summary>
        Private ReadOnly Property indentLengths() As System.Collections.Generic.List(Of Integer)
            Get
                If (Me.indentLengthsField Is Nothing) Then
                    Me.indentLengthsField = New Global.System.Collections.Generic.List(Of Integer)()
                End If
                Return Me.indentLengthsField
            End Get
        End Property
        '''<summary>
        '''Gets the current indent we use when adding lines to the output
        '''</summary>
        Public ReadOnly Property CurrentIndent() As String
            Get
                Return Me.currentIndentField
            End Get
        End Property
        '''<summary>
        '''Current transformation session
        '''</summary>
        Public Overridable Property Session() As Global.System.Collections.Generic.IDictionary(Of String, Object)
            Get
                Return Me.sessionField
            End Get
            Set
                Me.sessionField = value
            End Set
        End Property
        #End Region
        #Region "Transform-time helpers"
        '''<summary>
        '''Write text directly into the generated output
        '''</summary>
        Public Overloads Sub Write(ByVal textToAppend As String)
            If String.IsNullOrEmpty(textToAppend) Then
                Return
            End If
            'If we're starting off, or if the previous text ended with a newline,
            'we have to append the current indent first.
            If ((Me.GenerationEnvironment.Length = 0)  _
                        OrElse Me.endsWithNewline) Then
                Me.GenerationEnvironment.Append(Me.currentIndentField)
                Me.endsWithNewline = false
            End If
            'Check if the current text ends with a newline
            If textToAppend.EndsWith(Global.System.Environment.NewLine, Global.System.StringComparison.CurrentCulture) Then
                Me.endsWithNewline = true
            End If
            'This is an optimization. If the current indent is "", then we don't have to do any
            'of the more complex stuff further down.
            If (Me.currentIndentField.Length = 0) Then
                Me.GenerationEnvironment.Append(textToAppend)
                Return
            End If
            'Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(Global.System.Environment.NewLine, (Global.System.Environment.NewLine + Me.currentIndentField))
            'If the text ends with a newline, then we should strip off the indent added at the very end
            'because the appropriate indent will be added when the next time Write() is called
            If Me.endsWithNewline Then
                Me.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - Me.currentIndentField.Length))
            Else
                Me.GenerationEnvironment.Append(textToAppend)
            End If
        End Sub
        '''<summary>
        '''Write text directly into the generated output
        '''</summary>
        Public Overloads Sub WriteLine(ByVal textToAppend As String)
            Me.Write(textToAppend)
            Me.GenerationEnvironment.AppendLine
            Me.endsWithNewline = true
        End Sub
        '''<summary>
        '''Write formatted text directly into the generated output
        '''</summary>
        Public Overloads Sub Write(ByVal format As String, <System.ParamArrayAttribute()> ByVal args() As Object)
            Me.Write(String.Format(Global.System.Globalization.CultureInfo.CurrentCulture, format, args))
        End Sub
        '''<summary>
        '''Write formatted text directly into the generated output
        '''</summary>
        Public Overloads Sub WriteLine(ByVal format As String, <System.ParamArrayAttribute()> ByVal args() As Object)
            Me.WriteLine(String.Format(Global.System.Globalization.CultureInfo.CurrentCulture, format, args))
        End Sub
        '''<summary>
        '''Raise an error
        '''</summary>
        Public Sub [Error](ByVal message As String)
            Dim [error] As System.CodeDom.Compiler.CompilerError = New Global.System.CodeDom.Compiler.CompilerError()
            [error].ErrorText = message
            Me.Errors.Add([error])
        End Sub
        '''<summary>
        '''Raise a warning
        '''</summary>
        Public Sub Warning(ByVal message As String)
            Dim [error] As System.CodeDom.Compiler.CompilerError = New Global.System.CodeDom.Compiler.CompilerError()
            [error].ErrorText = message
            [error].IsWarning = true
            Me.Errors.Add([error])
        End Sub
        '''<summary>
        '''Increase the indent
        '''</summary>
        Public Sub PushIndent(ByVal indent As String)
            If (indent = Nothing) Then
                Throw New Global.System.ArgumentNullException("indent")
            End If
            Me.currentIndentField = (Me.currentIndentField + indent)
            Me.indentLengths.Add(indent.Length)
        End Sub
        '''<summary>
        '''Remove the last indent that was added with PushIndent
        '''</summary>
        Public Function PopIndent() As String
            Dim returnValue As String = ""
            If (Me.indentLengths.Count > 0) Then
                Dim indentLength As Integer = Me.indentLengths((Me.indentLengths.Count - 1))
                Me.indentLengths.RemoveAt((Me.indentLengths.Count - 1))
                If (indentLength > 0) Then
                    returnValue = Me.currentIndentField.Substring((Me.currentIndentField.Length - indentLength))
                    Me.currentIndentField = Me.currentIndentField.Remove((Me.currentIndentField.Length - indentLength))
                End If
            End If
            Return returnValue
        End Function
        '''<summary>
        '''Remove any indentation
        '''</summary>
        Public Sub ClearIndent()
            Me.indentLengths.Clear
            Me.currentIndentField = ""
        End Sub
        #End Region
        #Region "ToString Helpers"
        '''<summary>
        '''Utility class to produce culture-oriented representation of an object as a string.
        '''</summary>
        Public Class ToStringInstanceHelper
            Private formatProviderField  As System.IFormatProvider = Global.System.Globalization.CultureInfo.InvariantCulture
            '''<summary>
            '''Gets or sets format provider to be used by ToStringWithCulture method.
            '''</summary>
            Public Property FormatProvider() As System.IFormatProvider
                Get
                    Return Me.formatProviderField 
                End Get
                Set
                    If (Not (value) Is Nothing) Then
                        Me.formatProviderField  = value
                    End If
                End Set
            End Property
            '''<summary>
            '''This is called from the compile/run appdomain to convert objects within an expression block to a string
            '''</summary>
            Public Function ToStringWithCulture(ByVal objectToConvert As Object) As String
                If (objectToConvert Is Nothing) Then
                    Throw New Global.System.ArgumentNullException("objectToConvert")
                End If
                Dim t As System.Type = objectToConvert.GetType
                Dim method As System.Reflection.MethodInfo = t.GetMethod("ToString", New System.Type() {GetType(System.IFormatProvider)})
                If (method Is Nothing) Then
                    Return objectToConvert.ToString
                Else
                    Return CType(method.Invoke(objectToConvert, New Object() {Me.formatProviderField }),String)
                End If
            End Function
        End Class
        Private toStringHelperField As ToStringInstanceHelper = New ToStringInstanceHelper()
        '''<summary>
        '''Helper to produce culture-oriented representation of an object as a string
        '''</summary>
        Public ReadOnly Property ToStringHelper() As ToStringInstanceHelper
            Get
                Return Me.toStringHelperField
            End Get
        End Property
        #End Region
    End Class
    #End Region
End Namespace
