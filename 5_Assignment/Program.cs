//Un-comment below code and fix the issues
//Push to github


int RecursiveFibonacci(int first, int second, int count)
{
    count--;
    if(count == 0) {
        return second;
    }else{
        return RecursiveFibonacci(first + second, first, count);
    }
}


while(true){
    string gg = Console.ReadLine();
    
    if(gg.All(char.IsDigit)){
        int gg2 = int.Parse(gg);
        int lastFibo = RecursiveFibonacci(1,1,gg2);
        Console.WriteLine("Last fibo number was " + lastFibo);
    }else{
        Console.WriteLine("The Given String is Not a Number");
    }
}   