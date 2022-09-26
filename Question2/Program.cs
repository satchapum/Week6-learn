class Program {

    public static int InputWiresAmount() {
        Console.Write("Please Input number of wires : ");
        return int.Parse(Console.ReadLine());
    }

    public static int InputInternetWiresAmount() {
        Console.Write("Please Input number of Internet Wires : ");
        return int.Parse(Console.ReadLine());
    }

    public static int InputTableNumber() {
        Console.Write("Please Input number of Table : ");
        return int.Parse(Console.ReadLine());
    }

    public static bool[] InputstateWire(int WiresAmount) {
        bool[] WireState = new bool[WiresAmount];
        for(int number = 0; number < WiresAmount; number++) {
            Console.Write("Wire {0} Status : ",number+1);
            string InputState = Console.ReadLine();
            if(InputState == "True" ||InputState == "true"){
                WireState[number] = true;
            }
            else if(InputState == "False" ||InputState == "false"){
                WireState[number] = false;
            }
            else {
                throw new Exception("Please Input True or False");
            }
        }
        return WireState;
    }

    public static int[] InputInternetSpeed(int InternetWiresAmount) {
        int[] InternetSpeed = new int[InternetWiresAmount];
        for(int number = 0; number < InternetWiresAmount; number++) {
            Console.Write("InterSpeed Wire {0} : ",number+1);
            InternetSpeed[number] = int.Parse(Console.ReadLine());
        }
        return InternetSpeed;
    }

    public static List<bool> AllTableWire(int WiresAmount, int InternetWiresAmount, bool[] WireState) {
        List<bool> InternetStatus = new List<bool>();
        for (int numberInternerWire = 0; numberInternerWire < InternetWiresAmount; numberInternerWire++) {
            for (int numberWire = 0; numberWire < WiresAmount; numberWire++) {
                InternetStatus.Add(WireState[numberWire]);
            }
        }
        return InternetStatus;
    }

    public static List<int> AllTableInternetSpeed(int WiresAmount, int InternetWiresAmount, int[] WireState) {
        List<int> InternetSpeed = new List<int>();
        for (int numberInternerWire = 0; numberInternerWire < InternetWiresAmount; numberInternerWire++) {
            for (int numberWire = 0; numberWire < WiresAmount; numberWire++) {
                InternetSpeed.Add(WireState[numberInternerWire]);
            }
        }
        return InternetSpeed;
    }

    public static void Main(string[] args) {
        int WiresAmount = InputWiresAmount();
        int InternetWiresAmount = InputInternetWiresAmount();

        bool[] WireState = new bool[WiresAmount];
        WireState = InputstateWire(WiresAmount);
        List<bool> TableWireStatus = AllTableWire(WiresAmount, InternetWiresAmount, WireState);
       
        int[] InternetSpeed = new int[InternetWiresAmount];
        InternetSpeed = InputInternetSpeed(InternetWiresAmount);
        List<int> TableInternetSpeed = AllTableInternetSpeed(WiresAmount, InternetWiresAmount, InternetSpeed);;

        int TableNumber = InputTableNumber();

        PrintInfo(TableWireStatus, TableInternetSpeed, TableNumber);
    }

    public static void PrintInfo(List<bool> TableWireStatus, List<int> TableInternetSpeed, int TableNumber) {
        if(TableWireStatus[TableNumber-1] == true) {
            Console.WriteLine("Internet Speed is : {0} Mbps",TableInternetSpeed[TableNumber-1]);
        }
        else {
            Console.WriteLine("Offine");
        }
    }

}