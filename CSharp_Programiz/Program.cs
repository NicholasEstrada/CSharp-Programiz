using System;
using Operators;

namespace HelloWorld
{
    class Dog{
        public string raca;
        public string nome;
        protected int idade;
        public void daPata(bool i){
            if(i){
                Console.WriteLine("{0} pega", nome);
            }else{
                Console.WriteLine("Sem biscoito! " + nome);
            }
        }
        public void late(){
            Console.WriteLine("au au au");
        }
    }

    class Hellow : Dog // estender classe Dog
    {
        Hellow(){
            Console.WriteLine("Contructor Hellow World! Iniciada");
        }
            
        static void Main()
        {   

            /*string nome = "nicholas";
            Console.WriteLine(nome);

            Console.WriteLine("Hello, World!");

            bool eValido = true;
            Console.WriteLine(eValido);

            sbyte level = 23;
            Console.WriteLine(level);
            */

            //AssingOp op = new AssingOp();

            /* op.Opern();

            op.Aritmetica();

            op.Relation();

            op.comparacao();

            op.unary();

            op.ternary();

            op.bitWIseShift();

            op.compound();

            op.readLine();
            */
            //op.ifes();

            //op.suite();

            //op.loopes();

            //op.arraysCS();
                        
            Dog pincher = new Dog();
            // Console.WriteLine("Raca de Dog: ");
            pincher.raca = "Pincher"; // Console.ReadLine();
            // Console.WriteLine("Raca de Dog: ");
            pincher.nome = "Denival"; // Console.ReadLine();

            Console.WriteLine(pincher.raca +" "+pincher.nome);
            pincher.daPata(true);

            // trabalhando com tipo protegido
            Hellow pincher2 = new Hellow(); // extendida da classe Dog para acessar elemento protegido
            pincher2.idade = 9;
            Console.WriteLine(pincher2.idade); 
        }   
    }
}