Option Explicit On
Option Strict On

Public Class ImageProcessing

    '''<summary>Calculate basic bayer statistics on the passed INT32 data.</summary>
    Public Shared Function BayerStatistics(Of T)(ByRef Data(,) As T, ByVal OffsetX As Integer, ByVal SteppingX As Integer, ByVal OffsetY As Integer, ByVal SteppingY As Integer) As Dictionary(Of T, UInt32)

        Dim OneMore As UInt32 = CType(1, UInt32)

        'Count all values
        Dim AllValues As New Dictionary(Of T, UInt32)
        For Idx1 As Integer = OffsetX To Data.GetUpperBound(0) - 1 Step SteppingX
            For Idx2 As Integer = OffsetY To Data.GetUpperBound(1) - 1 Step SteppingY
                Dim PixelValue As T = Data(Idx1, Idx2)
                If AllValues.ContainsKey(PixelValue) = False Then
                    AllValues.Add(PixelValue, OneMore)
                Else
                    AllValues(PixelValue) += OneMore
                End If
            Next Idx2
        Next Idx1

        Return SortDictionary(AllValues)

    End Function

    '''<summary>Sort the passed dictionary according to T1 (key).</summary>
    Public Shared Function SortDictionary(Of T1, T2)(ByRef Hist As Dictionary(Of T1, T2)) As Dictionary(Of T1, T2)

        'Generate a list
        Dim KeyList As New List(Of T1)
        For Each Entry As T1 In Hist.Keys
            KeyList.Add(Entry)
        Next Entry
        'Sort keys
        KeyList.Sort()
        'Re-generate dictionary
        Dim RetVal As New Dictionary(Of T1, T2)
        For Each Entry As T1 In KeyList
            RetVal.Add(Entry, Hist(Entry))
        Next Entry
        Return RetVal

    End Function

End Class