Console.Clear();


int F1S = 1, F2S = 2,
    DS = 5, d = 10000, F = 1,
    time = 0, count = 0;
    


 

while(d > 10)
{ 
    if(F == 2)
       {
        time = d / (F2S + DS);
        F = 1;
        }

    
    if(F == 1)
       {
        time = d / (F1S + DS);
        F = 2;
       } 
        d = d - (F1S + F2S) * time; 
        count = count + 1;
    }

Console.Write("Dog Run ");
Console.WriteLine(count);
