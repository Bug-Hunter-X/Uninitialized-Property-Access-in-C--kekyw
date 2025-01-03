public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property that hasn't been initialized can lead to unexpected behavior.
        int value = MyProperty; // This could cause an error depending on the context.
    }
}