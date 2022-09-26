class Program {

    public static int InputNumber() {
        Console.Write("Please Input amount of number : ");
        return int.Parse(Console.ReadLine());
    }

    public static int[] InputAllNumber(int AmountOfNumber) {
        int[] AllNumber = new int[AmountOfNumber];
        for (int number = 0; number < AmountOfNumber; number++) {
            Console.Write("Please Input number {0} : ",number+1);
            AllNumber[number] = int.Parse(Console.ReadLine());
        }
        return AllNumber;
    }

    public static int[] SortNumber(int[] AllNumber) {
        int[] AlrSort = AllNumber;
        int checknumber;
        for(int PreNumber = 0; PreNumber < AllNumber.Length-1; PreNumber++) {
            for(int PostNumber = PreNumber+1; PostNumber < AllNumber.Length; PostNumber++) {
                if(AlrSort[PreNumber] < AlrSort[PostNumber]) {
                    checknumber = AlrSort[PreNumber];
                    AlrSort[PreNumber] = AlrSort[PostNumber];
                    AlrSort[PostNumber] = checknumber;
                }
            }

        }
        return AlrSort;
    }

    public static void Main(string[] args) {
        int AmountOfNumber = InputNumber();

        int[] AllNumber = new int[AmountOfNumber];
        AllNumber = InputAllNumber(AmountOfNumber);

        int[] sortNumber = new int[AmountOfNumber];
        sortNumber = SortNumber(AllNumber);

        PrintInfo(sortNumber);
    }

    public static void PrintInfo(int[] sortNumber) {
        int RevertArray = sortNumber.Length; 
        for(int NumberArray = 0; NumberArray < sortNumber.Length; NumberArray++) {
            Console.WriteLine("Number {0} : {1}",NumberArray+1 ,sortNumber[RevertArray-1]);
            RevertArray--;
        }
    }
}