<?php

class LuckyNumbers
{
    public function sumUp(array $digitsOfNumber1, array $digitsOfNumber2): int
    {
        return join($digitsOfNumber1) + join($digitsOfNumber2);
    }

    public function isPalindrome(int $number): bool
    {
        return $number == strrev($number) ? true : false;
    }

    public function validate(string $input): string
    {
        if ($input == '') return 'Required field';
        if ((int)$input > 0) return '';

        return 'Must be a whole number larger than 0';
    }
}
