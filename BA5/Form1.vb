Public Class Form1
  Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    For intYears As Integer = 2019 To 2022
      'ListBox1.
    Next
  End Sub

  Private Sub ClearForm()
    Me.TextBox1.Clear()
  End Sub

  Private Sub hatethisName(sender As Object, e As EventArgs) Handles Button1.Click, Button3.Click

    MessageBox.Show(sender.GetType().ToString)

    If sender.Equals(Button3) Then
      MessageBox.Show("B3")

    ElseIf sender.Equals(Button1) Then
      MessageBox.Show("B1")
    End If

    'Gets the items selected and converts it to a string
    Dim result As String = ListBox1.SelectedItem.ToString

    'Checks if Item1 is selected
    If result = "Item1" Then
      MessageBox.Show("Correct")
    ElseIf result = "Cat" Then
      MessageBox.Show("Meow")
    End If

    ClearForm()
  End Sub

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'Declare an array
    Dim array2(8) As String

    Dim array3(8, 8) As Integer

    'Intialize an index
    array2(0) = "helel"

    'Declare and intialize
    Dim array1 = {"Apple", "Banana", "Cat", "Item1", "Items2", "Items3", "Items5"}

    ' Dim array5() As String = {{"Apple", "Banana", "Cat", "Item1", "Items2", "Items3", "Items5"}, {"Apple", "Banana", "Cat", "Item1", "Items2", "Items3", "Items5"}}
    Dim scores1 = {{11, 12, 13}, {10, 10, 10}}

    Dim scores2(3, 3) As Integer

    MessageBox.Show(array1.GetUpperBound(0))

    Me.ListBox1.Sorted = True
    'Me.ListBox1.Items.AddRange(New Object() {"Apple", "Banana", "Cat", "Item1", "Items2", "Items3", "Items5", "NewItem"})
    ' Me.ListBox1.Items.Add("TestItem")

    'MessageBox.Show(array1.Length)

    array1(0) = "Zebra"

    For i = 0 To array1.Length - 1

      MessageBox.Show(array1(i))

      Me.ListBox1.Items.Add(array1(i))

    Next


    'Remove Item
    'ListBox1.Items.RemoveAt(0)

    'Highlights the first item in the list
    ListBox1.SelectedIndex = 2  'Or by name .SelectedItem = "Apple"

    'Msgbox of index of a specific item
    MessageBox.Show(ListBox1.Items.IndexOf("Banana"))


  End Sub

  Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

  End Sub
End Class
