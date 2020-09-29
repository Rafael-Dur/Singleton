//Interfaz de la clase greeter:

using System;

namespace Library
{
    public class Singleton<T>where T : new()
    {
    
        private static T objeto=default(T);
        private Singleton()
        {

        }

        public static T Instance
        {
            get
            {
                if(objeto == null)
                {
                    objeto=new T();
                }
                return objeto;
            }
        }


    }
}