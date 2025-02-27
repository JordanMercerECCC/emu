// <copyright file="IFixOperation.cs" company="QutEcoacoustics">
// All code in this file and all associated files are the copyright and property of the QUT Ecoacoustics Research Group.
// </copyright>

namespace MetadataUtility.Fixes
{
    using System.Threading.Tasks;
    using MetadataUtility.Utilities;

    public interface IFixOperation : ICheckOperation
    {
        Task<FixResult> ProcessFileAsync(string file, DryRun dryRun, bool backup);
    }

    public record FixResult(FixStatus Status, CheckResult CheckResult, string Message);
}
