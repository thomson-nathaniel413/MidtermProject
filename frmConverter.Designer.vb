﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConverter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConverter))
        Me.picBuilding = New System.Windows.Forms.PictureBox()
        Me.lblConverter = New System.Windows.Forms.Label()
        Me.lblMeasureIndicator = New System.Windows.Forms.Label()
        Me.txtMeasure = New System.Windows.Forms.TextBox()
        Me.grpConversionType = New System.Windows.Forms.GroupBox()
        Me.radInToM = New System.Windows.Forms.RadioButton()
        Me.radMToIn = New System.Windows.Forms.RadioButton()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConversionType.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBuilding
        '
        Me.picBuilding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picBuilding.Image = CType(resources.GetObject("picBuilding.Image"), System.Drawing.Image)
        Me.picBuilding.Location = New System.Drawing.Point(11, 12)
        Me.picBuilding.Name = "picBuilding"
        Me.picBuilding.Size = New System.Drawing.Size(259, 213)
        Me.picBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBuilding.TabIndex = 0
        Me.picBuilding.TabStop = False
        '
        'lblConverter
        '
        Me.lblConverter.AutoSize = True
        Me.lblConverter.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConverter.Location = New System.Drawing.Point(334, 42)
        Me.lblConverter.Name = "lblConverter"
        Me.lblConverter.Size = New System.Drawing.Size(236, 37)
        Me.lblConverter.TabIndex = 1
        Me.lblConverter.Text = "Converter App"
        '
        'lblMeasureIndicator
        '
        Me.lblMeasureIndicator.AutoSize = True
        Me.lblMeasureIndicator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeasureIndicator.Location = New System.Drawing.Point(291, 104)
        Me.lblMeasureIndicator.Name = "lblMeasureIndicator"
        Me.lblMeasureIndicator.Size = New System.Drawing.Size(314, 20)
        Me.lblMeasureIndicator.TabIndex = 2
        Me.lblMeasureIndicator.Text = "Enter a value and choose conversion: "
        '
        'txtMeasure
        '
        Me.txtMeasure.BackColor = System.Drawing.SystemColors.Info
        Me.txtMeasure.Location = New System.Drawing.Point(632, 101)
        Me.txtMeasure.Name = "txtMeasure"
        Me.txtMeasure.Size = New System.Drawing.Size(100, 26)
        Me.txtMeasure.TabIndex = 3
        '
        'grpConversionType
        '
        Me.grpConversionType.BackColor = System.Drawing.SystemColors.Info
        Me.grpConversionType.Controls.Add(Me.radMToIn)
        Me.grpConversionType.Controls.Add(Me.radInToM)
        Me.grpConversionType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConversionType.Location = New System.Drawing.Point(359, 174)
        Me.grpConversionType.Name = "grpConversionType"
        Me.grpConversionType.Size = New System.Drawing.Size(259, 100)
        Me.grpConversionType.TabIndex = 4
        Me.grpConversionType.TabStop = False
        Me.grpConversionType.Text = "Convert Measurement"
        '
        'radInToM
        '
        Me.radInToM.AutoSize = True
        Me.radInToM.Location = New System.Drawing.Point(7, 26)
        Me.radInToM.Name = "radInToM"
        Me.radInToM.Size = New System.Drawing.Size(169, 24)
        Me.radInToM.TabIndex = 0
        Me.radInToM.TabStop = True
        Me.radInToM.Text = "Inches to Meters"
        Me.radInToM.UseVisualStyleBackColor = True
        '
        'radMToIn
        '
        Me.radMToIn.AutoSize = True
        Me.radMToIn.Location = New System.Drawing.Point(7, 56)
        Me.radMToIn.Name = "radMToIn"
        Me.radMToIn.Size = New System.Drawing.Size(169, 24)
        Me.radMToIn.TabIndex = 1
        Me.radMToIn.TabStop = True
        Me.radMToIn.Text = "Meters to Inches"
        Me.radMToIn.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(70, 357)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(200, 50)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(295, 357)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(200, 50)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(516, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(200, 50)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(366, 297)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(102, 20)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "placeholder"
        '
        'frmConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.grpConversionType)
        Me.Controls.Add(Me.txtMeasure)
        Me.Controls.Add(Me.lblMeasureIndicator)
        Me.Controls.Add(Me.lblConverter)
        Me.Controls.Add(Me.picBuilding)
        Me.Name = "frmConverter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Building Plans Conversion"
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConversionType.ResumeLayout(False)
        Me.grpConversionType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBuilding As PictureBox
    Friend WithEvents lblConverter As Label
    Friend WithEvents lblMeasureIndicator As Label
    Friend WithEvents txtMeasure As TextBox
    Friend WithEvents grpConversionType As GroupBox
    Friend WithEvents radMToIn As RadioButton
    Friend WithEvents radInToM As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResult As Label
End Class
