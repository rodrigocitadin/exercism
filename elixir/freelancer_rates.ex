defmodule FreelancerRates do
  @daily_hours 8.0
  @biliable_days 22.0

  def daily_rate(hourly_rate) do
    hourly_rate * @daily_hours
  end

  def apply_discount(before_discount, discount) do
    before_discount - before_discount * discount / 100
  end

  def monthly_rate(hourly_rate, discount) do
    monthly_rate = daily_rate(hourly_rate) * @biliable_days
    monthly_rate = apply_discount(monthly_rate, discount)

    monthly_rate
    |> ceil()
  end

  def days_in_budget(budget, hourly_rate, discount) do
    days = 
      hourly_rate
      |> daily_rate()
      |> apply_discount(discount)

    Float.floor(budget / days, 1)
  end
end
