using Description_t = System.ComponentModel.DescriptionAttribute;
using NotImplementedException_t = System.NotImplementedException;
using DisallowNull_t = System.Diagnostics.CodeAnalysis.DisallowNullAttribute;
using AllowNull_t = System.Diagnostics.CodeAnalysis.AllowNullAttribute;
using NotNull_t = System.Diagnostics.CodeAnalysis.NotNullAttribute;
using MemberNotNull_t = System.Diagnostics.CodeAnalysis.MemberNotNullAttribute;

namespace NullPointersEtc.TwoThreeTrees;

[type: Description_t("2-3 tree type")]
public sealed class TwoThreeTree<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    public TwoThreeTree()
    {
        root = new EmptyTree<Key_t, Value_t>();
    }

    private TreeRoot<Key_t, Value_t> root;
}

[type: Description_t("Root class")]
internal abstract class TreeRoot<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
}

[type: Description_t("Root class")]
internal sealed class EmptyTree<Key_t, Value_t>
    : TreeRoot<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
}

[type: Description_t("Root class")]
internal sealed class SingletonTree<Key_t, Value_t>
    ([param: DisallowNull_t] Key_t theKey,
    [param: DisallowNull_t] Value_t theValue)
    : TreeRoot<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t] public Key_t Key { get => theKey; }
    [property: NotNull_t] public Value_t Value { get => theValue; }
}

[type: Description_t("Root class")]
internal sealed class DoubletonTree<Key_t, Value_t>
    ([param: DisallowNull_t] Key_t theLeftKey,
    [param: DisallowNull_t] Value_t theLeftValue,
    [param: DisallowNull_t] Key_t theRightKey,
    [param: DisallowNull_t] Value_t theRightValue)
    : TreeRoot<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t] public Key_t LeftKey { get => theLeftKey; }
    [property: NotNull_t] public Value_t LeftValue { get => theLeftValue; }
    [property: NotNull_t] public Key_t RightKey { get => theRightKey; }
    [property: NotNull_t] public Value_t RightValue { get => theRightValue; }
}

[type: Description_t("Root class")]
internal sealed class SingletonRoot<Key_t, Value_t>(
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeft,
    [param: DisallowNull_t] Key_t theKey,
    [param: DisallowNull_t] Value_t theValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theRight)
    : TreeRoot<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t] public TreeNode<Key_t, Value_t> LeftChild { get => theLeft; }
    [property: NotNull_t] public Key_t Key { get => theKey; }
    [property: NotNull_t] public Value_t Value { get => theValue; }
    [property: NotNull_t] public TreeNode<Key_t, Value_t> RightChild { get => theRight; }
}

[type: Description_t("Root class")]
internal sealed class DoubletonRoot<Key_t, Value_t>
    ([param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeftChild,
    [param: DisallowNull_t] Key_t theLeftKey,
    [param: DisallowNull_t] Value_t theLeftValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theMiddleChild,
    [param: DisallowNull_t] Key_t theRightKey,
    [param: DisallowNull_t] Value_t theRightValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theRightChild)
    : TreeRoot<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t] public TreeNode<Key_t, Value_t> LeftChild { get => theLeftChild; }
    [property: NotNull_t] public Key_t LeftKey { get => theLeftKey; }
    [property: NotNull_t] public Value_t LeftValue { get => theLeftValue; }
    [property: NotNull_t] public TreeNode<Key_t, Value_t> MiddleChild { get => theMiddleChild; }
    [property: NotNull_t] public Key_t RightKey { get => theRightKey; }
    [property: NotNull_t] public Value_t RightValue { get => theRightValue; }
    [property: NotNull_t] public TreeNode<Key_t, Value_t> RightChild { get => theRightChild; }
}

[type: Description_t("Child-node class")]
internal abstract class TreeNode<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
}

[type: Description_t("Child-node class")]
internal sealed class SingletonNode<Key_t, Value_t>
    ([param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeft,
    [param: DisallowNull_t] Key_t theKey,
    [param: DisallowNull_t] Value_t theValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theRight)
    : TreeNode<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t] public TreeNode<Key_t, Value_t> LeftChild { get => theLeft; }
    [property: NotNull_t] public Key_t Key { get => theKey; }
    [property: NotNull_t] public Value_t Value { get => theValue; }
    [property: NotNull_t] public TreeNode<Key_t, Value_t> RightChild { get => theRight; }
}

[type: Description_t("Child-node class")]
internal sealed class DoubletonNode<Key_t, Value_t>
    ([param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeftChild,
    [param: DisallowNull_t] Key_t theLeftKey,
    [param: DisallowNull_t] Value_t theLeftValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theMiddleChild,
    [param: DisallowNull_t] Key_t theRightKey,
    [param: DisallowNull_t] Value_t theRightValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theRightChild)
    : TreeNode<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t] public TreeNode<Key_t, Value_t> LeftChild { get => theLeftChild; }
    [property: NotNull_t] public Key_t LeftKey { get => theLeftKey; }
    [property: NotNull_t] public Value_t LeftValue { get => theLeftValue; }
    [property: NotNull_t] public TreeNode<Key_t, Value_t> MiddleChild { get => theMiddleChild; }
    [property: NotNull_t] public Key_t RightKey { get => theRightKey; }
    [property: NotNull_t] public Value_t RightValue { get => theRightValue; }
    [property: NotNull_t] public TreeNode<Key_t, Value_t> RightChild { get => theRightChild; }
}

[type: Description_t("Child-node class")]
internal sealed class SingletonLeaf<Key_t, Value_t>
    ([param: DisallowNull_t] Key_t theKey,
    [param: DisallowNull_t] Value_t theValue)
    : TreeNode<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t] public Key_t Key { get => theKey; }
    [property: NotNull_t] public Value_t Value { get => theValue; }
}

[type: Description_t("Child-node class")]
internal sealed class DoubletonLeaf<Key_t, Value_t>
    ([param: DisallowNull_t] Key_t theLeftKey,
    [param: DisallowNull_t] Value_t theLeftValue,
    [param: DisallowNull_t] Key_t theRightKey,
    [param: DisallowNull_t] Value_t theRightValue)
    : TreeNode<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t] public Key_t LeftKey { get => theLeftKey; }
    [property: NotNull_t] public Value_t LeftValue { get => theLeftValue; }
    [property: NotNull_t] public Key_t RightKey { get => theRightKey; }
    [property: NotNull_t] public Value_t RightValue { get => theRightValue; }
}
