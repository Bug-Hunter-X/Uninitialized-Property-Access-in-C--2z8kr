# Uninitialized Property Access in C#

This repository demonstrates a common, yet subtle, error in C#: accessing a property before it has been initialized.  The example shows how this can lead to unexpected behavior, often resulting in a default value (0 for integers) being used instead of the intended value.

The `UninitializedProperty.cs` file contains the buggy code.  The `UninitializedPropertySolution.cs` file provides a corrected version.