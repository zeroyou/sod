﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm12306Ticket
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnTestJS = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ckbToStation = New System.Windows.Forms.CheckBox()
        Me.ckbFromStation = New System.Windows.Forms.CheckBox()
        Me.txtToStation = New System.Windows.Forms.TextBox()
        Me.txtFromStation = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.linkMsg = New System.Windows.Forms.LinkLabel()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.btnOpenUrl2 = New System.Windows.Forms.Button()
        Me.btnOpenUrl = New System.Windows.Forms.Button()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.panBody = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.lblTime)
        Me.panel1.Controls.Add(Me.btnTestJS)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.ckbToStation)
        Me.panel1.Controls.Add(Me.ckbFromStation)
        Me.panel1.Controls.Add(Me.txtToStation)
        Me.panel1.Controls.Add(Me.txtFromStation)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Controls.Add(Me.linkMsg)
        Me.panel1.Controls.Add(Me.lblMsg)
        Me.panel1.Controls.Add(Me.btnOpenUrl2)
        Me.panel1.Controls.Add(Me.btnOpenUrl)
        Me.panel1.Controls.Add(Me.txtUrl)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1335, 170)
        Me.panel1.TabIndex = 2
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(748, 18)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(44, 18)
        Me.lblTime.TabIndex = 15
        Me.lblTime.Text = "时间"
        '
        'btnTestJS
        '
        Me.btnTestJS.Location = New System.Drawing.Point(1186, 10)
        Me.btnTestJS.Name = "btnTestJS"
        Me.btnTestJS.Size = New System.Drawing.Size(112, 34)
        Me.btnTestJS.TabIndex = 14
        Me.btnTestJS.Text = "检查脚本"
        Me.btnTestJS.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(26, 76)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(629, 18)
        Me.label1.TabIndex = 13
        Me.label1.Text = "填写并启用备用站点，增加成功率，比如北京站可以填写备用站点为 北京西。"
        '
        'ckbToStation
        '
        Me.ckbToStation.AutoSize = True
        Me.ckbToStation.Location = New System.Drawing.Point(1000, 70)
        Me.ckbToStation.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbToStation.Name = "ckbToStation"
        Me.ckbToStation.Size = New System.Drawing.Size(124, 22)
        Me.ckbToStation.TabIndex = 12
        Me.ckbToStation.Text = "备用目的地"
        Me.ckbToStation.UseVisualStyleBackColor = True
        '
        'ckbFromStation
        '
        Me.ckbFromStation.AutoSize = True
        Me.ckbFromStation.Location = New System.Drawing.Point(706, 70)
        Me.ckbFromStation.Margin = New System.Windows.Forms.Padding(4)
        Me.ckbFromStation.Name = "ckbFromStation"
        Me.ckbFromStation.Size = New System.Drawing.Size(124, 22)
        Me.ckbFromStation.TabIndex = 11
        Me.ckbFromStation.Text = "备用出发地"
        Me.ckbFromStation.UseVisualStyleBackColor = True
        '
        'txtToStation
        '
        Me.txtToStation.Location = New System.Drawing.Point(1150, 63)
        Me.txtToStation.Margin = New System.Windows.Forms.Padding(4)
        Me.txtToStation.Name = "txtToStation"
        Me.txtToStation.Size = New System.Drawing.Size(148, 28)
        Me.txtToStation.TabIndex = 10
        '
        'txtFromStation
        '
        Me.txtFromStation.Location = New System.Drawing.Point(842, 63)
        Me.txtFromStation.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFromStation.Name = "txtFromStation"
        Me.txtFromStation.Size = New System.Drawing.Size(148, 28)
        Me.txtFromStation.TabIndex = 9
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(893, 18)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(134, 18)
        Me.label2.TabIndex = 6
        Me.label2.Text = "刷新间隔（秒）"
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(1035, 13)
        Me.numericUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(56, 28)
        Me.numericUpDown1.TabIndex = 5
        Me.numericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'linkMsg
        '
        Me.linkMsg.AutoSize = True
        Me.linkMsg.Location = New System.Drawing.Point(1099, 18)
        Me.linkMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkMsg.Name = "linkMsg"
        Me.linkMsg.Size = New System.Drawing.Size(80, 18)
        Me.linkMsg.TabIndex = 4
        Me.linkMsg.TabStop = True
        Me.linkMsg.Text = "使用说明"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(26, 117)
        Me.lblMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(1169, 36)
        Me.lblMsg.TabIndex = 3
        Me.lblMsg.Text = "12306自助购票弹窗程序，可以开启本程序后进行其它工作，甚至在电脑关闭声音的情况下，及时通知有票信息。单击【开始刷票】按钮开始操作。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "请在购票网页中登录并输入" & _
    "你的购票信息，开启自动提交功能。"
        '
        'btnOpenUrl2
        '
        Me.btnOpenUrl2.Location = New System.Drawing.Point(629, 10)
        Me.btnOpenUrl2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpenUrl2.Name = "btnOpenUrl2"
        Me.btnOpenUrl2.Size = New System.Drawing.Size(112, 34)
        Me.btnOpenUrl2.TabIndex = 2
        Me.btnOpenUrl2.Text = "开始刷票"
        Me.btnOpenUrl2.UseVisualStyleBackColor = True
        '
        'btnOpenUrl
        '
        Me.btnOpenUrl.Location = New System.Drawing.Point(509, 10)
        Me.btnOpenUrl.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpenUrl.Name = "btnOpenUrl"
        Me.btnOpenUrl.Size = New System.Drawing.Size(112, 34)
        Me.btnOpenUrl.TabIndex = 1
        Me.btnOpenUrl.Text = "打开测试页"
        Me.btnOpenUrl.UseVisualStyleBackColor = True
        '
        'txtUrl
        '
        Me.txtUrl.Location = New System.Drawing.Point(28, 15)
        Me.txtUrl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(473, 28)
        Me.txtUrl.TabIndex = 0
        Me.txtUrl.Text = "TestHtml.html"
        '
        'panBody
        '
        Me.panBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panBody.Location = New System.Drawing.Point(0, 170)
        Me.panBody.Margin = New System.Windows.Forms.Padding(4)
        Me.panBody.Name = "panBody"
        Me.panBody.Size = New System.Drawing.Size(1335, 610)
        Me.panBody.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frm12306Ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 780)
        Me.Controls.Add(Me.panBody)
        Me.Controls.Add(Me.panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm12306Ticket"
        Me.Text = "frm12306Ticket"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents label1 As Label
    Private WithEvents ckbToStation As CheckBox
    Private WithEvents ckbFromStation As CheckBox
    Private WithEvents txtToStation As TextBox
    Private WithEvents txtFromStation As TextBox
    Private WithEvents label2 As Label
    Private WithEvents numericUpDown1 As NumericUpDown
    Private WithEvents linkMsg As LinkLabel
    Private WithEvents lblMsg As Label
    Private WithEvents btnOpenUrl2 As Button
    Private WithEvents btnOpenUrl As Button
    Private WithEvents txtUrl As TextBox
    Friend WithEvents panBody As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnTestJS As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
End Class
