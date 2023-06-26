# Итоговая контрольная работа по основному блоку
***
## Зачем был разработан этот проект?
Данная задача была разработана в рамках итоговой контрольной работы по основному блоку обучения в GeekBrains. Это своеобразные срез знаний. К описанной ниже программе также прилагается блок-схема работы программы и вот это описание. 

## 1. Задание
Задача: *Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

>Примеры:
>
>[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
>
>[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
>
>[“Russia”, “Denmark”, “Kazan”] → []

## 2. Описание

Программа позволяет ввести любое количество слов, чисел, символов и из предложенного массива выбрать только те, которые удовлетворяют критерию отбора. В данном случае критерием отбора является количество символов.

За фразой *любое количество слов* скрывается заранее определённый размер массива, который задаёт пользователь при первом запуске программы.

>![Ввод размера массива](arraySize.png)

Следом следует приглашение ввести слова:

>![Ввод значений массива](arrayInput.png)

Если размер массива выбран 4, то после ввода последнего слова и нажатия Enter на экране появится введённый массив.

Останется только ввести количество символов, по которому будет выполняться проверка длины слова:

>![Ввод количества символов для проверки](cropNum.png)

## 3. Разработка
Разработка программы велась в среде Visual Studio Code — редактор исходного кода, разработанный Microsoft для Windows, Linux и macOS. Позиционируется как «лёгкий» редактор кода для кроссплатформенной разработки веб- и облачных приложений

## 4. Требования
Особых требований к программе не предъявляется. Запускается программа в среде Visual Studio Code 1.79.0 через командную строку командой *dotnet run*.

## 5. FAQ 
1. Программа не открывается.
    >*Ответ: проверьте версию VS Code. Откройте папку с программой через File -> Open Folder..., а также проверьте наличий всех рабочих папок на компьютере скачанных из репозитория GitHub.*
2. Программа всё равно не открывается!
    >*Ответ: проверьте работоспособность программы на GitHub. Если всё в порядке, переходите к п.1.*
3. Программа зависла и не получается ввести значения!
    >*Ответ: в консоли нажмите сочетание клавиш клавиатуры Ctrl+C и снова введите команду dotnet run.*

## 6. Доработка проекта
1. В качестве доработки планируется добавить WinForms.
2. Возможность работать с динамическим массивом.
3. Добавить выбор Random массива вместо ручного ввода.

## 7. Команда проекта
Над проектом работал Ефанов Сергей https://github.com/msega5 студент GeekBrains.

## 8. Источники
В процессе работы пришлось много гуглить:
1. https://metanit.com/sharp/tutorial/2.34.php
2. https://learn.microsoft.com/ru-ru/dotnet/api/system.string.split
3. https://ru.stackoverflow.com/questions/418758/
4. http://fb3809fm.bget.ru/_csharp/221.php