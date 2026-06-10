# codesignalPracticeQuestions

Implementations of the practice questions on codesignal.

## AddTwoDigits

For a given integer value returns the sum of the digits so an input of 29 gives an output of 11 (2 + 9 = 11).

## ProcessQueries

Process a list of operations to either "ADD" an integer, check whether a specified integer "EXISTS", "REMOVE" the first occurrence of an integer or "GET_NEXT" to determine the next highest value.

A response which gives an optional result of these operations is returned. Empty string indicates there was no result as in the case of the "ADD" operation.

This method uses a Jagged Array: https://stackoverflow.com/questions/2576759/what-is-a-jagged-array 

SonarQube suggests this should be fixed so we probably wouldn't use this in real code, see csharpsquid:S2368 (Public methods should not have multidimensional array parameters).

## Notes

The solutions have been implemented in .NET 10 as the version used for the Code Signal tests is no longer active (.NET v9.0.203).
