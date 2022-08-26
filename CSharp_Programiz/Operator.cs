using System;
using System.Linq; // para arrays

namespace Operators
{
    class AssingOp
    {
        internal void Opern()
        {
            int num1, num2;
            float voa = 4.2F;
            
            num1 = 77;
            Console.WriteLine("num 1 é = {0}", num1);
            num2 = num1;
            Console.WriteLine("num 2 é = {0}", num2);
            voa = num1 + (num2 / voa);
            Console.WriteLine("Pega essa {0}", voa);
        }

        internal void Aritmetica()
        {
            double num1 = 10, num2 = 2, resultado;
            resultado = num1 + num2;
            Console.WriteLine(" + da {0} ; {1}+{2}", resultado, num1, num2);
            resultado = num1 - num2;
            Console.WriteLine(" - da {0} ; {1}-{2}", resultado, num1, num2);
            resultado = num1 * num2;
            Console.WriteLine(" * da {0} ; {1}*{2}", resultado, num1, num2);
            resultado = num1 / num2;
            Console.WriteLine(" + da {0} ; {1}/{2}", resultado, num1, num2);
            resultado = num1 % num2;
            Console.WriteLine(" % da {0} ; {1}%{2}", resultado, num1, num2);
        }
        internal void Relation()
        {
            bool result;
            int num1 = 11, num2 = 22;

            Console.WriteLine("num1 {0} num2{1}", num1, num2);
            result = (num1 == num2);
            Console.WriteLine(" == {0}", result);

            result = (num1 > num2);
            Console.WriteLine(" > {0}", result);

            result = (num1 < num2);
            Console.WriteLine(" < {0}", result);

            result = (num1 >= num2);
            Console.WriteLine(" >= {0}", result);

            result = (num1 <= num2);
            Console.WriteLine(" <= {0}", result);

            result = (num1 != num2);
            Console.WriteLine(" != {0}", result);
        }
        internal void comparacao()
        {
            bool result;
            int num1 = 7, num2 = 9;
            result = (num1 == num2) || (num1 > 5);
            Console.WriteLine(result);
            result = (num1 == num2) && (num1 > 5);
            Console.WriteLine(result);
        }
        internal void unary()
        {
            int number = 10, result;
            bool flag = true;

            result = +number;
            Console.WriteLine("+number = " + result);

            result = -number;
            Console.WriteLine("-number = " + result);

            result = ++number;
            Console.WriteLine("++number = " + result);

            result = --number;
            Console.WriteLine("--number = " + result);

            Console.WriteLine("!flag = " + (!flag));

            Console.WriteLine((number++));
            Console.WriteLine((number));

            Console.WriteLine((++number));
            Console.WriteLine((number));
        }

        internal void ternary()
        {
            int num = 10;
            string result;

            result = (num % 2 == 0) ? "É divisivel" : "Não é divisivel";
            Console.WriteLine("{0} {1}", num, result);
        }

        internal void bitWIseShift()
        {
            int num1 = 10;
            int num2 = 20;
            int result;

            result = ~num1; //ex: 1101 vira 0010 (inverte valor; 0=1, 1=0)
            Console.WriteLine("~{0} = {1}", num1, result);

            result = num1 & num2; // 00101011 & 00100101 vira 00100001 (compara; 1==1 = 1, 0==1 = 0, 0==0 = 0)
            Console.WriteLine("{0} & {1} = {2}", num1, num2, result);

            result = num1 | num2; // 1001 | 0110 vira 1111 (compara; 0==1 = 1) 
            Console.WriteLine("{0} | {1} = {2}", num1, num2, result);

            result = num1 ^ num2; // 1011 ^ 0001 vira 1010 xor compara 0==0 = 0, 0==1 = 1, 1==0 = 1, 1 == 1 = 0
            Console.WriteLine("{0} ^ {1} = {2}", num1, num2, result);

            result = num1 << 2; // 0010 << 2 vira 1000 (em 1 dobra valor, em 2 quadriplica)
            Console.WriteLine("{0} << 2 = {1}", num1, result);

            result = num1 >> 2; // 1000 >> 2 vira 0010 (em 1 /2, em 2 /4)
            Console.WriteLine("{0} >> 2 = {1}", num1, result);

        }

        internal void compound()
        {

            int number = 10;

            number += 5;
            Console.WriteLine("number += 5; " + number);

            number -= 3;
            Console.WriteLine(number);

            number *= 2;
            Console.WriteLine(number);

            number /= 3;
            Console.WriteLine(number);

            number %= 3;
            Console.WriteLine(number);

            number &= 10;
            Console.WriteLine(number);

            number |= 14;
            Console.WriteLine(number);

            number ^= 12;
            Console.WriteLine(number);

            number <<= 2;
            Console.WriteLine(number);

            number >>= 3;
            Console.WriteLine("number >>= 3; " + number);
        }
        internal void readLine()
        {
            string test;
            int userI;

            string userInput;
            int intVal;
            double doubleVal;

            test = Console.ReadLine();
            Console.WriteLine(test);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();

            Console.Write("Input using Read() - ");
            userI = Console.Read();
            Console.WriteLine("Ascii Value = {0}", userI);

            Console.Write("Enter integer value: ");
            userInput = Console.ReadLine();
            /* Converts to integer type */
            intVal = Convert.ToInt32(userInput);
            Console.WriteLine("You entered {0}", intVal);

            Console.Write("Enter double value: ");
            userInput = Console.ReadLine();
            /* Converts to double type */
            doubleVal = Convert.ToDouble(userInput);
            Console.WriteLine("You entered {0}", doubleVal);
        }

