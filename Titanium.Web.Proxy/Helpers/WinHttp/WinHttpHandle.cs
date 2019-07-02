using System;
using System.Runtime.InteropServices;

namespace PSYCOPMDLProCoreCommunications.Web.Proxy.Helpers.WinHttp
{
    internal class WinHttpHandle : SafeHandle
    {
        public WinHttpHandle() : base(IntPtr.Zero, true)
        {
        }

        public override bool IsInvalid => handle == IntPtr.Zero;

        protected override bool ReleaseHandle()
        {
            return NativeMethods.WinHttp.WinHttpCloseHandle(handle);
        }
    }
}
