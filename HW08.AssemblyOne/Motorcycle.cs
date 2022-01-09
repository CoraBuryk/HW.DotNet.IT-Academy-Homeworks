using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08.AssemblyOne
{
        //Классы
        public class Motorcycle
        {
            //Поля
            public int maxSpeedPublic = 120;
            internal int maxSpeedInternal = 130;
            private int maxSpeedPrivate = 210;
            protected int maxSpeedProtected = 60;

            public string numberID = "JDIW2d-sE";

            //Константа
            public const int maxSpeedConst = 90;

            // Методы
            public int MotoPublic()
            {
                int maxPublic = maxSpeedPublic + 10;
                return maxPublic;
            }
            internal int MotoInternal()
            {
                int maxPublic1 = maxSpeedPublic + 20;
                return maxPublic1;
            }
            private int MotoPrivate()
            {
                int maxPublic2 = maxSpeedPublic + 30;
                return maxPublic2;
            }
            protected int MotoProtected()
            {
                int maxPublic3 = maxSpeedPublic + 40;
                return maxPublic3;
            }
            protected internal int MotoProtectedInternal()
            {
                int maxPublic4 = maxSpeedPublic + 50;
                return maxPublic4;
            }
            private protected int MotoPrivateProtected()
            {
                int maxPublic5 = maxSpeedPublic + 60;
                return maxPublic5;
            }
            // Свойства
            public int MaxSpeed
            {
                get { return maxSpeedPrivate; }
                set { maxSpeedPrivate = maxSpeedProtected; }
            }
        }

        internal class MotocycleInternal
        {
            //Поля
            public string modelPublic = "FD";
            internal string modelInternal = "FER";
            private string modelPrivate = "EFGB";
            protected string modelProtected = "EFBQ";

            //Константа
            public const string modelConst = "XXQ";

            // Методы
            public string ModelPublic()
            {
                string publicModel = modelPublic + 10;
                return publicModel;
            }
            internal string ModelInternal()
            {
                string publicModel1 = modelPublic + 20;
                return publicModel1;
            }
            private string ModelPrivate()
            {
                string publicModel2 = modelPublic + 30;
                return publicModel2;
            }
            protected string ModelProtected()
            {
                string publicModel3 = modelPublic + 40;
                return publicModel3;
            }
            protected internal string ModelProtectedInternal()
            {
                string publicModel4 = modelPublic + 50;
                return publicModel4;
            }
            private protected string ModelPrivateProtected()
            {
                string publicModel5 = modelPublic + 60;
                return publicModel5;
            }
            // Свойства
            public string Model
            {
                get { return modelPublic; }
                set { modelPublic = modelConst; }
            }
        }
}