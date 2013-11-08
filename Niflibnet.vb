Imports System
Imports System.Runtime.InteropServices
<Serializable()> Public Class Niflibnet
    Public Function NiAv_to_niOb(from_av As NiAVObject, to_ob As NiObject)
        Dim intp As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(from_av))
        Marshal.StructureToPtr(from_av, intp, False)
        to_ob = Marshal.PtrToStructure(intp, GetType(NiAVObject))
        Marshal.FreeHGlobal(intp)
        Return to_ob
    End Function
    Public Function niOb_to_NiAv(from_Ob As NiObject, to_NiAvob As NiAVObject)
        Dim intp As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(from_Ob))
        Marshal.StructureToPtr(from_Ob, intp, False)
        to_NiAvob = Marshal.PtrToStructure(intp, GetType(NiAVObject))
        Marshal.FreeHGlobal(intp)
        Return to_NiAvob
    End Function
End Class
