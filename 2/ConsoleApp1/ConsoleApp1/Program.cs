using System;

namespace ConsoleApp1
{
    class ClassRoom
    {
        Pupil[] arrPupil;

        public ClassRoom(Pupil n1, Pupil n2, Pupil n3, Pupil n4)
        {
            arrPupil = new Pupil[] { n1, n2, n3, n4 };
        }
        public ClassRoom(Pupil n1, Pupil n2, Pupil n3)
        {
            arrPupil = new Pupil[] { n1, n2, n3 };
        }
        public ClassRoom(Pupil n1, Pupil n2)
        {
            arrPupil = new Pupil[] { n1, n2 };
        }

        public void PrintInfoStudy()
        {
            Console.WriteLine("Study: ");
            foreach (Pupil item in arrPupil)
                item.Study();
        }
        public void PrintInfoRead()
        {
            Console.WriteLine("Read: ");
            foreach (Pupil item in arrPupil)
                item.Read();
        }
        public void PrintInfoWrite()
        {
            Console.WriteLine("Write: ");
            foreach (Pupil item in arrPupil)
                item.Write();
        }
        public void PrintInfoRelax()
        {
            Console.WriteLine("Relax: ");
            foreach (Pupil item in arrPupil)
                item.Relax();
        }
    }

    class Program
    {
        static void Main()
        {
            ClassRoom cRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new GoodPupil());

            cRoom.PrintInfoRead();
            cRoom.PrintInfoRelax();
            cRoom.PrintInfoStudy();
            cRoom.PrintInfoWrite();

            Console.ReadKey();
        }
    }
}
