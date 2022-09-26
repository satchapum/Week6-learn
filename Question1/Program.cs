class Program {

    public static int InputAmountNumber() {
        Console.Write("Input amount of data :");
        string Input = Console.ReadLine();
        int.TryParse(Input, out int number);

        return number; 
    }

    public static List<string> InputData(int DataAmount) {
        List<string> DataInput = new List<string>();
        for(int number = 1; number <= DataAmount; number++) {
            Console.Write("Input data :");
            string Data = Console.ReadLine();
            DataInput.Add(Data);
        }
        return DataInput;
    }

    public static void Main(string[] args) {

        int DataAmount = InputAmountNumber();
        List<string> DataStore = new List<string>();
        DataStore = InputData(DataAmount);
        
        PrintInfo(DataStore, DataAmount);
    }

    public static void PrintInfo(List<string> DataStore, int DataAmount) {
        for(int number = DataAmount-1; number >= 0; number--) {
            Console.WriteLine("You data is : {0}",DataStore[number]);
        }
    }
}