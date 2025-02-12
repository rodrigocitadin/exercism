# SOLUTION ONE

# def square(number):
#     if number < 1 or number > 64:
#         raise ValueError("square must be between 1 and 64")

#     return number ** (number - 1)

# def total():
#     return 2 ** 64 - 1

# SOLUTION TWO

# def square(number):
#     if number < 1 or number > 64:
#         raise ValueError("square must be between 1 and 64")

#     return pow(2, number - 1)

# def total():
#     return pow(2, 64) - 1

# SOLUTION THREE

def square(number):
    if number < 1 or number > 64:
        raise ValueError("square must be between 1 and 64")

    return 1 << number - 1

def total():
    return (1 << 64) - 1
