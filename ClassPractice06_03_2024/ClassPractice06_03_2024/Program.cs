

using ClassPractice06_03_2024;

// boxing - unboxing

//int a = 5;

//object b = a;





//int a = 6;
//object b = a;
//int c = (int)b;




//byte num = 50;
//int num2 = num;


//int a = 10;
//byte b = a;











//Fish fish = new Fish();
//Animal animal1 = fish;



//Animal animal1 = new Animal();

//Fish fish1 = (Fish)animal;


//Animal animal2 = new Dog();
//Animal animal3 = new Fish();
//Animal animal = new();

//Fish fish1 = (Fish)animal;

//Dog dog1 = new Dog();



////object[] datas = { 1, 2, true, "salam" };

//Animal[] animals = { animal1, animal2, animal3, fish1, Dog, "salam" };



//foreach (var item in animals)
//{
//    if (item is Animal)
//    {
//        (Animal)item).Name = "toplan";
//    }

//}


//DataList dataList = new DataList();
//dataList[0] = "salam";
//dataList[1] = "sagol";
//Console.WriteLine(dataList[0]);


Employyee employyee1 = new Employyee();
employyee1.Id = 1;
employyee1.Age = 32;

Employyee employyee2 = new Employyee();
employyee2.Id = 2;
employyee2.Age = 28;

Console.WriteLine(employyee1 < employyee2);