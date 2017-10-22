// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace CrossPlatformExample.Proxy
{
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CrossPlatformExampleClient.
    /// </summary>
    public static partial class CrossPlatformExampleClientExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='valueToSquare'>
            /// </param>
            public static int? Square(this ICrossPlatformExampleClient operations, int valueToSquare)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICrossPlatformExampleClient)s).SquareAsync(valueToSquare), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='valueToSquare'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<int?> SquareAsync(this ICrossPlatformExampleClient operations, int valueToSquare, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.SquareWithHttpMessagesAsync(valueToSquare, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}