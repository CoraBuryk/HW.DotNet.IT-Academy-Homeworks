using System;

namespace HW08.AssemblyOne
{
    class Program
    {
        static void Main()
        {
            Motorcycle moto = new Motorcycle(); //Экземпляр класса
            int speedInt = moto.maxSpeedInternal; //Вызов поля 
            int speedPub = moto.maxSpeedPublic; //Вызов поля
            //int speedPriv = moto.maxSpeedPrivate; Доступен только в том типе, в котором определен
            //int speedProt = moto.maxSpeedProtected; Доступен в типе, в котором определен и в наследниках

            string ID = moto.numberID; //Вызов поля

            int speed = moto.MaxSpeed; //Вызов свойства

            int speedMethodPublic = moto.MotoPublic();
            int speedMethodInternal = moto.MotoInternal();
            int speedMethodProtectedInternal = moto.MotoProtectedInternal();
            //int speedMethodPrivate = moto.MotoPrivate();
            //int speedMethodProtected = moto.MotoProtected();
            //int speedMethodPrivateProtected = moto.MotoPrivateProtected();

            MotocycleInternal model = new MotocycleInternal();
            string modelPub = model.modelPublic;
            string modelInt = model.modelInternal;

            string mod = model.Model;

            string modelMethodPublic = model.ModelPublic();
            string modelMethodInternal = model.ModelInternal();
            string modelMethodProtectedInternal = model.ModelProtectedInternal();

            //Из 4 объявленных полей можно вызвать только 2 с модификаторами доступа Internal и Public
            //Из 6 объявленных методов можно вызвать только 3 с модификаторами доступа Public,Internal,Protected Internal

            //Т.е с модификаторами доступа Private,Protected и Private Protected можно работать только в вызванном классе,
            //в нашем случае в Motocycle. 
        }
    }
}