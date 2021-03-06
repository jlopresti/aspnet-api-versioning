﻿#if WEBAPI
namespace Microsoft.Web.Http
#else
namespace Microsoft.AspNetCore.Mvc
#endif
{
    using System;
    using Versioning;
    using static System.AttributeTargets;

    /// <summary>
    /// Represents the metadata to indicate a service is API version neutral.
    /// </summary>
    [AttributeUsage( Class, AllowMultiple = false, Inherited = true )]
    public sealed class ApiVersionNeutralAttribute : Attribute, IApiVersionNeutral
    {
    }
}
