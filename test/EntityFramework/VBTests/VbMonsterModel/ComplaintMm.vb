'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class ComplaintMm
    Public Property ComplaintId As Integer
    Public Property CustomerId As Nullable(Of Integer)
    Public Property Logged As Date
    Public Property Details As String

    Public Overridable Property Customer As Another.Place.CustomerMm
    Public Overridable Property Resolution As ResolutionMm

End Class
