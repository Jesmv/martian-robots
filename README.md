# Martian Robots

This is a solution for GuideSmith position. Exercise is done by Jessica Manso. 
It is written in C# using **.Net core** and simulate the movement of a Martian Robot.

## Prerequisites

* .Net Core SDK 3.1
* Docker

## Restore the solution 

```
dotnet restore
```

## Run the exercise
To build and run the program, go to the Robots folder and run the project:

```
cd Robots
dotnet run INPUT_FILE
```

The input file should include the planet dimension in the first line, and the initial position and movements for each robot. 
Like this:

```
5 3
1 1 E
RFRFRFRF
3 2 N
FRRFLLFFRRFLL
0 3 W
LLFFFLFLFL
```

## Run with docker

Build the docker image:

```
docker build -t martian_robots .
```

Run the container:

```
docker run -ti --rm -v YOUR_DATA_FOLDER:/data martian_robots /data/robots.txt
```

## Run tests

I used XUnit test from .NET framework.

To run the tests, make sure you are in the `Robots.Tests` folder, then execute the command:
```
dotnet test
```
