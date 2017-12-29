<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioDiv = New System.Windows.Forms.RadioButton()
        Me.radioMult = New System.Windows.Forms.RadioButton()
        Me.radioSub = New System.Windows.Forms.RadioButton()
        Me.radioAdd = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCorrectAnswer = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCheckYourAnswer = New System.Windows.Forms.Button()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lblNumbers = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.radioDiv)
        Me.GroupBox1.Controls.Add(Me.radioMult)
        Me.GroupBox1.Controls.Add(Me.radioSub)
        Me.GroupBox1.Controls.Add(Me.radioAdd)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(531, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose An Integer Operation"
        '
        'radioDiv
        '
        Me.radioDiv.AutoSize = True
        Me.radioDiv.Location = New System.Drawing.Point(429, 37)
        Me.radioDiv.Name = "radioDiv"
        Me.radioDiv.Size = New System.Drawing.Size(85, 25)
        Me.radioDiv.TabIndex = 3
        Me.radioDiv.TabStop = True
        Me.radioDiv.Text = "Division"
        Me.radioDiv.UseVisualStyleBackColor = True
        '
        'radioMult
        '
        Me.radioMult.AutoSize = True
        Me.radioMult.Location = New System.Drawing.Point(275, 37)
        Me.radioMult.Name = "radioMult"
        Me.radioMult.Size = New System.Drawing.Size(134, 25)
        Me.radioMult.TabIndex = 2
        Me.radioMult.TabStop = True
        Me.radioMult.Text = "Multiplication"
        Me.radioMult.UseVisualStyleBackColor = True
        '
        'radioSub
        '
        Me.radioSub.AutoSize = True
        Me.radioSub.Location = New System.Drawing.Point(136, 37)
        Me.radioSub.Name = "radioSub"
        Me.radioSub.Size = New System.Drawing.Size(120, 25)
        Me.radioSub.TabIndex = 1
        Me.radioSub.TabStop = True
        Me.radioSub.Text = "Subtraction"
        Me.radioSub.UseVisualStyleBackColor = True
        '
        'radioAdd
        '
        Me.radioAdd.AutoSize = True
        Me.radioAdd.Location = New System.Drawing.Point(23, 37)
        Me.radioAdd.Name = "radioAdd"
        Me.radioAdd.Size = New System.Drawing.Size(96, 25)
        Me.radioAdd.TabIndex = 0
        Me.radioAdd.TabStop = True
        Me.radioAdd.Text = "Addition"
        Me.radioAdd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox2.Controls.Add(Me.lblCorrectAnswer)
        Me.GroupBox2.Controls.Add(Me.btnNext)
        Me.GroupBox2.Controls.Add(Me.btnCheckYourAnswer)
        Me.GroupBox2.Controls.Add(Me.txtUserInput)
        Me.GroupBox2.Controls.Add(Me.lblNumbers)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(36, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(531, 162)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'lblCorrectAnswer
        '
        Me.lblCorrectAnswer.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblCorrectAnswer.Location = New System.Drawing.Point(21, 111)
        Me.lblCorrectAnswer.Name = "lblCorrectAnswer"
        Me.lblCorrectAnswer.Size = New System.Drawing.Size(286, 23)
        Me.lblCorrectAnswer.TabIndex = 5
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LightBlue
        Me.btnNext.Location = New System.Drawing.Point(332, 102)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(180, 32)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next Problem"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnCheckYourAnswer
        '
        Me.btnCheckYourAnswer.BackColor = System.Drawing.Color.LightBlue
        Me.btnCheckYourAnswer.Location = New System.Drawing.Point(332, 62)
        Me.btnCheckYourAnswer.Name = "btnCheckYourAnswer"
        Me.btnCheckYourAnswer.Size = New System.Drawing.Size(180, 34)
        Me.btnCheckYourAnswer.TabIndex = 3
        Me.btnCheckYourAnswer.Text = "Check Your Answer"
        Me.btnCheckYourAnswer.UseVisualStyleBackColor = False
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(209, 62)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(98, 27)
        Me.txtUserInput.TabIndex = 2
        '
        'lblNumbers
        '
        Me.lblNumbers.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumbers.Location = New System.Drawing.Point(25, 62)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(167, 27)
        Me.lblNumbers.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(21, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please type in your answer to the following math problem. Integer answera only."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(602, 281)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Integer Math Tutor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radioDiv As RadioButton
    Friend WithEvents radioMult As RadioButton
    Friend WithEvents radioSub As RadioButton
    Friend WithEvents radioAdd As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnCheckYourAnswer As Button
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents lblNumbers As Label
    Friend WithEvents Label1 As Label
    Private WithEvents lblCorrectAnswer As Label
End Class
