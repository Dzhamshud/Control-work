/*
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой
основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом
(не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4
должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк
формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

int count = 0;
string s = Console.ReadLine();// ввод строки
string[] s1 = s.Split(' ');// преобразование строки в массив строк s1 через пробел

for (int i = 0; i < s1.Length; i++)//цикл по массиву s1
{
    if (s1[i].Length <= 3) count++;//в счетчик записываем длину второго массива согласно условия задачи
}

string[] s2 = new string[count];//инициализируем массив s2
int index = 0;//вводим индекс для массива s2
for (int i = 0; i < s1.Length; i++)//цикл по массиву s1
{
    if (s1[i].Length <= 3)//проверяем условие
        {
        s2[index] = s1[i];//записываем значение в массив s2 удовлетворяющие условию
        index++;//учелививаем индекс массива s2 на 1(инкремент)
        }
}

void PrintArray (string[] array)//подпрограмма печати массива на экран
{
    for (int i = 0; i < array.Length; i++)
        {
        System.Console.Write($"{array[i]} ");
        }
}

PrintArray (s2);//вызов подпрограммы печати массива