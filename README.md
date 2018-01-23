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


Unit Tests are classically separated into three parts **Arrange, Act and Assert**. 
https://stackoverflow.com/questions/142481/auto-generation-of-net-unit-tests
Unit Test generators generally can only do the 'Arrange', and 'Act' portions on unit test creation; however unit test generators generally do not write 'Assert' portions as only you know what is correct and what is incorrect for your purposes.

NoUnit does assert as well


TDD
If the interfaces are defined, NoUnit would do Arrange and Act but not Assert as what happens in the test is not defined yet and NoUnit does not read your mind. Yet!


After Development Test
Nounit would do Assert as well as it will automatically detect the expected output based on function definiton. If the function body is also defined, NoUnit would detect the intended output with different parameters. If the function body is correct at Test generation time, the test cases generated would be complete and need no coding. If not it would require a revision.
