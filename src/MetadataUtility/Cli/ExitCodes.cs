// <copyright file="ExitCodes.cs" company="QutEcoacoustics">
// All code in this file and all associated files are the copyright and property of the QUT Ecoacoustics Research Group.
// </copyright>

namespace MetadataUtility.Cli
{
    public static class ExitCodes
    {
        public const int Success = 0;
        public const int Failure = 1;

        public static int Get(bool success)
        {
            return success ? Success : Failure;
        }
    }
}
