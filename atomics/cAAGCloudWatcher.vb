Option Explicit On
Option Strict On

Public Class AAGCloudWatcher

    Public Shared Function CloudToString(ByVal Value As AAG_CloudWatcher.CloudCond) As String
        Select Case Value
            Case AAG_CloudWatcher.CloudCond.CloudClear
                Return "Clear"
            Case AAG_CloudWatcher.CloudCond.CloudCloudy
                Return "Cloudy"
            Case AAG_CloudWatcher.CloudCond.CloudVeryCloudy
                Return "Very cloudy"
            Case AAG_CloudWatcher.CloudCond.CloudUnknown
                Return "Unknown"
            Case Else
                Return "???"
        End Select
    End Function

    Public Shared Function SkyToString(ByVal Value As AAG_CloudWatcher.SkyCond) As String
        Select Case Value
            Case AAG_CloudWatcher.SkyCond.skyClear
                Return "Clear"
            Case AAG_CloudWatcher.SkyCond.skyCloudy
                Return "Cloudy"
            Case AAG_CloudWatcher.SkyCond.skyVeryCloudy
                Return "Very Cloudy"
            Case AAG_CloudWatcher.SkyCond.skyWet
                Return "Wet"
            Case AAG_CloudWatcher.SkyCond.skyUnknown
                Return "Unknown"
            Case Else
                Return "???"
        End Select
    End Function

    Public Shared Function BrightnessToString(ByVal Value As AAG_CloudWatcher.BrightnessCond) As String
        Select Case Value
            Case AAG_CloudWatcher.BrightnessCond.BrightnessDark
                Return "Dark"
            Case AAG_CloudWatcher.BrightnessCond.BrightnessLight
                Return "Light"
            Case AAG_CloudWatcher.BrightnessCond.BrightnessVerylight
                Return "Very Light"
            Case AAG_CloudWatcher.BrightnessCond.BrightnessUnknown
                Return "Unknown"
            Case Else
                Return "???"
        End Select
    End Function

    Public Shared Function RainToString(ByVal Value As AAG_CloudWatcher.RainCond) As String
        Select Case Value
            Case AAG_CloudWatcher.RainCond.RainDry
                Return "Dry"
            Case AAG_CloudWatcher.RainCond.RainRain
                Return "Rain"
            Case AAG_CloudWatcher.RainCond.RainWet
                Return "Wet"
            Case AAG_CloudWatcher.RainCond.RainUnknown
                Return "Unknown"
            Case Else
                Return "???"
        End Select
    End Function

    Public Shared Function WindToString(ByVal Value As AAG_CloudWatcher.WindCond) As String
        Select Case Value
            Case AAG_CloudWatcher.WindCond.WindCalm
                Return "Calm"
            Case AAG_CloudWatcher.WindCond.WindWindy
                Return "Windy"
            Case AAG_CloudWatcher.WindCond.WindVeryWindy
                Return "Very Windy"
            Case AAG_CloudWatcher.WindCond.WindUnknown
                Return "Unknown"
            Case Else
                Return "???"
        End Select
    End Function

End Class