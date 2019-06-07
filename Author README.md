# Chapter 1 - C# in focus

## Getting started with tuples
Exactly what makes tupels so great? As you know, returning multiple values from a function is something you can already do in C#. Tuples simply give you another way to do this.

## Pattern matching
In C# 7, we now have the ability to use pattern matching. By using patterns, we can test if a value has a certain shape and if so, work with the information of that matching shape.

## Using out variables
The out keyword in C# has been around for a while. Using out passes arguments by reference. By default, all parameters in C# are passed by value unless you explicitly include an out or ref modifier.

## Using local functions
Local functions are private methods that are nested in another member. The use of local functions is quite common in functional languages. This has now been included in C# 7.

## Generalized async return types
The functionality of async/await is widely used to avoid performance bottlenecks and improve the responsiveness of your application. There is a slight issue though that in certain situations, returning a Task object from async methods could introduce performance issues. This is especially evident when an async method returns a cached result or completes in a synchronous fashion. 

## Throw expressions
Before C# 7, we used throw statements. The use of throw expressions didn't exist. It sort of makes sense, because using throw as an expression would always result in an exception. Whatever the reasoning was for not including throw expressions, the evolution of C# has necessitated the inclusion of this feature. The inclusion of throw expressions is now available in C# 7 in a limited set of contexts.

## Discards
C# 7 saw the introduction of discards. This is a really welcome addition to the language. It allows you to tell the compiler that you do not care about the value of a specific variable. Discards is therefore a dummy or temporary variable that is not going to be used at all in your application.

# Chapter 2 - Exploring C#

## Using and Implementing Abstract Classes
When we use the abstract modifier in a class declaration, we are actually saying that the class we are creating is only the basic base class of other classes. This means that any members marked as abstract or that are included in the base class have to be implemented by the derived classes (classes that use the base class).

## Using and implementing Interfaces
In the previous section, we had a look at abstract classes. You will remember that I said that abstract classes act like a common noun that describes the derived objects. When referring to interfaces however, we are saying that some or all of the derived classes share some sort of functionality. We can thus think of interfaces as verbs that describe an action.

## Asynchronous programming using async and await
Asynchronous programming will allow you to write code that can perform long running tasks while still keeping your application responsive. With the introduction of async in the .NET Framework 4.5, it removed the previously complicated approach to implementing asynchronous functionality in your applications.

## Making use of extension methods
Since C# 3.0, extension methods have been making a huge difference in how I use my code. I am able to add methods to existing types without creating a new derived type. The C# Programming guide describes extension methods as a special kind of static method. The only difference is that they are called as if they were instance methods on the type being extended (i.e. called by using instance method syntax).

## Generics
Generics have been with us since C# 2. The goal was to allow developers to reuse code while maintaining type safety. Think of generics as a blueprint that will allow you to define data structures that are type safe without the commitment of actually defining a type.

## Nullable types
In C#, all reference types such as strings are nullable. In fact, null is the default value of reference type variables. This means that, while they can be null, we actually need to see the null keyword as a literal that represents a null reference. Put differently, something that does not refer to any object in .NET. With the release of C# 2.0, we were introduced to nullable value types.

## Dynamic types
With the release of C# 4.0, developers were introduced to a new dynamic type. It's a static type, but dynamic objects bypass static type checking. Think of it acting like it has a type object.

# Chapter 3 - The new features of C# 8.0

## Nullable reference types
You will remember from the previous chapter that in order to mark a variable as nullable, you need to use the type and ? when declaring a variable. For example, int? represents a nullable int. Now you can do the same with reference types such as string? to declare a nullable string.

## Recursive patterns
Recursive patterns are a welcome addition to C#. You will remember that in C# 7, we saw the introduction of pattern matching. C# 8.0 takes this a step further by allowing patterns to contain other patterns.

## Ranges and indices
Ranges and indicies were designed in the first few months of 2018. What C# 8.0 allows us to do with indexed data structures is grab a slice of the array, string or span.

## Switch expressions
C#8.0 introduces switch expressions where the cases are expressions. Think of it as a lightweight version of switch statements.

## Target-typed new-expressions
In the past, you would need to add the type when creating an array of Point for example. With C# 8.0, when the type is given from the context, you can omit the type in these situations.

## Async streams
Think of a database that is queried for data which it can't return all at once. So, it needs to stream it, and the data will arrive at the calling code at certain intervals. Your code, however, wants to process this data in its own time. It is for this reason that C# 8.0 introduced IAsyncEnumerable<T> which is an asynchronous version of IEnumerable<T>.

## Using declarations
Another nice addition to C# 8.0 is the feature of simplifying using statements. Traditionally, using statements introduce a level of nesting. For simple cases, we now have using declarations in C# 8.0.

