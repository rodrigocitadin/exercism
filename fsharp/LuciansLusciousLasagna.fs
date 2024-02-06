module LuciansLusciousLasagna

let expectedMinutesInOven = 40

let remainingMinutesInOven timeInOven = expectedMinutesInOven - timeInOven

let preparationTimeInMinutes layers = layers * 2

let elapsedTimeInMinutes layers minutes =
    preparationTimeInMinutes layers + minutes
