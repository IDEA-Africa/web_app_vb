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

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated. 
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Partial Public Class FindInsuree
    
    '''<summary>
    '''Label8 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents Label8 As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''upDistrict control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents upDistrict As Global.System.Web.UI.UpdatePanel
    
    '''<summary>
    '''pnlTop control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents pnlTop As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''L_LASTNAME control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_LASTNAME As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''txtLastName control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtLastName As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''L_OTHERNAMES control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_OTHERNAMES As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''txtOtherNames control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtOtherNames As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''L_REGION control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_REGION As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''ddlRegion control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlRegion As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''L_CHF control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_CHF As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''txtCHFID control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtCHFID As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''L_BIRTHDATEFROM control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_BIRTHDATEFROM As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''txtBirthDateFrom control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtBirthDateFrom As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''btnDateFrom control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents btnDateFrom As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''CalendarExtender2 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents CalendarExtender2 As Global.AjaxControlToolkit.CalendarExtender
    
    '''<summary>
    '''L_District control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_District As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''ddlDistrict control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlDistrict As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''L_Phone control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_Phone As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''txtPhone control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtPhone As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''Label1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents Label1 As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''txtBirthDateTo control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtBirthDateTo As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''btnDateTo control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents btnDateTo As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''CalendarExtender1 control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents CalendarExtender1 As Global.AjaxControlToolkit.CalendarExtender
    
    '''<summary>
    '''L_Ward control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_Ward As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''ddlWard control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlWard As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''L_Email control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_Email As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''txtEmail control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtEmail As Global.System.Web.UI.WebControls.TextBox
    
    '''<summary>
    '''L_GENDER control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_GENDER As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''ddlGender control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlGender As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''L_Village control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_Village As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''ddlVillage control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlVillage As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''lblPhotoAssigned control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblPhotoAssigned As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''ddlPhotoAssigned control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlPhotoAssigned As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''L_MARITAL control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_MARITAL As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''ddlMarital control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlMarital As Global.System.Web.UI.WebControls.DropDownList
    
    '''<summary>
    '''chkOffline control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents chkOffline As Global.System.Web.UI.WebControls.CheckBox
    
    '''<summary>
    '''chkLegacy control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents chkLegacy As Global.System.Web.UI.WebControls.CheckBox
    
    '''<summary>
    '''btnSearch control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents btnSearch As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''L_FOUNDINSUREE control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents L_FOUNDINSUREE As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''pnlBody control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents pnlBody As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''hfInsuranceNumber control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents hfInsuranceNumber As Global.System.Web.UI.WebControls.HiddenField
    
    '''<summary>
    '''gvInsuree control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents gvInsuree As Global.System.Web.UI.WebControls.GridView
    
    '''<summary>
    '''pnlButtons control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents pnlButtons As Global.System.Web.UI.WebControls.Panel
    
    '''<summary>
    '''B_CLAIM control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents B_CLAIM As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''B_CLAIMSREVIEWS control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents B_CLAIMSREVIEWS As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''B_VIEW control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents B_VIEW As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''B_CANCEL control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents B_CANCEL As Global.System.Web.UI.WebControls.Button
    
    '''<summary>
    '''lblMsg control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblMsg As Global.System.Web.UI.WebControls.Label
End Class
