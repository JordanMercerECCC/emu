// <copyright file="FileNameDateStampInvalid.cs" company="QutEcoacoustics">
// All code in this file and all associated files are the copyright and property of the QUT Ecoacoustics Research Group.
// </copyright>

namespace MetadataUtility.Fixes.General
{
    using System;
    using MetadataUtility.Utilities;

    public class FileNameDateStampInvalid : IFixOperation
    {
        public static OperationInfo Metadata => new(
            WellKnownProblems.InvalidDateStamp,
            Fixable: true,
            Safe: true,
            Automatic: false,
            typeof(FileNameDateStampInvalid));

        public OperationInfo GetOperationInfo() => Metadata;

        public Task<CheckResult> CheckAffectedAsync(string file)
        {
            throw new NotImplementedException();
        }

        public Task<FixResult> ProcessFileAsync(string file, DryRun dryRun, bool backup)
        {
            throw new NotImplementedException();
        }
    }
}
