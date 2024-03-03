# README
## Домашнее задание к уроку #4.
### Задача 1

*Задание:*
```cs
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет: 
// "Позиция по рядам выходит за пределы массива"
// или
// "Позиция по колонкам выходит за пределы массива"
// Позиции в массиве считать от единицы.

// В коде, начальные условия:

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
 };

 int x = 2;
 int y = 2;
//  Выводится: 6
```

*Решение:*

[Решение Задачи #1](/Task1/Program.cs)

### Задача 2

*Задание:*
```cs
// Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

// Начальные условия:

int[,] numbers = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 
// Выводится:

9   10  11  12
5   6   7   8
1   2   3   4
```

*Решение:*

[Решение Задачи #2](/Task2/Program.cs)

### Задача 3

*Задание:*
```cs
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Начальные условия:


int[,] numbers = new int[,] {
    {1, 2, 3},
    {1, 1, 0},
    {7, 8, 2},
    {9, 10, 11}
};
// Выводится: 1

```

*Решение:*

[Решение Задачи #3](/Task3/Program.cs)

### Задача 4

*Задание:*
```
Задача 4*(не обязательная): Задайте двумерный массив
из целых чисел. Напишите программу, которая удалит
строку и столбец, на пересечении которых расположен
наименьший элемент массива. Под удалением
понимается создание нового двумерного массива без
строки и столбца
```

*Решение:*

[Решение Задачи #4](/Task4/Program.cs)