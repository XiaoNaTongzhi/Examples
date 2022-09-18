// определили 9 переменных (3 буквы по 3 группы)
int a1 = 15;
int b1 = 21;
int c1 = 39;

int a2 = 12;
int b2 = 23;
int c2 = 33;

int a3 = 13;
int b3 = 23;
int c3 = 33;

// Для начала считаем a1 максимальной: 
int max = a1; 
// она и есть максимальная из всех просмотренных, когда просмотрена только она.

// Сравниваем остальные с максимальной по очереди:
if (b1 > max) max = b1; 
if (c1 > max) max = c1;
if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;
if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

// Выводим максимальное число в терминал:
Console.WriteLine(max);
