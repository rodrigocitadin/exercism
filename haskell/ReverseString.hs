module ReverseString (reverseString) where

-- Bad solution n**2
-- reverseString :: String -> String
-- reverseString [] = []
-- reverseString (x:xs) = reverseString xs ++ [x]

reverseString :: String -> String
reverseString = foldl (flip (:)) []
