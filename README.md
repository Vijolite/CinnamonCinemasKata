Cinnamon Cinemas (class diagram inside file CinnamonCinemas_UML.png)

The Cinnamon Cinemas Movie Theatre has 15 seats, arranged in 3 rows of 5
- Rows are assigned a letter from A to C
- Seats are assigned a number from 1 to 5


The program allocates seats based on a random integer “number of seats” between 1 and 3

- The program allocates the required number of seats from the available seats starting from seat A1 and filling the auditorium from left to right, front to back
- All of the seats are available for sale when the program starts
- The program continues to allocate a random number of seats until it finds there are not enough seats left to complete the request
- Once there are not enough seats available to be allocated then the program stops