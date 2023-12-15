<?php

class PizzaPi
{
    public function calculateDoughRequirement($pizzas, $persons)
    {
        return $pizzas * (($persons * 20) + 200);
    }

    public function calculateSauceRequirement($pizzas, $canVolume)
    {
        return $pizzas * 125 / $canVolume;
    }

    public function calculateCheeseCubeCoverage($cheeseDimension, $thickness, $pizzaDiameter)
    {
        return floor(($cheeseDimension ** 3) / ($thickness * pi() * $pizzaDiameter));
    }

    public function calculateLeftOverSlices($pizzas, $friends)
    {
        return $pizzas * 8 % $friends;
    }
}
