defmodule RotationalCipher do
  @down_alphabet for n <- ?a..?z, do: <<n::utf8>>
  @up_alphabet for n <- ?A..?Z, do: <<n::utf8>>

  @doc """
  Given a plaintext and amount to shift by, return a rotated string.

  Example:
  iex> RotationalCipher.rotate("Attack at dawn", 13)
  "Nggnpx ng qnja"
  """
  @spec rotate(text :: String.t(), shift :: integer) :: String.t()
  def rotate(text, shift) do
    text
    |> String.split("", trim: true)
    |> Enum.map(&replace_char(&1, shift))
    |> List.to_string()
  end

  defp replace_char(text, shift) do
    cond do
      String.match?(text, ~r/[[:lower:]]/) -> cipher(text, shift, @down_alphabet)
      String.match?(text, ~r/[[:upper:]]/) -> cipher(text, shift, @up_alphabet)
      true -> text
    end
  end

  defp cipher(text, shift, alphabet) do
    value_index =
      alphabet
      |> Enum.find_index(&(&1 == text))
      |> Kernel.+(shift)
      |> verify_char_index()

    Enum.at(alphabet, value_index)
  end

  defp verify_char_index(index) when index >= 26, do: index - 26
  defp verify_char_index(index), do: index
end
