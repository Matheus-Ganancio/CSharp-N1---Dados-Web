// Conta bancaria

bankAccount userInfo_1 = new bankAccount();

userInfo_1.AccountName = "Matheus";
userInfo_1.Password = "xxxxxxx";
userInfo_1.AccountNumber = 00000000 - 0;
userInfo_1.Balance = 9999;
userInfo_1.HaveCreditCard = true;
//userInfo_1.CreditCardLimit = 

userInfo_1.userDetails();

Console.WriteLine("\n-------------------\n");

bankAccount userInfo_2 = new bankAccount();

userInfo_2.AccountName = "Marcelo";
userInfo_2.Password = "yyyyyyyy";
userInfo_2.AccountNumber = 9999999 - 9;
userInfo_2.Balance = 5000;
userInfo_2.HaveCreditCard = false;

userInfo_2.userDetails();

Console.WriteLine("\n-------------------\n");


// Modelos de carros

Car carDetail_1 = new Car();

carDetail_1.Accelerate = 95;
carDetail_1.Brake = false;
carDetail_1.Honk = true;

carDetail_1.carInfo();

Console.WriteLine("\n-------------------\n");

Product_Car productCar_1 = new Product_Car();

productCar_1.Name = "Corolla";
productCar_1.Brand = "Toyota";
productCar_1.Available = true;
productCar_1.Stock = 57;

productCar_1.carAvailability();
