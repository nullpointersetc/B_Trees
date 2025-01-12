using AssemblyCompany_a = System.Reflection.AssemblyCompanyAttribute;
using AssemblyCopyright_a = System.Reflection.AssemblyCopyrightAttribute;
using AssemblyDescription_a = System.Reflection.AssemblyDescriptionAttribute;
using AssemblyInformationalVersion_a = System.Reflection.AssemblyInformationalVersionAttribute;
using Description_t = System.ComponentModel.DescriptionAttribute;
using DisallowNull_t = System.Diagnostics.CodeAnalysis.DisallowNullAttribute;
using NotImplementedException_t = System.NotImplementedException;
using NotNull_t = System.Diagnostics.CodeAnalysis.NotNullAttribute;
using AssemblyMetadata_a = System.Reflection.AssemblyMetadataAttribute;
using AssemblyProduct_a = System.Reflection.AssemblyProductAttribute;
using AssemblyTitle_a = System.Reflection.AssemblyTitleAttribute;
using AssemblyVersion_a = System.Reflection.AssemblyVersionAttribute;
using ApplicationException_t = System.ApplicationException;
using ArgumentOutOfRangeException = System.ArgumentOutOfRangeException;

[assembly: AssemblyTitle_a(title: "Two-Three-Trees library"),
    AssemblyProduct_a(product: "B-Tree libraries"),
    AssemblyCompany_a(company: "Null Pointers etc."),
    AssemblyCopyright_a(copyright: "2025"),
    AssemblyDescription_a(description: "An implementation of 2-3 trees."),
    AssemblyVersion_a(version: "2025.0112.0.0")]

namespace NullPointersEtc.TwoThreeTrees;

