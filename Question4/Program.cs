class Program {

    public static int InputDestinationTarget() {
        Console.Write("Please input number of destinations : ");

        return int.Parse(Console.ReadLine());
    }

    public static int[] InputDestinationpoint(int DestinationTarget) {
        int[] DestinationPoint = new int[DestinationTarget];
        for(int number = 0; number < DestinationTarget; number++) {
            Console.Write("Please input point from {0} to : ",number + 1);
            int checkNumber = int.Parse(Console.ReadLine());
            if(checkNumber <= DestinationTarget) {
                DestinationPoint[number] = checkNumber; 
            }
            else {
                throw new Exception("Out of range");
            }
        }
        return DestinationPoint;
    }

    public static int InputStartPoint() {
        Console.Write("Please input started point : ");
        
        return int.Parse(Console.ReadLine());
    }

    public static int InputRound() {
        Console.Write("Please input number of round : ");
        
        return int.Parse(Console.ReadLine());
    }

    public static int CalculateLastPoint(int[] DestinationPoint,int Round,int StartPoint) {
        
        while(Round > 0) {
            StartPoint = DestinationPoint[StartPoint-1];
            Round--;
        }
        return StartPoint;
    }

    public static void Main(string[] args) {
        int DestinationTarget = InputDestinationTarget();

        int[] DestinationPoint = new int [DestinationTarget];
        DestinationPoint = InputDestinationpoint(DestinationTarget);
        
        int StartPoint = InputStartPoint();
        int Round = InputRound();
        int LastPoint = CalculateLastPoint(DestinationPoint,Round,StartPoint);
        
        PrintInfo(LastPoint);
    }

    public static void PrintInfo(int LastPoint) {
        Console.WriteLine("The last point is : {0}",LastPoint);
    }
}