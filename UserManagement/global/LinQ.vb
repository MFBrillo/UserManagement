Module LinQ
    Enum ComparisonTypeEnum
        Equal_enum
        Like_enum
    End Enum

    Class LinQCondition
        Public Property Column As String
        Public Property Value As String
        Public Property ComparisonType As ComparisonTypeEnum
    End Class

    'Personalized LinQ to keep the WHERE condition more dynamic
    Function Linq_Query(ByVal dt As DataTable, ByVal conditions As List(Of LinQCondition), Optional ByVal useOrOperator As Boolean = False) As DataTable
        Try
            Dim result As IEnumerable(Of DataRow)

            If useOrOperator Then
                result = From rows In dt.AsEnumerable
                         Where conditions.Any(Function(c) If(c.ComparisonType = ComparisonTypeEnum.Equal_enum,
                                                            $"{rows(c.Column)}".ToString.ToLower = c.Value.ToLower And rows(c.Column) IsNot DBNull.Value,
                                                            $"{rows(c.Column)}".ToString.ToLower.Contains(c.Value.ToLower)))
                         Select rows
            Else
                result = From rows In dt.AsEnumerable
                         Where conditions.All(Function(c) If(c.ComparisonType = ComparisonTypeEnum.Equal_enum,
                                                            $"{rows(c.Column)}".ToString.ToLower = c.Value.ToLower And rows(c.Column) IsNot DBNull.Value,
                                                            $"{rows(c.Column)}".ToString.ToLower.Contains(c.Value.ToLower)))
                         Select rows
            End If

            If result.Count > 0 Then
                Dim temp As DataTable = result.CopyToDataTable
                Return temp
            Else
                Return Nothing
            End If

        Catch ex As Exception
            Return Nothing
        End Try

    End Function
End Module
