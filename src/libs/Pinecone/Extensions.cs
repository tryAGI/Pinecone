using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Pinecone;

internal static class Extensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static Task CheckStatusCode(this HttpResponseMessage response, [CallerMemberName] string requestName = "")
    {
        return response.IsSuccessStatusCode
            ? Task.CompletedTask
            : ThrowOnFailedResponse(response, requestName);

        [DoesNotReturn, StackTraceHidden]
        static async Task ThrowOnFailedResponse(HttpResponseMessage response, string requestName)
        {
            throw new HttpRequestException(
                $"{requestName} request has failed. " +
                $"Code: {response.StatusCode:D} {response.StatusCode}. " +
                $"Message: {await response.Content.ReadAsStringAsync().ConfigureAwait(false)}");
        }
    }
}
