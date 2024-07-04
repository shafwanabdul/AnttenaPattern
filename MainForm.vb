Option Explicit On
Imports System.Drawing
Imports System.IO
Imports System.IO.Ports
Imports System.Math
Imports System.Net.Sockets
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Word
Public Class FormDirect
    Dim clientSocket As New System.Net.Sockets.TcpClient
    Dim serverStream As NetworkStream
    Dim colors() As Color = {Color.SandyBrown, Color.SandyBrown, Color.SandyBrown, Color.SandyBrown, Color.SandyBrown, Color.SandyBrown, Color.SandyBrown, Color.SandyBrown}
    Dim outStream() As Byte
    Dim result As String = ""
    Dim Xaxmin, Xaxmax, Yaxmax, Yaxmin, FCval As Double
    Dim APGain(360) As Double
    Dim APPower(360) As Double
    Dim TCPconnected, TTconneced, dataexist, testingenable As Boolean
    Dim APangle, waittime, FRbw As Integer
    Dim bmp As New Bitmap(410, 410)
    Dim dataap(360) As Single
    Dim tempAPGain(360) As String
    Dim RegisteredSPA As String = "DSA8E261100012"
    Private currentFreq As Single
    Private Sub FormDirect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CHAPP.ChartAreas.Clear()
        CHAPP.ChartAreas.Add("AntennaPattern")
        With CHAPP.ChartAreas("AntennaPattern")
            .AxisX.Title = ""
            .AxisX.Interval = 20
            .AxisX.IsMarginVisible = True
            .AxisX.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.MajorGrid.LineColor = Color.SkyBlue
            .AxisY.Title = ""
            .AxisY.Interval = 10
            .AxisY.Maximum = 20
            .AxisY.Minimum = -120
        End With
        CHAPP.Series.Clear()
        CHAPP.Series.Add("Antenna Pattern")
        With CHAPP.Series(0)
            .BorderWidth = 3
            .Color = Color.Red
            .IsVisibleInLegend = False
            .ChartType = DataVisualization.Charting.SeriesChartType.Polar
        End With
        TCPconnected = False
        CBAttenuatorInt.SelectedIndex = 10
        Me.CBmaxYax.SelectedIndex = 0
        Me.CBminYax.SelectedIndex = 20
        Me.CBPolAPYmax.SelectedItem = 0
        CBPolAPYmin.SelectedIndex = 20
        CBRL.SelectedIndex = 0
        CBStepSize.SelectedIndex = 0
        CBRBW.SelectedIndex = 0
        Load_Setting()
        TimerCheck.Enabled = False
        BSetCorr.Enabled = True
        BSetSPACtrl.Enabled = False
        BTTCCW.Enabled = False
        BReleaseMotor.Enabled = False
        BTTCW.Enabled = False
        BTT180.Enabled = False
        BTT0.Enabled = False
        BTTSetCent.Enabled = False
        BConTT.Enabled = False
        CBStepSize.SelectedIndex = 0
        APTB.Text = "Angle(degree); Antenna Gain(dBi)" & vbCrLf
        For filmag As Integer = 0 To 360
            APGain(filmag) = -120
        Next
        FCval = 1000000
        BStopAP.Enabled = False
        BAntPattern.Enabled = False
        For i = 0 To 359 Step 1
            CHAPP.Series(0).Points.AddXY(i, -120)
            APGain(i) = -120
            tempAPGain(i) = CStr(-120)
        Next
        PlotAP(tempAPGain)
    End Sub

    Private Sub tipshelp(sender As Object, ByVal infotitle As String, ByVal infohelp As String)
        Dim buttonToolTip As New ToolTip()
        buttonToolTip.ToolTipTitle = infotitle
        buttonToolTip.UseFading = True
        buttonToolTip.UseAnimation = True
        buttonToolTip.IsBalloon = True
        buttonToolTip.ShowAlways = True
        buttonToolTip.AutoPopDelay = 2000
        buttonToolTip.InitialDelay = 1000
        buttonToolTip.ReshowDelay = 2200
        buttonToolTip.IsBalloon = True
        buttonToolTip.SetToolTip(CType(sender, Control), infohelp)
    End Sub
    Private Function SendTCP(ByVal CMD As String)
        TS_ETH_TX.Text = CMD
        If clientSocket.Connected = True Then
            clientSocket.ReceiveBufferSize = 200000
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream() As Byte = System.Text.Encoding.ASCII.GetBytes(CMD & vbCrLf)
            Dim inStream(clientSocket.ReceiveBufferSize) As Byte
            Dim StrList(65535) As String
            Dim returndata As String = ""
            serverStream.ReadTimeout = 1000
            serverStream.Write(outStream, 0, outStream.Length)
            returndata = ""
            Threading.Thread.Sleep(750)
            While serverStream.DataAvailable
                serverStream.Read(inStream, 0, inStream.GetUpperBound(0))
                returndata = returndata & String.Concat(returndata, Encoding.ASCII.GetString(inStream))
            End While
            StrList = returndata.Split(CChar(","))
            If StrList.Length = 601 Then
                dataexist = True
                TSrtxstat.Text = "SPA Link Status: OK"
            Else
                TSrtxstat.Text = "SPA Link Status: truncated"
            End If
            Return StrList
        Else
            dataexist = False
            TSrtxstat.Text = "SPA Link Status: Fail"
        End If
        Return 0
    End Function
    Public Sub BConnect_Click_1(sender As Object, e As EventArgs) Handles BConnect.Click
        If Not clientSocket.Connected Then
            clientSocket.Connect(TextIP.Text, CInt(Val(Val(TextPort.Text))))
            If CheckSN(1) < 1 Then
                MsgBox("License not Valid" & vbCrLf & "Licensed to RIGOL DSA-875-TG" & vbCrLf & RegisteredSPA)
                End
            End If
            SendcommandTCP("*RST")
            BConnect.Enabled = False
            If clientSocket.Connected Then
                TCPconnected = True
                BAntPattern.Enabled = True
                BSetCorr.Enabled = True
                BSetSPACtrl.Enabled = True
            End If
        End If
    End Sub
    Private Function SendcommandTCP(ByVal CMD As String)
        TS_ETH_TX.Text = CMD
        Dim serverStream As NetworkStream = clientSocket.GetStream()
        Dim inStream2(clientSocket.ReceiveBufferSize) As Byte
        outStream = System.Text.Encoding.ASCII.GetBytes(CMD & vbCrLf)
        serverStream.Write(outStream, 0, outStream.Length)
        While serverStream.DataAvailable
            serverStream.Read(inStream2, 0, CInt(Val(clientSocket.ReceiveBufferSize)))
        End While
        Threading.Thread.Sleep(750)
        Return 0
    End Function
    Private Function CheckSN(void) As Integer
        TS_ETH_TX.Text = "*IDN?"
        If clientSocket.Connected = True Then
            clientSocket.ReceiveBufferSize = 2000000
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream() As Byte = System.Text.Encoding.ASCII.GetBytes("*IDN?" & vbCrLf)
            Dim inStream(clientSocket.ReceiveBufferSize) As Byte
            Dim StrList(65535) As String
            Dim StatusLic As Integer
            Dim returndata As String = ""
            StatusLic = 0
            serverStream.ReadTimeout = 1000
            serverStream.Write(outStream, 0, outStream.Length)
            returndata = ""
            Threading.Thread.Sleep(500)
            While serverStream.DataAvailable
                serverStream.Read(inStream, 0, inStream.GetUpperBound(0))
                returndata = returndata & String.Concat(returndata, Encoding.ASCII.GetString(inStream))
            End While
            StatusLic = InStr(returndata, RegisteredSPA)
            If StatusLic = 0 Then Return 0
            Return 1
        End If
    End Function

    Private Function PlotAP(ByVal XYval() As String)
        Dim x(362) As Double
        Dim i As Integer
        ZedGraphAP.IsShowPointValues = True
        If XYval IsNot Nothing Then
            For i = 0 To 360
                x(i) = i
            Next
            APGain(APangle) = CDbl(Val(XYval(150)))
        End If
        Dim myPane As GraphPane = ZedGraphAP.GraphPane
        myPane.CurveList.Clear()
        ZedGraphAP.GraphPane.AddCurve("Power VS Angle", x, APGain, Color.DarkGreen, ZedGraph.SymbolType.VDash)
        ZedGraphAP.Invalidate()
        ZedGraphAP.GraphPane.IsShowTitle = False
        ZedGraphAP.GraphPane.XAxis.Title = "Degree"
        ZedGraphAP.GraphPane.YAxis.Title = "Gain(dBi)"
        ZedGraphAP.GraphPane.YAxis.Max = Yaxmax
        ZedGraphAP.GraphPane.YAxis.Min = Yaxmin
        ZedGraphAP.GraphPane.XAxis.ScaleMag = 0
        ZedGraphAP.AxisChange()
        ZedGraphAP.GraphPane.XAxis.Max = 360
        Return 0
    End Function
    Private Function PlotAPReal(ByVal XYval() As Double)
        Dim x(362) As Double
        Dim i As Integer
        ZedGraphAP.IsShowPointValues = True
        If XYval IsNot Nothing Then
            For i = 0 To 360
                x(i) = i
            Next
            APGain(APangle) = CDbl(Val(XYval(150)))
        End If
        Dim myPane As GraphPane = ZedGraphAP.GraphPane
        myPane.CurveList.Clear()
        ZedGraphAP.GraphPane.AddCurve("Power VS Angle", x, APGain, Color.DarkGreen, ZedGraph.SymbolType.VDash)
        ZedGraphAP.Invalidate()
        ZedGraphAP.GraphPane.IsShowTitle = False
        ZedGraphAP.GraphPane.XAxis.Title = "Degree"
        ZedGraphAP.GraphPane.YAxis.Title = "Gain(dBi)"
        ZedGraphAP.GraphPane.YAxis.Max = Yaxmax
        ZedGraphAP.GraphPane.YAxis.Min = Yaxmin
        ZedGraphAP.GraphPane.XAxis.ScaleMag = 0
        ZedGraphAP.AxisChange()
        ZedGraphAP.GraphPane.XAxis.Max = 360
        Return 0
    End Function

    Private Sub TimerAntennaPattern_Tick(sender As Object, e As EventArgs) Handles TimerAntennaPattern.Tick
        Dim tempdata As String
        tempdata = SendTCP(":TRACe:DATA? TRACE1")(150)
        APGain(APangle) = Val(tempdata) + Val(TBFSL.Text) - Val(TBCorFac.Text) - Val(CBTGLvl.SelectedItem)
        APTB.Text = APTB.Text & APangle & ";" & Val(tempdata) & vbCrLf
        If CBStepSize.SelectedIndex = 0 Then
            SendCommand("CW1")
            APGain(360) = APGain(0)
            APGain(359) = APGain(0)
            APangle = APangle + 1
        End If
        If CBStepSize.SelectedIndex = 1 Then
            SendCommand("CW5")
            APGain(360) = APGain(0)
            APGain(359) = APGain(0)
            For i = 0 To 355 Step 5
                If CBStepSize.SelectedIndex = 1 Then
                    APGain(i + 1) = (((APGain(i + 5) - APGain(i)) / 5) * 1) + APGain(i)
                    APGain(i + 2) = (((APGain(i + 5) - APGain(i)) / 5) * 2) + APGain(i)
                    APGain(i + 3) = (((APGain(i + 5) - APGain(i)) / 5) * 3) + APGain(i)
                    APGain(i + 4) = (((APGain(i + 5) - APGain(i)) / 5) * 4) + APGain(i)
                End If
            Next
            APangle = APangle + 5
        End If
        LAngle.Text = APangle
        CHAPP.Series(0).Points.Clear()
        For i = 0 To 360 Step 1
            CHAPP.Series(0).Points.AddXY(i, APGain(i))
        Next
        CHAPP.Update()
        PlotAPReal(APGain)
        AutoscalePolar(1)
        If APangle > (359) Then
            APangle = 0
            TimerAntennaPattern.Enabled = False
            TimerAntennaPattern.Stop()
            MsgBox("PENGUKURAN SELESAI " & vbCrLf & " tunggu turn table posisi kembali ke sudut 0 ")
            testingenable = False
            APangle = 0
            SendCommand("Zero")
            LAngle.Text = APangle
            BTTCCW.Enabled = False
            BTTCW.Enabled = True
            Return
        End If
    End Sub

    Sub Load_Setting()
        'text
        My.Settings.Reload()
        TextIP.Text = My.Settings.APTextIP
        TextPort.Text = My.Settings.APTextPort
        TBFStart.Text = My.Settings.APTBFCent
        TBAF.Text = My.Settings.APTBAF
        TBAntCorr.Text = My.Settings.APTBAntCorr
        TBCableCorr.Text = My.Settings.APTBCableCorr
        TBAmpCorr.Text = My.Settings.APTBAmpCorr
        TBUserCorr.Text = My.Settings.APTBUserCorr
        TBNamaDUT.Text = My.Settings.APTBNamaDUT
        TBMerekDUT.Text = My.Settings.APTBMerekDUT
        TBNoSeri.Text = My.Settings.APTBNoSeri
        TBTipeDUT.Text = My.Settings.APTBTipeDUT
        TBOperator.Text = My.Settings.APTBOperator
        TBKomentar.Text = My.Settings.APTBKomentar
        'Checklist Box
        CBTG.Checked = My.Settings.APCBTG
        CBTTH.Checked = My.Settings.APCBTTH
        CLIncludeTable.Checked = My.Settings.APCLIncludeTable
        'Combo Box
        CBRL.SelectedIndex = My.Settings.APCBRL
        CBRBW.SelectedIndex = My.Settings.APCBRBW
        CBTGLvl.SelectedIndex = My.Settings.APCBTGLvl
        CBAttenuatorInt.SelectedIndex = My.Settings.APCBAttenuatorInt
        CBStepSize.SelectedIndex = My.Settings.APCBStepSize
    End Sub
    Private Sub SaveSettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveSettingToolStripMenuItem.Click
        My.Settings.APTextIP = TextIP.Text
        My.Settings.APTextPort = TextPort.Text
        My.Settings.APTBFCent = TBFStart.Text
        My.Settings.APTBAF = TBAF.Text
        My.Settings.APTBAntCorr = TBAntCorr.Text
        My.Settings.APTBCableCorr = TBCableCorr.Text
        My.Settings.APTBAmpCorr = TBAmpCorr.Text
        My.Settings.APTBUserCorr = TBUserCorr.Text
        My.Settings.APTBNamaDUT = TBNamaDUT.Text
        My.Settings.APTBMerekDUT = TBMerekDUT.Text
        My.Settings.APTBNoSeri = TBNoSeri.Text
        My.Settings.APTBTipeDUT = TBTipeDUT.Text
        My.Settings.APTBOperator = TBOperator.Text
        My.Settings.APTBKomentar = TBKomentar.Text
        'Checklist Box
        My.Settings.APCBTG = CBTG.Checked
        My.Settings.APCBTTH = CBTTH.Checked
        My.Settings.APCLIncludeTable = CLIncludeTable.Checked
        'Combo Box
        My.Settings.APCBRL = CBRL.SelectedIndex
        My.Settings.APCBRBW = CBRBW.SelectedIndex
        My.Settings.APCBTGLvl = CBTGLvl.SelectedIndex
        My.Settings.APCBAttenuatorInt = CBAttenuatorInt.SelectedIndex
        My.Settings.APCBStepSize = CBStepSize.SelectedIndex

        My.Settings.Save()
    End Sub
    Private Sub ExitToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem2.Click
        Dispose()
        End
    End Sub
    Private Sub TimerCheck_Tick(sender As Object, e As EventArgs) Handles TimerCheck.Tick
        If TTconneced = True Then
            BTT180.Enabled = True
            BTT0.Enabled = True
            BTTSetCent.Enabled = True
            BReleaseMotor.Enabled = True
            If APangle < (361 - Val(CBStepSize.SelectedItem)) Then
                BTTCW.Enabled = True
            End If
            If APangle > Val(CBStepSize.SelectedItem) - 1 Then
                BTTCCW.Enabled = True
            End If
            If APangle > (360 - Val(CBStepSize.SelectedItem)) Then
                BTTCW.Enabled = False
            End If
            If APangle < Val(CBStepSize.SelectedItem) Then
                BTTCCW.Enabled = False
            End If
        End If
        If TTconneced = False Or testingenable = True Then
            BTTCCW.Enabled = False
            BTTCW.Enabled = False
            BTT180.Enabled = False
            BTT0.Enabled = False
            BTTSetCent.Enabled = False
            BReleaseMotor.Enabled = False
        End If
    End Sub
    Private Sub BRptClr_Click(sender As Object, e As EventArgs) Handles BRptClr.Click
        APTB.Text = "Angle(degree); Gain(dBi)" & vbCrLf
    End Sub
    Private Sub BSaveReport_Click(sender As Object, e As EventArgs) Handles BSaveReport.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim extentionstr As String
        extentionstr = ""
        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|CSV files (*.csv)|*.|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.FilterIndex = 1 Then extentionstr = ".txt"
        If saveFileDialog1.FilterIndex = 2 Then extentionstr = ".csv"
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            saveFileDialog1.FileName = saveFileDialog1.FileName & extentionstr
            Dim sw As StreamWriter = New StreamWriter(saveFileDialog1.OpenFile())
            If (sw IsNot Nothing) Then
                sw.WriteLine(APTB.Text)
                sw.Close()
            End If
        End If
    End Sub
    Private Sub BAPRport_Click(sender As Object, e As EventArgs) Handles BAPRport.Click
        Dim oWord As Microsoft.Office.Interop.Word.Application
        Dim oDoc As Microsoft.Office.Interop.Word.Document
        Dim oTable As Microsoft.Office.Interop.Word.Table
        Dim oPara1, oPara2, oPara3 As Microsoft.Office.Interop.Word.Paragraph
        Dim oRng As Microsoft.Office.Interop.Word.Range
        Dim freqkerja As Single
        Dim satuan As String
        satuan = " KHz"
        freqkerja = FCval
        If freqkerja > 1000 Then
            freqkerja = freqkerja / 1000
            satuan = " MHz"
        End If
        If freqkerja > 1000 Then
            freqkerja = freqkerja / 1000
            satuan = " GHz"
        End If
        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add
        'Insert a paragraph at the beginning of the document.
        oPara1 = oDoc.Content.Paragraphs.Add
        oPara1.Range.Font.Size = 24
        oPara1.Range.Text = "******  ANTENNA PATTERN REPORT   ******" & vbCrLf & vbCrLf
        oPara1.Format.SpaceAfter = 0
        oPara1.Range.Font.Bold = 1
        oPara1.Format.Alignment = WdParagraphAlignment.wdAlignParagraphLeft
        oPara1.Range.InsertParagraphAfter()
        'Insert a paragraph at the end of the document. 
        oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara2.Format.Alignment = WdParagraphAlignment.wdAlignParagraphLeft
        oPara2.Range.Text = "Measurement Date and Time : " & Date.Now
        oPara2.Range.Text = oPara2.Range.Text & "Test Frequency     : " & freqkerja.ToString("#,##0.00") & satuan
        oPara2.Range.Text = oPara2.Range.Text & "Device Under Test  : " & TBNamaDUT.Text
        oPara2.Range.Text = oPara2.Range.Text & "Brand      : " & TBMerekDUT.Text
        oPara2.Range.Text = oPara2.Range.Text & "Type       : " & TBTipeDUT.Text
        oPara2.Range.Text = oPara2.Range.Text & "Serial     : " & TBNoSeri.Text
        oPara2.Range.Text = oPara2.Range.Text & "Operator   : " & TBOperator.Text
        oPara2.Range.Text = oPara2.Range.Text & "Comment    : " & TBKomentar.Text & vbCr & vbCr & vbCr
        oPara2.Format.SpaceAfter = 0
        oPara2.Range.InsertParagraphAfter()
        CHAPP.DrawToBitmap(bmp, New System.Drawing.Rectangle(0, 0, CHAPP.Width * 2, CHAPP.Height * 2))
        Clipboard.SetImage(bmp)
        ' bmp.Dispose()
        oRng = oDoc.Bookmarks.Item("\endofdoc").Range
        oRng.Paste()
        oDoc.Bookmarks.Item("\endofdoc").Range.InsertParagraphAfter()
        'Add text after the chart.
        oRng = oDoc.Bookmarks.Item("\endofdoc").Range
        oRng.InsertParagraphAfter()
        oRng.Paste()
        oPara3 = oDoc.Content.Paragraphs.Add
        oPara3.Range.InsertParagraphAfter()
        oPara3.Range.Font.Size = 12
        oPara3.Range.Text = "Picture 1 (Radiation Pattern In Polar Chart)" & vbCrLf & vbCrLf
        oPara3.Format.SpaceAfter = 0
        oPara3.Range.InsertParagraphAfter()
        Dim bmp2 As New Bitmap(ZedGraphAP.GraphPane.Image.Width, ZedGraphAP.GraphPane.Image.Height)
        DrawToBitmap(bmp2, New System.Drawing.Rectangle(0, 0, ZedGraphAP.GraphPane.Image.Width, ZedGraphAP.GraphPane.Image.Height))
        bmp2 = ZedGraphAP.GraphPane.Image
        Dim bmp3 As New Bitmap(ZedFAF.GraphPane.Image.Width, ZedFAF.GraphPane.Image.Height)
        DrawToBitmap(bmp2, New System.Drawing.Rectangle(0, 0, ZedFAF.GraphPane.Image.Width, ZedFAF.GraphPane.Image.Height))
        bmp3 = ZedFAF.GraphPane.Image
        Clipboard.SetImage(bmp2)
        bmp2.Dispose()
        oRng = oDoc.Bookmarks.Item("\endofdoc").Range
        oRng.Paste()
        oDoc.Bookmarks.Item("\endofdoc").Range.InsertParagraphAfter()
        oRng = oDoc.Bookmarks.Item("\endofdoc").Range
        oRng.InsertParagraphAfter()
        oRng.Paste()
        oPara3 = oDoc.Content.Paragraphs.Add
        oPara3.Range.InsertParagraphAfter()
        oPara3.Range.Font.Size = 12
        oPara3.Range.Text = "Picture 2 (Radiation Pattern In Cartesian Chart)" & vbCrLf & vbCrLf
        oPara3.Format.SpaceAfter = 0
        oPara3.Range.InsertParagraphAfter()

        If CLIncludeTable.Checked Then
            oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
            oPara3.Range.Text = "Antenna Pattern Angle vs Gain (normalized) in dBi"
            oPara3.Range.Font.Bold = 0
            oPara3.Format.SpaceAfter = 5
            oPara3.Range.InsertParagraphAfter()
            Dim r As Integer
            oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 61, 12, , AutoFitBehavior:=True)
            ' oTable.Range.Font.Size=10
            oTable.Columns.Width = 40
            oTable.Borders.Enable = 1
            oTable.Range.ParagraphFormat.SpaceAfter = 6
            oTable.Cell(1, 1).Range.Text = "Angle"
            oTable.Cell(1, 2).Range.Text = "Gain"
            For r = 2 To 61
                oTable.Cell(r, 1).Range.Text = CStr(r - 1)
                oTable.Cell(r, 2).Range.Text = FormatNumber(CStr(APGain(r - 1)), 1, TriState.False, , TriState.True)
                oTable.Cell(r, 1).Range.Italic = 1
            Next
            oTable.Cell(1, 3).Range.Text = "Angle"
            oTable.Cell(1, 4).Range.Text = "Gain"
            For r = 62 To 121
                oTable.Cell(r - 60, 3).Range.Text = CStr(r - 1)
                oTable.Cell(r - 60, 4).Range.Text = FormatNumber(CStr(APGain(r - 1)), 1, TriState.False, , TriState.True)
                oTable.Cell(r - 60, 3).Range.Italic = 1
            Next
            oTable.Cell(1, 5).Range.Text = "Angle"
            oTable.Cell(1, 6).Range.Text = "Gain"
            For r = 122 To 181
                oTable.Cell(r - 120, 5).Range.Text = CStr(r - 1)
                oTable.Cell(r - 120, 6).Range.Text = FormatNumber(CStr(APGain(r - 1)), 1, TriState.False, , TriState.True)
                oTable.Cell(r - 120, 5).Range.Italic = 1
            Next
            oTable.Cell(1, 7).Range.Text = "Angle"
            oTable.Cell(1, 8).Range.Text = "Gain"
            For r = 182 To 241
                oTable.Cell(r - 180, 7).Range.Text = CStr(r - 1)
                oTable.Cell(r - 180, 8).Range.Text = FormatNumber(CStr(APGain(r - 1)), 1, TriState.False, , TriState.True)
                oTable.Cell(r - 180, 7).Range.Italic = 1
            Next
            oTable.Cell(1, 9).Range.Text = "Angle"
            oTable.Cell(1, 10).Range.Text = "Gain"
            For r = 242 To 301
                oTable.Cell(r - 240, 9).Range.Text = CStr(r - 1)
                oTable.Cell(r - 240, 10).Range.Text = FormatNumber(CStr(APGain(r - 1)), 1, TriState.False, , TriState.True)
                oTable.Cell(r - 240, 9).Range.Italic = 1
            Next
            oTable.Cell(1, 11).Range.Text = "Angle"
            oTable.Cell(1, 12).Range.Text = "Gain"
            For r = 302 To 361
                oTable.Cell(r - 300, 11).Range.Text = CStr(r - 1)
                oTable.Cell(r - 300, 12).Range.Text = FormatNumber(CStr(APGain(r - 1)), 1, TriState.False, , TriState.True)
                oTable.Cell(r - 300, 11).Range.Italic = 1
            Next
            oTable.Rows.Item(1).Range.Font.Bold = 1
            oTable.Columns.AutoFit()
        End If
    End Sub

    Private Sub BConTT_Click(sender As Object, e As EventArgs) Handles BConTT.Click
        If (OpenComPort() > 0) Then
            TTconneced = True
            BConTT.Enabled = False
            TimerCheck.Enabled = True
            Statusbarcon.Text = "Antenna Mast Connected"
        End If
    End Sub
    Private Sub BTT0_Click(sender As Object, e As EventArgs) Handles BTT0.Click
        APangle = 0
        SendCommand("Zero")
        LAngle.Text = APangle
        BTTCCW.Enabled = False
        BTTCW.Enabled = True
    End Sub
    Private Sub BTT180_Click(sender As Object, e As EventArgs) Handles BTT180.Click
        APangle = 180
        SendCommand("Center")
        LAngle.Text = APangle
        BTTCW.Enabled = True
        BTTCCW.Enabled = True
    End Sub
    Private Sub BTTCW_Click(sender As Object, e As EventArgs) Handles BTTCW.Click
        If APangle < 360 Then
            If CBStepSize.SelectedIndex = 0 Then
                SendCommand("CW1")
                APangle = APangle + 1
            End If
        End If
        If APangle < 356 Then
            If CBStepSize.SelectedIndex = 1 Then
                SendCommand("CW5")
                APangle = APangle + 5
            End If
        End If
        If APangle > 359 Then
            If CBStepSize.SelectedIndex = 0 Then BTTCW.Enabled = False
        End If
        If APangle > 356 Then
            If CBStepSize.SelectedIndex = 1 Then BTTCW.Enabled = False
        End If
        LAngle.Text = APangle
    End Sub
    Private Sub BTTCCW_Click(sender As Object, e As EventArgs) Handles BTTCCW.Click
        If APangle > 0 Then
            If CBStepSize.SelectedIndex = 0 Then
                SendCommand("CCW1")
                APangle = APangle - 1
            End If
        End If
        If APangle > 4 Then
            If CBStepSize.SelectedIndex = 1 Then
                SendCommand("CCW5")
                APangle = APangle - 5
            End If
        End If
        If APangle < 1 Then
            If CBStepSize.SelectedIndex = 0 Then BTTCCW.Enabled = False
        End If
        If APangle < 4 Then
            If CBStepSize.SelectedIndex = 1 Then BTTCCW.Enabled = False
        End If
        BTTCW.Enabled = True
        LAngle.Text = APangle
    End Sub
    Private Sub BTTSetCent_Click(sender As Object, e As EventArgs) Handles BTTSetCent.Click
        SendCommand("CentSet")
        LAngle.Text = "180"
        APangle = 180
    End Sub
    Private Sub BReleaseMotor_Click(sender As Object, e As EventArgs) Handles BReleaseMotor.Click
        SendCommand("Release")
    End Sub
    Private Sub AboutToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem3.Click
        MsgBox("Antenna pattern ver 1.1b" & vbCrLf & "Registered for RIGOL DSA-875-TG" & vbCrLf & "SN:DSA8E261100012")
    End Sub
    Private Sub BSaveToCSvAPList_Click(sender As Object, e As EventArgs) Handles BSaveToCSvAFList.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim extentionstr As String
        extentionstr = ""
        saveFileDialog1.Filter = "txt files (*.txt)|*.txt|CSV files (*.csv)|*.|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.FilterIndex = 1 Then extentionstr = ".txt"
        If saveFileDialog1.FilterIndex = 2 Then extentionstr = ".csv"
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            saveFileDialog1.FileName = saveFileDialog1.FileName & extentionstr
            Dim sw As StreamWriter = New StreamWriter(saveFileDialog1.OpenFile())
            If (sw IsNot Nothing) Then
                sw.WriteLine(TBAFList.Text)
                sw.Close()
            End If
        End If
    End Sub

    Private Sub CBmaxYax_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CBmaxYax.SelectedIndexChanged
        If Me.CBmaxYax.SelectedIndex < 0 Then Me.CBmaxYax.SelectedIndex = 0
        If Me.CBminYax.SelectedIndex < 0 Then Me.CBminYax.SelectedIndex = 20
        If Val(Me.CBmaxYax.SelectedItem.ToString) < Val(Me.CBminYax.SelectedItem.ToString) Then Me.CBmaxYax.SelectedIndex = CInt(Val(Me.CBminYax.SelectedIndex))
        Yaxmax = CSng(Val(Me.CBmaxYax.SelectedItem.ToString))
        ZedGraphAP.GraphPane.YAxis.IsShowGrid = True
        ZedGraphAP.GraphPane.XAxis.IsShowGrid = True
        ZedGraphAP.GraphPane.YAxis.Max = Yaxmax
        ZedGraphAP.GraphPane.YAxis.Min = Yaxmin
        ZedGraphAP.GraphPane.YAxis.ScaleMagAuto = True
        ZedGraphAP.Refresh()
    End Sub
    Private Sub CBminYax_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CBminYax.SelectedIndexChanged
        If Me.CBmaxYax.SelectedIndex < 0 Then Me.CBmaxYax.SelectedIndex = 0
        If Me.CBminYax.SelectedIndex < 0 Then Me.CBminYax.SelectedIndex = 20
        If Val(Me.CBmaxYax.SelectedItem.ToString) < Val(Me.CBminYax.SelectedItem.ToString) Then Me.CBminYax.SelectedIndex = CInt(Val(Me.CBmaxYax.SelectedIndex))
        Yaxmin = CSng(Val(Val(Me.CBminYax.SelectedItem.ToString)))
        ZedGraphAP.GraphPane.YAxis.Max = Yaxmax
        ZedGraphAP.GraphPane.YAxis.Min = Yaxmin
        ZedGraphAP.GraphPane.YAxis.ScaleMagAuto = True
        ZedGraphAP.Refresh()
    End Sub
    Private Sub BSetCorr_Click(sender As Object, e As EventArgs) Handles BSetCorr.Click
        TBCorFac.Text = CStr(Val(TBAmpCorr.Text) + Val(TBAntCorr.Text) + Val(TBCableCorr.Text) + Val(TBUserCorr.Text))
    End Sub
    Private Sub BClearAFlist_MouseHover(sender As Object, e As EventArgs) Handles BClearAFlist.MouseHover
        tipshelp(BClearAFlist, "Clear Antenna Factor List", "Delete the data collected by Antenna Factor Measurement")
    End Sub
    Private Sub BSaveToCSvAFList_MouseHover(sender As Object, e As EventArgs) Handles BSaveToCSvAFList.MouseHover
        tipshelp(BSaveToCSvAFList, "Save Antenna Factor List", "Save the data collected by Antenna Factor Measurement to CSV file")
    End Sub
    Private Sub CBPolAPYmax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPolAPYmax.SelectedIndexChanged
        If Val(Me.CBPolAPYmin.SelectedIndex) < (Val(Me.CBPolAPYmax.SelectedIndex) + 1) Then
            Me.CBPolAPYmax.SelectedIndex = CInt(Val(Me.CBPolAPYmin.SelectedIndex))
        Else
            With CHAPP.ChartAreas("AntennaPattern")
                .AxisY.Maximum = Val(Me.CBPolAPYmax.SelectedItem.ToString)
            End With
        End If
    End Sub
    Private Sub CBPolAPYmin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPolAPYmin.SelectedIndexChanged
        If Val(Me.CBPolAPYmax.SelectedIndex) < 0 Then Me.CBPolAPYmax.SelectedIndex = 0
        With CHAPP.ChartAreas("AntennaPattern")
            .AxisY.Minimum = Val(Me.CBPolAPYmin.SelectedItem.ToString)
        End With
        With CHAPP.ChartAreas("AntennaPattern")
            .AxisY.Maximum = Val(Me.CBPolAPYmax.SelectedItem.ToString)
        End With
        If Val(Me.CBPolAPYmin.SelectedIndex) < (Val(Me.CBPolAPYmax.SelectedIndex) + 1) Then
            Me.CBPolAPYmin.SelectedIndex = CInt(Val(Me.CBPolAPYmax.SelectedIndex))
        Else
            With CHAPP.ChartAreas("AntennaPattern")
                .AxisY.Minimum = Val(Me.CBPolAPYmin.SelectedItem.ToString)
            End With
        End If
    End Sub
    Private Sub AutoscalePolar(ByVal autoscscale As Integer)
        Dim xypolvalmin, xypolvalmax, dataap(360) As Integer
        xypolvalmin = CInt(Val(APGain(0)))
        xypolvalmax = CInt(Val(APGain(0)))
        For i = 0 To 359 Step 1
            If xypolvalmin > APGain(i) Then xypolvalmin = CInt(Val(APGain(i)))
            If xypolvalmax < APGain(i) Then xypolvalmax = CInt(Val(APGain(i)))
        Next
        With CHAPP.ChartAreas("AntennaPattern")
            .AxisY.Maximum = xypolvalmax + 1
            .AxisY.Minimum = xypolvalmin - 1
        End With
    End Sub
    Private Sub BClearAFlist_Click(sender As Object, e As EventArgs) Handles BClearAFlist.Click
        TBAFList.Text = String.Format("{0,-20}{1,-30}{2,-30}" & vbCrLf, "Frequency", "AntennaFactor(dB/m)", "AntennaGain(dBi)")
        CHAPP.Series(0).Points.Clear()
    End Sub
    Private Sub BAutoscalePol_Click(sender As Object, e As EventArgs) Handles BAutoscalePol.Click
        AutoscalePolar(1)
    End Sub

    Private Sub PlotFAF(ByVal selectedFreq() As Double, ByVal DUTAF() As Double)
        Dim x(selectedFreq.Length - 1) As Double
        For i As Integer = 0 To selectedFreq.Length - 1
            x(i) = selectedFreq(i)
        Next

        ZedFAF.IsShowPointValues = True
        ZedFAF.GraphPane.CurveList.Clear()

        Dim curveDUTAF As LineItem = ZedFAF.GraphPane.AddCurve("Antenna Factor Vs Frequency", x, DUTAF, Color.DarkRed, SymbolType.Circle)
        curveDUTAF.Line.IsVisible = True
        curveDUTAF.Symbol.Fill = New Fill(Color.DarkRed)

        ZedFAF.GraphPane.IsShowTitle = False
        ZedFAF.GraphPane.XAxis.Title = "Frequency (MHz)"
        ZedFAF.GraphPane.YAxis.Title = "Antenna Factor (dBi)"

        Dim yMin As Double = DUTAF.Min()
        Dim yMax As Double = DUTAF.Max()
        Dim yMargin As Double = (yMax - yMin) * 5

        ZedFAF.GraphPane.YAxis.Min = yMin - yMargin
        ZedFAF.GraphPane.YAxis.Max = yMax + yMargin

        ZedFAF.AxisChange()
        ZedFAF.Invalidate()
    End Sub

    Private Sub LoadDemoDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDemoDataToolStripMenuItem.Click
        dataap = {-3.3535, -3.27616, -3.37732, -3.37323, -3.53678, -3.69445, -3.79741, -3.9572, -4.18314, -4.28075, -4.50665, -4.64665, -4.82482, -5.17553, -5.41335, -5.68885, -6.10886, -6.73604, -7.18874, -7.61829, -7.89082, -8.68102, -8.75335, -9.25667, -9.68566, -10.0798, -10.64479, -10.90118, -11.08116, -11.33626, -11.38239, -11.826, -11.74857, -12.35004, -12.56384, -13.507, -14.13833, -15.19466, -16.40546, -17.60912, -19.1157, -20.56914, -21.16259, -20.60994, -18.47469, -17.09308, -15.66461, -14.83924, -14.36362, -13.75676, -14.0952, -13.73652, -13.97831, -14.0952, -13.5961, -13.5366, -13.19349, -12.13577, -10.76306, -9.68936, -8.21893, -7.07529, -6.08405, -5.18686, -4.68937, -4.48251, -4.22081, -4.37545, -4.58003, -5.0336, -5.45807, -6.17177, -7.06708, -7.82999, -8.70931, -9.33044, -10.176, -10.64598, -11.41587, -11.40427, -12.12457, -11.77811, -11.97813, -11.63802, -11.36378, -10.51124, -10.04997, -9.1447, -8.70412, -8.01291, -7.47042, -7.04208, -6.58641, -6.30541, -6.21881, -6.10606, -6.06381, -6.16437, -6.13938, -6.26823, -6.19366, -6.25613, -6.35173, -6.41607, -6.56645, -6.9417, -7.39903, -7.96899, -8.59808, -9.01261, -9.29196, -9.79149, -10.16316, -11.02672, -12.20826, -13.09432, -15.20163, -16.70384, -18.05604, -18.35198, -19.00063, -17.15031, -15.90136, -14.82682, -13.47343, -12.58743, -11.48257, -10.93285, -10.26087, -9.89429, -9.75305, -9.54255, -9.16409, -9.33501, -9.33501, -9.33469, -9.7815, -10.03703, -10.29005, -10.87091, -11.35976, -11.94846, -13.03088, -14.14435, -15.35937, -16.01626, -18.23917, -19.23685, -20.58855, -20.78451, -19.52708, -17.74191, -16.96425, -15.61829, -14.83376, -13.52381, -12.6484, -11.69049, -10.95347, -9.97587, -9.36739, -8.90343, -8.56087, -8.27094, -8.25156, -8.34888, -8.59827, -8.68633, -8.97799, -9.18253, -9.74294, -10.08082, -10.35863, -11.35397, -12.69409, -13.64191, -14.95465, -16.44373, -18.31628, -21.5344, -24.37138, -34.89447, -35.37163, -26.37389, -23.60817, -19.80688, -16.99992, -15.16263, -14.32726, -13.02853, -11.73878, -10.75003, -9.6198, -8.96918, -8.45792, -7.87106, -7.61211, -7.32741, -7.38262, -7.0588, -6.82228, -6.92948, -7.342, -7.50321, -7.64899, -8.072, -8.12019, -8.54317, -8.98975, -9.55157, -9.6626, -10.05197, -10.6664, -11.3604, -11.54392, -12.53194, -12.46367, -12.77176, -12.92152, -12.81506, -12.85397, -12.7854, -12.5696, -12.20792, -11.90173, -11.74416, -11.16935, -11.37329, -11.05421, -11.0997, -10.99844, -10.8272, -11.37265, -11.48035, -11.9657, -12.45345, -12.86391, -13.3165, -14.12396, -14.60249, -14.78968, -15.97343, -16.73888, -17.29578, -18.48573, -20.18982, -20.83994, -20.61094, -20.8457, -20.32432, -19.36375, -19.10863, -18.3407, -17.3997, -16.87266, -15.83006, -15.15965, -13.84524, -12.98184, -12.04964, -10.95592, -10.10809, -9.01232, -8.20217, -7.56331, -6.97678, -6.72771, -6.12437, -6.12683, -6.09622, -6.21327, -6.30058, -6.69302, -7.10839, -7.78146, -8.60203, -9.05122, -9.73652, -10.49569, -11.18069, -11.63382, -12.23138, -12.28422, -12.53783, -12.01624, -11.74551, -11.46339, -10.54948, -9.66577, -8.93454, -8.11665, -7.6616, -7.14874, -6.59092, -6.34239, -6.35506, -6.11803, -6.03008, -6.09447, -6.07132, -5.97865, -6.12225, -6.0172, -6.04963, -6.22646, -6.32146, -6.32111, -6.49367, -6.25861, -6.32038, -6.09692, -5.77454, -5.43108, -4.94147, -4.63629, -4.32083, -4.05689, -3.89508, -3.72474, -3.64358, -3.58762, -3.46767, -3.53776, -3.41488, -3.44304, -3.49105, -3.62744, -3.53279, -3.5863, -3.63564, -3.50017, -3.35677, -3.27973, -3.15141, -2.93442, -2.70225, -2.48795, -2.27632, -2.17598, -1.93488, -1.85821, -1.84528, -1.86878, -1.93097, -2.04258, -2.12513, -2.35496, -2.46757, -2.69038, -2.93735, -3.00327, -3.04644, -3.25589, -3.16318, -3.17672, -3.06054, -3.0598, -3.13941, -2.98509, -3.00721}
        CHAPP.Series.Clear()
        CHAPP.Series.Add("Antenna Pattern")
        With CHAPP.Series(0)
            .BorderWidth = 3
            .Color = Color.Red
            .IsVisibleInLegend = False
            .ChartType = DataVisualization.Charting.SeriesChartType.Polar
        End With
        For i = 0 To 359 Step 1
            CHAPP.Series(0).Points.AddXY(i, dataap(i))
            tempAPGain(i) = CStr(Val(dataap(i)))
            APGain(i) = Val(dataap(i))
        Next
        PlotAP(tempAPGain)
        AutoscalePolar(1)
    End Sub

    Private Sub BAddToListAPList_Click(sender As Object, e As EventArgs) Handles BAddToListAPList.Click
        If Val(TBMeasDistance.Text) <= 0 Then
            MsgBox("Input DUT Antenna to Reference Antenna Distance")
            Return
        End If

        'If Not TCPconnected Then
        '    MsgBox("TCP connection is not established.")
        '    Return
        'End If

        Dim startFreq As Double = CDbl(Val(TBFStart.Text)) * 1000000 ' Convert to Hz
        Dim stopFreq As Double = CDbl(Val(TBFStop.Text)) * 1000000 ' Convert to Hz
        Dim stepFreq As Double = GetStepFrequency()

        Dim freqList As New List(Of Double)
        Dim dutAFList As New List(Of Double)

        Dim selectedFreq As Double = startFreq
        Do While selectedFreq <= stopFreq
            'UpdateCalculatedValues(selectedFreq)

            freqList.Add(selectedFreq / 1000000) ' Convert to MHz
            dutAFList.Add(CDbl(TBDUTAF.Text))

            AddToList(selectedFreq)
            selectedFreq += stepFreq
        Loop

        PlotFAF(freqList.ToArray(), dutAFList.ToArray())
    End Sub

    Private Sub UpdateCalculatedValues(selectedFreq As Double)
        Dim TBPowerdBmValue As Double = 0.0
        If TCPconnected Then
            TBPowerdBm.Text = CStr(Val(SendTCP(":TRACe:DATA? TRACE1")(150)))
            TBPowerdBm.Text = FormatNumber(TBPowerdBm.Text, 1, TriState.False, , TriState.True)
            TBPowerdBmValue = CDbl(TBPowerdBm.Text)
        End If

        ' Calculate FSL
        Dim distance As Double = Val(TBMeasDistance.Text)
        Dim FSL As Double = 20 * Math.Log10(distance) + 20 * Math.Log10(selectedFreq) - 147.55
        TBFSL.Text = FormatNumber(FSL, 1, TriState.False, , TriState.True)

        ' Calculate EIRP
        TBPowerdBmValue = Val(TBPowerdBm.Text)
        Dim EIRP As Double = TBPowerdBmValue - Val(TBCorFac.Text) + FSL
        TBEIRPow.Text = FormatNumber(EIRP, 1, TriState.False, , TriState.True)

        ' Calculate DUT AG
        Dim DUTAG As Double = Val(TBEIRPow.Text) - Val(CBTGLvl.SelectedItem)
        TBDUTAG.Text = FormatNumber(DUTAG, 1, TriState.False, , TriState.True)

        ' Calculate DUT AF
        Dim DUTAF As Double = (20 * Math.Log10(selectedFreq / 1000)) - DUTAG - 29.7707
        TBDUTAF.Text = FormatNumber(DUTAF, 1, TriState.False, , TriState.True)
    End Sub

    Private Sub AddToList(selectedFreq As Double)
        If TBAFList.Text = "" Then
            TBAFList.AppendText(Environment.NewLine)
        End If

        Dim entry As String = $"{selectedFreq / 1000000}, {TBDUTAF.Text}, {TBDUTAG.Text}"
        TBAFList.AppendText(entry & Environment.NewLine)
    End Sub

    Private Sub TBMeasDistance_Validated(sender As Object, e As EventArgs) Handles TBMeasDistance.Validated
        If TBFStart.Text = "" Or TBFStop.Text = "" Then
            MsgBox("Please enter valid start and stop frequencies.")
            Return
        End If

        Dim startFreq As Double = CDbl(Val(TBFStart.Text)) * 1000000
        Dim stopFreq As Double = CDbl(Val(TBFStop.Text)) * 1000000
        Dim stepFreq As Double = GetStepFrequency()

        TBAFList.Text = String.Format("{0,-20}{1,-30}{2,-30}" & vbCrLf, "Frequency(MHz)", "AntennaFactor(dB/m)", "AntennaGain(dBi)")

        CBBFreq.Items.Clear()

        Dim selectedFreq As Double = startFreq
        While selectedFreq <= stopFreq

            Dim freqInMHz As Double = selectedFreq / 1000000
            CBBFreq.Items.Add(freqInMHz)

            selectedFreq += stepFreq
        End While
    End Sub
    Private Sub TBAF_Validated(sender As Object, e As EventArgs) Handles TBAF.Validated
        TBAntCorr.Text = CStr((20 * Log10(currentFreq / 1000)) - Val(TBAF.Text) - 29.7707)
        TBAntCorr.Text = FormatNumber(TBAntCorr.Text, 1, TriState.False, , TriState.True)
    End Sub
    Private Sub TBAntCorr_Validated(sender As Object, e As EventArgs) Handles TBAntCorr.Validated
        TBAF.Text = CStr((20 * Log10(currentFreq / 1000)) - Val(TBAntCorr.Text) - 29.7707)
        TBAF.Text = FormatNumber(TBAF.Text, 1, TriState.False, , TriState.True)
        TBCorFac.Text = CStr(Val(TBAntCorr.Text) - Val(TBCableCorr.Text) + Val(TBAmpCorr.Text) + Val(TBUserCorr.Text))
        TBCorFac.Text = FormatNumber(TBCorFac.Text, 1, TriState.False, , TriState.True)
    End Sub
    Private Sub TBCableCorr_Validated(sender As Object, e As EventArgs) Handles TBCableCorr.Validated
        TBCorFac.Text = CStr(Val(TBAntCorr.Text) - Val(TBCableCorr.Text) + Val(TBAmpCorr.Text) + Val(TBUserCorr.Text))
    End Sub
    Private Sub TBAmpCorr_Validated(sender As Object, e As EventArgs) Handles TBAmpCorr.Validated
        TBCorFac.Text = CStr(Val(TBAntCorr.Text) - Val(TBCableCorr.Text) + Val(TBAmpCorr.Text) + Val(TBUserCorr.Text))
    End Sub
    Private Sub TBUserCorr_Validated(sender As Object, e As EventArgs) Handles TBUserCorr.Validated
        TBCorFac.Text = CStr(Val(TBAntCorr.Text) - Val(TBCableCorr.Text) + Val(TBAmpCorr.Text) + Val(TBUserCorr.Text))
    End Sub
    Private Sub TextIP_MouseHover(sender As Object, e As EventArgs) Handles TextIP.MouseHover
        If CBTTH.Checked Then tipshelp(TextIP, "IP Configuration", "Set IP Address for connection to Spectrum Analyzer")
    End Sub
    Private Sub TextPort_MouseHover(sender As Object, e As EventArgs) Handles TextPort.MouseHover
        If CBTTH.Checked Then tipshelp(TextPort, "Port Configuration", "Set Port Address for connection to Spectrum Analyzer")
    End Sub
    Private Sub TBAF_MouseHover(sender As Object, e As EventArgs) Handles TBAF.MouseHover
        If CBTTH.Checked Then tipshelp(TBAF, "Antenna Factor", "Set Correction Factor (from FStart to FStop) for measurement for calculating Antenna Gain")
    End Sub
    Private Sub TBAntCorr_MouseHover(sender As Object, e As EventArgs) Handles TBAntCorr.MouseHover
        If CBTTH.Checked Then tipshelp(TBAntCorr, "Antenna Gain", "Set Antenna Gain (from FStart to FStop), Positive mean gain")
    End Sub
    Private Sub TBCableCorr_MouseHover(sender As Object, e As EventArgs) Handles TBCableCorr.MouseHover
        If CBTTH.Checked Then tipshelp(TBCableCorr, "Cable", "Set Cable Loss (Attenuation from FStart to FStop), Positive value means loss")
    End Sub
    Private Sub TBAmpCorr_MouseHover(sender As Object, e As EventArgs) Handles TBAmpCorr.MouseHover
        If CBTTH.Checked Then tipshelp(TBAmpCorr, "Amplifier", "Set Pre/Amplifier Gain (from FStart to FStop), Positive value means Gain")
    End Sub
    Private Sub TBUserCorr_MouseHover(sender As Object, e As EventArgs) Handles TBUserCorr.MouseHover
        If CBTTH.Checked Then tipshelp(TBUserCorr, "User", "Set User Correction, Positive mean Gain, Negative means Loss")
    End Sub
    Private Sub TBMeasDistance_MouseHover(sender As Object, e As EventArgs) Handles TBMeasDistance.MouseHover
        If CBTTH.Checked Then tipshelp(TBMeasDistance, "Measurement Distance", "Set the distance between Reference and DUT antenna in meter")
    End Sub
    Private Sub BConnect_MouseHover(sender As Object, e As EventArgs) Handles BConnect.MouseHover
        If CBTTH.Checked Then tipshelp(BConnect, "Connect SPA", "Connect to Spectrum Analyzer")
    End Sub
    Private Sub BConTT_MouseHover(sender As Object, e As EventArgs) Handles BConTT.MouseHover
        If CBTTH.Checked Then tipshelp(BConTT, "Connect TT", "Connect to Turn Table Controler")
    End Sub
    Private Sub BSetCorr_MouseHover(sender As Object, e As EventArgs) Handles BSetCorr.MouseHover
        If CBTTH.Checked Then tipshelp(BSetCorr, "Set Correction Factor", "Set The Correction Factor so the Spectrum show Value after correction Factor")
    End Sub
    Private Sub BAddToListAPList_MouseHover(sender As Object, e As EventArgs) Handles BAddToListAPList.MouseHover
        If CBTTH.Checked Then tipshelp(BAddToListAPList, "Add to Antenna Pattern List", "Add the Measurement for the result list")
    End Sub
    Private Sub BTT0_MouseHover(sender As Object, e As EventArgs) Handles BTT0.MouseHover
        If CBTTH.Checked Then tipshelp(BTT0, "Set 0", "Set the Turn Table Position to 0 degree")
    End Sub
    Private Sub BTT180_MouseHover(sender As Object, e As EventArgs) Handles BTT180.MouseHover
        If CBTTH.Checked Then tipshelp(BTT180, "Set 180", "Set the Turn Table Position to 180 degree")
    End Sub
    Private Sub BTT360_MouseHover(sender As Object, e As EventArgs) Handles BTTSetCent.MouseHover
        If CBTTH.Checked Then tipshelp(BTTSetCent, "Set 360", "Set the Turn Table Position to 360 degree")
    End Sub
    Private Sub BTTCCW_MouseHover(sender As Object, e As EventArgs) Handles BTTCCW.MouseHover
        If CBTTH.Checked Then tipshelp(BTTCCW, "Counter Clock Wise", "Rotate the Turn Table Counter Clockwise according step size")
    End Sub
    Private Sub BTTCW_MouseHover(sender As Object, e As EventArgs) Handles BTTCW.MouseHover
        If CBTTH.Checked Then tipshelp(BTTCW, "Clock Wise", "Rotate the Turn Table Clockwise according step size")
    End Sub
    Private Sub CBmaxYax_MouseHover(sender As Object, e As EventArgs) Handles CBmaxYax.MouseHover
        If CBTTH.Checked Then tipshelp(CBmaxYax, "Y(max)", "Set The chart Maximum Y axis")
    End Sub
    Private Sub CBminYax_MouseHover(sender As Object, e As EventArgs) Handles CBminYax.MouseHover
        If CBTTH.Checked Then tipshelp(CBminYax, "Y(min)", "Set The chart Minimum Y axis")
    End Sub
    Private Sub CBPolAPYmax_MouseHover(sender As Object, e As EventArgs) Handles CBPolAPYmax.MouseHover
        If CBTTH.Checked Then tipshelp(CBPolAPYmax, "Y(max)", "Set The chart Magintude Y axis")
    End Sub
    Private Sub CBPolAPYmin_MouseHover(sender As Object, e As EventArgs) Handles CBPolAPYmin.MouseHover
        If CBTTH.Checked Then tipshelp(CBPolAPYmin, "Y(min)", "Set The chart Minimum Y axis")
    End Sub
    Private Sub BSaveReport_MouseHover(sender As Object, e As EventArgs) Handles BSaveReport.MouseHover
        If CBTTH.Checked Then tipshelp(BSaveReport, "Save Text Report", "Save the Result to the CSV or text file")
    End Sub
    Private Sub BRptClr_MouseHover(sender As Object, e As EventArgs) Handles BRptClr.MouseHover
        If CBTTH.Checked Then tipshelp(BRptClr, "Clear Log", "Clear the Result For next Measurement")
    End Sub
    Private Sub BAPRport_MouseHover(sender As Object, e As EventArgs) Handles BAPRport.MouseHover
        If CBTTH.Checked Then tipshelp(BAPRport, "Antenna Pattern Report As Word", "Save The Pattern Report in Document File (DOC)")
    End Sub
    Private Sub BAutoscalePol_MouseHover(sender As Object, e As EventArgs) Handles BAutoscalePol.MouseHover
        If CBTTH.Checked Then tipshelp(BAutoscalePol, "Autoscale", "Make The chart autoscale(fit the data)")
    End Sub
    Private Sub CLIncludeTable_MouseEnter(sender As Object, e As EventArgs) Handles CLIncludeTable.MouseEnter
        If CBTTH.Checked Then tipshelp(CLIncludeTable, "Include Table", "Input the result table to the Report Generated")
    End Sub
    Private Sub CBComPort_MouseHover(sender As Object, e As EventArgs) Handles CBComPort.MouseHover
        If CBTTH.Checked Then tipshelp(CBComPort, "COM Port", "Select COM Port the Antenna Rotator Connected")
    End Sub
    Private Sub BScanPort_MouseHover(sender As Object, e As EventArgs) Handles BScanPort.MouseHover
        If CBTTH.Checked Then tipshelp(BScanPort, "Scan COM Port", "Scan Com Port In the Computer")
    End Sub
    Private Sub TBFCent_MouseHover1(sender As Object, e As EventArgs)
        If CBTTH.Checked Then tipshelp(TBFStart, "Frequency Center", "Input Center Frequency Measured in kHz")
    End Sub
    Private Sub CBRL_MouseHover1(sender As Object, e As EventArgs) Handles CBRL.MouseHover
        If CBTTH.Checked Then tipshelp(CBRL, "Reference Level", "Chose Reference Level(max Level In Spectrum)")
    End Sub
    Private Sub CBRBW_MouseHover1(sender As Object, e As EventArgs) Handles CBRBW.MouseHover
        If CBTTH.Checked Then tipshelp(CBRBW, "RBW", "Select Resolution Band Width, Lower Setting more Dynamic Range")
    End Sub
    Private Sub CBAttenuatorInt_MouseHover1(sender As Object, e As EventArgs) Handles CBAttenuatorInt.MouseHover
        If CBTTH.Checked Then tipshelp(CBAttenuatorInt, "SPA Attenuator", "Select Internal SPA Attenuator")
        If CBTTH.Checked Then tipshelp(CBAttenuatorInt, "SPA Attenuator", "Select Internal SPA Attenuator")
    End Sub
    Private Sub CBTGLvl_MouseHover(sender As Object, e As EventArgs) Handles CBTGLvl.MouseHover
        If CBTTH.Checked Then tipshelp(CBTGLvl, "TG Level", "Select Tracking Generator Level in dBm, Lover if Using Amplifier")
    End Sub
    Private Sub BSetSPACtrl_MouseHover1(sender As Object, e As EventArgs) Handles BSetSPACtrl.MouseHover
        If CBTTH.Checked Then tipshelp(BSetSPACtrl, "Set SPA Setting", "Apply SPA Setting Above")
    End Sub
    Private Sub CBTG_MouseHover1(sender As Object, e As EventArgs) Handles CBTG.MouseHover
        If CBTTH.Checked Then tipshelp(CBTG, "TG Enable", "Enable Tracking Generator In SPA")
    End Sub
    Private Sub BNormalize_MouseHover(sender As Object, e As EventArgs) Handles BNormalize.MouseHover
        If CBTTH.Checked Then tipshelp(BNormalize, "Normalize", "Set Present Level As ZERO Reference")
    End Sub
    Private Sub CBStepSize_MouseHover(sender As Object, e As EventArgs) Handles CBStepSize.MouseHover
        If CBTTH.Checked Then tipshelp(CBStepSize, "Step Size", "Set Stepper motor Step for each Measurement")
    End Sub
    Private Sub BAntPattern_MouseHover(sender As Object, e As EventArgs) Handles BAntPattern.MouseHover
        If CBTTH.Checked Then tipshelp(BAntPattern, "START", "START The Antenna Pattern Measurement")
    End Sub
    Private Sub BStopAP_MouseHover(sender As Object, e As EventArgs) Handles BStopAP.MouseHover
        If CBTTH.Checked Then tipshelp(BStopAP, "STOP", "STOP The Antenna Pattern Measurement, not recomenced")
    End Sub
    Private Sub GBReport_MouseHover(sender As Object, e As EventArgs) Handles GBReport.MouseHover
        If CBTTH.Checked Then tipshelp(GBReport, "DUT Measurement Info", "Input Info about Measurement and Testing")
    End Sub
    Private Sub TBNamaDUT_MouseHover(sender As Object, e As EventArgs) Handles TBNamaDUT.MouseHover
        If CBTTH.Checked Then tipshelp(GBReport, "DUT Device", "Input DUT Device Name, example LTE Antenna")
    End Sub
    Private Sub TBMerekDUT_MouseHover(sender As Object, e As EventArgs) Handles TBMerekDUT.MouseHover
        If CBTTH.Checked Then tipshelp(TBNamaDUT, "DUT Brand Info", "Input DUT Brand, example Huawei")
    End Sub
    Private Sub TBNoSeri_MouseHover(sender As Object, e As EventArgs) Handles TBNoSeri.MouseHover
        If CBTTH.Checked Then tipshelp(TBNoSeri, "DUT SN", "Input DUT Serial Number")
    End Sub
    Private Sub TBTipeDUT_MouseHover(sender As Object, e As EventArgs) Handles TBTipeDUT.MouseHover
        If CBTTH.Checked Then tipshelp(TBTipeDUT, "DUT Type", "Input Type or Model Info")
    End Sub
    Private Sub TBOperator_MouseHover(sender As Object, e As EventArgs) Handles TBOperator.MouseHover
        If CBTTH.Checked Then tipshelp(TBOperator, "Operator Info", "Input Operator conduting Measuement Name")
    End Sub
    Private Sub TBKomentar_MouseHover(sender As Object, e As EventArgs) Handles TBKomentar.MouseHover
        If CBTTH.Checked Then tipshelp(TBKomentar, "Comment", "Input Other Info")
    End Sub
    Private Sub TextPort_Validated(sender As Object, e As EventArgs) Handles TextPort.Validated
        TextPort.Text = CStr(Val(TextPort.Text))
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBComPort.SelectedIndexChanged
        If CBComPort.SelectedIndex > -1 Then BConTT.Enabled = True
    End Sub
    Public Sub BScanPort_Click(sender As Object, e As EventArgs) Handles BScanPort.Click
        Dim nameArray() As String
        nameArray = SerialPort.GetPortNames
        Array.Sort(nameArray)
        CBComPort.DataSource = nameArray
        CBComPort.DropDownStyle = ComboBoxStyle.DropDownList
        CBComPort.SelectedIndex = 0
    End Sub
    Sub CloseComPort()
        Try
            Using SerialPort
                If (Not (SerialPort Is Nothing)) Then
                    If SerialPort.IsOpen Then
                        Do While (SerialPort.BytesToWrite > 0)
                        Loop
                    End If
                End If
            End Using
        Catch ex As UnauthorizedAccessException
        End Try
    End Sub
    Function OpenComPort() As Integer
        Try
            If Not SerialPort.IsOpen Then
                SerialPort.PortName = CBComPort.SelectedItem.ToString
                SerialPort.BaudRate = 9600
                SerialPort.Parity = Parity.None
                SerialPort.DataBits = 8
                SerialPort.StopBits = StopBits.One
                SerialPort.Handshake = Handshake.None
                SerialPort.ReadTimeout = 3000
                SerialPort.WriteTimeout = 5000
                SerialPort.Open()
                Return 1
            End If
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message)
            Return 0
        Catch ex As UnauthorizedAccessException
            MessageBox.Show(ex.Message)
            Return 0
        Catch ex As System.IO.IOException
            MessageBox.Show(ex.Message)
            Return 0
        End Try
    End Function
    Private Sub CBComPort_SelectedIndexChanged(sender As Object, e As EventArgs)
        SerialPort.PortName = CBComPort.SelectedItem.ToString
    End Sub
    Function SendCommand(ByVal command As String) As String
        Dim response As String = ""
        If SerialPort.IsOpen Then
            Try
                SerialPort.WriteLine(command)
                ' response = SerialPort.ReadLine
            Catch ex As UnauthorizedAccessException
                MessageBox.Show(ex.Message)
            End Try
        End If
        Return response
    End Function
    Private Sub BNormalize_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub BSetSPACtrl_Click_1(sender As Object, e As EventArgs) Handles BSetSPACtrl.Click
        Dim sendtcpdata As String
        Dim RbwScale As Integer
        If TCPconnected = True Then
            Console.WriteLine("TCP connected. Sending commands...")

            Dim startFreq As Single = CSng(Val(TBFStart.Text)) * 1000000 ' Using MHz
            Dim stopFreq As Single = CSng(Val(TBFStop.Text)) * 1000000 ' Using MHz
            Dim stepFreq As Single = GetStepFrequency()

            sendtcpdata = ":SENSe:FREQuency:STARt " & startFreq
            Console.WriteLine("Sending command: " & sendtcpdata)
            SendcommandTCP(sendtcpdata)

            sendtcpdata = ":SENSe:FREQuency:STOP " & stopFreq
            Console.WriteLine("Sending command: " & sendtcpdata)
            SendcommandTCP(sendtcpdata)

            sendtcpdata = ":DISPlay:WINdow:TRACe:Y:SCALe:RLEVel " & Val(CBRL.SelectedItem)
            Console.WriteLine("Sending command: " & sendtcpdata)
            SendcommandTCP(sendtcpdata)

            RbwScale = 1
            If CBRBW.SelectedItem.ToString.EndsWith(" MHz") Then RbwScale = 1000000
            If CBRBW.SelectedItem.ToString.EndsWith(" kHz") Then RbwScale = 1000
            If CBRBW.SelectedItem.ToString.EndsWith(" Hz") Then RbwScale = 1
            FRbw = CInt(Val(CBRBW.SelectedItem)) * RbwScale
            sendtcpdata = ":SENSe:BANDwidth:RESolution " & Val(FRbw)
            Console.WriteLine("Sending command: " & sendtcpdata)
            SendcommandTCP(sendtcpdata)

            sendtcpdata = ":SENSe:POWer:RF:ATTenuation " & Val(CBAttenuatorInt.SelectedItem)
            Console.WriteLine("Sending command: " & sendtcpdata)
            SendcommandTCP(sendtcpdata)

            sendtcpdata = ":SOURce:POWer:LEVel:IMMediate:AMPLitude " & Val(CBTGLvl.SelectedItem)
            Console.WriteLine("Sending command: " & sendtcpdata)
            SendcommandTCP(sendtcpdata)

            If CBTG.Checked = False Then
                sendtcpdata = ":OUTPut:STATe 0"
                Console.WriteLine("Sending command: " & sendtcpdata)
                SendcommandTCP(sendtcpdata)
            ElseIf CBTG.Checked = True Then
                sendtcpdata = ":OUTPut:STATe 1"
                Console.WriteLine("Sending command: " & sendtcpdata)
                SendcommandTCP(sendtcpdata)
            End If

            sendtcpdata = ":INITiate:CONTinuous ON"
            Console.WriteLine("Sending command: " & sendtcpdata)
            SendcommandTCP(sendtcpdata)
        Else
            Console.WriteLine("TCP not connected.")
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TBFStop_TextChanged(sender As Object, e As EventArgs) Handles TBFStop.TextChanged

    End Sub

    Private Sub LBDFFCenter_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TBFCent_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TBFStart.TextChanged

    End Sub

    Private Sub ZedGraphAP_Load(sender As Object, e As EventArgs) Handles ZedGraphAP.Load

    End Sub

    Private Sub APTB_TextChanged(sender As Object, e As EventArgs) Handles APTB.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CBTTH_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CBTG_CheckedChanged(sender As Object, e As EventArgs) Handles CBTG.CheckedChanged

    End Sub

    Private Sub ZedFAF_Load(sender As Object, e As EventArgs) Handles ZedFAF.Load


    End Sub

    Private Sub TBAFList_TextChanged(sender As Object, e As EventArgs) Handles TBAFList.TextChanged

    End Sub

    Private Sub TBPowerdBm_TextChanged(sender As Object, e As EventArgs) Handles TBPowerdBm.TextChanged

    End Sub

    Private Sub TBFSL_TextChanged(sender As Object, e As EventArgs) Handles TBFSL.TextChanged

    End Sub

    Private Sub TBDUTAG_TextChanged(sender As Object, e As EventArgs) Handles TBDUTAG.TextChanged

    End Sub

    Private Sub TBEIRPow_TextChanged(sender As Object, e As EventArgs) Handles TBEIRPow.TextChanged

    End Sub

    Private Sub TBMeasDistance_TextChanged(sender As Object, e As EventArgs) Handles TBMeasDistance.TextChanged

    End Sub

    Private Sub TBDUTAF_TextChanged(sender As Object, e As EventArgs) Handles TBDUTAF.TextChanged

    End Sub

    Private Sub TBKomentar_TextChanged(sender As Object, e As EventArgs) Handles TBKomentar.TextChanged

    End Sub

    Private Sub TXYAP_Click(sender As Object, e As EventArgs) Handles TXYAP.Click

    End Sub     

    Private Sub PlotAntennaGainPolar(ByVal degrees() As Double, ByVal antennaFactors() As Double)

    End Sub

    Private Sub LMeasDistance_Click(sender As Object, e As EventArgs) Handles LMeasDistance.Click

    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Function GetStepFrequency() As Double
        Dim stepFrequency As Double = 0.0
        Dim stepText As String = CBBFStep.SelectedItem.ToString()

        If stepText.EndsWith(" KHz") Then
            Dim value As String = stepText.Replace(" KHz", "")
            If Double.TryParse(value, stepFrequency) Then
                stepFrequency *= 1000
            Else
                MessageBox.Show("Invalid frequency value")
            End If
        ElseIf stepText.EndsWith(" MHz") Then
            Dim value As String = stepText.Replace(" MHz", "")
            If Double.TryParse(value, stepFrequency) Then
                stepFrequency *= 1000000
            Else
                MessageBox.Show("Invalid frequency value")
            End If
        End If

        Return stepFrequency
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 10 To 100 Step 10
            CBBFStep.Items.Add(i & " KHz")
            CBBFStep.Items.Add(i & " MHz")
        Next

        If CBBFStep.Items.Count > 0 Then
            CBBFStep.SelectedIndex = 0
        End If
    End Sub

    Private Sub CBBFStep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBFStep.SelectedIndexChanged

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub CBBFreq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBFreq.SelectedIndexChanged
        Dim selectedFreqMHz As Double = CDbl(CBBFreq.SelectedItem)
        Dim selectedFreqHz As Double = selectedFreqMHz * 1000000

        UpdateCalculatedValues(selectedFreqHz)
    End Sub

    Private Sub BAntPattern_Click_1(sender As Object, e As EventArgs) Handles BAntPattern.Click
        If LAngle.Text = "0" Then
            Func_tab.SelectedTab = TAPolar
            BAntPattern.Enabled = False
            BStopAP.Enabled = True
            TimerAntennaPattern.Enabled = True
            If CBStepSize.SelectedIndex = 0 Then TimerAntennaPattern.Interval = 1000
            If CBStepSize.SelectedIndex = 1 Then TimerAntennaPattern.Interval = 2000
        Else
            MsgBox("Set turn table to 0 Position Before Start Measurement")
            Return
        End If
    End Sub
    Private Sub BStopAP_Click_1(sender As Object, e As EventArgs) Handles BStopAP.Click
        BAntPattern.Enabled = True
        BStopAP.Enabled = False
        TimerAntennaPattern.Enabled = False
    End Sub
    Private Sub BNormalize_Click_1(sender As Object, e As EventArgs) Handles BNormalize.Click
        Dim sendtcpdata As String
        If TCPconnected = True Then
            sendtcpdata = ":CALCulate:NTData:STATe ON"
            SendcommandTCP(sendtcpdata)
        End If
    End Sub

    Private Sub CBRL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBRL.SelectedIndexChanged
        If CBRL.SelectedIndex < 31 Then
            If CBAttenuatorInt.SelectedIndex < 30 Then CBAttenuatorInt.SelectedIndex = CInt(Val(CBRL.SelectedItem)) + 10
        End If
    End Sub
    Private Sub CBAttenuatorInt_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CBAttenuatorInt.SelectedIndexChanged
        If CBAttenuatorInt.SelectedIndex < 31 Then
            If CBRL.SelectedIndex < 30 Then CBRL.SelectedIndex = 30 - CInt(Val(Val(CBAttenuatorInt.SelectedItem)))
        End If
    End Sub
    Private Sub CBRBW_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBRBW.SelectedIndexChanged

    End Sub
    Private Sub BReleaseMotor_MouseHover(sender As Object, e As EventArgs) Handles BReleaseMotor.MouseHover
        If CBTTH.Checked Then tipshelp(BReleaseMotor, "Motor Release", "Relase Motor Breake so the motor can be rotated manualy")
    End Sub
    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Dim indata As String
        indata = SerialPort.ReadExisting
        TSSLTTStatus.Text = indata
    End Sub
End Class