namespace ConsoleApp1;

public class main
{
    public static void Main(string[] args)
    {
        Application application = new Application();
        
        Container gasContainer = application.CreateGasContainer(100, 50, 500);
        Console.WriteLine(application.PrintContainerInformation(gasContainer));
        
        Container liquidContainer = application.CreateLiquidContainer(100, 50, 500);
        Console.WriteLine(application.PrintContainerInformation(liquidContainer));
        
        Container refrigeratedContainer = application.CreateRefrigeratedContainer(125, 70, 750, new Load(false, 15.7, "Milk"));
        Console.WriteLine(application.PrintContainerInformation(refrigeratedContainer));
        
        
        application.LoadingLoadIntoContainer(gasContainer, new Load(true, null, "Gas"), 40);
        Console.WriteLine(application.PrintContainerInformation(gasContainer));
        
        
        application.LoadingLoadIntoContainer(liquidContainer, new Load(false, null, "Liquid"), 60);
        Console.WriteLine(application.PrintContainerInformation(liquidContainer));
        
        
        application.LoadingLoadIntoContainer(refrigeratedContainer, new Load(false, 11, "Milk"), 80);
        Console.WriteLine(application.PrintContainerInformation(refrigeratedContainer));

        
        application.EmptyingContainer(liquidContainer);
        Console.WriteLine(application.PrintContainerInformation(liquidContainer));
        
        List<Container> list = new List<Container>();
        
        Ship ship = new Ship(10, 50, 1000, list);
        Console.WriteLine(application.PrintShipInformation(ship));
        
        application.LoadingContainerOntoShip(ship, liquidContainer);
        Console.WriteLine(application.PrintShipInformation(ship));
        
        

    }
}