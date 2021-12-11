using System;

namespace StructVeEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dd1= new Dikdortgen();//class tipinde new sozcugu kullanmak gerekli.
            dd1.Kisakenar=3;
            dd1.Uzunkenar=4;
            Console.WriteLine("class yapisi ile alan : {0}",dd1.Alanhesapla());

            Dikdortgen_Struct dd2= new Dikdortgen_Struct();//struct tipinde new sozcugu kullanmak zorunlu degil.
            dd2.Kisakenar=3;
            dd2.Uzunkenar=4;
            Console.WriteLine("struct yapisi ile alan : {0}",dd2.Alanhesapla());

            Dikdortgen_Struct dd3;//struct tipinde new sozcugu kullanmadan yapilan tanimlama budur.
            dd3.Kisakenar=3;
            dd3.Uzunkenar=4;
            Console.WriteLine("struct yapisi ile alan : {0}",dd3.Alanhesapla());

            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik=32;
            if(sicaklik<=(int)HavaDurumu.normal)
            {
                Console.WriteLine("Disariya cikmak icin havanin biraz isinmasini bekleyin!");
            }
            else if(sicaklik>=(int)HavaDurumu.cokSıcak)
            {
                Console.WriteLine("normal sicakligin uzerinde bir hava vardir!");
            }
            else if(sicaklik>=(int)HavaDurumu.soguk && sicaklik<=(int)HavaDurumu.cokSıcak)
            {
                Console.WriteLine("Let's go!");
            }
        }
    }

    public class Dikdortgen
    {
        public int Uzunkenar;
        public int Kisakenar;

        public int Alanhesapla()
        {
            return this.Uzunkenar*this.Kisakenar;
        }

    }

    struct Dikdortgen_Struct
    {
        public int Uzunkenar;
        public int Kisakenar;

        public int Alanhesapla()
        {
            return this.Uzunkenar*this.Kisakenar;
        }
    }

    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar

    }

    enum HavaDurumu
    {
        soguk=0,
        normal=25,
        cokSoguk=-10,
        cokSıcak=42
    }
}
