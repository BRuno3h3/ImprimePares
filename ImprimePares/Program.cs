List<int> numeroPar = new List<int>();


int i = 0;

while(i <= 100) 
    {
        if(i % 2 == 0) 
        {     
            numeroPar.Add(i);
        }
        i++;
    };

foreach(int num in numeroPar)
{
    Console.WriteLine(num);
}






