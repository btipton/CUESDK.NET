﻿namespace Spectrum.CUE.SDK
{
    /// <summary>
    /// Contains shared list of all errors that could happen during calling of Corsair* functions.
    /// </summary>
    public enum CorsairError
    {
        /// <summary>
        /// If previously called function was completed successfully
        /// </summary>
        CE_Success,

        /// <summary>
        /// If CUE is not running or was shut down or third-party control is disabled in CUE settings (runtime error)
        /// </summary>
        CE_ServerNotFound,

        /// <summary>
        /// If some other client has or took over exclusive control (runtime error)
        /// </summary>
        CE_NoControl,

        /// <summary>
        /// If developer did not perform protocol handshake (developer error)
        /// </summary>
        CE_ProtocolHandshakeMissing,

        /// <summary>
        /// If developer is calling the function that is not supported by the server (either  protocol has been broken by server or client or the function is new and server is too old. Check CorsairProtocolDetails for details), (developer error)
        /// </summary>
        CE_IncompatableProtocol,

        /// <summary>
        /// If developer supplied invalid arguments to the function (for specifics look at function descriptions), (developer error)
        /// </summary>
        CE_InvalidArguments
    }
}
