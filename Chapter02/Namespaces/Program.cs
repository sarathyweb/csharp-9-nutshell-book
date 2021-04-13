using System;
// A namespace is a domain for type names
// Types are typically organized in hierarchical namespaces

namespace Outer
{
    namespace Middle
    {
        namespace Inner
        {
            class Class1 { }
            class Class2 { }
        }
    }
}

// using directive
// The using directive imports a namespace

// Using static
// The using static directive imports a type rather than a namespace
//
//using static System.Console;
//WriteLine("Hello");
