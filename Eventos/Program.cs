//Eventos := editor -> suscríptor

/*Editor o Publisher
 * Determina cuando se "lanza" el evento
 * -Definicion del evento
 * -Delegado
 */
public class Editor {
    public delegate void EjemploEvento();
    public event EjemploEvento ejemploEvento;
}

public class EditorCalc {
    public delegate void EjemploDelegado();
    public event EjemploDelegado ejemploEvento;

    public void Sumar(int a, int b) {

        if (ejemploEvento != null)
        {
            ejemploEvento();
            Console.WriteLine($"La suma es: {a + b}");
        }
        else {
            Console.WriteLine("No tiene una suscripcion al evento");
        }
    }
}

/*Suscriptor
 * Acepta el evento y provee un event handler, es decir
 * Metodo que sera ejecutado cuando ocurra el evento.
 */

/*Evento
 * Delegado encapsulado en la clase del editor
 * Delegado -> llama a un metodo cuando se cumple una condicion.
 */
