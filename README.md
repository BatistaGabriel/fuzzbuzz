# Fuzz Buzz
> This repo was created to save some studies of how to use NUnit on .Net projects and also how to create a software following the BDD-TDD mindset.
---
## First Scenario ✔
> Given an integer input
- > When the mod of the division by three is equal zero
- > Then fill up the output variable with the string "Fuzz"

## Second Scenario ✔
> Given an integer input
- > When the mod of the division by five is equal zero
- > Then fill up the output variable with the string "Buzz"

## Third Scenario ✔
> Given an integer input
- > When the mod of the division by three is equal zero
    - > And also the mod of the division by five is equal zero
- > Then fill up the output variable with the string "FuzzBuzz"

## Fourth Scenario ✔
> Given an integer input
- > When the mod of the division by three is not equal zero
    - > And also the mod of the division by five is not equal zero
- > Then fill up the output variable with the input value as a string