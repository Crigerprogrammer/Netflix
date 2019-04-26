using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
 La clase ListaDoble es donde se almacenará las peliculas correspondientes a una categoria
 Tiene dos atributos
 primero-> el nodo que encabeza la lista
 ultimo-> el nodo que cierra la lista

    Ambos son nodos dobles, es decir que tiene dos enlaces
    Es en esta parte en donde se ve reflejada la naturaleza de una lista doblemente enlazada
    En la cantidad de enlaces que poseen sus nodos
    Sabemos por teoria que un nodo puede tener n cantidad de enlaces
    Para este caso tendremos dos, a ello debe su nombre esta lista
    Su caracteristica principal es que puede realizar recorridos en ambas direcciones
    De adelante hacia atras, y de atras hacia adelante


    NOTA: Aquí radia el unico cambio que se realizó y que diferencia una app en consola
    y una web, en la forma de mostrar los recorridos
    Mientras que para consola usabamos Console.writeline para mostrar el resultado en cuanto se obtenia
    Aqui concatenaremos en una cadena el recorrido, separado por saltos de linea
    para retornarlo y despues usarlo a nuestra conveniencia en nuestros formularios de asp
     */
namespace Netflix
{

    public class ListaDoble
    {
        //atributo
        public  Pelicula primero;//nodo a la cabeza
        public  Pelicula ultimo;//nodo que finaliza
        //constructor vacio
        public ListaDoble() {
            primero = null;
            ultimo = null;
        }
        //constructor con parametros
        public ListaDoble(Pelicula primero_, Pelicula ultimo_) {
            primero = primero_;
            ultimo = ultimo_;
        }

        //insercion 
        public void insertar(Pelicula nuevo) {
            if (primero == null)//pregunto si esta vacio, esto siempre se pregunta
            {
                primero = nuevo;//si esta vacia tanto el primero como el ultimo quedan en el valor de nuevo
                ultimo = nuevo;
            }
            else {//si no esta vacio
                ultimo.siguiente = nuevo;//agrego el nuevo despes del ultimo
                nuevo.anterior = ultimo; //digo que el nuevo apunta como anterior al ultimo
                ultimo = nuevo;//ahora el ultimo va a ser el que acabo de ingresar
            }
        }

        public string recorrerAdelante() {
            if (primero == null)//pregunto si esta vacia
            {
                return "La lista doble está vacía";
            }
            else {//si no esta vacia
                string retornar = "";
                Pelicula tmp = new Pelicula();//inicializo un temporal
                tmp = primero;//lo coloco al principio
                while (tmp != null) {//mientras qe no apunte a null va a ejecutar el ciclo
                    retornar = retornar + "Pelicula: " + tmp.nombre + " del año: " + tmp.año.ToString() + "<br>";//imprime
                    tmp = tmp.siguiente;//aumenta el temporal
                }
                return retornar;
            }
        }

        public  string recorrerAtras() //lo mismo  que el metodo anterior solo que empieza al final, o sea de atras para adelante
        {
            if (primero == null)
            {
                return "La lista doble está vacía";
            }
            else
            {
                string retornar = "";
                Pelicula tmp = new Pelicula();
                tmp = ultimo;
                while (tmp != null)
                {
                    retornar = retornar + "Pelicula: " + tmp.nombre + " del año: " + tmp.año.ToString() + "<br>";//imprime
                    tmp = tmp.anterior;
                }
                return retornar;
            }
        }
    }
}