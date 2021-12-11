/* STRUCT YAPISI ILE CLASS YAPISININ KARSILASTIRILMASI
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
}

*/