[type: Description_t("2-3 tree type")]
public sealed class TwoThreeTree<Key_t, Value_t>
    where Key_t : notnull, System.IComparable<Key_t>
    where Value_t : notnull
{
    public TwoThreeTree()
    {
        root = New1();
    }

    public void Set(Key_t key, Value_t value)
    {
        if (root is EmptyTree<Key_t, Value_t>)
            root = New2(key, value);
        else
            throw new NotImplementedException_t();
    }

    public bool Contains(
        [param: DisallowNull_t] Key_t key)
    {
        if (root is EmptyTree<Key_t, Value_t>)
            return false;
        else if (root is SingletonTree<Key_t, Value_t> singleton)
            return singleton.Key.Equals(key);
        else
            return false;
    }

    public Value_t Get(
        [param: DisallowNull_t] Key_t key)
    {
        if (root is EmptyTree<Key_t, Value_t>)
            throw new ArgumentOutOfRangeException(
                paramName: nameof(key),
                actualValue: key,
                message: "key is not set in this tree");
        else if (root is SingletonTree<Key_t, Value_t> singleton)
            if (singleton.Key.Equals(key))
                return singleton.Value;
            else
                throw new ArgumentOutOfRangeException(
                    paramName: nameof(key),
                    actualValue: key,
                    message: "key is not set in this tree");
        else
            throw new ArgumentOutOfRangeException(
               paramName: nameof(key),
               actualValue: key,
               message: "key is not set in this tree");
    }

    public void Remove(
        [param: DisallowNull_t] Key_t key)
    {
        if (root is EmptyTree<Key_t, Value_t>)
            return;
        else if (root is SingletonTree<Key_t, Value_t> sing)
            if (sing.Key.Equals(key))
                root = New1();
            else
                return;
        else
            throw new NotImplementedException_t();
    }

    private static bool Compare(Key_t left, Key_t comesBefore) => left.CompareTo(comesBefore) < 0;

    private static EmptyTree<Key_t, Value_t> New1()
        => new EmptyTree<Key_t, Value_t>();

    private static SingletonTree<Key_t, Value_t> New2(
        [param: DisallowNull_t] Key_t theKey,
        [param: DisallowNull_t] Value_t theValue)
        => new SingletonTree<Key_t, Value_t>(
            theKey: theKey, theValue: theValue);

    private static DoubletonTree<Key_t, Value_t> New3(
        [param: DisallowNull_t] Key_t theLeftKey,
        [param: DisallowNull_t] Value_t theLeftValue,
        [param: DisallowNull_t] Key_t theRightKey,
        [param: DisallowNull_t] Value_t theRightValue)
        => new DoubletonTree<Key_t, Value_t>(
            theLeftKey: theLeftKey, theLeftValue: theLeftValue,
            theRightKey: theRightKey, theRightValue: theRightValue);

    private static SingletonRoot<Key_t, Value_t> New4(
        [param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeft,
        [param: DisallowNull_t] Key_t theKey,
        [param: DisallowNull_t] Value_t theValue,
        [param: DisallowNull_t] TreeNode<Key_t, Value_t> theRight)
        => new SingletonRoot<Key_t, Value_t>(
            theLeft: theLeft,
            theKey: theKey, theValue: theValue,
            theRight: theRight);

    private static DoubletonRoot<Key_t, Value_t> New5(
        [param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeftChild,
        [param: DisallowNull_t] Key_t theLeftKey,
        [param: DisallowNull_t] Value_t theLeftValue,
        [param: DisallowNull_t] TreeNode<Key_t, Value_t> theMiddleChild,
        [param: DisallowNull_t] Key_t theRightKey,
        [param: DisallowNull_t] Value_t theRightValue,
        [param: DisallowNull_t] TreeNode<Key_t, Value_t> theRightChild)
        => new DoubletonRoot<Key_t, Value_t>(
            theLeftChild: theLeftChild,
            theLeftKey: theLeftKey,
            theLeftValue: theLeftValue,
            theMiddleChild: theMiddleChild,
            theRightKey: theRightKey,
            theRightValue: theRightValue,
            theRightChild: theRightChild);

    private static SingletonNode<Key_t, Value_t> New6(
        [param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeft,
        [param: DisallowNull_t] Key_t theKey,
        [param: DisallowNull_t] Value_t theValue,
        [param: DisallowNull_t] TreeNode<Key_t, Value_t> theRight)
        => new(theLeft: theLeft,
            theKey: theKey, theValue: theValue, theRight: theRight);

    private static DoubletonNode<Key_t, Value_t> New7(
        [param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeftChild,
        [param: DisallowNull_t] Key_t theLeftKey,
        [param: DisallowNull_t] Value_t theLeftValue,
        [param: DisallowNull_t] TreeNode<Key_t, Value_t> theMiddleChild,
        [param: DisallowNull_t] Key_t theRightKey,
        [param: DisallowNull_t] Value_t theRightValue,
        [param: DisallowNull_t] TreeNode<Key_t, Value_t> theRightChild)
        => new(theLeftChild: theLeftChild,
            theLeftKey: theLeftKey, theLeftValue: theLeftValue,
            theMiddleChild: theMiddleChild,
            theRightKey: theRightKey, theRightValue: theRightValue,
            theRightChild: theRightChild);

    private static SingletonLeaf<Key_t, Value_t> New8(
        [param: DisallowNull_t] Key_t theKey,
        [param: DisallowNull_t] Value_t theValue)
        => new(theKey: theKey, theValue: theValue);

    private static DoubletonLeaf<Key_t, Value_t> New9(
        [param: DisallowNull_t] Key_t theLeftKey,
        [param: DisallowNull_t] Value_t theLeftValue,
        [param: DisallowNull_t] Key_t theRightKey,
        [param: DisallowNull_t] Value_t theRightValue)
        => new(theLeftKey: theLeftKey,
            theLeftValue: theLeftValue,
            theRightKey: theRightKey,
            theRightValue: theRightValue);

    [field: NotNull_t]
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
    where Key_t : notnull, System.IComparable<Key_t>
    where Value_t : notnull
{
}

[type: Description_t("Root class")]
internal sealed class SingletonTree<Key_t, Value_t>
    ([param: DisallowNull_t] Key_t theKey,
    [param: DisallowNull_t] Value_t theValue)
    : TreeRoot<Key_t, Value_t>
    where Key_t : notnull, System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t]
    public Key_t Key { get => theKey; }

    [property: NotNull_t]
    public Value_t Value { get => theValue; }
}

[type: Description_t("Root class")]
internal sealed class DoubletonTree<Key_t, Value_t>
    ([param: DisallowNull_t] Key_t theLeftKey,
    [param: DisallowNull_t] Value_t theLeftValue,
    [param: DisallowNull_t] Key_t theRightKey,
    [param: DisallowNull_t] Value_t theRightValue)
    : TreeRoot<Key_t, Value_t>
    where Key_t : notnull, System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t]
    public Key_t LeftKey { get => theLeftKey; }

    [property: NotNull_t]
    public Value_t LeftValue { get => theLeftValue; }

    [property: NotNull_t]
    public Key_t RightKey { get => theRightKey; }

    [property: NotNull_t]
    public Value_t RightValue { get => theRightValue; }
}

[type: Description_t("Root class")]
internal sealed class SingletonRoot<Key_t, Value_t>(
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeft,
    [param: DisallowNull_t] Key_t theKey,
    [param: DisallowNull_t] Value_t theValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theRight)
    : TreeRoot<Key_t, Value_t>
    where Key_t : notnull, System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t]
    public TreeNode<Key_t, Value_t> LeftChild { get => theLeft; }

    [property: NotNull_t]
    public Key_t Key { get => theKey; }

    [property: NotNull_t]
    public Value_t Value { get => theValue; }

    [property: NotNull_t]
    public TreeNode<Key_t, Value_t> RightChild { get => theRight; }
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
    where Key_t : notnull, System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t]
    public TreeNode<Key_t, Value_t> LeftChild { get => theLeftChild; }

    [property: NotNull_t]
    public Key_t LeftKey { get => theLeftKey; }

    [property: NotNull_t]
    public Value_t LeftValue { get => theLeftValue; }

    [property: NotNull_t]
    public TreeNode<Key_t, Value_t> MiddleChild
    { get => theMiddleChild; }

    [property: NotNull_t]
    public Key_t RightKey { get => theRightKey; }

    [property: NotNull_t]
    public Value_t RightValue
    { get => theRightValue; }

    [property: NotNull_t]
    public TreeNode<Key_t, Value_t> RightChild
    { get => theRightChild; }
}

