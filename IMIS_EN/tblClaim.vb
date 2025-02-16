'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class tblClaim
    Public Property ClaimID As Integer
    Public Property ClaimUUID As Guid
    Public Property InsureeID As Integer
    Public Property ClaimCode As String
    Public Property DateFrom As Date
    Public Property DateTo As Nullable(Of Date)
    Public Property ICDID As Integer
    Public Property ClaimStatus As Byte
    Public Property Adjuster As Nullable(Of Integer)
    Public Property Adjustment As String
    Public Property Claimed As Nullable(Of Decimal)
    Public Property Approved As Nullable(Of Decimal)
    Public Property Reinsured As Nullable(Of Decimal)
    Public Property Valuated As Nullable(Of Decimal)
    Public Property DateClaimed As Date
    Public Property DateProcessed As Nullable(Of Date)
    Public Property Feedback As Boolean
    Public Property FeedbackID As Nullable(Of Integer)
    Public Property Explanation As String
    Public Property FeedbackStatus As Nullable(Of Byte)
    Public Property ReviewStatus As Nullable(Of Byte)
    Public Property ApprovalStatus As Nullable(Of Byte)
    Public Property RejectionReason As Nullable(Of Byte)
    Public Property ValidityFrom As Date
    Public Property ValidityTo As Nullable(Of Date)
    Public Property LegacyID As Nullable(Of Integer)
    Public Property AuditUserID As Integer
    Public Property ValidityFromReview As Nullable(Of Date)
    Public Property ValidityToReview As Nullable(Of Date)
    Public Property AuditUserIDReview As Nullable(Of Integer)
    Public Property RowID As Byte()
    Public Property HFID As Integer
    Public Property RunID As Nullable(Of Integer)
    Public Property AuditUserIDSubmit As Nullable(Of Integer)
    Public Property AuditUserIDProcess As Nullable(Of Integer)
    Public Property SubmitStamp As Nullable(Of Date)
    Public Property ProcessStamp As Nullable(Of Date)
    Public Property Remunerated As Nullable(Of Decimal)
    Public Property GuaranteeId As String
    Public Property ClaimAdminId As Nullable(Of Integer)
    Public Property ICDID1 As Nullable(Of Integer)
    Public Property ICDID2 As Nullable(Of Integer)
    Public Property ICDID3 As Nullable(Of Integer)
    Public Property ICDID4 As Nullable(Of Integer)
    Public Property VisitType As String
    Public Property ClaimCategory As String
    Public ClaimItems As New tblClaimItems
    Public ClaimServices As New tblClaimServices

    Public Overridable Property tblBatchRun As tblBatchRun
    Public Overridable Property tblClaimAdmin As tblClaimAdmin
    Public Overridable Property tblFeedback As tblFeedback
    Public Overridable Property tblHF As tblHF
    Public Overridable Property tblICDCodes As tblICDCodes
    Public Overridable Property tblInsuree As tblInsuree
    Public Overridable Property tblUsers As tblUsers
    Public Overridable Property tblClaimItems As ICollection(Of tblClaimItems) = New HashSet(Of tblClaimItems)
    Public Overridable Property tblClaimServices As ICollection(Of tblClaimServices) = New HashSet(Of tblClaimServices)
    Public Overridable Property tblFeedback1 As ICollection(Of tblFeedback) = New HashSet(Of tblFeedback)

End Class
