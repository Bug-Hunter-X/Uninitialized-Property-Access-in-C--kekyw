# Uninitialized Property Access in C#

This repository demonstrates a common but subtle error in C#: accessing a property before it has been assigned a value.  This can lead to unexpected behavior, often resulting in `NullReferenceException`s or other unpredictable results. The example showcases this issue and provides a solution.

## The Problem

In the `bug.cs` file, the `MyClass` class defines a property `MyProperty` but doesn't initialize it in the constructor.  The `MyMethod` function attempts to read the value of `MyProperty` without ensuring it has a value. This can result in a runtime exception or, at best, an unexpected value.

## The Solution

The `bugSolution.cs` file demonstrates how to avoid this issue. It initializes `MyProperty` in the constructor, ensuring it always holds a valid value before access.