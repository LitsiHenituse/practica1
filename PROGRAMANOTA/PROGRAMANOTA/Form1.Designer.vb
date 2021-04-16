<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTCANTIDAD = New System.Windows.Forms.TextBox()
        Me.LSTRESPUESTAS = New System.Windows.Forms.ListBox()
        Me.CmbIniciar = New System.Windows.Forms.Button()
        Me.CmbLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CANTIDAD DE NOTAS DEL ESTUDIANTE"
        '
        'TXTCANTIDAD
        '
        Me.TXTCANTIDAD.Location = New System.Drawing.Point(286, 34)
        Me.TXTCANTIDAD.Name = "TXTCANTIDAD"
        Me.TXTCANTIDAD.Size = New System.Drawing.Size(50, 20)
        Me.TXTCANTIDAD.TabIndex = 1
        Me.TXTCANTIDAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LSTRESPUESTAS
        '
        Me.LSTRESPUESTAS.FormattingEnabled = True
        Me.LSTRESPUESTAS.Location = New System.Drawing.Point(461, 44)
        Me.LSTRESPUESTAS.Name = "LSTRESPUESTAS"
        Me.LSTRESPUESTAS.Size = New System.Drawing.Size(223, 290)
        Me.LSTRESPUESTAS.TabIndex = 2
        '
        'CmbIniciar
        '
        Me.CmbIniciar.Location = New System.Drawing.Point(265, 74)
        Me.CmbIniciar.Name = "CmbIniciar"
        Me.CmbIniciar.Size = New System.Drawing.Size(91, 33)
        Me.CmbIniciar.TabIndex = 3
        Me.CmbIniciar.Text = "Iniciar"
        Me.CmbIniciar.UseVisualStyleBackColor = True
        '
        'CmbLimpiar
        '
        Me.CmbLimpiar.Location = New System.Drawing.Point(265, 130)
        Me.CmbLimpiar.Name = "CmbLimpiar"
        Me.CmbLimpiar.Size = New System.Drawing.Size(90, 36)
        Me.CmbLimpiar.TabIndex = 4
        Me.CmbLimpiar.Text = "Limpiar"
        Me.CmbLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmbLimpiar)
        Me.Controls.Add(Me.CmbIniciar)
        Me.Controls.Add(Me.LSTRESPUESTAS)
        Me.Controls.Add(Me.TXTCANTIDAD)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXTCANTIDAD As TextBox
    Friend WithEvents LSTRESPUESTAS As ListBox
    Friend WithEvents CmbIniciar As Button
    Friend WithEvents CmbLimpiar As Button
End Class