[type: Description_t("Child-node class")]
internal abstract class TreeNode<Key_t, Value_t>
    where Key_t : notnull, System.IComparable<Key_t>
    where Value_t : notnull
{
    public bool MustExpandToSet(Key_t key) => false;

    public TreeNode<Key_t, Value_t> Set(Key_t key, Value_t value) => this;

    public TreeNode<Key_t, Value_t>
        ExpandedLeft(Key_t key, Value_t value)
        => throw new NotImplementedException_t();

    public Key_t ExpandedMiddleKey(Key_t key, Value_t value)
        => key;

    public Value_t ExpandedMiddleValue(Key_t key, Value_t value)
        => value;

    public TreeNode<Key_t, Value_t>
        ExpandedRight(Key_t key, Value_t value)
        => throw new NotImplementedException_t();
}

[type: Description_t("Child-node class")]
internal sealed class SingletonNode<Key_t, Value_t>
    ([param: DisallowNull_t] TreeNode<Key_t, Value_t> theLeft,
    [param: DisallowNull_t] Key_t theKey,
    [param: DisallowNull_t] Value_t theValue,
    [param: DisallowNull_t] TreeNode<Key_t, Value_t> theRight)
    : TreeNode<Key_t, Value_t>
    where Key_t : notnull, System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t]
    public TreeNode<Key_t, Value_t> LeftChild { get => theLeft; }

    [property: NotNull_t]
    public Key_t Key { get => theKey; }

    [property: NotNull_t]
    public Value_t Value { get => theValue; }

    [property: NotNull_t]
    public TreeNode<Key_t, Value_t> RightChild { get => theRight; }
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
    [property: NotNull_t]
    public TreeNode<Key_t, Value_t> LeftChild { get => theLeftChild; }

    [property: NotNull_t]
    public Key_t LeftKey { get => theLeftKey; }

    [property: NotNull_t]
    public Value_t LeftValue { get => theLeftValue; }

    [property: NotNull_t]
    public TreeNode<Key_t, Value_t> MiddleChild { get => theMiddleChild; }

    [property: NotNull_t]
    public Key_t RightKey { get => theRightKey; }

    [property: NotNull_t]
    public Value_t RightValue { get => theRightValue; }

    [property: NotNull_t]
    public TreeNode<Key_t, Value_t> RightChild { get => theRightChild; }
}

[type: Description_t("Child-node class")]
internal sealed class SingletonLeaf<Key_t, Value_t>
    ([param: DisallowNull_t] Key_t theKey,
    [param: DisallowNull_t] Value_t theValue)
    : TreeNode<Key_t, Value_t>
    where Key_t : notnull, System.IComparable<Key_t>
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
    where Key_t : notnull, System.IComparable<Key_t>
    where Value_t : notnull
{
    [property: NotNull_t]
    public Key_t LeftKey { get => theLeftKey; }

    [property: NotNull_t]
    public Value_t LeftValue { get => theLeftValue; }

    [property: NotNull_t]
    public Key_t RightKey { get => theRightKey; }

    [property: NotNull_t]
    public Value_t RightValue { get => theRightValue; }
}
