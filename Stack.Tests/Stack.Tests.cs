namespace Stack.Tests;

public class StackTests
{
    // SUT is the functionality that we are testing.
    
    [Fact]
    public void RemoveIntFromStack(){
        //Arrange
        int StackLength = 10;
        int FirstStackNumber = 1;
        int SecondStackNumber = 55;
        //Act
        TStack<int> stack = new(StackLength);
        stack.Push(FirstStackNumber);
        stack.Push(SecondStackNumber);

        //Assert
        stack.RemoveTop();
        Assert.Equal(1,stack.CheckTop());
    }

    [Fact]
    public void AddIntToStack()
    {
        //Arrange
        int StackLength = 10;
        int FirstStackNumber = 1;
        //Act
        TStack<int> stack = new(StackLength);
        stack.Push(FirstStackNumber);
        //Assert
        Assert.Equal(1,stack.CheckTop());
    }
    [Fact]
    public void AddStringToStack()
    {
        //Arrange
        int StackLength = 10;
        string FirstStackItem = "Banana";
        //Act
        TStack<string> stack = new(StackLength);
        stack.Push(FirstStackItem);
        //Assert
        Assert.Equal("Banana",stack.CheckTop());
    }

    [Fact]
    public void IsStackEmpty()
    {
        //Arrange
        int StackLength = 10;
        //Act
        TStack<int> stack = new(StackLength);
        //Assert
        //Assert.Equal(0,stack.CheckTop());
        InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => stack.CheckTop());
        Assert.Equal("Array is empty!",exception.Message);
    }

}
