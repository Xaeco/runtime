// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.ServiceProcess
{
    [Flags]
    public enum ServiceControllerPermissionAccess
    {
        None = 0,
        Browse = 1 << 1,
        Control = 1 << 2 | Browse,
    }
}
