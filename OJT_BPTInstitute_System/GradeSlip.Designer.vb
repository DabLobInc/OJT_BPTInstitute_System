<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeSlip
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        GS_courseDesc_col_lbl = New DataGridViewTextBoxColumn()
        GS_midGrade_col_lbl = New DataGridViewTextBoxColumn()
        GS_finGrade_col_lbl = New DataGridViewTextBoxColumn()
        GS_overGrade_col_lbl = New DataGridViewTextBoxColumn()
        GS_Remarks_col_lbl = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 20)
        Label1.TabIndex = 0
        Label1.Text = "STUDENT NO:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 1
        Label2.Text = "NAME:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 20)
        Label3.TabIndex = 2
        Label3.Text = "COURSE / YR / SEC:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(420, 125)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 20)
        Label4.TabIndex = 3
        Label4.Text = "COMPANY ASSIGNED:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(420, 166)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 20)
        Label5.TabIndex = 4
        Label5.Text = "TRAINING PERIOD:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {GS_courseDesc_col_lbl, GS_midGrade_col_lbl, GS_finGrade_col_lbl, GS_overGrade_col_lbl, GS_Remarks_col_lbl})
        DataGridView1.Location = New Point(32, 227)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(738, 188)
        DataGridView1.TabIndex = 5
        ' 
        ' GS_courseDesc_col_lbl
        ' 
        GS_courseDesc_col_lbl.HeaderText = "COURSE DESCRIPTION"
        GS_courseDesc_col_lbl.MinimumWidth = 6
        GS_courseDesc_col_lbl.Name = "GS_courseDesc_col_lbl"
        GS_courseDesc_col_lbl.Width = 125
        ' 
        ' GS_midGrade_col_lbl
        ' 
        GS_midGrade_col_lbl.HeaderText = "MIDTERMS"
        GS_midGrade_col_lbl.MinimumWidth = 6
        GS_midGrade_col_lbl.Name = "GS_midGrade_col_lbl"
        GS_midGrade_col_lbl.Width = 125
        ' 
        ' GS_finGrade_col_lbl
        ' 
        GS_finGrade_col_lbl.HeaderText = "FINALS"
        GS_finGrade_col_lbl.MinimumWidth = 6
        GS_finGrade_col_lbl.Name = "GS_finGrade_col_lbl"
        GS_finGrade_col_lbl.Width = 125
        ' 
        ' GS_overGrade_col_lbl
        ' 
        GS_overGrade_col_lbl.HeaderText = "OVERALL GRADE"
        GS_overGrade_col_lbl.MinimumWidth = 6
        GS_overGrade_col_lbl.Name = "GS_overGrade_col_lbl"
        GS_overGrade_col_lbl.Width = 125
        ' 
        ' GS_Remarks_col_lbl
        ' 
        GS_Remarks_col_lbl.HeaderText = "REMARKS"
        GS_Remarks_col_lbl.MinimumWidth = 6
        GS_Remarks_col_lbl.Name = "GS_Remarks_col_lbl"
        GS_Remarks_col_lbl.Width = 125
        ' 
        ' GradeSlip
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "GradeSlip"
        Text = "GradeSlip"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GS_courseDesc_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents GS_midGrade_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents GS_finGrade_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents GS_overGrade_col_lbl As DataGridViewTextBoxColumn
    Friend WithEvents GS_Remarks_col_lbl As DataGridViewTextBoxColumn
End Class
