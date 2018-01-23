# NoUnit
Autogenerate complete functional unit test cases for .Net projects. Save UT writing  Time


Load dll and it will autogenerate every combination of Unit tests for you. No time spent on writing UT anymore.


### This is a POC. Code will be Rewritten.

## Differences From IntelliTest
1. Intellitest just runs your functions with multiple input to tell you weather it breaks or not with multiple inputs
2. If logic changes and return values change, Intellitest does not check it as Intellitest only looks for brekage
3. Nounit also creates a UT dll which will remember what previous values where. If logic is changed in any way, it will break not just on exceptions.

NoUnit supports everything that intellitest does. It will create a UT dll based on existing code and have multiple test cases with all possible inputs.
If code is changes, and UT is run with the previous geneated dll, it will break if return values are changed. So it has **memory**. IntelliTest does not have memory.
