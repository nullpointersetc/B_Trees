using Description_t = System.ComponentModel.DescriptionAttribute;
using DisallowNull_t = System.Diagnostics.CodeAnalysis.DisallowNullAttribute;
using NotImplementedException_t = System.NotImplementedException;
using NotNull_t = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace NullPointersEtc.TwoThreeFourTrees;

public sealed class TwoThreeFourTree<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    public TwoThreeFourTree()
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
internal sealed class TripletonTree<Key_t, Value_t>
    ([param: DisallowNull_t] Key_t theLeftKey,
    [param: DisallowNull_t] Value_t theLeftValue,
    [param: DisallowNull_t] Key_t theMiddleKey,
    [param: DisallowNull_t] Value_t theMiddleValue,
    [param: DisallowNull_t] Key_t theRightKey,
    [param: DisallowNull_t] Value_t theRightValue)
    : TreeRoot<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t] public Key_t LeftKey { get => theLeftKey; }
    [property: NotNull_t] public Value_t LeftValue { get => theLeftValue; }
    [property: NotNull_t] public Key_t MiddleKey { get => theMiddleKey; }
    [property: NotNull_t] public Value_t MiddleValue { get => theMiddleValue; }
    [property: NotNull_t] public Key_t RightKey { get => theRightKey; }
    [property: NotNull_t] public Value_t RightValue { get => theRightValue; }
}

[type: Description_t("Root class")]
internal sealed class SingletonRoot<Key_t, Value_t>
    ([param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeftChild,
    [param: DisallowNull_t] Key_t theMiddleKey,
    [param: DisallowNull_t] Value_t theMiddleValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theRightChild)
    : TreeRoot<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t] public TreeNode<Key_t, Value_t> LeftChild { get => theLeftChild; }
    [property: NotNull_t] public Key_t MiddleKey { get => theMiddleKey; }
    [property: NotNull_t] public Value_t MiddleValue { get => theMiddleValue; }
    [property: NotNull_t] public TreeNode<Key_t, Value_t> RightChild { get => theRightChild; }
}

[type: Description_t("Root class")]
internal sealed class DoubletonRoot<Key_t, Value_t>
    ([param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeftChild,
    [param: DisallowNull_t] Key_t theLeftKey,
    [param: DisallowNull_t] Value_t theLeftValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeftMiddleChild,
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
    [property: NotNull_t] public TreeNode<Key_t, Value_t> LeftMiddleChild { get => theLeftMiddleChild; }
    [property: NotNull_t] public Key_t RightKey { get => theRightKey; }
    [property: NotNull_t] public Value_t RightValue { get => theRightValue; }
    [property: NotNull_t] public TreeNode<Key_t, Value_t> RightChild { get => theRightChild; }
}

[type: Description_t("Root class")]
internal sealed class TripletonRoot<Key_t, Value_t>
    ([param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeftChild,
    [param: DisallowNull_t] Key_t theLeftKey,
    [param: DisallowNull_t] Value_t theLeftValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeftMiddleChild,
    [param: DisallowNull_t] Key_t theMiddleKey,
    [param: DisallowNull_t] Value_t theMiddleValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theMiddleRightChild,
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
    [property: NotNull_t] public TreeNode<Key_t, Value_t> LeftMiddleChild { get => theLeftMiddleChild; }
    [property: NotNull_t] public Key_t MiddleKey { get => theMiddleKey; }
    [property: NotNull_t] public Value_t MiddleValue { get => theMiddleValue; }
    [property: NotNull_t] public TreeNode<Key_t, Value_t> MiddleRightChild { get => theMiddleRightChild; }
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
    ([param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeftChild,
    [param: DisallowNull_t] Key_t theMiddleKey,
    [param: DisallowNull_t] Value_t theMiddleValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theRightChild)
    : TreeNode<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t] public TreeNode<Key_t, Value_t> LeftChild { get => theLeftChild; }
    [property: NotNull_t] public Key_t MiddleKey { get => theMiddleKey; }
    [property: NotNull_t] public Value_t MiddleValue { get => theMiddleValue; }
    [property: NotNull_t] public TreeNode<Key_t, Value_t> RightChild { get => theRightChild; }
}

[type: Description_t("Child-node class")]
internal sealed class DoubletonNode<Key_t, Value_t>
    ([param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeftChild,
    [param: DisallowNull_t] Key_t theLeftKey,
    [param: DisallowNull_t] Value_t theLeftValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeftMiddleChild,
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
    [property: NotNull_t] public TreeNode<Key_t, Value_t> LeftMiddleChild { get => theLeftMiddleChild; }
    [property: NotNull_t] public Key_t RightKey { get => theRightKey; }
    [property: NotNull_t] public Value_t RightValue { get => theRightValue; }
    [property: NotNull_t] public TreeNode<Key_t, Value_t> RightChild { get => theRightChild; }
}

[type: Description_t("Child-node class")]
internal sealed class TripletonNode<Key_t, Value_t>
    ([param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeftChild,
    [param: DisallowNull_t] Key_t theLeftKey,
    [param: DisallowNull_t] Value_t theLeftValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeftMiddleChild,
    [param: DisallowNull_t] Key_t theMiddleKey,
    [param: DisallowNull_t] Value_t theMiddleValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theMiddleRightChild,
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
    [property: NotNull_t] public TreeNode<Key_t, Value_t> LeftMiddleChild { get => theLeftMiddleChild; }
    [property: NotNull_t] public Key_t MiddleKey { get => theMiddleKey; }
    [property: NotNull_t] public Value_t MiddleValue { get => theMiddleValue; }
    [property: NotNull_t] public TreeNode<Key_t, Value_t> MiddleRightChild { get => theMiddleRightChild; }
    [property: NotNull_t] public Key_t RightKey { get => theRightKey; }
    [property: NotNull_t] public Value_t RightValue { get => theRightValue; }
    [property: NotNull_t] public TreeNode<Key_t, Value_t> RightChild { get => theRightChild; }
}

[type: Description_t("Child-node class")]
internal sealed class SingletonLeaf<Key_t, Value_t>
    ([param: DisallowNull_t] Key_t theMiddleKey,
    [param: DisallowNull_t] Value_t theMiddleValue)
    : TreeNode<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t] public Key_t MiddleKey { get => theMiddleKey; }
    [property: NotNull_t] public Value_t MiddleValue { get => theMiddleValue; }
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

[type: Description_t("Child-node class")]
internal sealed class TripletonLeaf<Key_t, Value_t>
    ([param: DisallowNull_t] Key_t theLeftKey,
    [param: DisallowNull_t] Value_t theLeftValue,
    [param: DisallowNull_t] Key_t theMiddleKey,
    [param: DisallowNull_t] Value_t theMiddleValue,
    [param: DisallowNull_t] Key_t theRightKey,
    [param: DisallowNull_t] Value_t theRightValue)
    : TreeNode<Key_t, Value_t>
    where Key_t : System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t] public Key_t LeftKey { get => theLeftKey; }
    [property: NotNull_t] public Value_t LeftValue { get => theLeftValue; }
    [property: NotNull_t] public Key_t MiddleKey { get => theMiddleKey; }
    [property: NotNull_t] public Value_t MiddleValue { get => theMiddleValue; }
    [property: NotNull_t] public Key_t RightKey { get => theRightKey; }
    [property: NotNull_t] public Value_t RightValue { get => theRightValue; }
}
