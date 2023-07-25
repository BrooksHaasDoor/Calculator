<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalculatorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ZeroBtn = New Button()
        DecimalBtn = New Button()
        ClearBtn = New Button()
        OneBtn = New Button()
        TwoBtn = New Button()
        ThreeBtn = New Button()
        FourBtn = New Button()
        FiveBtn = New Button()
        SixBtn = New Button()
        SevenBtn = New Button()
        EightBtn = New Button()
        NineBtn = New Button()
        DivideBtn = New Button()
        MultiplyBtn = New Button()
        SubtractBtn = New Button()
        AddBtn = New Button()
        EqualsBtn = New Button()
        ResultTxt = New TextBox()
        LatestOperationTxt = New TextBox()
        SuspendLayout()
        ' 
        ' ZeroBtn
        ' 
        ZeroBtn.Location = New Point(12, 202)
        ZeroBtn.Name = "ZeroBtn"
        ZeroBtn.Size = New Size(38, 36)
        ZeroBtn.TabIndex = 0
        ZeroBtn.Text = "0"
        ZeroBtn.UseVisualStyleBackColor = True
        ' 
        ' DecimalBtn
        ' 
        DecimalBtn.Location = New Point(56, 202)
        DecimalBtn.Name = "DecimalBtn"
        DecimalBtn.Size = New Size(38, 36)
        DecimalBtn.TabIndex = 1
        DecimalBtn.Text = "."
        DecimalBtn.UseVisualStyleBackColor = True
        ' 
        ' ClearBtn
        ' 
        ClearBtn.Location = New Point(100, 202)
        ClearBtn.Name = "ClearBtn"
        ClearBtn.Size = New Size(38, 36)
        ClearBtn.TabIndex = 2
        ClearBtn.Text = "C"
        ClearBtn.UseVisualStyleBackColor = True
        ' 
        ' OneBtn
        ' 
        OneBtn.Location = New Point(12, 160)
        OneBtn.Name = "OneBtn"
        OneBtn.Size = New Size(38, 36)
        OneBtn.TabIndex = 3
        OneBtn.Text = "1"
        OneBtn.UseVisualStyleBackColor = True
        ' 
        ' TwoBtn
        ' 
        TwoBtn.Location = New Point(56, 160)
        TwoBtn.Name = "TwoBtn"
        TwoBtn.Size = New Size(38, 36)
        TwoBtn.TabIndex = 4
        TwoBtn.Text = "2"
        TwoBtn.UseVisualStyleBackColor = True
        ' 
        ' ThreeBtn
        ' 
        ThreeBtn.Location = New Point(100, 160)
        ThreeBtn.Name = "ThreeBtn"
        ThreeBtn.Size = New Size(38, 36)
        ThreeBtn.TabIndex = 5
        ThreeBtn.Text = "3"
        ThreeBtn.UseVisualStyleBackColor = True
        ' 
        ' FourBtn
        ' 
        FourBtn.Location = New Point(12, 118)
        FourBtn.Name = "FourBtn"
        FourBtn.Size = New Size(38, 36)
        FourBtn.TabIndex = 6
        FourBtn.Text = "4"
        FourBtn.UseVisualStyleBackColor = True
        ' 
        ' FiveBtn
        ' 
        FiveBtn.Location = New Point(56, 118)
        FiveBtn.Name = "FiveBtn"
        FiveBtn.Size = New Size(38, 36)
        FiveBtn.TabIndex = 7
        FiveBtn.Text = "5"
        FiveBtn.UseVisualStyleBackColor = True
        ' 
        ' SixBtn
        ' 
        SixBtn.Location = New Point(100, 118)
        SixBtn.Name = "SixBtn"
        SixBtn.Size = New Size(38, 36)
        SixBtn.TabIndex = 8
        SixBtn.Text = "6"
        SixBtn.UseVisualStyleBackColor = True
        ' 
        ' SevenBtn
        ' 
        SevenBtn.Location = New Point(12, 76)
        SevenBtn.Name = "SevenBtn"
        SevenBtn.Size = New Size(38, 36)
        SevenBtn.TabIndex = 9
        SevenBtn.Text = "7"
        SevenBtn.UseVisualStyleBackColor = True
        ' 
        ' EightBtn
        ' 
        EightBtn.Location = New Point(56, 76)
        EightBtn.Name = "EightBtn"
        EightBtn.Size = New Size(38, 36)
        EightBtn.TabIndex = 10
        EightBtn.Text = "8"
        EightBtn.UseVisualStyleBackColor = True
        ' 
        ' NineBtn
        ' 
        NineBtn.Location = New Point(100, 76)
        NineBtn.Name = "NineBtn"
        NineBtn.Size = New Size(38, 36)
        NineBtn.TabIndex = 11
        NineBtn.Text = "9"
        NineBtn.UseVisualStyleBackColor = True
        ' 
        ' DivideBtn
        ' 
        DivideBtn.Location = New Point(144, 76)
        DivideBtn.Name = "DivideBtn"
        DivideBtn.Size = New Size(68, 36)
        DivideBtn.TabIndex = 12
        DivideBtn.Text = "/"
        DivideBtn.UseVisualStyleBackColor = True
        ' 
        ' MultiplyBtn
        ' 
        MultiplyBtn.Location = New Point(144, 118)
        MultiplyBtn.Name = "MultiplyBtn"
        MultiplyBtn.Size = New Size(68, 36)
        MultiplyBtn.TabIndex = 13
        MultiplyBtn.Text = "*"
        MultiplyBtn.UseVisualStyleBackColor = True
        ' 
        ' SubtractBtn
        ' 
        SubtractBtn.Location = New Point(144, 160)
        SubtractBtn.Name = "SubtractBtn"
        SubtractBtn.Size = New Size(68, 36)
        SubtractBtn.TabIndex = 14
        SubtractBtn.Text = "-"
        SubtractBtn.UseVisualStyleBackColor = True
        ' 
        ' AddBtn
        ' 
        AddBtn.Location = New Point(144, 202)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(68, 36)
        AddBtn.TabIndex = 15
        AddBtn.Text = "+"
        AddBtn.UseVisualStyleBackColor = True
        ' 
        ' EqualsBtn
        ' 
        EqualsBtn.Location = New Point(12, 244)
        EqualsBtn.Name = "EqualsBtn"
        EqualsBtn.Size = New Size(200, 63)
        EqualsBtn.TabIndex = 16
        EqualsBtn.Text = "="
        EqualsBtn.UseVisualStyleBackColor = True
        ' 
        ' ResultTxt
        ' 
        ResultTxt.Location = New Point(12, 12)
        ResultTxt.Name = "ResultTxt"
        ResultTxt.ReadOnly = True
        ResultTxt.Size = New Size(200, 23)
        ResultTxt.TabIndex = 18
        ' 
        ' LatestOperationTxt
        ' 
        LatestOperationTxt.Location = New Point(12, 41)
        LatestOperationTxt.Name = "LatestOperationTxt"
        LatestOperationTxt.ReadOnly = True
        LatestOperationTxt.Size = New Size(200, 23)
        LatestOperationTxt.TabIndex = 19
        ' 
        ' CalculatorForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(224, 318)
        Controls.Add(LatestOperationTxt)
        Controls.Add(ResultTxt)
        Controls.Add(EqualsBtn)
        Controls.Add(AddBtn)
        Controls.Add(SubtractBtn)
        Controls.Add(MultiplyBtn)
        Controls.Add(DivideBtn)
        Controls.Add(NineBtn)
        Controls.Add(EightBtn)
        Controls.Add(SevenBtn)
        Controls.Add(SixBtn)
        Controls.Add(FiveBtn)
        Controls.Add(FourBtn)
        Controls.Add(ThreeBtn)
        Controls.Add(TwoBtn)
        Controls.Add(OneBtn)
        Controls.Add(ClearBtn)
        Controls.Add(DecimalBtn)
        Controls.Add(ZeroBtn)
        Name = "CalculatorForm"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ZeroBtn As Button
    Friend WithEvents DecimalBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents OneBtn As Button
    Friend WithEvents TwoBtn As Button
    Friend WithEvents ThreeBtn As Button
    Friend WithEvents FourBtn As Button
    Friend WithEvents FiveBtn As Button
    Friend WithEvents SixBtn As Button
    Friend WithEvents SevenBtn As Button
    Friend WithEvents EightBtn As Button
    Friend WithEvents NineBtn As Button
    Friend WithEvents DivideBtn As Button
    Friend WithEvents MultiplyBtn As Button
    Friend WithEvents SubtractBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents EqualsBtn As Button
    Friend WithEvents ResultTxt As TextBox
    Friend WithEvents LatestOperationTxt As TextBox
End Class
