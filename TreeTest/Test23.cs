using Assert_t = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Description_t = System.ComponentModel.DescriptionAttribute;
using TestClass_t = Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute;
using TestMethod_t = Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute;
using TwoThreeTree_t = NullPointersEtc.TwoThreeTrees.TwoThreeTree<int, int>;

namespace NullPointersEtc.TreeTests;

[TestClass_t,
    Description_t(description: "Tests for my 2-3 tree implementation.")]
public sealed class TwoThreeTreeTests
{
    public TwoThreeTreeTests()
    {
    }

    [TestMethod_t(displayName: "TwoThreeTree Tests")]
    public void TestMethod1()
    {
        TwoThreeTree_t tree = new();

        Assert_t.IsNotNull(tree, message: "tree should have been properly constructed");

        Assert_t.IsFalse(tree.Contains(5));
    }
}
