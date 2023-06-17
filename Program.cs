// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.Clear();
    {
        double FirstVal, SecondVal;
        string Action;

        
        FirstVal = double.Parse(Console.ReadLine());

        
        SecondVal = double.Parse(Console.ReadLine());

        
        Action = Console.ReadLine();

        switch (Action)
        {
            case "+":
                Console.WriteLine(FirstVal + SecondVal);
                break;
            case "-":
                Console.WriteLine(FirstVal - SecondVal);
                break;
            case "*":
                Console.WriteLine(FirstVal * SecondVal);
                break;
            case "/":
                Console.WriteLine(FirstVal / SecondVal);
                break;
            default:
                
                break;

        }

        Console.ReadLine();

    }



}

