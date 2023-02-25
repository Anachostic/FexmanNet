Imports System.Resources
Imports FexmanNet.My.Resources

Public Class EffectResources

    Private Shared _DisplayLookup As System.Resources.ResourceManager

    Shared Function GetResource(deviceType As Enums.DeviceEnum) As System.Resources.ResourceManager
        Dim res As Global.System.Resources.ResourceManager
        Select Case deviceType
            Case Enums.DeviceEnum.MU100
                res = New Global.System.Resources.ResourceManager("FexmanNet.MU100", GetType(MU100).Assembly)

            Case Enums.DeviceEnum.MU80
                res = New Global.System.Resources.ResourceManager("FexmanNet.MU80", GetType(MU80).Assembly)

            Case Enums.DeviceEnum.SW60
                res = New Global.System.Resources.ResourceManager("FexmanNet.SW60", GetType(MU80).Assembly)

            Case Enums.DeviceEnum.SW1000
                res = New Global.System.Resources.ResourceManager("FexmanNet.SW1000", GetType(MU80).Assembly)

            Case Else
                Throw New NotSupportedException

        End Select

        Return res

    End Function

    Shared Function GetDisplayLookups() As System.Resources.ResourceManager
        If _DisplayLookup Is Nothing Then
            _DisplayLookup = New Global.System.Resources.ResourceManager("FexmanNet.DisplayValueLookups", GetType(DisplayValueLookups).Assembly)
        End If

        Return _DisplayLookup
    End Function

End Class
