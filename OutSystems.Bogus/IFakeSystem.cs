using OutSystems.ExternalLibraries.SDK;

namespace OutSystems.Bogus
{
    /// <summary>
    /// Generates fake system and file data using the Bogus library.
    /// </summary>
    [OSInterface(
        Description = "Generates fake system data (file names, MIME types, extensions, semver) using the Bogus library.",
        Name = "FakeSystem",
        IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png"
    )]
    public interface IFakeSystem
    {
        /// <summary>
        /// Generates a fake file name with extension.
        /// </summary>
        /// <remarks>
        /// Returns a file name with a realistic extension (e.g., "report.pdf", "image.jpg").
        /// </remarks>
        /// <example>
        /// <code>
        /// string fileName = fakeSystem.FakeFileName("en", 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates a fake file name with extension.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "FileName"
        )]
        string FakeFileName(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake MIME type.
        /// </summary>
        /// <remarks>
        /// Returns a MIME type string in type/subtype format (e.g., "application/json", "image/png").
        /// </remarks>
        [OSAction(
            Description = "Generates a fake MIME type (e.g., application/json).",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "MimeType"
        )]
        string FakeMimeType(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake file extension.
        /// </summary>
        /// <remarks>
        /// Returns a file extension without the leading dot (e.g., "pdf", "jpg", "csv").
        /// </remarks>
        [OSAction(
            Description = "Generates a fake file extension (e.g., pdf, jpg).",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "FileExtension"
        )]
        string FakeFileExtension(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a fake semantic version string.
        /// </summary>
        /// <remarks>
        /// Returns a semantic version string in major.minor.patch format (e.g., "1.2.3").
        /// </remarks>
        [OSAction(
            Description = "Generates a fake semantic version string (e.g., 1.2.3).",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Semver"
        )]
        string FakeSemver(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );
    }
}
