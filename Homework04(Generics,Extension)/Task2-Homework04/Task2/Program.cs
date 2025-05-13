using Task2.Domain.Models;

Vehicle car = new Car();
Vehicle plane = new Airplane();
Vehicle boat = new Boat();
Vehicle motorBike = new MotorBike();

car.DisplayInfo();
plane.DisplayInfo();
boat.DisplayInfo();
motorBike.DisplayInfo();

Car driveCar = new Car();
Airplane flyPlane = new Airplane();
Boat sailBoat = new Boat();
MotorBike driveMotorBike = new MotorBike();

driveCar.Drive();
flyPlane.Fly();
sailBoat.Sail();
driveMotorBike.Wheelie();