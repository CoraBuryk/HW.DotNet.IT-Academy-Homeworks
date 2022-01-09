using System;
using HW08.AssemblyOne;

namespace HW08.AssemblyTwo
{
    class Program
    {
        static void Main()
        {
            Motorcycle moto = new Motorcycle();
            //int speedInt = moto.maxSpeedInternal; 
            int speedPub = moto.maxSpeedPublic;
            //int speedPriv = moto.maxSpeedPrivate; 
            //int speedProt = moto.maxSpeedProtected; 

            string ID = moto.numberID; //Вызов поля

            int speed = moto.MaxSpeed; //Вызов свойства

            int speedMethodPublic = moto.MotoPublic();
            /*int speedMethodInternal = moto.MotoInternal();
            int speedMethodProtectedInternal = moto.MotoProtectedInternal();
            int speedMethodPrivate = moto.MotoPrivate();
            int speedMethodProtected = moto.MotoProtected();
            int speedMethodPrivateProtected = moto.MotoPrivateProtected();*/

            // MotocycleInternal model = new MotocycleInternal();

            //В другом консольном проекте есть доступ к классам, полям и тд только с ключевым словом Public
        }
    }
}