i = False

while True:
    print("Weight converter.")
    try:
        weight = float(input("Your weight: "))
    except ValueError:
        print("Invalid input. Please enter a number for the weight.")
        continue

    unit = input("Is your weight in (K)g or (L)bs?: ")

    if unit.upper() == "K":
        converted = weight / 0.45
        print("Weight in Lbs: " + str(converted))
    elif unit.upper() == "L":
        converted = weight * 0.45
        print("Weight in Kg: " + str(converted))
    else:
        print("Input error. Please enter 'K' for kilograms or 'L' for pounds.")
        continue

    while True:
        retry = input("Do you want to try again? Y/N: ")
        if retry.upper() == "N":
            print("Have a nice day!")
            i = True
            break
        elif retry.upper() == "Y":
            break
        else:
            print("Wrong input, please try again.")
