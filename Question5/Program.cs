class Program {

    public static int InputNumber(){
        Console.Write("Please Input size of group : ");
        return int.Parse(Console.ReadLine());
    }

    public static int[] InputGroupMember(int InputNumber) {
        int[] GroupMember = new int[InputNumber];
        for(int round = 0; round < InputNumber; round++) {
            Console.Write("Input member {0} : ",round+1);
            GroupMember[round] = int.Parse(Console.ReadLine()); 
        }
        Array.Sort(GroupMember);
        return GroupMember;
    }

    public static int[] CheckMember(int[] MemberFirstGroup, int[] MemberSecondGroup) {
        int FirstNumber = MemberFirstGroup.Length;
        int SecondNumber = MemberSecondGroup.Length;

        if(FirstNumber == SecondNumber) {
            return SortAndMerge(MemberFirstGroup,MemberSecondGroup);
        }
        else if(FirstNumber < SecondNumber) {
            return SortAndMerge(MemberSecondGroup,MemberFirstGroup);
        }
        else {
            return SortAndMerge(MemberFirstGroup,MemberSecondGroup);
        }
    }

    public static int[] SortAndMerge(int[] FirstGroup, int[] SecondGroup) {
        List<int> MergeGroup = new List<int>();
        int[] Allgroup = new int[FirstGroup.Length + SecondGroup.Length];
        Allgroup = FirstGroup.Concat(SecondGroup).ToArray();

        for(int round = 0; round < Allgroup.Length; round++) {
            bool NotIntersec = true;
            
            for(int Round = 0; Round < round; Round++) {
                if(Allgroup[round] == Allgroup[Round]) {
                    NotIntersec = false;
                }
            }
            if(NotIntersec == true) {
                MergeGroup.Add(Allgroup[round]);
            }
        }
        int[] ArrayGroup = MergeGroup.ToArray();
        Array.Sort(ArrayGroup);
        return ArrayGroup; 
    }

    public static void Main(string[] args) {
        int InputSizeOfFirstGroup = InputNumber();
        int[] MemberFirstGroup = new int[InputSizeOfFirstGroup];
        MemberFirstGroup = InputGroupMember(InputSizeOfFirstGroup);

        int InputSizeOfSecondGroup = InputNumber();
        int[] MemberSecondGroup = new int[InputSizeOfSecondGroup];
        MemberSecondGroup = InputGroupMember(InputSizeOfSecondGroup);

        int[] MergeGroup = new int[InputSizeOfFirstGroup+InputSizeOfSecondGroup];
        MergeGroup = CheckMember(MemberFirstGroup, MemberSecondGroup);
        
        PrintInfomation(MergeGroup);
    }

    public static void PrintInfomation(int[] MergeGroup) {
        for(int i = 0; i < MergeGroup.Length; i++) {
            Console.WriteLine(MergeGroup[i]);
        }
    }
}