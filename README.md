# Robot

This project is a coding test. This test consists of creating a program that controls the movement of a robot in a defined space.

To solve this test, I have used C#, .Net Framework 4.7.2 and NUnit. With these tools I have implemented a console application that reads the instructions to be executed by the robot and outputs its position and orientation.

The solution is composed of two projects. On one hand, a project called **"Robot"** in which the code that controls the robot is implemented. On the other hand a project called **"Robot.Tests"** with all the unit tests created to test the code.

The "Robot" project consists of three main classes:
- The "Board" class represents the space in which the robot moves.
- The "Robot" class represents the robot. This class has two functions:
  - "Move()" in charge of moving the robot forward.
  - "ChangeDirection()" in charge of changing the direction of the robot.
 - The "ControlPanel" class is in charge of reading the input, moving the robot and returning the final position.

## How To Use
When executing the code, a console will appear in which the board size and the command must be entered. 
For example:
```
5x5
FFRFLFLF
```
The result:
```
2,5,NorthWest
```
