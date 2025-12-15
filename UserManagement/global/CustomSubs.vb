Module CustomSubs
    Public hoveredRow As Integer = -1
    Public hoveredCol As Integer = -1
    Public Sub ClearDGV(ByVal grid As DataGridView)
        grid.DataSource = Nothing
        grid.Refresh()
    End Sub
    Public Sub Custom_ComboBox(ByVal combo As ComboBox, ByVal dt As DataTable, ByVal DisplayMember As String, ByVal ValueMember As String, Optional ByVal selectedindex As Integer = -1)
        With combo
            .DataSource = dt
            .DisplayMember = DisplayMember
            .ValueMember = ValueMember
            .SelectedIndex = selectedindex
        End With
    End Sub
    Public Sub CustomMsg(ByVal Title As String, ByVal Message As String, Optional ByVal BtnText As String = "Close Now")
        OkPrompt.MsgText.Text = Message
        OkPrompt.TitleText.Text = Title
        OkPrompt.MsgText.Visible = True
        OkPrompt.TitleText.Visible = True
        OkPrompt.btnclose.Text = BtnText
        Opaque.Show()
        OkPrompt.ShowDialog()
    End Sub
    Public Sub CustomYesNoPrompt(ByVal Title As String, ByVal Message As String, Optional ByVal BtnText As String = "OK")
        YesNoPrompt.MsgText.Text = Message
        YesNoPrompt.TitleText.Text = Title
        YesNoPrompt.ShowDialog()
    End Sub
    Public Sub Datagrid_HideColumn(ByVal grid As DataGridView, ByVal cols As String())
        For Each col In cols
            If grid.Columns.Contains(col) Then grid.Columns(col).Visible = False
        Next
    End Sub

    Public Sub Datagrid_RenameColumn(ByVal grid As DataGridView, ByVal cols As String(), ByVal newcolumn As String())
        Dim i = 0
        For Each col In cols
            If grid.Columns.Contains(col) Then
                grid.Columns(col).HeaderText = newcolumn(i)
            End If
            i += 1
        Next
    End Sub
    Friend Sub Add_GridButton(ByVal grid As DataGridView, ByVal header As String, ByVal btnText As String, ByVal btnName As String, ByVal displayedIndex As Integer, Optional btnwidth As Integer = 80)
        Dim btn As New DataGridViewButtonColumn With {
            .HeaderText = header,
            .Text = btnText,
            .Name = btnName,
            .Width = btnwidth,
            .UseColumnTextForButtonValue = True
        }
        btn.DefaultCellStyle.ForeColor = Color.Black
        btn.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(51, 153, 255)
        If grid.Columns.Contains(btnName) = False Then grid.Columns.Add(btn)
        Try
            grid.Columns(btnName).DisplayIndex = displayedIndex
            AddHandler grid.RowPostPaint, Sub(s, e)
                                              btn.Width = btnwidth
                                          End Sub
        Catch ex As Exception
            'MsgBox(Err.Description,, "Error found!")
        End Try
    End Sub

    Public Sub Custom_ComboBoxDatasource(ByVal combo As ComboBox, ByVal dt As DataTable, ByVal DisplayMember As String, ByVal ValueMember As String, Optional ByVal selectedindex As Integer = -1)
        With combo
            .DataSource = dt
            .DisplayMember = DisplayMember
            .ValueMember = ValueMember
            .SelectedIndex = selectedindex
        End With
    End Sub
    Public Sub GotoMousePointer(targetControl As Control)
        Dim targetLocation As Point = targetControl.PointToScreen(New Point(targetControl.Width / 2, targetControl.Height / 2))
        Cursor.Position = targetLocation
    End Sub
    Friend Sub Set_GridColWidth(column As Dictionary(Of String, Integer), datagrid As DataGridView)
        If column IsNot Nothing Then
            For i As Integer = 0 To column.Count - 1
                Dim col = column.ElementAt(i).Key.ToString
                Dim colwidth = column.ElementAt(i).Value
                datagrid.Columns(col).Width = colwidth
            Next
        End If
    End Sub

    Friend Sub CenterColumnsByName(dgv As DataGridView, ParamArray columnNames() As String)
        For Each colName In columnNames
            If dgv.Columns.Contains(colName) Then
                With dgv.Columns(colName)
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                End With
            End If
        Next
    End Sub
    Friend Sub CenterColumnsByCell(dgv As DataGridView, ParamArray columnNames() As String)
        For Each colName In columnNames
            If dgv.Columns.Contains(colName) Then
                With dgv.Columns(colName)
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End With
            End If
        Next
    End Sub
    Friend Sub OverrideColumnAlignment(dgv As DataGridView, columnName As String, align As DataGridViewContentAlignment)
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow AndAlso dgv.Columns.Contains(columnName) Then
                row.Cells(columnName).Style.Alignment = align
            End If
        Next
    End Sub
    Friend Sub Add_GridButtonWithImage(ByVal grid As DataGridView,
                                   ByVal header As String,
                                   ByVal btnText As String,
                                   ByVal btnName As String,
                                   ByVal displayedIndex As Integer,
                                   ByVal btnImage As Image,
                                   Optional btnWidth As Integer = 80,
                                   Optional backColor As Color = Nothing)

        ' Create button column
        Dim btn As New DataGridViewButtonColumn With {
        .HeaderText = header,
        .Text = btnText,
        .Name = btnName,
        .Width = btnWidth,
        .UseColumnTextForButtonValue = True
    }

        ' Add only if not exists
        If Not grid.Columns.Contains(btnName) Then
            grid.Columns.Add(btn)
        End If

        ' Set display index
        Try
            grid.Columns(btnName).DisplayIndex = displayedIndex
        Catch
        End Try

        ' Store image + background
        If Not TypeOf grid.Tag Is Dictionary(Of String, Tuple(Of Image, Color)) Then
            grid.Tag = New Dictionary(Of String, Tuple(Of Image, Color))()
        End If

        Dim dict = DirectCast(grid.Tag, Dictionary(Of String, Tuple(Of Image, Color)))
        dict(btnName) = Tuple.Create(btnImage, If(backColor = Nothing, Color.FromArgb(51, 153, 255), backColor))

        ' Hook painting
        RemoveHandler grid.CellPainting, AddressOf Grid_CellPainting
        AddHandler grid.CellPainting, AddressOf Grid_CellPainting
    End Sub

    Private Sub Grid_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)
        Dim grid = DirectCast(sender, DataGridView)
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim dict = TryCast(grid.Tag, Dictionary(Of String, Tuple(Of Image, Color)))
        If dict Is Nothing Then Exit Sub

        Dim colName = grid.Columns(e.ColumnIndex).Name
        If Not dict.ContainsKey(colName) Then Exit Sub

        Dim data = dict(colName)
        Dim img = data.Item1
        Dim backColor = data.Item2

        ' Fill background
        Using br As New SolidBrush(backColor)
            e.Graphics.FillRectangle(br, e.CellBounds)
        End Using

        ' Draw button border
        ControlPaint.DrawBorder(e.Graphics, e.CellBounds, grid.GridColor, ButtonBorderStyle.Solid)

        ' Draw text if any
        If Not String.IsNullOrEmpty(CStr(e.FormattedValue)) Then
            TextRenderer.DrawText(e.Graphics,
                              CStr(e.FormattedValue),
                              e.CellStyle.Font,
                              e.CellBounds,
                              e.CellStyle.ForeColor,
                              TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        End If

        ' Draw image (centered)
        If img IsNot Nothing Then
            Dim imgX As Integer = e.CellBounds.Left + (e.CellBounds.Width - img.Width) \ 2
            Dim imgY As Integer = e.CellBounds.Top + (e.CellBounds.Height - img.Height) \ 2
            e.Graphics.DrawImage(img, imgX, imgY, img.Width, img.Height)
        End If

        e.Handled = True
    End Sub

    Public Sub FormShowUserControl(ByVal uc As UserControl)                      'Clear panel and add form projects/modules
        Main.MainPanel.Controls.Clear()
        Main.MainPanel.Controls.Add(uc)
        uc.Size = Main.MainPanel.Size
        uc.Show()
    End Sub
    Public Sub FormShowUserControlUser(ByVal uc As UserControl, ByVal um As UserManagement)                      'Clear panel and add form projects/modules
        um.MainPanel.Controls.Clear()
        um.MainPanel.Controls.Add(uc)
        uc.Size = um.MainPanel.Size
        uc.Show()
    End Sub
    Friend Sub Add_GridAutoNumber(ByVal grid As DataGridView,
                              ByVal header As String,
                              ByVal colName As String,
                              ByVal displayedIndex As Integer,
                              Optional colWidth As Integer = 50)

        Dim col As New DataGridViewTextBoxColumn With {
            .HeaderText = header,
            .Name = colName,
            .Width = colWidth,
            .ReadOnly = True
        }

        If grid.Columns.Contains(colName) = False Then grid.Columns.Add(col)

        Try
            grid.Columns(colName).DisplayIndex = displayedIndex

            ' Handle auto numbering in RowPostPaint
            AddHandler grid.RowPostPaint,
                Sub(s, e)
                    If e.RowIndex >= 0 Then
                        grid.Rows(e.RowIndex).Cells(colName).Value = (e.RowIndex + 1).ToString()
                    End If
                End Sub
        Catch ex As Exception
            'MsgBox(ex.Message,, "Error found!")
        End Try
    End Sub
End Module
