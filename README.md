# Задание:

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

# Решение:

Составлена блок-схема, где отображен алгоритм программы. Название файла: Scheme.

Написана программа по заданию. Название файла: FinalTask.

На старте задан массив типа string, с названием str, длинною в 4 элемента.Затем создан еще один результирующий массив типа string, с названием str2, длинною в массив str1. 

Создана функция Counter, которая принимает на себя эти 2 массива. Внутри функции создан счетчик равный нулю, затем цикл for: перебор массива с условием: если элемент массива меньше, либо равен 3, то записываем его в результирующий массив и прибавляем счетчик.

Далее создана функция PrintArray для печати результирующего массива. Внутри функции цикл for, который перебирает результирующий массив и печатает каждый элемент.
