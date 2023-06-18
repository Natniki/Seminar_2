//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа


int fortrest(int vale)
{
    Console.Write(vale + " => ");
    int res = vale /10 % 10;
    return res;
}
Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num>999 || num<100)
{
    Console.WriteLine(" oshibka: chislo ne trehznachnoe!");
}   
else
{ 
    int result = fortrest( num);
    Console.WriteLine(result);
}
    
        
    





