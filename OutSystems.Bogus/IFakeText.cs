using OutSystems.ExternalLibraries.SDK;

namespace OutSystems.Bogus
{
    /// <summary>
    /// Generates fake text and lorem ipsum content using the Bogus library.
    /// </summary>
    [OSInterface(
        Description = "Generates fake text and lorem ipsum content (words, sentences, paragraphs, slugs) using the Bogus library.",
        Name = "FakeText",
        IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png"
    )]
    public interface IFakeText
    {
        /// <summary>
        /// Generates a single lorem ipsum word.
        /// </summary>
        /// <remarks>
        /// Returns a single lorem ipsum word.
        /// </remarks>
        [OSAction(
            Description = "Generates a single lorem ipsum word.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Word"
        )]
        string FakeLoremWord(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates multiple lorem ipsum words joined by spaces.
        /// </summary>
        /// <remarks>
        /// Returns the specified number of lorem ipsum words joined by spaces. Count is capped at 10,000.
        /// </remarks>
        /// <example>
        /// <code>
        /// string words = fakeText.FakeLoremWords(count: 5, seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates multiple lorem ipsum words joined by spaces.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Words"
        )]
        string FakeLoremWords(
            [OSParameterAttribute(Description = "Number of words to generate. Default is 3.")]
            int count = 3,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a lorem ipsum sentence.
        /// </summary>
        /// <remarks>
        /// The wordCount parameter is approximate — the actual sentence may have slightly more or fewer words. The sentence ends with a period.
        /// </remarks>
        [OSAction(
            Description = "Generates a lorem ipsum sentence.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Sentence"
        )]
        string FakeLoremSentence(
            [OSParameterAttribute(Description = "Approximate number of words. Default is 6.")]
            int wordCount = 6,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a lorem ipsum paragraph.
        /// </summary>
        /// <remarks>
        /// Returns a paragraph composed of multiple sentences.
        /// </remarks>
        [OSAction(
            Description = "Generates a lorem ipsum paragraph.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Paragraph"
        )]
        string FakeLoremParagraph(
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates multiple lorem ipsum paragraphs separated by newlines.
        /// </summary>
        /// <remarks>
        /// Returns multiple paragraphs separated by newline characters. Count is capped at 10,000.
        /// </remarks>
        /// <example>
        /// <code>
        /// string text = fakeText.FakeLoremParagraphs(count: 3, seed: 42);
        /// </code>
        /// </example>
        [OSAction(
            Description = "Generates multiple lorem ipsum paragraphs separated by newlines.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Paragraphs"
        )]
        string FakeLoremParagraphs(
            [OSParameterAttribute(Description = "Number of paragraphs. Default is 3.")]
            int count = 3,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );

        /// <summary>
        /// Generates a URL-friendly slug from lorem ipsum words.
        /// </summary>
        /// <remarks>
        /// Returns a URL-friendly slug with words separated by hyphens (e.g., "lorem-ipsum-dolor").
        /// </remarks>
        [OSAction(
            Description = "Generates a URL-friendly slug from lorem ipsum words.",
            IconResourceName = "OutSystems.Bogus.resources.Bogus_icon.png",
            ReturnName = "Slug"
        )]
        string FakeLoremSlug(
            [OSParameterAttribute(Description = "Number of words in the slug. Default is 3.")]
            int wordCount = 3,
            [OSParameterAttribute(Description = "Locale code (e.g., 'en', 'pt_BR'). Default is 'en'.")]
            string locale = "en",
            [OSParameterAttribute(Description = "Seed for reproducibility. 0 means random.")]
            int seed = 0
        );
    }
}
