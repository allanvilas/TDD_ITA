



namespace Stack;

public class TStack<T>
{
    private T[] StackArray;
    private int Top = -1;

    public TStack(int Size)
    {
        StackArray = new T[Size];
    }

    public void Push(T Item)
    {
        if(StackArray.Length == Top){
            throw new OverflowException("Stack is full!");
        }
        StackArray[++Top] = Item;
    }

    public T CheckTop()
    {        
        if(Top == -1){
            throw new InvalidOperationException("Array is empty!");
        }
        // No Entries
        return StackArray[Top];        
    }

    public int Count()
    {
        if(StackArray.Length == -1){
            throw new Exception("Array is empty!");
        }
        return Top + 1;
    }

    public T RemoveTop()
    {
        if(StackArray.Length == -1){
            throw new InvalidOperationException("Array is empty!");
        }
        return StackArray[Top--];
    }
}