using OOP;

// Create a car object with 4 doors
Car car1 = new Car("Toyota", "Corolla", "White", 4);
car1.GetCarDetail(car1);

// Create a car object with an invalid number of doors
Car car2 = new Car("BMW", "X5", "Black", 5);
car2.GetCarDetail(car2);

// Create a car object without specifying the number of doors
Car car3 = new Car("Honda", "Civic", "Blue");
car3.GetCarDetail(car3);