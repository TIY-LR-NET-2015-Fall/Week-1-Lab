#Week 1 Project -Data

## Description

parsing CSV and using classes


## Objectives

### Learning Objectives

After completing this assignment, you should…

* Understand data design
* Deeply understand functions, variables, classes, and loops


### Performance Objectives

After completing this assignment, you be able to effectively use

* classes, functions, and data
* comma separated values (CSV)



## Details

### Deliverables

* A gist containing at least:
  * `planet_express_logs.csv`
  * `program.cs`
  * A Class "Delivery", with will hold the data in the CSV file 

### Requirements

* I should be able to run the code in `program.cs` and see the output on the screen

## Normal Mode

**Good news DotNetters!**  
We have a week of records tracking what we shipped at Planet Express.  I need you to answer a few questions for Hermes.

1. How much money did we make this week?
2. How much of a bonus did each employee get? (bonuses are paid to employees who pilot the Planet Express)
3. How many trips did each employee pilot?
4. Define and use a class for each shipment

Different employees have favorite destinations they always pilot to

* Fry - pilots to Earth (because he isn't allowed into space)
* Amy - pilots to Mars (so she can visit her family)
* Bender - pilots to Uranus (teeheee...)
* Leela - pilots everywhere else because she is the only responsible one

They get a bonus of 10% of the money for the shipment as the bonus
            
## Hard Mode

* Define a class "Parse", with a method `ParseData()`, with an argument `fileName`
  and outputs the information to the console
* How much money did we make broken down by planet? ie.. how much did we make shipping to Earth? Mars? Saturn? etc.


## Nightmare Mode

* No methods can be longer than 10 lines long
* Make your program work with a command line argument of the file name

For example
> `myapp.exe  c:\logs\planet_express_logs.csv`


## Notes

File name: `planet_express_logs.csv`
Record format:

> Destination, What got shipped, Number of crates, Money we made, Order Created On
