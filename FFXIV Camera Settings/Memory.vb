Public Class Memory

    Private ZoomCurrentAddress As Int32
    Private ZoomMaxAddress As Int32

    Private FovCurrentAddress As Int32
    Private FovMaxAddress As Int32

    Public Sub CalculateAddresses()
        If IsAttached() Then
            ZoomCurrentAddress = CalculateAddress(My.Settings.CameraAddress, My.Settings.ZoomCurrentOffset)
            ZoomMaxAddress = CalculateAddress(My.Settings.CameraAddress, My.Settings.ZoomMaxOffset)

            FovCurrentAddress = CalculateAddress(My.Settings.CameraAddress, My.Settings.FovCurrentOffset)
            FovMaxAddress = CalculateAddress(My.Settings.CameraAddress, My.Settings.FovMaxOffset)
        End If
    End Sub

    Private Function CalculateAddress(ByVal addr_ptrs() As Int32, ByVal final_offset As Int32) As Int32
        Dim addr As Int32 = ffxiv_proc.MainModule.BaseAddress
        For Each offset In addr_ptrs
            addr = Deref(addr, offset)
        Next
        Return addr + final_offset
    End Function

    Public Sub WriteZoomMax(ByVal val As Decimal)
        If IsAttached() Then
            WriteDecimal(ZoomMaxAddress, val)
            If My.Settings.SetZoomCurrent Then WriteDecimal(ZoomCurrentAddress, val)
        End If
    End Sub

    Public Sub WriteFov(ByVal val As Decimal)
        If IsAttached() Then
            WriteDecimal(FovMaxAddress, val)
            WriteDecimal(FovCurrentAddress, val)
        End If
    End Sub

    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        DetachFromProcess()
    End Sub

    Public Shared Function GetFFXivProcesses() As Process()
        Return Process.GetProcessesByName(FFXIV_PROCESS)
    End Function

    Public Function AttachToProcess(ByVal id As Integer) As Boolean
        If id <> ffxiv_proc_id Then DetachFromProcess()
        If ffxiv_proc_hdl <> IntPtr.Zero Then Return True ' attached already

        Try
            ffxiv_proc_id = id
            ffxiv_proc = Process.GetProcessById(ffxiv_proc_id)

            If Not IsNothing(ffxiv_proc) Then
                ffxiv_proc_hdl = OpenProcess(PROCESS_READ_WRITE_QUERY, False, ffxiv_proc.Id)

                CalculateAddresses()
            End If
        Catch ex As Exception
            Debug.Print(ex.StackTrace & vbCrLf)
            DetachFromProcess()
        End Try

        Return ffxiv_proc_hdl <> IntPtr.Zero
    End Function

    Public Sub DetachFromProcess()
        If ffxiv_proc_hdl <> IntPtr.Zero Then CloseHandle(ffxiv_proc_hdl)
        ffxiv_proc_hdl = IntPtr.Zero
        ffxiv_proc_id = -1
    End Sub

    Private Function Deref(addr As IntPtr, offset As Int32) As Int32
        If addr = 0 Then Throw New Exception()
        Return ReadInt32(IntPtr.Add(addr, offset))
    End Function

    Private Function ReadInt32(ByVal addr As IntPtr) As Int32
        Dim _dataBytes(4) As Byte
        ReadProcessMemory(ffxiv_proc_hdl, addr, _dataBytes, 4, vbNull)
        Return BitConverter.ToInt32(_dataBytes, 0)
    End Function

    Public Function IsAttached() As Boolean
        Return ffxiv_proc_hdl <> IntPtr.Zero
    End Function

    Private Declare Function OpenProcess Lib "kernel32.dll" (ByVal dwDesiredAcess As UInt32, ByVal bInheritHandle As Boolean, ByVal dwProcessId As Int32) As IntPtr
    Private Declare Function ReadProcessMemory Lib "kernel32" (ByVal hProcess As IntPtr, ByVal lpBaseAddress As IntPtr, ByVal lpBuffer() As Byte, ByVal iSize As Integer, ByRef lpNumberOfBytesRead As Integer) As Boolean
    Private Declare Function WriteFloatMemory Lib "kernel32" Alias "WriteProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Single, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Single
    Private Declare Function CloseHandle Lib "kernel32.dll" (ByVal hObject As IntPtr) As Boolean

    Private Const FFXIV_PROCESS As String = "ffxiv"
    Private Const PROCESS_VM_READ = &H10
    Private Const PROCESS_VM_WRITE = &H20
    Private Const PROCESS_VM_OPERATION = &H8
    Private Const PROCESS_QUERY_INFORMATION = &H400
    Private Const PROCESS_READ_WRITE_QUERY = PROCESS_VM_READ + PROCESS_VM_WRITE + PROCESS_VM_OPERATION + PROCESS_QUERY_INFORMATION

    Private ffxiv_proc As Process
    Private ffxiv_proc_hdl As IntPtr = IntPtr.Zero
    Private ffxiv_proc_id As Integer = -1

    Public Sub WriteDecimal(ByVal Address As Int32, ByVal Float As Decimal)
        WriteFloatMemory(ffxiv_proc_hdl, Address, Decimal.ToSingle(Float), 4, Nothing)
    End Sub
End Class