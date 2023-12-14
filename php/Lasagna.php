<?php

declare(strict_types=1);

class Lasagna
{
    function expectedCookTime()
    {
        return 40;
    } 

    function remainingCookTime($elapsed_minutes)
    {
        $time = $this->expectedCookTime();

        return $time - $elapsed_minutes;
    }

    function totalPreparationTime($layers_to_prep)
    {
        return $layers_to_prep * 2;
    }

    function totalElapsedTime($layers_to_prep, $elapsed_minutes)
    {
        $layers = $this->totalPreparationTime($layers_to_prep);

        return $elapsed_minutes + $layers;
    }

    function alarm()
    {
        return "Ding!";
    }
}
