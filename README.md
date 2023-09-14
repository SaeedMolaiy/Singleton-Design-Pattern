# Singleton Design Pattern

The Singleton pattern is a creational design pattern that ensures a class has only one instance and provides a global point of access to that instance. It is particularly useful when you want to control access to a shared resource or ensure that there's only one instance of a specific class in your application.

### How it Works

The `SingletonClass` class in this repository uses a few key techniques to implement the Singleton pattern:

1. **Private Constructor**: The `SingletonClass` has a private constructor, which means that instances of the class cannot be created from outside the class. This is essential to prevent multiple instances from being created.

2. **Static Instance**: The class includes a static private field `_singletonClass` to hold the single instance of the class. It is initially set to `null` to ensure lazy initialization.

3. **Lazy Initialization**: The instance is created only when it is first requested. This is achieved through the `GetSingletonClass` method, which checks whether `_singletonClass` is `null`. If it is `null`, a new instance of `SingletonClass` is created and assigned to `_singletonClass`.

4. **Thread Safety**: To ensure thread safety during instance creation, a lock is used. The `lock (Obj)` statement ensures that only one thread at a time can create the instance, preventing multiple instances from being created concurrently.
