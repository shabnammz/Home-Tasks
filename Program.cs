//Task1. Verilmiş n ve m (n<m) ədədləri arasındakı tək ədədlərin sayını tapın.

//int num1 = 3;
//int num2 = 12;
//int count = 0;

//for (int i = num1; i < num2; i++)

//{
//    if (i % 2 == 1)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);





//Task2. Verilmiş n ve m (n<m) ədədləri arasındakı tək ədədlərin cəmini tapın.

//int num1 = 3;
//int num2 = 12;
//int sum = 0;

//for (int i = num1; i < num2; i++)

//{
//    if (i % 2 == 1)
//    {
//        sum += i ;
//    }
//}
//Console.WriteLine(sum);




//Task3. m -ədədi verilir. 1-dən m-ədədinə kimi olan cüt ədədlərin hasilini tapin. 

//int num = 11;
//int hasil = 1;

//for (int i = 1; i < num; i++)
//{
//    if (i % 2 == 0)
//        hasil *= i;
//}
//Console.WriteLine(hasil);




//Task4. a - ədədi 3-ə bölünən cüt ədəddirsə "3-e bolunur cutdur" ,3-ə bölünən tək ədəddirsə "3-e bolunur tekdir" əks halda "3-e bolunmur" sözünü ekranda çap edin.

//int num = 8;

//if (num % 2 == 0 && num % 3 == 0)
//{
//    Console.WriteLine("3-e bolunur cutdur");
//}
//else if (num % 2 == 1 && num % 3 == 0)
//{
//    Console.WriteLine("3-e bolunur tekdir");
//}
//else
//{
//    Console.WriteLine("3-e bolunmur");
//}





//Task5. Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın. 

//int num = 9;
//bool prime = true;

//if (num <= 1)
//{
//    prime = false;
//    Console.WriteLine("Ne sade, ne murekkeb ededdir.");
//}
//for (int i = 2; i < num; i++)
//{
//    if (num % i == 0)
//    {
//        prime = false;
//    }
//}

//if (prime)
//{
//    Console.WriteLine("Sade ededdir.");
//}
//else
//{
//    Console.WriteLine("Murekkeb ededdir.");
//}
