Class MainWindow
    Dim dictionary As New Dictionary(Of String, String)



    Sub btnnew_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnnew.Click
        If txtKey.Text = "" Or txtValue.Text = "" Then
            MessageBox.Show("Please have an input")
        Else
            lBox1.Items.Add(txtKey.Text)
            dictionary.Add(txtKey.Text, txtValue.Text)
        End If

    End Sub

    Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnedit.Click
        If txtKey.Text = "" Then
            MessageBox.Show("Please input the model you want to edit.")
        Else
            lBox1.Items.Remove(lBox1.SelectedItem)

            dictionary.Remove(txtKey.Text)
            dictionary.Add(txtKey.Text, txtValue.Text)
        End If

    End Sub

    Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btndel.Click
        dictionary.Remove(lBox1.SelectedItem)
        lBox1.Items.Remove(lBox1.SelectedItem)

    End Sub

    Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnfind.Click
        If dictionary.ContainsKey(txtFind.Text) Then
            Dim a As String = dictionary.Item(txtFind.Text)
            output(a)
        Else
            MessageBox.Show("Cant find model")
        End If
    End Sub


    Sub output(ByVal value As String)
        txtValue.Text += value + vbCrLf
    End Sub


    Sub btnclear_Click(ByVal sender As Object, ByVal e As RoutedEventArgs) Handles btnclear.Click
        txtFind.Clear()
        txtKey.Clear()
        txtValue.Clear()
    End Sub


    Sub load(ByVal sender As Object, ByVal e As RoutedEventArgs) Handles MyBase.Loaded
        lBox1.Items.Add("Switch Color")
        lBox1.Items.Add("Pokemon Go")
        lBox1.Items.Add("Tap Tap Dash")
        lBox1.Items.Add("Piano Tiles 2")
        lBox1.Items.Add("Dota 2")
        dictionary.Add("model1", "Switch Color - Tap the ball carefully through each obstacle and your ball will switch color with some powerups.")
        dictionary.Add("model2", "Pokemon Go - is a free-to-play, location-based augmented reality game developed by Niantic for iOS, Android, and Apple Watch devices. It was initially released in selected countries in July 2016.")
        dictionary.Add("model3", "Tap Tap Dash - Tap to jump or change direction. Don't fall it in to path.")
        dictionary.Add("model4", "Piano Tiles 2 - This game will not tap the white tiles. This game also will challenge you how as you can.")
        dictionary.Add("model5", "Dota 2 - is a free-to-play multiplayer online battle arena (MOBA) video game developed and published by Valve Corporation for Microsoft Windows, OS X, and Linux.")
    End Sub

    Sub dblclick(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles lBox1.MouseDoubleClick
        txtValue.Clear()
        txtKey.Text = lBox1.SelectedItem
        output(dictionary.Item(lBox1.SelectedItem))
    End Sub
End Class
