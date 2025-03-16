using tpModul5_103022300016;

class Program
{
    public static void Main(string[] args)
    {
        DataGeneric<String> dataNIM = new DataGeneric<String>("103022300016");
        dataNIM.printData();
        DataGeneric<int> dataUmur = new DataGeneric<int>(20);
        dataUmur.printData();
    }
}