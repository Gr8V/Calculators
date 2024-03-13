import math
import os

firstNum = int()
secondNum = int()

shouldExit = False

while shouldExit != True:
    op = str()
    try:
        firstNum = int(input("First Number: "))
        op = input("Enter a operator: ")
        if op != "sqrt":
            secondNum = int(input("Second Number: "))
    except ValueError:
        print("Invalid input! Please enter a valid number.")
    output = int()
    match op:
        case "+":
            output = firstNum+secondNum
        case "-":
            output = firstNum-secondNum
        case "*":
            output = firstNum*secondNum
        case "/":
            output = firstNum/secondNum
        case "**":
            output = firstNum**secondNum
        case "sqrt":
            output = math.sqrt(firstNum)
        case _:
            print("Not a valid operator.")
    print("Output: ", output)
    status = input("write 'y' to continue: ")
    if status == "y":
        os.system('cls' if os.name == 'nt' else 'clear')
    else:
        shouldExit = True
