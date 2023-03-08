using LibraryAnagram;

namespace LibraryAnagramTest
{
    public class AnagramTest
    {
        Anagram anagram = new Anagram();

        [Test]
        [TestCase("", "")]
        [TestCase("Word", "droW")]
        [TestCase("Привіт", "тівирП")]
        [TestCase("Word in a sentence", "droW ni a ecnetnes")]
        public void SimpleReverse(string input, string output)
        {
            Assert.That(anagram.Reverse(input), Is.EqualTo(output));
        }

        [Test]
        [TestCase("  !", "  !")]
        [TestCase("  !  ", "  !  ")]
        [TestCase("\n  ! \t// ", "\n  ! \t// ")]
        [TestCase(" Word ", " droW ")]
        [TestCase("Word\n in a!\t! sentence\t", "droW\n ni a!\t! ecnetnes\t")]
        public void ReverseWithWhitespaces(string input, string output)
        {
            Assert.That(anagram.Reverse(input), Is.EqualTo(output));
        }
    }
}