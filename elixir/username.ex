defmodule Username do
  def sanitize([]), do: []

  def sanitize([head | tail]) when head == ?ä, do: ~c"ae" ++ sanitize(tail)
  def sanitize([head | tail]) when head == ?ö, do: ~c"oe" ++ sanitize(tail)
  def sanitize([head | tail]) when head == ?ü, do: ~c"ue" ++ sanitize(tail)
  def sanitize([head | tail]) when head == ?ß, do: ~c"ss" ++ sanitize(tail)

  def sanitize([head | tail]) do
    case head do
      head when head >= ?a and head <= ?z -> [head] ++ sanitize(tail)
      head when head == ?_ -> [head] ++ sanitize(tail)
      _ -> sanitize(tail)
    end
  end
end
