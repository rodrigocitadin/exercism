defmodule RotationalCipher do
  @alphabet for n <- ?a..?z, do: <<n::utf8>>
  @upcase_alphabet for n <- ?A..?Z, do: <<n::utf8>>

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
    |> Enum.map(fn v -> replace_char(v, shift) end)
    |> List.to_string()
  end

  defp replace_char(text, shift) do
    String.match?(text, ~r/[[:lower:]]/) -> cipher(text, shift, @alphabet)
    String.match?(text, ~r/[[:upper:]]/) -> cipher(text, shift, @upcase_alphabet)
    _ -> text
  end

  defp cipher(text, shift, alphabet) do
    value_index = shift + Enum.find_index(alphabet, fn v -> v == text end)

    value_index =
      if value_index >= 26 do
        value_index - 26
      else
        value_index
      end

    Enum.at(alphabet, value_index)
  end
end
