using tpModul5_103022300016;
public class Program
{
    public static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        String nama = "Edsel Septa Haryanto"; // tipe data string
        halo.halo(nama);
        int angkaInt = 2; // tipe data int
        halo.halo(angkaInt);
        double angkaDouble = 2.5; // tipe data double
        halo.halo(angkaDouble);
    }
}