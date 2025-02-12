def is_armstrong_number(number: int) -> bool:
    digits = list(str(number))
    power = len(digits)
    result = 0

    for n in digits:
        digit = int(n) ** power
        result += digit

    return result == number

# Below is not my solution but a really pretty solution

# def is_armstrong_number(number: int) -> bool:
#     digits = str(number)
#     power = len(digits)

#     return number == sum([int(n) ** power for n in digits])
