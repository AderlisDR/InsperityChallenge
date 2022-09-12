using NUnit.Framework;

namespace StringSortingApp.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(new object[] { 2, "abaccadcc", "xyzxy" }, "ccccaaabd\nxxyyz")]
        [TestCase(new object[] { 10, "dulgvgzwqg", "gxtjtmtywr", "hnlnxiupgt", "gzjotckivp", "dpwwsdptae", "pcscpilknb", "btvyhhmflf", "artrtnqxcr", "nrtcmcoadn", "fkdsgnekft" }, "gggdlquvwz\ntttgjmrwxy\nnnghilptux\ncgijkoptvz\nddppwwaest\nccppbiklns\nffhhblmtvy\nrrrttacnqx\nccnnadmort\nffkkdegnst")]
        [TestCase(new object[] { 5, "wzenwebuau", "vokfxzynwl", "neldfeyrxk", "wqadfiodgs", "ykiuvzfcbc" }, "eeuuwwabnz\nfklnovwxyz\needfklnrxy\nddafgioqsw\nccbfikuvyz")]
        [TestCase(new object[] { 10, "qakmc", "rrtbk", "vaixn", "wmpnj", "uproi", "btska", "ejqwr", "elwlg", "oaoiy", "hrqkn" }, "ackmq\nrrbkt\nainvx\njmnpw\niopru\nabkst\nejqrw\nllegw\nooaiy\nhknqr")]
        [TestCase(new object[] { 3, "pzjim", "njnfq", "xyohs" }, "ijmpz\nnnfjq\nhosxy")]
        [TestCase(new object[] { 5, "xqycs", "beoax", "afkso", "bldit", "gwrys" }, "cqsxy\nabeox\nafkos\nbdilt\ngrswy")]
        public void With_Test_Case_Input_Object_Array_Must_Return_Expected_Output_String(object[] testCaseInput, string expectedOutput)
        {
            var result = StringManipulation.SortingOperations(testCaseInput);
            Assert.That(result, Is.EqualTo(expectedOutput));
        }
    }
}