# Chapter 4 - Creating responsive web applications using ASP.NET MVC

## Creating your ASP.NET MVC Application
Responsive web applications are essential in modern application development. Users need to be able to view the content of your web application on any device. This means that a web application needs to resize itself based on whatever device it is being viewed on.

## Referencing jQuery and Bootstrap
In your Solution Explorer, if you expand the App_Start folder you will see a class called BundleConfig. It is here that you will see references to CSS and JavaScript files.

## Setting up and using SCSS
SCSS is an implementation of SASS (Syntactically Awesome Style Sheets). In fact, SASS supports two types of syntax namely SCSS and SASS. The main difference between SCSS and SASS is the use of curly braces and semicolons that SCSS uses. Being used to C#, it makes more sense to use SCSS. SCSS is fully compliant with CSS, so all your existing code will still work.

## Creating Models, Controllers, Views and using Razor
The whole premise of MVC is to separate concerns based on the role of each part of your application. As you probably know, MVC stands for Model, View and Controller. Let's see how this all fits together.

## Adding a plugin
Sometimes you might want to add additional functionality to a web application. Sure, you can definitely roll your own, but why reinvent the wheel if the functionality exists in a plugin?

## Testing your responsive layout using Chrome
The Google Chrome browser has definitely become one of the most popular browsers in the world today. The power of being able to add functionality to the browser with extensions, allows users to make it their own. For developers, it also provides a host of features in the form of Chrome's Developer Tools.

## Debugging your jQuery using Chrome Developer Tools
Being able to debug your jQuery and JavaScript gives you complete control over the code you write. No more guessing and hit and miss attempts at debugging errors (here's looking at you SYSPRO VbScript devs). You can write your jQuery and use Chrome Developer Tools with complete confidence to debug your code.

# Chapter 5 - Getting started with .NET Core 3.0

## Creating .NET Core Apps in Visual Studio 2019
These days it's hard to do anything online without hearing the word .NET Core . It might leave some wondering exactly what it is. Well, .NET Core is an open -source development platform that is maintained on Github by Microsoft and the .NET Community. It allows developers to write applications that suppo rt Windows, Linux and macOS.

## What is new in .NET Core 3.0
There are a host of new features in .NET Core 3.0, some of which I will not discuss. I will however, highlight some of the more interesting features such as Windows desktop, support for C#8, default executables, fast built-in JSON support and Cryptography.

## Installing .NET Core 3.0 Preview on Linux with Snap
The recommended way to install .NET Core 3.0 Preview on Linux is via Snap.

## Create and Run an ASP.NET MVC app on Linux
See what you need to do to get your ASP.NET Core MVC app up and running on Linux.

## Edit your ASP.NET Core MVC app on Linux with Visual Studio Code
Microsoft has done a huge amount of work to bring Visual Studio to all platforms. Visual Studio Code gives developers a fantastic IDE for creating applications on Linux and macOS. I even use it daily on my Windows Desktop if I need to quickly work on a file.

## Debug your ASP.NET Core MVC project with Visual Studio Code
Visual Studio Code allows you to debug your code. You need to do a little heavy lifting to get this all set up, but once you have done this, you're all sorted.

# Chapter 6 - Being more productive in Visual Studio 2019

## New features in Visual Studio 2019
Visual Studio 2019 brings what matters most to developers, in a more condensed and focusd way by providing a fresh perspective on the UI.

## Visual Studio Live Share
Visual Studio Live Share is a fantastic service that allows you to "phone a friend" essentially. You can share your codebase and its context with a colleague and collaborate with them right from within Visual Studio.

## Refactorings and code fixes
In this section of the book we will be looking at some general Visual Studio tips. You can use these in Visual Studio to improve your code and become more productive in your day-to-day coding.

## Enable JavaScript debugging in ASP.NET projects
If you create a new browser config in the Browse with menu for an ASP.NET project, Visual Studio 2019 will enable JavaScript debugging for your project when you launch your debug session.

## Exporting your editor settings
If you are working in a team, you can use a file called an EditorConfig file to enforce certain coding styles for your project. The nice thing about an EditoConfig file is the fact that you can check it in to source control and have it travel with each new pull of the repo.

## Visual Studio IntelliCode using AI
In 2018 during Build, Microsoft announced the AI powered Visual Studio IntelliCode. It is aimed at improving the productivity of developers by providing recommendations on contextual code completion, inferring style rules and code formatting. It is available for Visual Studio 2017, 2019 and Visual Studio Code as an optional extension.

## General Visual Studio Tips
Visual Studio offers you so much flexibility in what you can do. It is the gold standard of IDE's in my opinion. As mentioned earlier in this chapter, some of the finer tips and features might get overlooked. 