using Assert_t = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Description_t = System.ComponentModel.DescriptionAttribute;
using TestClass_t = Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute;
using TestMethod_t = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;

namespace NullPointersEtc.TreeTests;

[TestClass_t,
    Description_t(description: "Tests for my 2-3-4 tree implementation.")]
public sealed class TwoThreeFourTreeTests
{
    public TwoThreeFourTreeTests()
    {
    }

    [TestMethod_t(displayName: "TwoThreeFourTree Tests")]
    public void TestMethod1()
    {
        NullPointersEtc.TwoThreeFourTrees.TwoThreeFourTree<int, int> tree = new();

        Assert_t.IsNotNull(tree, message: "tree should have been properly constructed");
    }
}
