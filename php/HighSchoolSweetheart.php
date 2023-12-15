<?php

class HighSchoolSweetheart
{
    public function firstLetter(string $name): string
    {
        return ltrim($name)[0];
    }

    public function initial(string $name): string
    {
        $initial = strtoupper($this->firstLetter($name));

        return "{$initial}.";
    }

    public function initials(string $name): string
    {
        $nameArr = explode(" ", trim($name));
        $initials = '';

        foreach ($nameArr as $nameSplit) {
            $initials .= $this->initial($nameSplit) . ' ';
        }

        return rtrim($initials);
    }

    public function pair(string $sweetheart_a, string $sweetheart_b): string
    {
        $firstInitials = $this->initials($sweetheart_a);
        $secondInitials = $this->initials($sweetheart_b);

        return <<<HEART
                 ******       ******
               **      **   **      **
             **         ** **         **
            **            *            **
            **                         **
            **     $firstInitials  +  $secondInitials     **
             **                       **
               **                   **
                 **               **
                   **           **
                     **       **
                       **   **
                         ***
                          *
            HEART;
    }
}
