// Ничего не работает(


// Дополнительная задача (задача со звёздочкой): 
// Напишите программу, которая на вход принимает радиус круга и находит его площадь округленную до целого числа, 
// необходимо вывести максимальную цифру в полученном округлённом значении площади круга.
// 10 -> 4
// 20 -> 7
// 30 -> 8

//S = п R 2

Console.Clear();

Console.WriteLine("Введите радиус круга: ");
int r = Convert.ToInt32(Console.ReadLine());

int S = Convert.ToInt32(Math.PI * ( r * r ));

Console.WriteLine("Площадь круга:" + S);

int lenArray = S;

int[] array = new int[lenArray];


//string s = Convert.ToString(s);
//char a1 = Convert.ToString(S)[0];
//char a2 = Convert.ToString(S)[1];
//char a3 = Convert.ToString(S)[2];
//char a4 = Convert.ToString(S)[3];
//char a5 = Convert.ToString(S)[4];
//char a6 = Convert.ToString(S)[5];
//char a7 = Convert.ToString(S)[6];
//char a8 = Convert.ToString(S)[7];
//char a9 = Convert.ToString(S)[8];
//char a10 = Convert.ToString(S)[9];
//int a2 = S.ToString()[1];
//int a3 = S.ToString()[2];
//int a4 = S.ToString()[3];
//int a5 = S.ToString()[4];
//int a6 = S.ToString()[5];
//int a7 = S.ToString()[6];
//int a8 = S.ToString()[7];
//int a9 = S.ToString()[8];
//int a10 = S.ToString()[9];

//int [] array =  {Convert.ToInt32(Console.ReadLine())};
//Console.WriteLine($"{a1}, {a2}, {a3}" );
int Max = 0; 

for (int i = 1; i < lenArray; i++ ){
      if(array[i] > Max){
      Max = array[i];
      }
     Console.WriteLine("Максимальная цифра:" + Max );
}

Console.WriteLine("Максимальная цифра:" + Max );

