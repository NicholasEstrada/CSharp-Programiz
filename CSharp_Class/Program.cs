using System;
namespace EstudoClass{
class DogConstruct{

        private string[] nome = new string[3];
        public string this[int index]{ // recebe indexadores de arrays
            get{
                return nome[index];
            }
            set{
                nome[index] = value;
            }
        }
        /*
        string nomeCao;
        string racaCao;
        int age;
        int age1;
        DogConstruct(){  // (int num1, int num2 (int age
            //this.age = age;
            //Console.WriteLine("idade " + age);
            //Console.WriteLine("scopo 1");
            age = 4;
            age1 = 7;
        }
        */

        /*
        void passParam(DogConstruct pug){ // argumento é um objeto
            Console.WriteLine("age: " + age);
            Console.WriteLine("age1: " + age1);
        }
        void display(){
            passParam(this); // objeto
        }
        */

        /*
        DogConstruct(int num) : this(11,22){ // invocar construtor com this
            Console.WriteLine("Scopo 2");
        }
        */

        /*
        DogConstruct(){ // Constructor Overloading
            Console.WriteLine("Sem args");
        }
        */

        /*
        DogConstruct(string nome, string raca, int idade){ // com variaveis de instancia
            nomeCao = nome;
            racaCao = raca;
            idadeCao = idade;
            Console.WriteLine("Cachorro instanciado "+nomeCao+" "+racaCao+" "+idadeCao);
        }
        */

        /*
        static DogConstruct(){ // instanciado apenas uma vez
            Console.WriteLine("Static construct!");
            Console.WriteLine();
        }
        */

        /*
        static void Main(string[] args){
            //DogConstruct pug = new DogConstruct("Joel", "pug", 8);
            //DogConstruct pug2 = new DogConstruct("pug2", "pug", 5);
            //DogConstruct statNull = new DogConstruct();
            //DogConstruct pug = new DogConstruct(); // (5); 
            //pug.display();
        }
        */
    }
    class ProgramIndex{
        public static void Main(){
            DogConstruct pug = new DogConstruct();
            pug[0] = "Rui";
            pug[1] = "Lui";
            pug[2] = "Fui";
            for (int i = 0; i < 3; i++) {
                Console.WriteLine(pug[i] + " ");
            }
        }
    }
}