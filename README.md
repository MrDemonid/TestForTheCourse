# Итоговая контрольная работа по основному блоку.

## Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение:
1. Вводим с консоли массив строк, методом **InputStringArray()**. В методе изначально создаётся пустой массив и в бесконечном цикле производится ввод строк, посредством **Console.ReadLine()**. Если введён символ **'q'**, то прекращаем ввод и выходим из функции, иначе увеличиваем размер массива (**Array.Resize()**) на один элемент и добавляем введенную строку в последний элемент массива. Для малого размера массива такой способ вполне пригоден, для больших размеров целесообразнее использовать для ввода списки, а потом конвертировать список в массив строк. Данный метод так же реализован, но закоментирован.
2. Поскольку в целевом массиве элементов может быть меньше, чем в исходном, то выделять под него память такого же размера, как исходный массив, нерационально. Поэтому, создана дополнительная функция **GetStringsCount()**, подсчитывающая в массиве количество строк, удовлетворяющих заданной длине.
3. Функция **SelectString()** решает основную задачу. Вначале создаётся массив под результат, размера **GetStringsCount()**. Затем в цикле проходимся по всем элементам исходного массива и добавляем в новый массив те строки, чья длина входит в заданный диапазон. Поскольку в целевой массив могут войти не все строки из исходного массива, то для его заполнения используется отдельный индекс (**newIndex**).

Примечание: Функция **SelectString()** принимает дополнительно два параметра: **minLen** и **maxLen**, которые задают диапазон длин нужных для выборки строк. Сделано это с целью немного расширить универсальность функции и избавиться от *"магического"* числа **'3'** в теле функции.

## Блок-схема
Поскольку главная задача блок-схемы - это наглядное представление алгоритма решения задачи, то в неё не вошли некоторые детали реализации алгоритма. 

В частности, исходный массив изначально инициализируется предопределенными значениями.

Целевой массив просто задан как массив, без указания сколько под него выделяется памяти и как. Для понимания сути алгоритма это было бы лишним, отвлекающим внимание.

PS: Функцию подсчета длины строки оформил в отдельную подпрограмму скорее из "академического" интереса, особой нужды в ней нет. Тем не менее, с ней суть алгоритма понятнее.
