using System.Threading;
using System;
 // Necesitamos este namespace ya que esto es un programa de consola//

/// Aqui podemos ver los hilos como caminos de ejecucion que toman nuestros programas, normalmente los programas tienen un solo main
/// que vendria siendo un solo hilo lo que significa que las instrucciones se ejecutaran una por una, pero todos los dias las tecnologias
/// avanzan trayendo con si equipos con 2, 4, 8, 16, hasta 32 nucleos ahora la programacion multihilo como bien sabemos es la ejecucion 
///miltiple de las instrucciones, ejecutando estas al mismo tiempo y por lo tanto podemos apreovechar esto para ejecutar una instruccion
/// en cada nucleo volviendo mas rapida y eficiente nuestro programa.  

namespace Threading{

    class program{

        //Main representa el hilo principal//
        //static void Main(string[] args){

        //    Console.WriteLine("un solo hilo");
        //}

         static void Main(string[] args){

             ///instanciamos el objeto thread/ hilo y 
             ///colocamos el delegado que corresponde esto lo hacemos para decirle al programa que camino seguira el hilo
             /// por asi decirlo, puede entenderse como el metodo de ejecucio que este seguira

             Thread miHilo = new Thread(Saludos); //Saludos es el metodo que Thread va a ejecutar

            ///Ahora lo inicializamos ya que no arranca
            ///al momento de instanciarse
            miHilo.Start();

            Console.ForegroundColor = ConsoleColor.White;/// // aqui posiblemente al ejecutar esto veremos que se muestra en verde el mensaje 
            Console.WriteLine("Saludos desde main");       // no es que no lo muestre en blanco si no que se devuelve para ejecutar la 
                                                           // la segunda instruccion mostrando esta en verde y esto pasa porque no tenemos
            ///Aqui pasaremos datos al hilo                // sincronismo en la aplicacion, por lo tanto no tenemos total control de como 
            //Thread mihilo = new  Thread(MiMensaje);      // se muestra el programa

            /// Al inicial el hilo mandamos el mensaje
            //mihilo.Start(5);
        }

        ///Creamos un metodo que se ejecutara en el segundo hilo
        ///Debe de coincidir con el delegado
        ///Public delegate void ThreadStart();

        static void Saludos(){
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Saludos desde el hilo");
        }

        ///Este metodo se ejecuta en el segundo hilo
        ///y recibe un parametro del exterior

        static void MiMensaje(object o){
            int m = Convert.ToInt32(o);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Saludos desde el mensaje {0}, {1}", m, m * 2);
        }
    }
}

