// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

/*=============================================================================
**
**
**
** Purpose: The exception class for some failed P/Invoke calls.
**
**
=============================================================================*/

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
    [Serializable]
    [TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public class EntryPointNotFoundException : TypeLoadException
    {
        public EntryPointNotFoundException()
            : base(SR.Arg_EntryPointNotFoundException)
        {
            HResult = HResults.COR_E_ENTRYPOINTNOTFOUND;
        }

        public EntryPointNotFoundException(string? message)
            : base(message)
        {
            HResult = HResults.COR_E_ENTRYPOINTNOTFOUND;
        }

        public EntryPointNotFoundException(string? message, Exception? inner)
            : base(message, inner)
        {
            HResult = HResults.COR_E_ENTRYPOINTNOTFOUND;
        }

        [Obsolete(Obsoletions.LegacyFormatterImplMessage, DiagnosticId = Obsoletions.LegacyFormatterImplDiagId, UrlFormat = Obsoletions.SharedUrlFormat)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected EntryPointNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
