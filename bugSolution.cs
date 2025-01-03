public class MyClass {
    public int MyProperty { get; set; } //added default value

    public MyClass(){
        MyProperty = 0; // Initialize the property in the constructor
    }
    public void MyMethod() {
        int value = MyProperty; // Now, MyProperty will always have an initial value
    }
}