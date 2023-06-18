
int fortrest(int i)
{
    Console.Write(i + " => ");
    int res = i /10 % 10;
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
    
        
    





