using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WozDev.CredentialManager
{
    /// <summary>
    /// Flags that control the function's operation.
    /// </summary>
    [Flags]
    public enum CredWriteFlags : uint
    {
        /// <summary>
        /// The credential BLOB from an existing credential is preserved with the same credential name and credential type. The CredentialBlobSize of the passed in Credential structure must be zero.
        /// </summary>
        CRED_PRESERVE_CREDENTIAL_BLOB = 0x1
    }
}