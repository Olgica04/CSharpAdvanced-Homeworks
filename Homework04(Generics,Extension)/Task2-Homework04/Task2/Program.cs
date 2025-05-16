using Task2.Domain.Models;

Vehicle car = new Car();
Vehicle plane = new Airplane();
Vehicle boat = new Boat();
Vehicle motorBike = new MotorBike();

car.DisplayInfo();
plane.DisplayInfo();
boat.DisplayInfo();
motorBike.DisplayInfo();

((Car)car).Drive();
((Airplane)plane).Fly();
((Boat)boat).Sail();
((MotorBike)motorBike).Wheelie();