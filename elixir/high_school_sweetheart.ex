defmodule HighSchoolSweetheart do
  def first_letter(name) do
    name
    |> String.trim()
    |> String.first()
  end

  def initial(name) do
    initial =    
      name
      |> first_letter()
      |> String.capitalize()

    "#{initial}."
  end

  def initials(full_name) do
    initials =
      full_name
      |> String.split()
      |> Enum.map(&initial/1)

    "#{hd(initials)}" <> " " <> "#{tl(initials)}"
  end

  def pair(i1, i2) do
"""
     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     #{initials(i1)}  +  #{initials(i2)}     **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *
"""
  end
end
