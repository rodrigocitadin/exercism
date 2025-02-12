module Darts (score) where

score :: Float -> Float -> Int
score x y
  | z <= 1 = 10
  | z <= 5 = 5
  | z <= 10 = 1
  | otherwise = 0
  where
    z = sqrt (x ^ 2 + y ^ 2)
