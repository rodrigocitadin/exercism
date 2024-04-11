defmodule KitchenCalculator do
  @unities %{
    :milliliter => 1,
    :cup => 240,
    :fluid_ounce => 30,
    :teaspoon => 5,
    :tablespoon => 15
  }  

  def get_volume({_cup, volume}), do: volume

  def to_milliliter({unit, volume}), do: {:milliliter, volume * @unities[unit]}

  def from_milliliter({_, volume}, unit), do: {unit, volume / @unities[unit]}

  def convert(volume_pair, unit2) do 
    volume_pair 
    |> to_milliliter()
    |> from_milliliter(unit2)
  end
end
