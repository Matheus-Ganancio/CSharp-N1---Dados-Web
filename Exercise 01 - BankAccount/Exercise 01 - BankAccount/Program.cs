bankAccount userInfo_1 = new bankAccount();

userInfo_1.accountName = "Matheus";
userInfo_1.password = "xxxxxxx";
userInfo_1.accountNumber = 00000000 - 0;
userInfo_1.balance = 9.999;
userInfo_1.haveCreditCard = true;
userInfo_1.creditCardLimit = userInfo_1.balance * 1.5;

userInfo_1.userDetails();

Console.WriteLine("\n-------------------\n");

bankAccount userInfo_2 = new bankAccount();

userInfo_2.accountName = "Marcelo";
userInfo_2.password = "yyyyyyyy";
userInfo_2.accountNumber = 9999999 - 9;
userInfo_2.balance = 5.000;
userInfo_2.haveCreditCard = false;

userInfo_2.userDetails();

Console.WriteLine("\n-------------------\n");


// Cars

Car carDetail_1 = new Car();

carDetail_1.accelerate = 95;
carDetail_1.brake = false;
carDetail_1.honk = true;

carDetail_1.carInfo();

Console.WriteLine("\n-------------------\n");