''Copyright (c) 2016-2017 Swiss Agency for Development and Cooperation (SDC)
''
''The program users must agree to the following terms:
''
''Copyright notices
''This program is free software: you can redistribute it and/or modify it under the terms of the GNU AGPL v3 License as published by the 
''Free Software Foundation, version 3 of the License.
''This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of 
''MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU AGPL v3 License for more details www.gnu.org.
''
''Disclaimer of Warranty
''There is no warranty for the program, to the extent permitted by applicable law; except when otherwise stated in writing the copyright 
''holders and/or other parties provide the program "as is" without warranty of any kind, either expressed or implied, including, but not 
''limited to, the implied warranties of merchantability and fitness for a particular purpose. The entire risk as to the quality and 
''performance of the program is with you. Should the program prove defective, you assume the cost of all necessary servicing, repair or correction.
''
''Limitation of Liability 
''In no event unless required by applicable law or agreed to in writing will any copyright holder, or any other party who modifies and/or 
''conveys the program as permitted above, be liable to you for damages, including any general, special, incidental or consequential damages 
''arising out of the use or inability to use the program (including but not limited to loss of data or data being rendered inaccurate or losses 
''sustained by you or third parties or a failure of the program to operate with any other programs), even if such holder or other party has been 
''advised of the possibility of such damages.
''
''In case of dispute arising out or in relation to the use of the program, it is subject to the public law of Switzerland. The place of jurisdiction is Berne.
'
' 
'

Public Class PricelisMIBI
    Public Function GetDistricts(ByVal userId As Integer, Optional ByVal showSelect As Boolean = False, Optional RegionId As Integer = 0) As DataTable
        Dim Districts As New IMIS_BL.LocationsBL
        Return Districts.GetDistricts(userId, showSelect, RegionId)
    End Function
    Public Function GetPLMedicalItems(ByVal PlItemID As Integer) As DataTable
        Dim getDataTable As New IMIS_BL.PriceListMIBL
        Return getDataTable.GetPLMedicalItems(PlItemID)
    End Function
    Public Sub LoadPriceListMI(ByRef ePLItems As IMIS_EN.tblPLItems)
        Dim load As New IMIS_BL.PriceListMIBL
        load.LoadPriceListMI(ePLItems)
    End Sub
    Public Function SavePriceListMI(ByRef ePLItems As IMIS_EN.tblPLItems) As Integer
        Dim SaveData As New IMIS_BL.PriceListMIBL
        Return SaveData.SavePriceListMI(ePLItems)
    End Function

    Public Sub SavePLItemDetails(ByVal ePLItemDetails As IMIS_EN.tblPLItemsDetail, ByVal action As Integer)
        Dim Item As New IMIS_BL.PriceListMIBL
        Item.SavePLItemDetails(ePLItemDetails, action)
    End Sub
    Public Function GetRegions(UserId As Integer, Optional ShowSelect As Boolean = True, Optional ByVal IncludeNational As Boolean = False) As DataTable
        Dim BL As New IMIS_BL.LocationsBL
        Return BL.GetRegions(UserId, ShowSelect:=ShowSelect, IncludeNational:=IncludeNational)
    End Function
    Public Function GetPLItemIdByUUID(ByVal uuid As Guid) As Integer
        Dim PLItem As New IMIS_BL.PriceListMIBL
        Return PLItem.GetPLItemIdByUUID(uuid)
    End Function

    Public Function GetHFsByPriceListItem(PLItemId As Integer, NewLocationId As Integer) As String
        Dim BL As New IMIS_BL.HealthFacilityBL
        Return BL.GetHFsByPriceListItem(PLItemId, NewLocationId)
    End Function
End Class