        internal void ifes()
        {
            int num = 8;
            if (num > 5)
            {
                Console.WriteLine("Deu isso {0}", num);
            }
            else
            {
                num += 1;
                Console.WriteLine("menor que 5");
            }

            if (num == 7)
            {
                Console.WriteLine("==");
            }
            else if (num < 5)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine(">");
            }

            int num1 = 3, num2 = 6, num3 = 9;
            if (num1 != (num2 / 2))
            {
                if (num3 < num2)
                {
                    Console.WriteLine("primeiro");
                }
                else
                {
                    Console.WriteLine("segundo");
                }
            }
            else
            {
                if (num3 < num1)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
            }

            Console.WriteLine("exemplo ternario: ");
            string retorno;
            //retorno = num1 != (num2/2) ? num3<num2 ? "primeiro" : num3<num1 ? "terceiro" : "quarto" : "segundo";
            int a = 3 , b = 6;
            retorno = a > b ? "a is greater than b" : a < b ? "b is greater than a" : "a is equal to b";
            Console.WriteLine(retorno);

        }

        internal void suite()
        {
            char vogal;
            Console.WriteLine("digite vogal: ");
            vogal = Convert.ToChar(Console.ReadLine());

            switch(Char.ToLower(vogal)){
                case 'a':
                    // Console.WriteLine("vogal {0}", vogal);
                    // break;
                case 'e':
                    // Console.WriteLine("vogal {0}", vogal);
                    // break;
                case 'i':
                    // Console.WriteLine("vogal {0}", vogal);
                    // break;
                case 'o':
                    // Console.WriteLine("vogal {0}", vogal);
                    // break;
                case 'u':
                    Console.WriteLine("vogal {0}", vogal);
                    break;
                default:
                    Console.WriteLine("nao aceita");
                    break;
            }

        }
        internal void loopes(){
            for(int i=0;i<8;i++){
                Console.WriteLine(i);
            }

            for (int i=0, j=0; i+j<=5; i++, j++)
			{
				Console.WriteLine("i = {0} and j = {1}", i,j);
			}
            int q = 0;

            for(;q<5;){
                q++;
                Console.WriteLine(q);
            }
            int n = 1, sum=0;

			while (n<=5)
			{
				sum += n;
				n++;
			}
			Console.WriteLine("Sum = {0}", sum);

            int y = 1, u = 5, product;

			do
			{
				product = u * y;
				Console.WriteLine("{0} * {1} = {2}", u, y, product);
				y++;
			} while (y <= 10);

            Console.WriteLine("Estudo de breack's");
            for(int k=-1;k<=3;k++){
                if(k==2){
                    Console.WriteLine("Parou {0}", k);
                    break;
                }
            }

            Console.WriteLine("Estudo de continue");
            int p = 0;
            while(p <5){ // volta 3
                p++;
                if(p==3){
                    continue; // isso retorna para o loop e nao executa as linhas abaixo do loop
                }
                Console.WriteLine(p);
            }

        }

        internal void arraysCS()
        {
            int[] idade;
            idade = new int[5]; // tamanho do array
            // ou em uma linha
            int[] age = new int[5];

            int[] nums = {99, 11, 22, 33, 44, 55};
            Console.WriteLine("os arrays; " + nums[0] + " " + nums[1] + " " + nums[4]);
            nums[4] = 77; // tem que dar o valor ja existente, ele não "nums[] = 77" nem "nums[5] = 77"
            Console.WriteLine(nums.Length);
            foreach(int a in nums){
                Console.WriteLine(a);
            }
            Console.WriteLine("max tam array " + nums.Max());
            Console.WriteLine("min tam array " + nums.Min());

            float soma = nums.Sum();
            int qtd = nums.Count();
            float media = soma/qtd;
            Console.WriteLine("media " + media); 
            Console.WriteLine("avarege func " + nums.Average());

            // array multidimensional
            int[,] bidim = new int[2,3]{{4,3,7},{8,5,9}};
            // 2 linhas por 3 colunas
            Console.WriteLine(bidim[0,2]);
            Console.WriteLine(bidim[1,2]);
            bidim[1,2] = 777;
            Console.WriteLine(bidim[0,2]);

            for(int i = 0;i < bidim.GetLength(0); i++){
                Console.Write("linha "+ i + ": ");
                for(int j = 0; j < bidim.GetLength(1); j++){
                    Console.Write(bidim[i,j] + " ");
                }
            }

            // array 3d tridim
            int[,,] tridim =    {{{3,2,4},{4,2,6}},
                                {{5,7,4},{2,7,5}}};
            
            // array irregular
            int[][] arrEgular = {
                new int[] {3,2,5},
                new int[] {8,4,9},
            };
            Console.WriteLine(arrEgular[0][1]);

            for(int i=0;i < arrEgular.Length;i++){
                for(int j=0;j < arrEgular[1].Length;j++){
                    Console.Write(arrEgular[i][j]+" ");
                }
                Console.WriteLine();
            }
            
            int[][,] jaggedArray = new int[3][ , ]  {
                new int[ , ] { {1, 8}, {6, 7} },
                new int[ , ] { {0, 3}, {5, 6}, {9, 10} },
                new int[ , ] { {11, 23}, {100, 88}, {0, 10} }
            };
            Console.WriteLine(jaggedArray[0][0, 1]);
            Console.WriteLine(jaggedArray[1][2, 1]);
            Console.WriteLine(jaggedArray[2][1, 0]);

            var numbers = new List<int>() { 5, -8, 3, 14, 9, 17, 0, 4 }; // declarar variavel array
            int sum = 0;
            foreach (int number in numbers) {
                sum += number;
            }
            Console.WriteLine("Sum = {0}", sum);

            var lista = new List<char>() {'w','f','h','k'};
            Console.WriteLine(lista[2]);
        }
    }

    

}