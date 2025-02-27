// <copyright file="FileNameExtractorTests.cs" company="QutEcoacoustics">
// All code in this file and all associated files are the copyright and property of the QUT Ecoacoustics Research Group.
// </copyright>

namespace MetadataUtility.Tests.Metadata
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FluentAssertions;
    using MetadataUtility.Metadata;
    using MetadataUtility.Models;
    using MetadataUtility.Tests.TestHelpers;
    using Xunit;
    using Xunit.Abstractions;

    public class FileNameExtractorTests : TestBase
    {
        private readonly FilenameExtractor subject;

        public FileNameExtractorTests(ITestOutputHelper output)
            : base(output)
        {
            this.subject = new FilenameExtractor(
                this.BuildLogger<FilenameExtractor>(),
                this.TestFiles,
                this.FilenameParser);
        }

        public Recording Recording => new();

        [Theory]
        [ClassData(typeof(FixtureHelper.FixtureData))]
        public async void CanProcessFilesWorks(FixtureModel model)
        {
            // we can process all files that have a filename
            var result = await this.subject.CanProcessAsync(model.ToTargetInformation(this.RealFileSystem));

            Assert.True(result);
        }

        [Theory]
        [ClassData(typeof(FixtureHelper.FixtureData))]
        public async void ProcessFilesWorks(FixtureModel model)
        {
            // we can process all files that have a filename
            var recording = await this.subject.ProcessFileAsync(
                model.ToTargetInformation(this.RealFileSystem),
                this.Recording);

            recording.Extension.Should().Be(model.Extension);

            // TODO: Add other assertions here!
        }
    }
}
